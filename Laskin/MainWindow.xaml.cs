using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Diagnostics;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Blue color was = #2B60DE
    /// </summary>
    public partial class MainWindow : Window
    {
        string operand1, operand2  = string.Empty;
        double opr1, opr2, result, value;
        string operation;
        int resultCounter, bracketCounter; // Both are 0, no need = 0;
        string calculationDirectory = "C:\\Users\\Jasu\\Documents\\Visual Studio 2015\\Projects\\Laskin\\Calculations";
        string calculationPath = "C:\\Users\\Jasu\\Documents\\Visual Studio 2015\\Projects\\Laskin\\Calculations\\Calculations.txt";

        public MainWindow() 
        {
            InitializeComponent();   
            DirectoryInfo direInfo = new DirectoryInfo(calculationDirectory);
            if (!direInfo.Exists)
            {
                direInfo.Create();      
            }
            
            FileInfo fileInfo = new FileInfo(calculationPath);
            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }

            StreamWriter sw = File.AppendText("C:\\Users\\Jasu\\Documents\\Visual Studio 2015\\Projects\\Laskin\\Calculations\\Calculations.txt");
            if (fileInfo.Length == 0) // If file is empty execute. 
            {
                sw.WriteLine("Calculations \t" + "\t" + "Results \t" + "\t" + "Date and time");
                sw.Flush();
                sw.Close();
            }
        }

        private void SetToClipboard(object text)
        {
            Clipboard.SetText(TextBox.Text); // Stores Textbox.Text into Clipboard. User does not need to use Ctrl+C. This already does it. User can paste directly Ctrl+V
        }

