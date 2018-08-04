using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YanyingZhang_Lab07_Sec_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // input should be >=0
                int result = 1;
                int inputNumber = Convert.ToInt32(calculateTxt.Text);
                for (int i = 1; i <= inputNumber; i++)
                {
                    result = i * result;
                }
                calculateResult.Text = result.ToString();
                
            }
            catch(Exception ex)
            {
                calculateResult.Text = ex.Message;
            }
        }

        public delegate bool NumberCheck(int number);
        private static bool IsEven(int number) => number % 2 == 0;
        private static bool IsOdd(int number) => number % 2 == 1;

        private void checkBtn_Click(object sender, EventArgs e)
        {
            try
            {                
                NumberCheck evenCheck = IsEven;
                NumberCheck oddCheck = IsOdd;
                string result = null;

                int inputNumber = Convert.ToInt32(checkTxt.Text);
                if (evenCheck(inputNumber))
                {
                    result = " is an even number.";
                }
                if (oddCheck(inputNumber))
                {
                    result = " is an odd number.";
                }
                checkResult.Text = checkTxt.Text + result;
            }
            catch(Exception ex)
            {
                checkResult.Text = ex.Message;
            }
        }


        private void generateBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int value;
            //int[] numberList = new int[10];
            List<int> numberList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                value = random.Next(10, 100);
                numberList.Add(value);
                displayListView.Items.Add(value.ToString());
            }
            
        }

    }
}
