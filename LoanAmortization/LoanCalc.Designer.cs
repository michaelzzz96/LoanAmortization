namespace LoanAmortization
{
    partial class LoanCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbLoan = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtMonthly = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAPR = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.grbLoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLoan
            // 
            this.grbLoan.Controls.Add(this.btnClose);
            this.grbLoan.Controls.Add(this.txtTotal);
            this.grbLoan.Controls.Add(this.txtMonthly);
            this.grbLoan.Controls.Add(this.label4);
            this.grbLoan.Controls.Add(this.label3);
            this.grbLoan.Controls.Add(this.label2);
            this.grbLoan.Controls.Add(this.label1);
            this.grbLoan.Controls.Add(this.txtAPR);
            this.grbLoan.Controls.Add(this.txtYear);
            this.grbLoan.Controls.Add(this.lblLoanAmount);
            this.grbLoan.Controls.Add(this.btnClear);
            this.grbLoan.Controls.Add(this.txtLoan);
            this.grbLoan.Controls.Add(this.btnCalculate);
            this.grbLoan.Location = new System.Drawing.Point(12, 12);
            this.grbLoan.Name = "grbLoan";
            this.grbLoan.Size = new System.Drawing.Size(403, 460);
            this.grbLoan.TabIndex = 6;
            this.grbLoan.TabStop = false;
            this.grbLoan.Text = "Loan Data Input";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(341, 388);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 35);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(200, 327);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(134, 26);
            this.txtTotal.TabIndex = 10;
            // 
            // txtMonthly
            // 
            this.txtMonthly.Location = new System.Drawing.Point(200, 266);
            this.txtMonthly.Name = "txtMonthly";
            this.txtMonthly.ReadOnly = true;
            this.txtMonthly.Size = new System.Drawing.Size(134, 26);
            this.txtMonthly.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Money Paid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Montly Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "APR percent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Term in Years( 1 to 50)";
            // 
            // txtAPR
            // 
            this.txtAPR.Location = new System.Drawing.Point(200, 183);
            this.txtAPR.Name = "txtAPR";
            this.txtAPR.Size = new System.Drawing.Size(134, 26);
            this.txtAPR.TabIndex = 4;
            this.txtAPR.Text = "6";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(200, 110);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(134, 26);
            this.txtYear.TabIndex = 3;
            this.txtYear.Text = "30";
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(6, 44);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(105, 20);
            this.lblLoanAmount.TabIndex = 1;
            this.lblLoanAmount.Text = "Loan Amount";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(10, 384);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 43);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(200, 44);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(134, 26);
            this.txtLoan.TabIndex = 2;
            this.txtLoan.Text = "100000.00";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(181, 383);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(153, 44);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Amortize";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 19;
            this.lstOutput.Location = new System.Drawing.Point(437, 12);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(452, 460);
            this.lstOutput.TabIndex = 7;
            // 
            // LoanCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 491);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.grbLoan);
            this.Name = "LoanCalc";
            this.Text = "Loan Amortization";
            this.grbLoan.ResumeLayout(false);
            this.grbLoan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLoan;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtMonthly;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAPR;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

