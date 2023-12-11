namespace UnitConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSelectConversion = new Label();
            grpRadioButtons = new GroupBox();
            rdoOuncesToGrams = new RadioButton();
            rdoPoundsToKilog = new RadioButton();
            rdoFahToCelsius = new RadioButton();
            rdoMilesToKilom = new RadioButton();
            rdoFeetToMeters = new RadioButton();
            rdoGramsToOunces = new RadioButton();
            rdoKilogToPounds = new RadioButton();
            rdoCelsiusToFah = new RadioButton();
            rdoKilomtoMiles = new RadioButton();
            rdoMetersToFeet = new RadioButton();
            lblEnterValues = new Label();
            txtValue = new TextBox();
            btnConvert = new Button();
            lblResult = new Label();
            grpRadioButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblSelectConversion
            // 
            lblSelectConversion.AutoSize = true;
            lblSelectConversion.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectConversion.Location = new Point(54, 43);
            lblSelectConversion.Name = "lblSelectConversion";
            lblSelectConversion.Size = new Size(382, 50);
            lblSelectConversion.TabIndex = 0;
            lblSelectConversion.Text = "1. Select Conversion";
            // 
            // grpRadioButtons
            // 
            grpRadioButtons.Controls.Add(rdoOuncesToGrams);
            grpRadioButtons.Controls.Add(rdoPoundsToKilog);
            grpRadioButtons.Controls.Add(rdoFahToCelsius);
            grpRadioButtons.Controls.Add(rdoMilesToKilom);
            grpRadioButtons.Controls.Add(rdoFeetToMeters);
            grpRadioButtons.Controls.Add(rdoGramsToOunces);
            grpRadioButtons.Controls.Add(rdoKilogToPounds);
            grpRadioButtons.Controls.Add(rdoCelsiusToFah);
            grpRadioButtons.Controls.Add(rdoKilomtoMiles);
            grpRadioButtons.Controls.Add(rdoMetersToFeet);
            grpRadioButtons.Location = new Point(104, 106);
            grpRadioButtons.Name = "grpRadioButtons";
            grpRadioButtons.Size = new Size(853, 272);
            grpRadioButtons.TabIndex = 1;
            grpRadioButtons.TabStop = false;
            grpRadioButtons.Text = "Conversion Options:";
            // 
            // rdoOuncesToGrams
            // 
            rdoOuncesToGrams.AutoSize = true;
            rdoOuncesToGrams.Location = new Point(364, 217);
            rdoOuncesToGrams.Name = "rdoOuncesToGrams";
            rdoOuncesToGrams.Size = new Size(228, 36);
            rdoOuncesToGrams.TabIndex = 9;
            rdoOuncesToGrams.TabStop = true;
            rdoOuncesToGrams.Text = "Ounces to Grams";
            rdoOuncesToGrams.UseVisualStyleBackColor = true;
            // 
            // rdoPoundsToKilog
            // 
            rdoPoundsToKilog.AutoSize = true;
            rdoPoundsToKilog.Location = new Point(364, 175);
            rdoPoundsToKilog.Name = "rdoPoundsToKilog";
            rdoPoundsToKilog.Size = new Size(264, 36);
            rdoPoundsToKilog.TabIndex = 8;
            rdoPoundsToKilog.TabStop = true;
            rdoPoundsToKilog.Text = "Pounds to Kilograms";
            rdoPoundsToKilog.UseVisualStyleBackColor = true;
            // 
            // rdoFahToCelsius
            // 
            rdoFahToCelsius.AutoSize = true;
            rdoFahToCelsius.Location = new Point(364, 133);
            rdoFahToCelsius.Name = "rdoFahToCelsius";
            rdoFahToCelsius.Size = new Size(268, 36);
            rdoFahToCelsius.TabIndex = 7;
            rdoFahToCelsius.TabStop = true;
            rdoFahToCelsius.Text = "Fahrenheit to Celsius";
            rdoFahToCelsius.UseVisualStyleBackColor = true;
            // 
            // rdoMilesToKilom
            // 
            rdoMilesToKilom.AutoSize = true;
            rdoMilesToKilom.Location = new Point(364, 91);
            rdoMilesToKilom.Name = "rdoMilesToKilom";
            rdoMilesToKilom.Size = new Size(251, 36);
            rdoMilesToKilom.TabIndex = 6;
            rdoMilesToKilom.TabStop = true;
            rdoMilesToKilom.Text = "Miles to Kilometers";
            rdoMilesToKilom.UseVisualStyleBackColor = true;
            // 
            // rdoFeetToMeters
            // 
            rdoFeetToMeters.AutoSize = true;
            rdoFeetToMeters.Location = new Point(364, 49);
            rdoFeetToMeters.Name = "rdoFeetToMeters";
            rdoFeetToMeters.Size = new Size(201, 36);
            rdoFeetToMeters.TabIndex = 5;
            rdoFeetToMeters.TabStop = true;
            rdoFeetToMeters.Text = "Feet to Meters";
            rdoFeetToMeters.UseVisualStyleBackColor = true;
            // 
            // rdoGramsToOunces
            // 
            rdoGramsToOunces.AutoSize = true;
            rdoGramsToOunces.Location = new Point(18, 217);
            rdoGramsToOunces.Name = "rdoGramsToOunces";
            rdoGramsToOunces.Size = new Size(228, 36);
            rdoGramsToOunces.TabIndex = 4;
            rdoGramsToOunces.TabStop = true;
            rdoGramsToOunces.Text = "Grams to Ounces";
            rdoGramsToOunces.UseVisualStyleBackColor = true;
            // 
            // rdoKilogToPounds
            // 
            rdoKilogToPounds.AutoSize = true;
            rdoKilogToPounds.Location = new Point(18, 175);
            rdoKilogToPounds.Name = "rdoKilogToPounds";
            rdoKilogToPounds.Size = new Size(264, 36);
            rdoKilogToPounds.TabIndex = 3;
            rdoKilogToPounds.TabStop = true;
            rdoKilogToPounds.Text = "Kilograms to Pounds";
            rdoKilogToPounds.UseVisualStyleBackColor = true;
            // 
            // rdoCelsiusToFah
            // 
            rdoCelsiusToFah.AutoSize = true;
            rdoCelsiusToFah.Location = new Point(18, 133);
            rdoCelsiusToFah.Name = "rdoCelsiusToFah";
            rdoCelsiusToFah.Size = new Size(268, 36);
            rdoCelsiusToFah.TabIndex = 2;
            rdoCelsiusToFah.TabStop = true;
            rdoCelsiusToFah.Text = "Celsius to Fahrenheit";
            rdoCelsiusToFah.UseVisualStyleBackColor = true;
            // 
            // rdoKilomtoMiles
            // 
            rdoKilomtoMiles.AutoSize = true;
            rdoKilomtoMiles.Location = new Point(18, 91);
            rdoKilomtoMiles.Name = "rdoKilomtoMiles";
            rdoKilomtoMiles.Size = new Size(251, 36);
            rdoKilomtoMiles.TabIndex = 1;
            rdoKilomtoMiles.TabStop = true;
            rdoKilomtoMiles.Text = "Kilometers to Miles";
            rdoKilomtoMiles.UseVisualStyleBackColor = true;
            // 
            // rdoMetersToFeet
            // 
            rdoMetersToFeet.AutoSize = true;
            rdoMetersToFeet.Location = new Point(18, 49);
            rdoMetersToFeet.Name = "rdoMetersToFeet";
            rdoMetersToFeet.Size = new Size(201, 36);
            rdoMetersToFeet.TabIndex = 0;
            rdoMetersToFeet.TabStop = true;
            rdoMetersToFeet.Text = "Meters to Feet";
            rdoMetersToFeet.UseVisualStyleBackColor = true;
            // 
            // lblEnterValues
            // 
            lblEnterValues.AutoSize = true;
            lblEnterValues.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnterValues.Location = new Point(54, 412);
            lblEnterValues.Name = "lblEnterValues";
            lblEnterValues.Size = new Size(281, 50);
            lblEnterValues.TabIndex = 2;
            lblEnterValues.Text = "2. Enter value:";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(338, 423);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(286, 39);
            txtValue.TabIndex = 3;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(403, 481);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(150, 46);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.Location = new Point(188, 625);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(147, 50);
            lblResult.TabIndex = 5;
            lblResult.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 763);
            Controls.Add(lblResult);
            Controls.Add(btnConvert);
            Controls.Add(txtValue);
            Controls.Add(lblEnterValues);
            Controls.Add(grpRadioButtons);
            Controls.Add(lblSelectConversion);
            Name = "Form1";
            Text = "Unit Converter";
            grpRadioButtons.ResumeLayout(false);
            grpRadioButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelectConversion;
        private GroupBox grpRadioButtons;
        private RadioButton rdoOuncesToGrams;
        private RadioButton rdoPoundsToKilog;
        private RadioButton rdoFahToCelsius;
        private RadioButton rdoMilesToKilom;
        private RadioButton rdoFeetToMeters;
        private RadioButton rdoGramsToOunces;
        private RadioButton rdoKilogToPounds;
        private RadioButton rdoCelsiusToFah;
        private RadioButton rdoKilomtoMiles;
        private RadioButton rdoMetersToFeet;
        private Label lblEnterValues;
        private TextBox txtValue;
        private Button btnConvert;
        private Label lblResult;
    }
}