using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Background;
using Windows.Storage;
using Windows.UI.Xaml.Controls;

namespace SDKTemplate
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "Bluetooth Low Energy";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title="Client: Discover servers", ClassType=typeof(Scenario1_Discovery) },
            new Scenario() { Title="Client: Connect to a server", ClassType=typeof(Scenario2_Client) },
            new Scenario() { Title="Server: Publish foreground", ClassType=typeof(Scenario3_ServerForeground) },
        };

        public string SelectedBleDeviceId;
        public string SelectedBleDeviceName = "No device selected";
    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}