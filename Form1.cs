using NativeWifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinWifi
{
	public partial class Form1 : Form
	{
    public class WifiStatus
		{
			public string SSID { get; set; }
			public string APMacAdress { get; set; }
			public DateTime CurrentTS { get; set; }
      public DateTime LastTS { get; set; }
      public string OLDAPMacAdress { get; set; }
      public uint RX { get; set; }
      public uint TX { get; set; }
      public uint SignalQuality { get; set; }
			public string WifiIP { get; set; }

			public WifiStatus()
			{

			}
    }

		/// <summary>
		/// Simple class to hold a Friendly name associated with the AP MAC Adress
		/// </summary>
		[Serializable]
		public class FriendlyName
		{
			public string MAC { get; set; }
			public string Name { get; set; }

			public FriendlyName()
			{

			}
			public FriendlyName(string mac, string name)
			{
				MAC = mac;
				Name = name;
			}
		}  

		public List<FriendlyName> FriendlyNames; // List of friendly names gets saved into App-directory

    public WifiStatus wifistatus = null;

		public Form1()
		{
			InitializeComponent();
      notify.Visible = false;
      wifistatus = new WifiStatus();
			FriendlyNames = new List<FriendlyName>();
		}
		
		private void GetConnectedWifiStatus() // Assumes we are on Interface[0] - that is the default Wifi interface
		{
			try
			{
				var wlanClient = new WlanClient();

				//foreach (WlanClient.WlanInterface wlanInterface in wlanClient.Interfaces) // Could improve here by letting user select interface
				{
					var MacAdressOfConnectedAP = wlanClient.Interfaces[0].CurrentConnection.wlanAssociationAttributes.Dot11Bssid;
          wifistatus.SSID = Encoding.UTF8.GetString(wlanClient.Interfaces[0].CurrentConnection.wlanAssociationAttributes.dot11Ssid.SSID).Replace("\0", string.Empty); ;
					wifistatus.TX = wlanClient.Interfaces[0].CurrentConnection.wlanAssociationAttributes.txRate;
          wifistatus.RX = wlanClient.Interfaces[0].CurrentConnection.wlanAssociationAttributes.rxRate;
          wifistatus.SignalQuality = wlanClient.Interfaces[0].CurrentConnection.wlanAssociationAttributes.wlanSignalQuality;

          string MAC = MacAdressOfConnectedAP.ToString();
					var output = string.Join(":", Enumerable.Range(0, 6)
						.Select(i => MAC.Substring(i * 2, 2)));

					MAC = output;
					
					if( string.IsNullOrEmpty(wifistatus.APMacAdress))
					{
						wifistatus.APMacAdress = MAC;
						wifistatus.CurrentTS = DateTime.Now;
					}

					if( wifistatus.APMacAdress != MAC )
					{
						// New AP
						wifistatus.OLDAPMacAdress = wifistatus.APMacAdress;
						wifistatus.LastTS = wifistatus.CurrentTS;
						wifistatus.APMacAdress = MAC;
						wifistatus.CurrentTS = DateTime.Now;
											
						if (notify.Visible == true)
						{
							Show();
							this.WindowState = FormWindowState.Normal;
							notify.Visible = false;
							this.CenterToScreen();
						}
					}
          else
					{
						wifistatus.CurrentTS = DateTime.Now;
					}
					wifistatus.APMacAdress = MAC;
					wifistatus.WifiIP = GetWifiIPAdress();

					FriendlyName f = FriendlyNames.Find(x => x.MAC == MAC);
					if(f != null)
					{
						tbAP.Text = f.Name + " : " + wifistatus.APMacAdress;
					}
					else
						tbAP.Text = wifistatus.APMacAdress;

					tbIP.Text = wifistatus.WifiIP;
					tbCurrentTS.Text = wifistatus.CurrentTS.ToLongTimeString();

					FriendlyName ff = FriendlyNames.Find(x => x.MAC == wifistatus.OLDAPMacAdress);
					if (ff != null)
					{
						tbOldAP.Text = ff.Name + " : " + wifistatus.OLDAPMacAdress;
					}
					else
						tbOldAP.Text = wifistatus.OLDAPMacAdress;
	
					tbOldTS.Text = wifistatus.LastTS.ToLongTimeString();
					if (tbOldTS.Text.Equals("00:00:00"))
						tbOldTS.Text = "";

					tbQuality.Text = wifistatus.SignalQuality.ToString() +"%";
					tbSpeed.Text = (wifistatus.TX / 1000).ToString() + " / " + (wifistatus.RX/1000).ToString() + " mbps" ;

        }
			}
			catch (Exception)
			{
				wifistatus.APMacAdress = string.Empty;
				tbAP.Text="Not connected to WiFi...";
				
        wifistatus.OLDAPMacAdress = string.Empty;
        wifistatus.RX = 0;
        wifistatus.TX = 0;
        wifistatus.SSID = string.Empty;
        wifistatus.SignalQuality = 0;
			}
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
      if (this.WindowState == FormWindowState.Minimized)
      {
        Hide();
        notify.Visible = true;

				string notifyText = $"Connected: {tbAP.Text}";
				// Display this text on the Tray-icon
				notify.Text = notifyText;
			}
		}

		private void notify_DoubleClick(object sender, EventArgs e)
		{
      Show();
      this.WindowState = FormWindowState.Normal;
      notify.Visible = false;
      this.CenterToScreen();
    }

		private void Form1_Load(object sender, EventArgs e)
		{
      this.CenterToScreen();
			try
			{
				FriendlyNames = ReadFromBinaryFile<List<FriendlyName>>(@".\list.dat");
			}
			catch { } // Don't fail if file doesn't exists

			GetConnectedWifiStatus();

			tsCombo.SelectedIndex = 4; // 180 seconds default value when auto-refresh is enabled
			
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			timer1.Stop();
			notify.Visible = false;
		}

		/// <summary>
		/// Gets the active Wifi-connections IPv4 adress
		/// </summary>
		/// <returns></returns>
		private string GetWifiIPAdress() 
		{
			string ipAddress = "";
			try
			{
				var ni = NetworkInterface.GetAllNetworkInterfaces();
				foreach (NetworkInterface item in ni.Where(x => x.NetworkInterfaceType == NetworkInterfaceType.Wireless80211))
				{
					if (item.OperationalStatus == OperationalStatus.Up) //&& item.NetworkInterfaceType == ?
					{
						foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
						{
							if (ip.Address.AddressFamily == AddressFamily.InterNetwork & !System.Net.IPAddress.IsLoopback(ip.Address))
							{
								ipAddress = ip.Address.ToString();
							}
						}
					}
				}
			}
			catch { }
      return ipAddress;
		}
		/// <summary>
		/// Serialize object binary to and from disk
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="filePath"></param>
		/// <param name="objectToWrite"></param>
		/// <param name="append"></param>
		public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
		{
			using (System.IO.Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
			{
				var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				binaryFormatter.Serialize(stream, objectToWrite);
			}
		}
		public static T ReadFromBinaryFile<T>(string filePath)
		{
				using (Stream stream = File.Open(filePath, FileMode.Open))
				{
					var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
					return (T)binaryFormatter.Deserialize(stream);
				}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			GetConnectedWifiStatus();
		}
		/// <summary>
		/// Save friendlyname
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(tsTbName.Text))
			{
				if (FriendlyNames.Exists(x => x.MAC == wifistatus.APMacAdress))
				{
					FriendlyName f = FriendlyNames.Find(x => x.MAC == wifistatus.APMacAdress);
					f.Name = tsTbName.Text;
				}
				else
				{
					FriendlyNames.Add(new FriendlyName(wifistatus.APMacAdress, tsTbName.Text));
				}
				WriteToBinaryFile(@".\list.dat", FriendlyNames, false);
				tsTbName.Text = "";
				GetConnectedWifiStatus();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			GetConnectedWifiStatus();
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			if (tsButtonAutoRefresh.Checked == true)
			{
				tsButtonAutoRefresh.CheckState = CheckState.Checked;
				timer1.Interval = int.Parse(tsCombo.SelectedItem.ToString()) * 1000;
				timer1.Start();
				tsButtonAutoRefresh.Checked = true;
				tsButtonAutoRefresh.Text = "Auto refresh On";
				tsLabel.Text = "Autorefresh active";
			}
			if (tsButtonAutoRefresh.Checked == false)
			{

				tsButtonAutoRefresh.CheckState = CheckState.Unchecked;
				timer1.Stop();
				tsButtonAutoRefresh.Checked = false;
				tsButtonAutoRefresh.Text = "Auto refresh disabled";
				tsLabel.Text = "Autorefresh disabled";
			}
		}

		private void tsCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			timer1.Stop();
			timer1.Interval = int.Parse(tsCombo.SelectedItem.ToString()) * 1000;
			timer1.Start();
		}
	}
}
