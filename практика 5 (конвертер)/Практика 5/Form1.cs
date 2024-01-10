using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_5
{
    public partial class Form1 : Form
    {
        private const int MAX_VALUE_LENGTH = 10;
        private string _valueToConvert = string.Empty;
        private readonly char _comma = ',';
        public Form1()
        {
            InitializeComponent();
        }

        #region Buttons
        private void Button1_Click(object sender, EventArgs e) => AssignNum(Button1);

        private void Button2_Click(object sender, EventArgs e) => AssignNum(Button2);

        private void Button3_Click(object sender, EventArgs e) => AssignNum(Button3);

        private void Button4_Click(object sender, EventArgs e) => AssignNum(Button4);

        private void Button5_Click(object sender, EventArgs e) => AssignNum(Button5);

        private void Button6_Click(object sender, EventArgs e) => AssignNum(Button6);

        private void Button7_Click(object sender, EventArgs e) => AssignNum(Button7);

        private void Button8_Click(object sender, EventArgs e) => AssignNum(Button8);

        private void Button9_Click(object sender, EventArgs e) => AssignNum(Button9);

        private void Button0_Click(object sender, EventArgs e)
        {
            if (_valueToConvert.Length < 1)
                return;
            AssignNum(Button0);
        }
        #endregion

        private void AssignNum(Button button)
        {
            if (_valueToConvert.Length >= MAX_VALUE_LENGTH)
                return;
            _valueToConvert += button.Text;

            UpdateFootsLabel();
            UpdateMetresLabel();
        }
        private void UpdateFootsLabel()
        {
            FootsLabel.Text = _valueToConvert;
        }
        private void UpdateMetresLabel()
        {
            var valueToConvert = Convert.ToDouble(_valueToConvert);
            var metres = valueToConvert * 0.3048;
            var metreText = metres.ToString();

            if (metreText[metreText.Length - 1] == _comma)
                metreText = metreText.Remove(metreText.Length - 1, 1);

            MetresLabel.Text = metreText;
        }
        private void CommaButton_Click(object sender, EventArgs e)
        {
            if (_valueToConvert.Contains(_comma))
                return;

            AssignNum(CommaButton);
        }
        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            var value = Convert.ToDouble(_valueToConvert) * -1;
            _valueToConvert = value.ToString();

            UpdateFootsLabel();
            UpdateMetresLabel();
        }
        private void ClearButton_Click(object sender, EventArgs e) => AssignZeroValues();

        private void AssignZeroValues()
        {
            _valueToConvert = string.Empty;
            FootsLabel.Text = "0";
            MetresLabel.Text = "0";
        }
        private void RemoveLastCharButton_Click(object sender, EventArgs e)
        {
            if (_valueToConvert.Length <= 1)
            {
                AssignZeroValues();
            }
            _valueToConvert = _valueToConvert.Remove(_valueToConvert.Length - 1, 1);
            
            UpdateFootsLabel();
            UpdateMetresLabel();
        }
    }   
}

