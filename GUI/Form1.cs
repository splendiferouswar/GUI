using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, tempNo;

            num1 = Int32.Parse(firstNumber.Text); //take the first number from user input and put it into num1 variable
            num2 = Int32.Parse(secondNumber.Text); //take the seconf number from the user and put it inside the num2 variable

            if (num1 > num2) //if the first number entered is bigger than the second number then do the following
            {
                tempNo = num1; //take the first (the big one) put inside a tamporary variable called tempNo
                num1 = num2; //take teh big number and put it inside the num2 variable
                num2 = tempNo; //take the temporary small number and give it to num2
            }

            goThrough(num1, num2);
        }
        public static bool isPrime(int number) //a boolean function to check if a number is a prime
        {
            bool primeBool = true; //creating a boolean variable to keep track of whether a number is prime or not

            if (number < 2) primeBool = false; //if the number is less than 2 return a false
            int sqrRoot = (int)Math.Sqrt((double)number); //finding the square root of the number
            for (int i = 2; i <= sqrRoot; i += 1) //start with two, keep moving 2 numbers up, stop until you reach the square root of the number
            {
                if (number % i == 0) primeBool = false; //if the modulo is 0 (if after dividing, the remainder is zero), return false
            }
            return primeBool; //otherwise return true, only prime numbers will create a true
        }
        public void goThrough(int num1, int num2) //function for going through every number within the range
        {
            int counter = 0; //counter to keep track for when to put in a new line
            for (int i = num1; i <= num2; i++) //start the loop  with the small number, keep adding 1 untill the num2
            {
                if (isPrime(i)) //if it is a prime 
                {
                    primesBox.Text += i.ToString() + ", "; //append to the text box and add a coma
                    counter++; //increase the counter by 1
                }
                if (counter == 5) //if the counter has reached 5
                {
                    primesBox.Text += Environment.NewLine; //add an empty line
                    counter = 0; //reset the counter
                }
            }
        }
    }
}
