using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InsertQRCodeBlock
{
    /// <summary>
    /// Defines a control that can be used to display or edit a real number (double).
    /// </summary>
    public class NumericBox : TextBox
    {
        private double _value;
        private ErrorProvider _errorProvider;
        private int _decimalPlaces;
        protected string _stringFormat;

        /// <summary>
        /// Sets default values.
        /// </summary>
        public NumericBox()
        {
            _value = 0;
            _errorProvider = new ErrorProvider();
            Maximum = double.MaxValue;
            Minimum = double.MinValue;
            ErrorMsg = "Incorrect number";
            SetFormat();
        }

        /// <summary>
        /// Gets or sets the number of digits diplayed in the box.
        /// </summary>
        public int DecimalPlaces
        {
            get { return _decimalPlaces; }
            set { _decimalPlaces = value; SetFormat(); }
        }

        /// <summary>
        /// Gets or sets the ErrorProvider message.
        /// </summary>
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Gets or sets the Maximum allowed value.
        /// </summary>
        public double Maximum { get; set; }

        /// <summary>
        /// Gets or stes the minimum allowed value.
        /// </summary>
        public double Minimum { get; set; }

        /// <summary>
        /// Gets or sets the number value as double (may be more accurate than the displayed one).
        /// Updates the Text according to DecimalPlaces.
        /// </summary>
        public virtual double Value
        {
            get { return _value; }
            set { _value = value; Text = _value.ToString(_stringFormat); }
        }

        /// <summary>
        /// Evaluates if the value is a valid real number. 
        /// If not, cancels the validation and displayd the ErrorProvider icon.
        /// </summary>
        /// <param name="e">The event data</param>
        protected override void OnValidating(CancelEventArgs e)
        {
            double d;
            if (!double.TryParse(Text, out d) || d > Maximum || d < Minimum)
            {
                e.Cancel = true;
                SelectAll();
                _errorProvider.SetError(this, ErrorMsg);
            }
            else
            {
                Value = d;
            }
            base.OnValidating(e);
        }

        /// <summary>
        /// Updates Text and Value.
        /// </summary>
        /// <param name="e">The event data.</param>
        protected override void OnValidated(EventArgs e)
        {
            _value = Convert.ToDouble(Text);
            Text = _value.ToString(_stringFormat);
            base.OnValidated(e);
        }

        /// <summary>
        /// Hides the ErrorProvider icon.
        /// </summary>
        /// <param name="e">The event data.</param>
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            _errorProvider.SetError(this, "");
        }

        /// <summary>
        /// Creates a format string according to DecimalPlaces value. 
        /// Updates the Format property.
        /// </summary>
        private void SetFormat()
        {
            if (DecimalPlaces < 1)
                _stringFormat = "0";
            else
            {
                _stringFormat = "0.";
                for (int i = 0; i < DecimalPlaces; i++) _stringFormat += "0";
            }
        }
    }
}