#region "MenuItem buttons       
        private void History_Click(object sender, RoutedEventArgs e) // OpenText() = opens file for the program, so program can use file data. Does not "open it/show it" for the user. 
        {
            FileInfo fileInfo = new FileInfo(calculationPath);        
            try
            {
                Process.Start(calculationPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("File does not exists!" + " " + ex.Message);
            } 
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(TextBox.Text);
        }

        private void Paste_Click(object sender, RoutedEventArgs e) // Returns, paste latest Clipboard data. 
        {
            TextBox.Text = Clipboard.GetText();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {        
            StreamWriter sw = File.CreateText("C:\\Users\\Jasu\\Documents\\Visual Studio 2015\\Projects\\Laskin\\Calculations\\Calculations.txt");
            sw.WriteLine("Calculations \t" + "\t" + "Results \t" + "\t" + "Date and time");
            sw.Flush();
            sw.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
#endregion
        #region "Degree and Radian conversion functions for sin,cos,tan
        private double degreeToRadian(double opr1)
            {
                result = opr1 * (Math.PI / 180);
                return result;
            }

                private double radianToDegreeSin(double opr1)  
                {
                    value = Math.Asin(opr1) * 180 / Math.PI;
                    //value = (opr1 * 180) / Math.PI; -> toimii vain sin
                    result = Math.Round(value, 2);
                    return result;
                }
                    private double radianToDegreeCos(double opr1)
                    {
                        value = Math.Acos(opr1) * 180 / Math.PI;
                        result = Math.Round(value, 2);
                        return result;
                    }
                        private double radianToDegreeTan(double opr1)
                        {
                            value = Math.Atan(opr1) * 180 / Math.PI;
                            result = Math.Round(value, 2);
                            return result;
                        }
#endregion
        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Clear();
               // equation.Clear();     
            }
                TextBox.Text += "1";
                equation.Text += "1";
                SetToClipboard(TextBox.Text);
            }      
             private void two_Click(object sender, RoutedEventArgs e)
             {
                 if (TextBox.Text == "0")
                 {          
                     TextBox.Clear();
                    // equation.Clear();                  
                 }
                     TextBox.Text += "2";
                     equation.Text += "2";
                     SetToClipboard(TextBox.Text);
             }
               
                private void three_Click(object sender, RoutedEventArgs e)
                {
                    if (TextBox.Text == "0")
                    {
                        TextBox.Clear();
                      //  equation.Clear();
                    }
                        TextBox.Text += "3";
                        equation.Text += "3";
                        SetToClipboard(TextBox.Text);
                }
          
                   private void four_Click(object sender, RoutedEventArgs e)
                   {
                       if (TextBox.Text == "0")
                       {
                           TextBox.Clear();
                         //   equation.Clear();
                        }
                           TextBox.Text += "4";
                           equation.Text += "4";
                           SetToClipboard(TextBox.Text);
                   }

                      private void five_Click(object sender, RoutedEventArgs e)
                      {
                          if (TextBox.Text == "0")
                          {
                              TextBox.Clear();
                          //    equation.Clear();
                          }
                              TextBox.Text += "5";
                              equation.Text += "5";
                              SetToClipboard(TextBox.Text);
                      }

                         private void six_Click(object sender, RoutedEventArgs e)
                         {
                             if (TextBox.Text == "0")
                             {
                                 TextBox.Clear();
                              //   equation.Clear();
                             }                                                    
                                TextBox.Text += "6";
                                equation.Text += "6";
                                SetToClipboard(TextBox.Text);
                         }

                            private void seven_Click(object sender, RoutedEventArgs e)
                            {
                                if (TextBox.Text == "0")
                                {
                                    TextBox.Clear();
                                //    equation.Clear();
                                }
                                    TextBox.Text += "7";
                                    equation.Text += "7";
                                    SetToClipboard(TextBox.Text);
                             }

                               private void eight_Click(object sender, RoutedEventArgs e)
                               {
                                   if (TextBox.Text == "0")
                                   {
                                        TextBox.Clear();
                                   //     equation.Clear();
                                   }
                                        TextBox.Text += "8";
                                        equation.Text += "8";
                                        SetToClipboard(TextBox.Text);
                               }

                                  private void nine_Click(object sender, RoutedEventArgs e)
                                  {
                                      if (TextBox.Text == "0")
                                      {
                                          TextBox.Clear();
                                     //     equation.Clear();
                                      }
                                          TextBox.Text += "9";
                                          equation.Text += "9";
                                          SetToClipboard(TextBox.Text);
                                  }

                                     private void zero_Click(object sender, RoutedEventArgs e)
                                     {   
                                         if (!TextBox.Text.Contains("0") || TextBox.Text.Length >= 2) // Last statement 0,000... first statement 1000  cant click 0 first, need to click , or someother number like 1.
                                         {
                                            TextBox.Text += "0";
                                            equation.Text += "0";
                                            SetToClipboard(TextBox.Text);
                                         }                                
                                     }

                                  private void dot_Click(object sender, RoutedEventArgs e)
                                  {
                                        if (!TextBox.Text.Contains(",")) // If textbox not contains dot, textbox.text = textbox.text + ",", so dot is added there. But if dot already exist, this if-statement will not be executed! So you can press dot button only once! and it will add only one dot
                                        { // NOTICE! parenthesis, or equation.content += "," does not work
                                            TextBox.Text += ",";
                                            equation.Text += ",";
                                        }                                                 
                                            if (equation.Text.Length == 1)
                                            {
                                                equation.Text = "0" + ",";
                                            }              
                                  }

                                    private void equal_Click(object sender, RoutedEventArgs e)
                                    {
                                        operand2 = TextBox.Text; 
                                        double opr1, opr2;
                                        // Converts string to double so operands 1,2 are now double
                                        double.TryParse(operand1, out opr1);
                                        double.TryParse(operand2, out opr2);

                                        try // Try to execute switch sequences 
                                        {
                                        switch (operation)
                                        {
                                            case "+":
                                                if (result == 0)
                                                {
                                                    result = opr1;
                                                }
                                                result += opr2;
                                                break;

                                            case "-":
                                                result -= opr2;
                                                break;

                                            case "*":
                                                if (result == 0)
                                                {
                                                    result = opr1;
                                                }
                                                result *= opr2;
                                                break;

                                            case "/":
                                                if (result == 0)
                                                {
                                                    result = opr1;
                                                }
                                                else if (opr2 != 0)
                                                {
                                                    result /= opr2;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Cannot be divided by zero!");
                                                }
                                                break;

                                            case "^y":
                                                result = Math.Pow(opr1, opr2);
                                                break;

                                            case "logy":
                                                if(opr2 > 0)
                                                {
                                                    result = Math.Log(opr1, opr2); // Log = Log10. Math.log(opr1, 2) = 2 base logarithm.
                                                }
                                                else
                                                {                          
                                                  result = Math.Log10(opr1);
                                                }
                                                break;
                                            case "yroot":
                                                result = Math.Pow(opr1, 1 / opr2); // Ex. 3^1/6 = 1,200
                                                break;
                                        }
                                            TextBox.Text = result.ToString();   
                                            resultCounter = 0;
                                            bracketCounter = 0;
                                            operation = " "; // In division calculations operation must reset. Example: 30/10 = 3 sqrt = "Cannot be divided by zero!", but gives right answer.
                                        }
                                        catch (Exception ex) // If errors occurs, when "=" button is pressed. Output errormessage.
                                        { 
                                            MessageBox.Show("Something went wrong during calculating! More Details: " +
                                                             ex.Message);
                                        }
                                        
                                         StreamWriter strW = File.AppendText("C:\\Users\\Jasu\\Documents\\Visual Studio 2015\\Projects\\Laskin\\Calculations\\Calculations.txt");
                                         if (equation.Text.Length <= 0)
                                         {
                                            equation.Text = "0";
                                            strW.WriteLine(equation.Text + "\t" + "\t" + "\t" + result + "\t" + "\t" + "\t" + DateTime.Now);
                                            strW.Flush();
                                            strW.Close();
                                         }

                                         else
                                         {
                                            strW.WriteLine(equation.Text + "\t" + "\t" + "\t" + result + "\t" + "\t" + "\t" + DateTime.Now);
                                            strW.Flush();
                                            strW.Close();
                                         }
                                         result = 0;
                                         equation.Text = string.Empty;
                                         SetToClipboard(TextBox.Text);
                                   }

                            private void plus_Click(object sender, RoutedEventArgs e)
                            {
                                // string operand1 = (string)Convert.ChangeType(result, typeof(string)); // laskujärjestystä reverse polish notation
                                operand1 = TextBox.Text;
                                double.TryParse(operand1, out opr1);               
                                operation = "+";
                                equation.Text += " " + "+" + " ";                
                                TextBox.Text = string.Empty;  
                                result += opr1;                              
                            }

                        private void minus_Click(object sender, RoutedEventArgs e)  
                        {                  
                            operand1 = TextBox.Text;                                                                                       
                            double.TryParse(operand1, out opr1);
                            operation = "-";
            
                            equation.Text += " " + "-" + " ";
                            TextBox.Text = string.Empty;

                            if (resultCounter == 0)
                            {        
                               result = opr1;            
                            }        
                            else
                            {
                                result -= opr1;
                            }
                            resultCounter++;                    
                        }
                                                                                                         
                     private void times_Click(object sender, RoutedEventArgs e)
                     {
                        operand1 = TextBox.Text;
                        double.TryParse(operand1, out opr1);
                        operation = "*";
                        equation.Text += " " + "*" + " ";
                        TextBox.Text = string.Empty;

                        if (result == 0)
                        {
                            result = opr1;
                        }
                        else
                        {
                            result *= opr1;
                        }
                    }
        
                 private void division_Click(object sender, RoutedEventArgs e)
                 {
                        operand1 = TextBox.Text;
                        double.TryParse(operand1, out opr1);
                        operation = "/";
                        equation.Text += " " + "/" + " ";
                        TextBox.Text = string.Empty;

                        if (result == 0)
                        {
                            result = opr1;
                        }
                        else
                        {
                            result /= opr1;                
                        }
                 }

             private void back_Click(object sender, RoutedEventArgs e) 
             {
                if (TextBox.Text.Length > 0 && equation.Text.Length > 0) // Crashes if there is no statement equation.text.length > 0. 
                {
                    TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1, 1); 
                    equation.Text = equation.Text.Remove(equation.Text.Length - 1, 1);
                }        
                    if (TextBox.Text.Length == 0 )
                    {
                      TextBox.Text = "0";
                    }        
                        if (equation.Text.Length >= 1) // 1+2+3 --> 1+3+2 = 6 Toimii 
                        {
                             operand1 = equation.Text;
                        }
                            if (equation.Text.Length == 0)
                            {
                                result = 0;
                            }
             }

        private void sqrt_Click(object sender, RoutedEventArgs e) // Sqrt = X pow 1/2
        {
            operand1 = TextBox.Text;
            double.TryParse(operand1, out opr1);
            equation.Text += " " + "sqrt" + " ";
            TextBox.Text = string.Empty;

            result = Math.Sqrt(opr1);
        }

            private void pi_Click(object sender, RoutedEventArgs e)
            {    
                if (TextBox.Text == "0")
                {
                    TextBox.Clear();
                }
                   TextBox.Text += Math.PI.ToString();
                   equation.Text += Math.PI.ToString();
            }

                private void x2_Click(object sender, RoutedEventArgs e)
                {
                    operand1 = TextBox.Text;
                    double.TryParse(operand1, out opr1);
                    equation.Text += TextBox.Text + " " + "^ 2" + " ";
                    TextBox.Text = string.Empty;
  
                    result = Math.Pow(opr1, 2);
                }

                    private void xy_Click(object sender, RoutedEventArgs e) 
                    {    
                        operand1 = TextBox.Text;
                        double.TryParse(operand1, out opr1);
                        operation = "^y";
                        equation.Text += TextBox.Text + " " + "^" + " ";
                        TextBox.Text = string.Empty;
            /*
                        operand2 = TextBox.Text;
                        double.TryParse(operand2, out opr2);
                        TextBox.Text = string.Empty;
            */
                    }
                        private void bracketOpen_Click(object sender, RoutedEventArgs e) // Tänne lasku, että kerrotaan luku sulkujen sisällä? 3X(3) = 9
                        {
                             bracketCounter += 1;
                             equation.Text += " " + "(";
                             TextBox.Text = string.Empty;
                        }
                            private void bracketClose_Click(object sender, RoutedEventArgs e)
                            {
                                if (bracketCounter != 0)
                                {
                                    equation.Text += " " + ")";
                                    TextBox.Text = string.Empty;
                                    bracketCounter--;
                                }
                            }
                                private void nFactorial_Click(object sender, RoutedEventArgs e) // Does not count correctly in decimal numbers, only in integers
                                {
                                        /* Hyödynnä tätä + vihko 
                                        For example,
                                        2.25 = Integer part is 2;
                                        fractional part is 25/100
                                        GCD is 25, so 1/4 is the fractional representation
                                        In code it might look something like this:
                                        String convertToFraction(double d) {
                                        // get the whole number part
                                        long i = (long) Math.ceil(d);
                                        // get the fractional part
                                        double numerator = d - i;
                                        // Convert the fractional part to a String
                                        String frac = new Double(numerator).toString();
                                        // We only want what's to the right of the //decimal point
                                        frac = frac.substring(frac.indexOf('.'));
                                        // Put the String back into a double
                                        numerator = Double.parseDouble(frac);
                                        int power = frac.length();
                                        double denominator = Math.pow(10, power);
                                        // implement findGCD()
                                        int gcd = findGCD(numerator, denominator);
                                        numerator /= gcd;
                                        denominator /= gcd;
                                        return i + "-" + (long) numerator + "/" + (long)denominator;
                                        }
                                        */
                                        
                                    double fact;
                                    operand1 = TextBox.Text;
                                    double.TryParse(operand1, out opr1);

                                    TextBox.Text = string.Empty;
                                    double intePart = Math.Truncate(opr1);
                                    double fractional = opr1 - intePart;

                                    fact = opr1;
           
                                   // for (double i = 1; i < opr1; i++) // 4! = 1*2*3*4
                                    //{
                                     //   fact *= i;
                                      //  result = fact;
                                   // }

                                    for (double i = opr1; i > 1; i--) // 4! = 4*3*2*1
                                    {
                                        fact *= i - 1;
                                        result = fact;
                                    }

                                }                                                             
                                    private void log_Click(object sender, RoutedEventArgs e)
                                    {
                                        operand1 = TextBox.Text;
                                        double.TryParse(operand1, out opr1);
                                        operation = "logy";
                                        equation.Text = " " + "log" + " ";
                                        TextBox.Text = string.Empty;     
                                    }
                                        private void yRoot_Click(object sender, RoutedEventArgs e) 
                                        {
                                            operand1 = TextBox.Text;
                                            double.TryParse(operand1, out opr1);
                                            operation = "yroot";
                                            equation.Text += " " + "yroot" + " ";
                                            TextBox.Text = string.Empty;
                                        }

                                    private void cubeRoot_Click(object sender, RoutedEventArgs e) // Cuberoot = X pow 1/3
                                    {
                                        operand1 = TextBox.Text;
                                        double.TryParse(operand1, out opr1);
                                        equation.Text += " " + "cuberoot" + " ";
                                        TextBox.Text = string.Empty;

                                        result = Math.Pow(opr1, 0.3333333);
                                    }

                                private void sin_Click(object sender, RoutedEventArgs e) // Math.Sin expects the input is radian, not degree
                                {
                                    operand1 = TextBox.Text;
                                    double.TryParse(operand1, out opr1);
                                    equation.Text += " " + "sin" + " ";
                                    TextBox.Text = string.Empty;

                                    result = Math.Sin(degreeToRadian(opr1));
                              }

                            private void sin1_Click(object sender, RoutedEventArgs e)  
                            {          
                                operand1 = TextBox.Text;
                                double.TryParse(operand1, out opr1);
                                equation.Text += " " + "arcsin" + " ";
                                TextBox.Text = string.Empty;

                                radianToDegreeSin(opr1);
                            }

                        private void cos_Click(object sender, RoutedEventArgs e)
                        {
                            operand1 = TextBox.Text;
                            double.TryParse(operand1, out opr1);
                            equation.Text += " " + "cos" + " ";
                            TextBox.Text = string.Empty;

                            result = Math.Cos(degreeToRadian(opr1));
                        }

                    private void cos1_Click(object sender, RoutedEventArgs e) 
                    {
                        operand1 = TextBox.Text;
                        double.TryParse(operand1, out opr1);
                        equation.Text += " " + "arccos" + " ";
                        TextBox.Text = string.Empty;

                        radianToDegreeCos(opr1);
                    }

                private void tan_Click(object sender, RoutedEventArgs e)
                {
                    operand1 = TextBox.Text;
                    double.TryParse(operand1, out opr1);
                    equation.Text += " " + "tan" + " ";
                    TextBox.Text = string.Empty;

                    result = Math.Tan(degreeToRadian(opr1));
                }

            private void tan1_Click(object sender, RoutedEventArgs e) 
            {
                operand1 = TextBox.Text;
                double.TryParse(operand1, out opr1);
                equation.Text += " " + "arctan" + " ";
                TextBox.Text = string.Empty;

                radianToDegreeTan(opr1); 
            }

        private void empty_Click(object sender, RoutedEventArgs e)
        {
             TextBox.Clear();
             equation.Clear();
             TextBox.Text = "0";
             resultCounter = 0;
             bracketCounter = 0;
             result = 0;
            // Clear the equals button, so after calculating, don't remember, what has calculated.
             operand1 = string.Empty;
             operand2 = string.Empty;
        }
    }
}