using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Uno.UI.Samples.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Uno.UI.Samples.Content.UITests.CommandBar
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	[Sample]
	public sealed partial class CommandBar_MegaBug : Page
	{
		public CommandBar_MegaBug()
		{
			this.InitializeComponent();

		}

		void ChangeText(int buttonNumber)
		{
			string newText = $"Button {buttonNumber} Tapped";
			if (newText != TappedText.Text)
			{
				TappedText.Text = newText;
				if (TappedBorder.Visibility == Visibility.Collapsed)
				{
					TappedBorder.Visibility = Visibility.Visible;
				}
			}
			else
			{
				ToggleBorderVisibility();
			}
		}

		void ToggleBorderVisibility()
		{
			TappedBorder.Visibility = TappedBorder.Visibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
		}

		void b1Click(object s, object a)
		{
			ChangeText(1);
		}

		void b2Click(object s, object a)
		{
			ChangeText(2);
		}

		void b3Click(object s, object a)
		{
			ChangeText(3);
		}

		void b4Click(object s, object a)
		{
			ChangeText(4);
		}
	}
}
