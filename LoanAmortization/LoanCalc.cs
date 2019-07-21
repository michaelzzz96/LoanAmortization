using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanAmortization
{
    public partial class LoanCalc : Form
    {
        public LoanCalc()
        {
            InitializeComponent();
        }


        // Global Variables
        double loanAmount = 0.0;
        double termIn = 0.0;
        double rateIn = 0.0;



        public void LoanAmountOk()
        {
            // Check if Loan Amount is acceptable
            bool loanAmountOkay = double.TryParse(
                txtLoan.Text,
                out loanAmount);


            if (loanAmountOkay == true)
            {
                txtLoan.BackColor = Color.White;
                if (loanAmount < 1000)
                {
                    txtLoan.Focus();
                    txtLoan.Clear();
                    txtLoan.BackColor = Color.LightPink;
                    return;
                }
                else if (loanAmount > 1000000)
                {
                    txtLoan.Focus();
                    txtLoan.Clear();
                    txtLoan.BackColor = Color.LightPink;
                    return;
                }
            }//end if

            else
            {
                txtLoan.Focus();
                txtLoan.Clear();
                txtLoan.BackColor = Color.LightPink;
                return;
            }// end else
        }


        public void LoanYearOk()
        {
            // Check if Loan Year is acceptable
            bool loanYearsOkay = double.TryParse(
               txtYear.Text,
               out termIn);

            if (loanYearsOkay == true)
            {
                txtYear.BackColor = Color.White;
                if (termIn > 50)
                {
                    txtYear.Focus();
                    txtYear.Clear();
                    txtYear.BackColor = Color.LightPink;
                    return;
                }
                if (termIn <= 0)
                {
                    txtLoan.Focus();
                    txtLoan.Clear();
                    txtLoan.BackColor = Color.LightPink;
                    return;
                }


            }//end if

            else
            {
                txtYear.Focus();
                txtYear.Clear();
                txtYear.BackColor = Color.LightPink;
                return;
            }// end else
        }



        public void InterestOk()
        {
            // Check if InterestRate is acceptable
            bool InterestRateOkay = double.TryParse(
               txtAPR.Text,
               out rateIn);

            if (InterestRateOkay == true)
            {
                txtAPR.BackColor = Color.White;
                if (rateIn > 10)
                {
                    txtAPR.Focus();
                    txtAPR.Clear();
                    txtAPR.BackColor = Color.LightPink;
                    return;
                }
                if (rateIn <= 0)
                {
                    txtAPR.Focus();
                    txtAPR.Clear();
                    txtAPR.BackColor = Color.LightPink;
                    return;
                }


            }//end if
            else
            {
                txtAPR.Focus();
                txtAPR.Clear();
                txtAPR.BackColor = Color.LightPink;
                return;
            }// end else
        }



        /// <summary>
        /// Calculate the Loan amount, term, and APR percent entered by
        /// the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();

            try
            {

                // Calling Methods
                LoanAmountOk();
                LoanYearOk();
                InterestOk();


                //Interest rate
                rateIn = (rateIn / 100.0) / 12.0;

                //Monthly Payment
                double monthlyPayment = CalcMonthlyPayment(loanAmount, rateIn, termIn);

                //Principal of Loan Amount
                double principalLoanAmount = 0;
                
                //Balance of Amount
                double BalanceAmount = 0;
                
                //Interest Paid
                double interest = 0;
                
                //Principal
                double principal = loanAmount;
                
                //Total Payment
                double totalPayment = 0;

                //display the monthly payment
                txtMonthly.Text = monthlyPayment.ToString("c");

                //set the total amount paid
                txtTotal.Text = (monthlyPayment * (12 * termIn)).ToString("c");

                // Dispaly Columns
                lstOutput.Items.Add(string.Format("{0,5}{1,17}{2,22}{3,20}",
                "Month", "Principal", "Int/Pmt", "Prn/Pmt"));

                //Iterate to Output interest, balance, total interest, and total
                for (int month = 1; month <= termIn * 12; month++)
                {
                    // Calculate the Interest
                    interest = principal * rateIn;

                    // Calculate the Principal
                    principalLoanAmount = monthlyPayment - interest;

                    // Calculte the Balance
                    BalanceAmount = principal - principalLoanAmount;

                    // Calculate the Total
                    totalPayment = totalPayment + interest;

                    //Output
                    lstOutput.Items.Add(string.Format("{0,10}{1,17}{2,18}{3,21}",
                    month, BalanceAmount.ToString("c"), interest.ToString("c"),
                    principalLoanAmount.ToString("c")));
                    principal = BalanceAmount;

                }// end loop

            }// end try
            catch (Exception exc)
            {
                MessageBox.Show("Error was thrown in btnCalculate: " + exc);
                MessageBox.Show(exc.StackTrace);

            }// end catch

           
        } // end btnCalculate

        /// <summary>
        /// This method takes as arguments Loan Principal in, APR in, and
        /// The duration of the loan in months
        /// It calculates what the discount rate is and computes the fixed
        /// monthly payment is.
        /// </summary>
        /// <param name="princIn"></param>
        /// <param name="aprIn"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        private double CalcMonthlyPayment(
            double princIn,
            double aprIn,
            double duration)
        {
            
            // local variable for months
            double months = duration * 12;

            // Calculation
            double monthlyPayment = (princIn * aprIn *
                Math.Pow(1 + aprIn, months))
                / (Math.Pow(1 + aprIn, months) - 1);

            return monthlyPayment;
        }

        /// <summary>
        /// Clear the user output
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLoan.Clear();
            txtMonthly.Clear();
            txtAPR.Clear();
            txtTotal.Clear();
            txtYear.Clear();
            lstOutput.Items.Clear();
        }


        /// <summary>
        /// Close the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
