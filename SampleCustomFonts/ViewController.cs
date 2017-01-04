using System;

using UIKit;

namespace SampleCustomFonts
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			var font = UIFont.FromName("ArimaMadurai-Bold", 40f);
			myLabel.Text = "Dheeraj Kumar G";
			myLabel.Font = font;
		}
	}
}
