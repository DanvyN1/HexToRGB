using System;

using UIKit;

namespace HextoRGB
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            //Button
            convertButton.TouchUpInside += ConvertButton_TouchUpInside;
        }

		void ConvertButton_TouchUpInside(object sender, EventArgs e)
		{
            //Identifying red, blue, green hex values in the text field.
            string hexValue = hexValueTextField.Text;
            string redHexValue = hexValue.Substring (0, 2);
            string greenHexValue = hexValue.Substring(2, 2);
            string blueHexValue = hexValue.Substring(4, 2);

            //coverts the hex values into numbers
            int redValue = int.Parse(redHexValue, System.Globalization.NumberStyles.HexNumber);
            int greenValue = int.Parse(greenHexValue, System.Globalization.NumberStyles.HexNumber);
            int blueValue = int.Parse(blueHexValue, System.Globalization.NumberStyles.HexNumber);

            //Assigns the labels with their number values.
            redValueLabel.Text = redValue.ToString();
            greenValueLabel.Text = greenValue.ToString();
            blueValueLabel.Text = blueValue.ToString();

            //View
            colorView.BackgroundColor = UIColor.FromRGB(redValue, greenValue, blueValue);
		}
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
