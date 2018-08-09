using System;
using System.Collections;
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

        private async void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long inputNumber = Convert.ToInt64(calculateTxt.Text);
                string output = null;
                if (inputNumber < 0)
                {
                    output = "You cannot put a negative value";
                }
                else
                {
                    Task<long> factorialTask = Task.Run(() => Factorial(inputNumber));
                    await factorialTask;
                    output = factorialTask.Result.ToString();
                }
                calculateResult.Text = output;
                
            }
            catch(Exception ex)
            {
                calculateResult.Text = ex.Message;
            }
        }

        private long Factorial(long num)
        {
            long result = 1;
            for (int i = 1; i <= num; i++)
            {
                result = i * result;
            }
            return result;
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
                if (inputNumber < 0)
                {
                    result = "You cannot put a negative value";
                }
                else
                {
                    if (evenCheck(inputNumber))
                    {
                        result = checkTxt.Text + " is an even number.";
                    }
                    if (oddCheck(inputNumber))
                    {
                        result = checkTxt.Text + " is an odd number.";
                    }
                }
                checkResult.Text = result;
            }
            catch(Exception ex)
            {
                checkResult.Text = ex.Message;
            }
        }

        public List<int> intList = new List<int>();
        public List<double> doubleList = new List<double>();
        public List<char> charList = new List<char>();
        Random random = new Random();

        private void generateBtn_Click(object sender, EventArgs e)
        {
            displayListView.Items.Clear();
            if (intRdb.Checked)
            {
                GenerateValues(intList);
            }
            if (doubleRdb.Checked)
            {
                GenerateValues(doubleList);
            }
            if(charRdb.Checked)
            {
                GenerateValues(charList);
            }
        }

        private void GenerateValues(List<int> intList)
        {
            int value;
            intList.Clear();
            for (int i = 0; i < 10; i++)
            {
                value = random.Next(10, 100);
                intList.Add(value);
                displayListView.Items.Add(value.ToString());
            }
        }

        private void GenerateValues(List<double> doubleList)
        {
            double value;
            doubleList.Clear();
            for (int i = 0; i < 10; i++)
            {
                value = Math.Round((random.NextDouble() + random.Next(10,100)), 2);
                doubleList.Add(value);
                displayListView.Items.Add(value.ToString());
            }
        }

        private void GenerateValues(List<char> charList)
        {
            char value;
            charList.Clear();
            for (int i = 0; i < 10; i++)
            {
                value = (char)(random.Next(26) + 'a');
                charList.Add(value);
                displayListView.Items.Add(value.ToString());
            }
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            int searchValue = Convert.ToInt32(searchTxt.Text);
            if (intList.Contains(searchValue))
            {
                MessageBox.Show("is found");
            }
            else
            {
                MessageBox.Show("is not found");
            }
        }
    }
}
