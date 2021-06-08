using System;
using System.Windows;

namespace BarkerSpeechTest
{
    public partial class SettingsWindow : Window
    {
        private MainWindow mainWindow;

        public SettingsWindow(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;

            SubscriptionUriEditor.Text = mainWindow.subscriptionEndpointId;
            SubscriptionKeyEditor.Text = mainWindow.subscriptionKey;
            RegionEditor.Text = mainWindow.region;

            ShowConfidenceToggleButton.IsChecked = mainWindow.showConfidenceWithResults;

            SubscriptionUriEditor.Focus();
        }

        private void CancelButton_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            mainWindow.subscriptionEndpointId = SubscriptionUriEditor.Text;
            mainWindow.subscriptionKey = SubscriptionKeyEditor.Text;
            mainWindow.region = RegionEditor.Text;

            mainWindow.showConfidenceWithResults = (bool)ShowConfidenceToggleButton.IsChecked;

            mainWindow.SaveSettings();

            this.Close();
        }
    }
}
