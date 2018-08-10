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

        // GroupBox 1 - Calculate the factorial
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

        // GroupBox 2 - Check number is even or odd
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

        // GroupBox 3 - Generate 10 random values
        public List<int> intList = new List<int>();
        public List<double> doubleList = new List<double>();
        public List<char> charList = new List<char>();
        
        bool intCheck = false;
        bool doubleCheck = false;
        bool charCheck = false;
        
        private void generateBtn_Click(object sender, EventArgs e)
        {
            displayListView.Items.Clear();
            if (intRdb.Checked)
            {
                GenerateValues(intList);

                intCheck = true;
                doubleCheck = false;
                charCheck = false;
            }
            if (doubleRdb.Checked)
            {
                GenerateValues(doubleList);

                intCheck = false;
                doubleCheck = true;
                charCheck = false;
            }
            if(charRdb.Checked)
            {
                GenerateValues(charList);

                intCheck = false;
                doubleCheck = false;
                charCheck = true;
            }
        }

        Random random = new Random();

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

        // GroupBox 3 - Search value
        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = searchTxt.Text;
                if (searchValue == "")
                {
                    MessageBox.Show("Empty input.");
                }
                else
                {
                    bool containValue = false;
                    if (intCheck == true)
                    {
                        containValue = SearchData(intList, searchValue);
                    }
                    if (doubleCheck == true)
                    {
                        containValue = SearchData(doubleList, searchValue);
                    }
                    if (charCheck == true)
                    {
                        containValue = SearchData(charList, searchValue);
                    }

                    // output the result
                    if (containValue == true)
                    {
                        MessageBox.Show(searchValue + " is found in the list.");
                    }
                    else
                    {
                        MessageBox.Show(searchValue + " is not found in the list.");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool SearchData<T>(List<T> inputValues, string searchValue ) where T : IComparable<T>
        {
            bool valueCheck = false;
            foreach (var value in inputValues)
            {
                if((value.ToString()).CompareTo(searchValue) == 0)
                {
                    valueCheck = true;
                }
            }
            return valueCheck;
        }

        // GroupBox 3 -Display values
        private void displayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> iList = new List<int>();
                List<double> dList = new List<double>();
                List<char> cList = new List<char>();

                int lowIndex = Convert.ToInt32(lowIndexTxt.Text);
                int highIndex = Convert.ToInt32(highIndexTxt.Text);
                
                outputTxt.Text = "";
                if ((lowIndex>=0) && (lowIndex <= highIndex) && (highIndex < 10))
                { 
                    if (intCheck == true)
                    {
                        iList = PrintData(intList, lowIndex, highIndex);
                        foreach (var element in iList)
                        {
                            outputTxt.Text += element + " ";
                        }
                    }
                    if (doubleCheck == true)
                    {
                        dList = PrintData(doubleList, lowIndex, highIndex);
                        foreach (var element in dList)
                        {
                            outputTxt.Text += element + " ";
                        }
                    }
                    if (charCheck == true)
                    {
                        cList = PrintData(charList, lowIndex, highIndex);
                        foreach (var element in cList)
                        {
                            outputTxt.Text += element + " ";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<T> PrintData<T>(List<T> inputList, int low, int high)
        {
            List<T> list = new List<T>();
            for(int i=0; i < inputList.LongCount(); i++)
            {
                if ((i >= low) && (i <= high))
                {
                    list.Add(inputList[i]);
                }
            }
            return list;
        }
    }
}
