using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace spinners
{
    public partial class SpinnerPage : ContentPage
    {
        List<string> primaryList = new List<string> { "Blue", "Green" };
        List<string> secondaryList = new List<string> { "Sky", "Cobalt", "Mauve" };
        List<string> additionalList = new List<string> { "No spangle", "Spangle" };

        int primaryPos = -1;
        int secondaryPos = -1;
        int additionalPos = -1;

        public SpinnerPage()
        {
            InitializeComponent();

            spinPrimary.ItemsSource = primaryList;
            spinSecondary.ItemsSource = secondaryList;
            spinAdditional.ItemsSource = additionalList;

            spinPrimary.SelectedIndexChanged += (sender, e) =>
            {
                primaryPos = ((Picker)sender).SelectedIndex;
                UpdateColor();
            };

            spinSecondary.SelectedIndexChanged += (sender, e) =>
            {
                secondaryPos = ((Picker)sender).SelectedIndex;
                UpdateColor();
            };

            spinAdditional.SelectedIndexChanged += (sender, e) =>
            {
                additionalPos = ((Picker)sender).SelectedIndex;
                UpdateColor();
            };
        }

        void UpdateColor()
        {
            var color = string.Empty;

            if (primaryPos != -1)
            {
                color = additionalPos > 0 ? $"{additionalList[1]} " : "";
                color += secondaryPos != -1 ? $"{secondaryList[secondaryPos]} " : "";
                color += primaryList[primaryPos];
            }

            lblColor.Text = color;
        }
    }
}
