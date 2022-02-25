using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public bool newVal = false;
        public bool equalAgain = false;
        public bool alreadyPreview2 = false;
        public bool squared = false;
        public bool abs = false;
        public bool fact = false;
        public bool sqrt = false;
        public bool squared10 = false;
        public bool log = false;
        public string previewHolder = string.Empty;
        public string operation = string.Empty;
        public string preview2Holder = string.Empty;
        public double newCalculated = 0;
        public double previewCalculated = 0;
        public double calculatedAnswer = 0;
        public double lastNumber = 0;
        public ArrayList paranLastValue = new ArrayList();
        public ArrayList paranOperations = new ArrayList();
        public int paranCounter = 0;
        public bool needChange = false;

        private void reset(bool preview1reset = true)
        {
          
        }
        // erasing buttons
        private void eraseButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void angleButton_Click(object sender, EventArgs e)
        {
            
        }
        private void hypButton_Click(object sender, EventArgs e)
        {
            
        }

        private void changeTrigoButton_Click(object sender, EventArgs e)
        {
           
        }

        private void ButtonPressed(string selectedNumber)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ButtonPressed("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonPressed("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonPressed("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonPressed("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonPressed("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonPressed("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonPressed("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonPressed("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonPressed("9");
        }
        private void button0_Click(object sender, EventArgs e)
        {
            ButtonPressed("0");
        }
        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!preview1.Text.Contains("."))
            {
                preview1.Text += ".";
            }
        }
        private void preview2HolderOperation(string previewSymbol)
        {
            if (alreadyPreview2)
            {
                preview2Holder = preview2.Text + $" {previewSymbol} ";
                alreadyPreview2 = false;
            }
            else
            {
                preview2Holder = preview2.Text + preview1.Text + $" {previewSymbol} ";
            }
        }
        private void Operational(string whatOperation, string previewSymbol)
        {
            
            
        }
        private void buttonAddition_Click(object sender, EventArgs e)
        {
            Operational("add", "+");
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            Operational("minus", "-");
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Operational("divide", "÷");
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Operational("multiply", "×");
        }
        private void AfterEqual()
        {
           
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
           
        }

        private void preview1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonNegativePositive_Click(object sender, EventArgs e)
        {
            if (preview1.Text != "0")
            {
                preview1.Text = (-1 * double.Parse(preview1.Text)).ToString();
            }
        }
        private void ClosingParen(string whatOperation)
        {
           
        }
        private void ParanEqual()
        {
            
        }
        private void ClosedTheParan()
        {
            
        }
        private void buttonOpenParen_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCloseParen_Click(object sender, EventArgs e)
        {
            
        }

        private void AngleOperation(string whatAngle)
        {
           
        }

        private void sinButton_Click(object sender, EventArgs e)
        {
            AngleOperation(sinButton.Text);
        }

        private void cosButton_Click(object sender, EventArgs e)
        {
            AngleOperation(cosButton.Text);
        }

        private void tanButton_Click(object sender, EventArgs e)
        {
            AngleOperation(tanButton.Text);
        }

        private void secButton_Click(object sender, EventArgs e)
        {
            AngleOperation(secButton.Text);
        }

        private void cscButton_Click(object sender, EventArgs e)
        {
            AngleOperation(cscButton.Text);
        }

        private void cotButton_Click(object sender, EventArgs e)
        {
            AngleOperation(cotButton.Text);
        }

        private void xSquareSupport()
        {
            preview1.Text = newCalculated.ToString();
            newVal = false;
            squared = true;
        }
        private void xSquaredOtherSupport(double toThe = 2)
        {
            
        }
        private void xSquaredButton_Click(object sender, EventArgs e)
        {
            xSquaredOtherSupport();
        }

        private void AbsoluteSupport()
        {
            preview2.Text += $" |{preview1.Text}|";
            preview1.Text = newCalculated.ToString();
        }
        private void buttonAbsolute_Click(object sender, EventArgs e)
        {
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
