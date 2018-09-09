using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            var browser = new WebView();
            browser.Source = "https://webchat.botframework.com/embed/contosobankbot32?s=xV_GXml_rw0.cwA.Fbc.24iEuHTtTJo2Hvs21Bn7N5ZLk-lKN5EBTg8QGliQywc";
            this.Content = browser;
        }
	}
}
