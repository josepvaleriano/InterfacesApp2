using System;

using Xamarin.Forms;

namespace InterfacesApp2
{
	public class Inicio : ContentPage
	{
		public Inicio()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};


#if __IOS__
			Padding = new Thickness(0, 25, 0, 0);
			#endif
		}
	}
}

