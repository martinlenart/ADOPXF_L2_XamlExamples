using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamlExamples.Views
{
    public partial class PropertyValuesPage : ContentPage
    {
        public PropertyValuesPage()
        {
            InitializeComponent();
            myLabel.Text = "Hello again";
    
        }
        void ButtonClicked(object sender, System.EventArgs e)
        {
            ((Button)sender).Text = "It is so!";
        }
     }
}
