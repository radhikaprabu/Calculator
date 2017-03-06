using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using Xamarin.Forms;

namespace Calculator
{
    public partial class CalculatorPage 
    {
        App app = Application.Current as App;
        List<int> numbers = new List<int>();
        float leftNumber = 0;
        float rightNumber = 0;
        String operation = "";
        public CalculatorPage()
        {
            InitializeComponent();

            displayLabel.Text = app.DisplayLabelText;
        }

        void OnDigitButtonClicked(object sender, EventArgs args)
        {
            String key = ((Button)sender).Text;
            displayLabel.Text += key;
        }
        void OnOperationButtonClicked(object sender, EventArgs args)
        {
            String key = ((Button)sender).Text;
            leftNumber = float.Parse(displayLabel.Text);
            displayLabel.Text = "";
            operation = key;
        }
        void OnEqualButtonClicked(object sender, EventArgs args)
        {
            rightNumber = float.Parse(displayLabel.Text);
            switch (operation)
                {
                case "+": displayLabel.Text = "" + (leftNumber + rightNumber);
                    break;
                case "-": displayLabel.Text = "" + (leftNumber - rightNumber);
                    break;
                case "/":
                    displayLabel.Text = "" + (leftNumber / rightNumber);
                    break;
                case "*":
                    displayLabel.Text = "" + (leftNumber * rightNumber);
                    break;
                default: break;
                }
            leftNumber = 0;
            rightNumber = 0;
            operation = null;
        }
        void OnClearButtonClicked(object sender, EventArgs args)
        {
            displayLabel.Text = "";
            leftNumber = 0;
            rightNumber = 0;
            operation = null;
        }

        void OnButton1Clicked(object sender, EventArgs args)
        {
            Resources["buttonStyle"] = Resources["buttonStyle1"];
        }

        void OnButton2Clicked(object sender, EventArgs args)
        {
            Resources["buttonStyle"] = Resources["buttonStyle2"];
        }

        void OnButton3Clicked(object sender, EventArgs args)
        {
            Resources["buttonStyle"] = Resources["buttonStyle3"];
        }

        void OnResetButtonClicked(object sender, EventArgs args)
        {
            Resources["buttonStyle"] = null;
        }
    }
}
