
namespace CalculatingNumbers
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDivition = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnNegetive = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNegetive);
            this.panel1.Controls.Add(this.btnCE);
            this.panel1.Controls.Add(this.btnEqual);
            this.panel1.Controls.Add(this.btnDivition);
            this.panel1.Controls.Add(this.btnSub);
            this.panel1.Controls.Add(this.btnSum);
            this.panel1.Controls.Add(this.btnMultiply);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnBackspace);
            this.panel1.Controls.Add(this.btnPoint);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(2, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 158);
            this.panel1.TabIndex = 0;
            // 
            // btnCE
            // 
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCE.Location = new System.Drawing.Point(12, 14);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(33, 23);
            this.btnCE.TabIndex = 25;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEqual.Location = new System.Drawing.Point(129, 128);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(33, 23);
            this.btnEqual.TabIndex = 22;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEqual_MouseClick);
            // 
            // btnDivition
            // 
            this.btnDivition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivition.Location = new System.Drawing.Point(129, 41);
            this.btnDivition.Name = "btnDivition";
            this.btnDivition.Size = new System.Drawing.Size(33, 23);
            this.btnDivition.TabIndex = 21;
            this.btnDivition.Text = "/";
            this.btnDivition.UseVisualStyleBackColor = true;
            this.btnDivition.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators);
            // 
            // btnSub
            // 
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSub.Location = new System.Drawing.Point(129, 70);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(33, 23);
            this.btnSub.TabIndex = 20;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators);
            // 
            // btnSum
            // 
            this.btnSum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSum.Location = new System.Drawing.Point(129, 99);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(33, 23);
            this.btnSum.TabIndex = 19;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators);
            // 
            // btnMultiply
            // 
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiply.Location = new System.Drawing.Point(129, 14);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(33, 23);
            this.btnMultiply.TabIndex = 18;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(51, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(33, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackspace.Location = new System.Drawing.Point(90, 14);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(33, 23);
            this.btnBackspace.TabIndex = 14;
            this.btnBackspace.Text = "--->";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBackspace_MouseClick);
            // 
            // btnPoint
            // 
            this.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPoint.Location = new System.Drawing.Point(90, 128);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(33, 23);
            this.btnPoint.TabIndex = 13;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Location = new System.Drawing.Point(90, 41);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(33, 23);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Location = new System.Drawing.Point(51, 41);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(33, 23);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Location = new System.Drawing.Point(12, 41);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(33, 23);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Location = new System.Drawing.Point(90, 70);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(33, 23);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Location = new System.Drawing.Point(51, 70);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(33, 23);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Location = new System.Drawing.Point(12, 70);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(33, 23);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Location = new System.Drawing.Point(90, 99);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(33, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Location = new System.Drawing.Point(51, 99);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(33, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Location = new System.Drawing.Point(12, 99);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(33, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // btn0
            // 
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Location = new System.Drawing.Point(51, 128);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(33, 23);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // btnOnOff
            // 
            this.btnOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOnOff.Location = new System.Drawing.Point(108, 41);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(56, 23);
            this.btnOnOff.TabIndex = 23;
            this.btnOnOff.Text = "On";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDisplay.Size = new System.Drawing.Size(152, 20);
            this.txtDisplay.TabIndex = 24;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // btnNegetive
            // 
            this.btnNegetive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNegetive.Location = new System.Drawing.Point(12, 128);
            this.btnNegetive.Name = "btnNegetive";
            this.btnNegetive.Size = new System.Drawing.Size(33, 23);
            this.btnNegetive.TabIndex = 26;
            this.btnNegetive.Text = "-/+";
            this.btnNegetive.UseVisualStyleBackColor = true;
            this.btnNegetive.Click += new System.EventHandler(this.btnNegetive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(183, 229);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDivition;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnNegetive;
    }
}

