namespace UnitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double userValue = double.Parse(txtValue.Text);
            double resultConversion = 0;

            if (rdoMetersToFeet.Checked)
            {
                resultConversion = (userValue * 3.28);

                lblResult.Text = "Result: " + resultConversion.ToString("#.##") + " feet";
            }
            else if (rdoKilomtoMiles.Checked)
            {
                resultConversion = (userValue * 0.621371);

                lblResult.Text = "Result: " + resultConversion.ToString("#.##") + " miles";
            }
            else if (rdoCelsiusToFah.Checked)
            {
                resultConversion = (userValue * 1.8) + 32;

                lblResult.Text = "Result: " + resultConversion.ToString("#.##") + " degrees Fahrenheit";
            }
            else if (rdoKilogToPounds.Checked)
            {
                resultConversion = (userValue * 2.20462);

                lblResult.Text = "Result: " + resultConversion.ToString("#.##") + " pounds";
            }
            else if (rdoGramsToOunces.Checked)
            {
                resultConversion = (userValue * 0.035274);

                lblResult.Text = "Result: " + resultConversion.ToString("#.##") + " ounces";
            }
            else if (rdoFeetToMeters.Checked)
            {
                resultConversion = (userValue * 0.3048);

                lblResult.Text = "Result: " + resultConversion.ToString("#.##") + " meters";
            }
            else if (rdoMilesToKilom.Checked)
            {
                resultConversion = (userValue * 1.60934);

                lblResult.Text = "Result: " + resultConversion.ToString("#.##") + " kilometers";
            }
            else if (rdoFahToCelsius.Checked)
            {
                resultConversion = (userValue - 32) * 0.555555;

                lblResult.Text = "Result: " + resultConversion.ToString("#.##") + " degrees Celsius";
            }
            else if (rdoPoundsToKilog.Checked)
            {
                resultConversion = (userValue * 0.454);

                lblResult.Text = "Result: " + resultConversion.ToString("#.##") + " kilograms";
            }
            else if (rdoOuncesToGrams.Checked)
            {
                resultConversion = (userValue * 28.3495);

                lblResult.Text = "Result: " + resultConversion.ToString("#.##") + " grams";
            }


        }//end btnConvert_Click
    }
}//end namespace