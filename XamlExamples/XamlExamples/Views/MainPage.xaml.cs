using System;
using Xamarin.Forms;

namespace XamlExamples.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		protected async void navigateToPage(object sender, EventArgs args)
		{
			Type pageType = ((TextCell)sender).CommandParameter as Type;
			Page page = (Page)Activator.CreateInstance(pageType);
			await this.Navigation.PushAsync(page);
		}
	}
}
