using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;

namespace Mobile_App
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            // Update button text
            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            // Screen reader announcement
            SemanticScreenReader.Announce(CounterBtn.Text);

            // Button Click Animation
            await CounterBtn.ScaleTo(1.1, 100);
            await CounterBtn.ScaleTo(1.0, 100);

            // Image Click Animation (Optional)
            await this.FindByName<Image>("YourImageName").RelRotateTo(360, 1000);
        }
    }
}
