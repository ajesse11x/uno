using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Common;
using Uno.UI.Samples.Controls;

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Uno.UI.Samples.Content.UITests.FocusManager
{
	[SampleControlInfo("FocusManager", "FocusManager_FocusDirection")]
	public sealed partial class FocusManager_FocusDirection : UserControl
	{
		public FocusManager_FocusDirection()
		{
			this.InitializeComponent();

			var buttonNext = NextButton as Button;
			var buttonPrevious = PreviousButton as Button;
			var buttonUp = UpButton as Button;
			var buttonDown = DownButton as Button;
			var buttonRight = RightButton as Button;
			var buttonLeft = LeftButton as Button;
			var buttonNone = NoneButton as Button;

			buttonNext.Command = new DelegateCommand(() => Windows.UI.Xaml.Input.FocusManager.TryMoveFocus(Windows.UI.Xaml.Input.FocusNavigationDirection.Next));
			buttonPrevious.Command = new DelegateCommand(() => Windows.UI.Xaml.Input.FocusManager.TryMoveFocus(Windows.UI.Xaml.Input.FocusNavigationDirection.Previous));
			buttonUp.Command = new DelegateCommand(() => Windows.UI.Xaml.Input.FocusManager.TryMoveFocus(Windows.UI.Xaml.Input.FocusNavigationDirection.Up));
			buttonDown.Command = new DelegateCommand(() => Windows.UI.Xaml.Input.FocusManager.TryMoveFocus(Windows.UI.Xaml.Input.FocusNavigationDirection.Down));
			buttonRight.Command = new DelegateCommand(() => Windows.UI.Xaml.Input.FocusManager.TryMoveFocus(Windows.UI.Xaml.Input.FocusNavigationDirection.Right));
			buttonLeft.Command = new DelegateCommand(() => Windows.UI.Xaml.Input.FocusManager.TryMoveFocus(Windows.UI.Xaml.Input.FocusNavigationDirection.Left));
			buttonNone.Command = new DelegateCommand(() => Windows.UI.Xaml.Input.FocusManager.TryMoveFocus(Windows.UI.Xaml.Input.FocusNavigationDirection.None));
		}

	}
}
