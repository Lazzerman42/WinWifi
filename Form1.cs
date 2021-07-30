using NativeWifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
      public string OLDAPMacAdress { get; set; }
      public uint RX { get; set; }
      public uint TX { get; set; }
      public uint SignalQuality { get; set; }

      public WifiStatus()
			{

			}
    }

    public WifiStatus wifistatus = null;

		public Form1()
		{
			InitializeComponent();
      notify.Visible = false;
      wifistatus = new WifiStatus();
		}

		private void button1_Click(object sender, EventArgs e)
		{
      WlanClient client = new WlanClient();
      foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
      {
        // Lists all networks with WEP security
        Wlan.WlanAvailableNetwork[] networks = wlanIface.GetAvailableNetworkList(0);
        foreach (Wlan.WlanAvailableNetwork network in networks)
        {
          tb.AppendText("Found network with SSID: " + GetStringForSSID(network.dot11Ssid) +"\r\n");
        }

        // Retrieves XML configurations of existing profiles.
        // This can assist you in constructing your own XML configuration
        // (that is, it will give you an example to follow).
        foreach (Wlan.WlanProfileInfo profileInfo in wlanIface.GetProfiles())
        {
          string name = profileInfo.profileName; // this is typically the network's SSID
          string xml = wlanIface.GetProfileXml(profileInfo.profileName);

          tb.AppendText(xml + "\r\n");
        }

        // Connects to a known network with WEP security
        //string profileName = "Cheesecake"; // this is also the SSID
        //string mac = "52544131303235572D454137443638";
        //string key = "hello";
        //string profileXml = string.Format("<?xml version=\"1.0\"?><WLANProfile xmlns=\"http://www.microsoft.com/networking/WLAN/profile/v1\"><name>{0}</name><SSIDConfig><SSID><hex>{1}</hex><name>{0}</name></SSID></SSIDConfig><connectionType>ESS</connectionType><MSM><security><authEncryption><authentication>open</authentication><encryption>WEP</encryption><useOneX>false</useOneX></authEncryption><sharedKey><keyType>networkKey</keyType><protected>false</protected><keyMaterial>{2}</keyMaterial></sharedKey><keyIndex>0</keyIndex></security></MSM></WLANProfile>", profileName, mac, key);
        //wlanIface.SetProfile(Wlan.WlanProfileFlags.AllUser, profileXml, true);
        //wlanIface.Connect(Wlan.WlanConnectionMode.Profile, Wlan.Dot11BssType.Any, profileName);
      }
    }

    static string GetStringForSSID(Wlan.Dot11Ssid ssid)
    {
      return Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
    }

		private void button2_Click(object sender, EventArgs e)
		{
      var wlanClient = new WlanClient();
      foreach (WlanClient.WlanInterface wlanInterface in wlanClient.Interfaces)
      {
        Wlan.WlanBssEntry[] wlanBssEntries = wlanInterface.GetNetworkBssList();
        foreach (Wlan.WlanBssEntry wlanBssEntry in wlanBssEntries)
        {
          byte[] macAddr = wlanBssEntry.dot11Bssid;
          var macAddrLen = (uint)macAddr.Length;
          var str = new string[(int)macAddrLen];
          for (int i = 0; i < macAddrLen; i++)
          {
            str[i] = macAddr[i].ToString("x2");
          }
          string mac = string.Join("", str);
          tb.AppendText (GetStringForSSID(wlanBssEntry.dot11Ssid) + " : " + mac +  "\r\n");
        }
      }
    }

		private void button3_Click(object sender, EventArgs e)
		{
			GetConnectedWifiStatus();
		}

		private void GetConnectedWifiStatus()
		{
			try
			{
				var wlanClient = new WlanClient();

				//foreach (WlanClient.WlanInterface wlanInterface in wlanClient.Interfaces)
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

          wifistatus.APMacAdress = MAC;
          System.Net.NetworkInformation.IPInterfaceProperties ip = wlanClient.Interfaces[0].NetworkInterface.GetIPProperties();
          System.Net.NetworkInformation.IPv4InterfaceProperties ip4 = ip.GetIPv4Properties();

          string s = "jhek";

        }
			}
			catch (Exception)
			{
        wifistatus.APMacAdress = string.Empty;
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
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
      notify.Visible = false;
		}

		private void button4_Click(object sender, EventArgs e)
		{
      string ipAddress = "";
      var ni = NetworkInterface.GetAllNetworkInterfaces(); 
      foreach (NetworkInterface item in ni.Where(x=>x.NetworkInterfaceType == NetworkInterfaceType.Wireless80211))
      {
        if (item.OperationalStatus == OperationalStatus.Up) //&& item.NetworkInterfaceType == ?
        {
          foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
          {
            if (ip.Address.AddressFamily == AddressFamily.InterNetwork & !System.Net.IPAddress.IsLoopback(ip.Address))
            {
              ipAddress = ip.Address.ToString();
              tb.AppendText(ipAddress+ "\r\n");
            }
          }
        }
      }
    }
	}
}
