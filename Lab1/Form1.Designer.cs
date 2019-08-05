using System.Windows.Forms;

namespace Lab1
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.result = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.expression = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.deleteLast = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.negative = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labela = new System.Windows.Forms.Label();
            this.labelb = new System.Windows.Forms.Label();
            this.labelc = new System.Windows.Forms.Label();
            this.avalue = new System.Windows.Forms.TextBox();
            this.bvalue = new System.Windows.Forms.TextBox();
            this.cvalue = new System.Windows.Forms.TextBox();
            this.resetPythagoreanTheoremFormButton = new System.Windows.Forms.Button();
            this.calculatePythagoreanTheoremButton = new System.Windows.Forms.Button();
            this.quadraticEquationLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateRootsButton = new System.Windows.Forms.Button();
            this.resetEquationButton = new System.Windows.Forms.Button();
            this.aconst = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bconst = new System.Windows.Forms.TextBox();
            this.cconst = new System.Windows.Forms.TextBox();
            this.firstRootLabel = new System.Windows.Forms.Label();
            this.secondRootLabel = new System.Windows.Forms.Label();
            this.firstRoot = new System.Windows.Forms.Label();
            this.secondRoot = new System.Windows.Forms.Label();
            this.rootsBox = new System.Windows.Forms.GroupBox();
            this.noRootsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.rootsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(89, 46);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(318, 27);
            this.result.TabIndex = 0;
            this.result.Text = "0";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(89, 134);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.AddDigit);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(170, 134);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.AddDigit);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(251, 134);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.AddDigit);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(251, 163);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.AddDigit);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(170, 163);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AddDigit);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(89, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AddDigit);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(251, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddDigit);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(170, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddDigit);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(89, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddDigit);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(170, 221);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 23);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.AddDigit);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(332, 134);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = "x";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.AddDigit);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(332, 105);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 12;
            this.button12.Text = "/";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.AddDigit);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(332, 163);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 14;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.AddDigit);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(332, 192);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 13;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.AddDigit);
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(332, 221);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 15;
            this.calculate.Text = "=";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.Calculate);
            // 
            // expression
            // 
            this.expression.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expression.Location = new System.Drawing.Point(89, 9);
            this.expression.Name = "expression";
            this.expression.Size = new System.Drawing.Size(318, 27);
            this.expression.TabIndex = 16;
            this.expression.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(89, 105);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 17;
            this.clear.Text = "CE";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear);
            // 
            // clearAll
            // 
            this.clearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAll.Location = new System.Drawing.Point(170, 105);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(75, 23);
            this.clearAll.TabIndex = 18;
            this.clearAll.Text = "C";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.ClearAll);
            // 
            // deleteLast
            // 
            this.deleteLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLast.Location = new System.Drawing.Point(251, 105);
            this.deleteLast.Name = "deleteLast";
            this.deleteLast.Size = new System.Drawing.Size(75, 23);
            this.deleteLast.TabIndex = 19;
            this.deleteLast.Text = "<-";
            this.deleteLast.UseVisualStyleBackColor = true;
            this.deleteLast.Click += new System.EventHandler(this.DeleteLast);
            // 
            // point
            // 
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(251, 221);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(75, 23);
            this.point.TabIndex = 20;
            this.point.Text = ",";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.AddPoint);
            // 
            // negative
            // 
            this.negative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negative.Location = new System.Drawing.Point(89, 221);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(75, 23);
            this.negative.TabIndex = 21;
            this.negative.Text = "+-";
            this.negative.UseVisualStyleBackColor = true;
            this.negative.Click += new System.EventHandler(this.MakeNegative);
            // 
            // tan
            // 
            this.tan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tan.Location = new System.Drawing.Point(332, 76);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 25;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.CalculateTrigonometric);
            // 
            // cos
            // 
            this.cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cos.Location = new System.Drawing.Point(251, 76);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 24;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.CalculateTrigonometric);
            // 
            // sin
            // 
            this.sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sin.Location = new System.Drawing.Point(170, 76);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 23;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.CalculateTrigonometric);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-3, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 3);
            this.label1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(438, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Pythagoras\' theorem                                         a^2 + b^2 = c^2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela.Location = new System.Drawing.Point(295, 305);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(28, 17);
            this.labela.TabIndex = 30;
            this.labela.Text = "a =";
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelb.Location = new System.Drawing.Point(295, 343);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(28, 17);
            this.labelb.TabIndex = 31;
            this.labelb.Text = "b =";
            // 
            // labelc
            // 
            this.labelc.AutoSize = true;
            this.labelc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelc.Location = new System.Drawing.Point(296, 382);
            this.labelc.Name = "labelc";
            this.labelc.Size = new System.Drawing.Size(27, 17);
            this.labelc.TabIndex = 32;
            this.labelc.Text = "c =";
            // 
            // avalue
            // 
            this.avalue.Location = new System.Drawing.Point(332, 304);
            this.avalue.Name = "avalue";
            this.avalue.Size = new System.Drawing.Size(100, 20);
            this.avalue.TabIndex = 33;
            // 
            // bvalue
            // 
            this.bvalue.Location = new System.Drawing.Point(332, 342);
            this.bvalue.Name = "bvalue";
            this.bvalue.Size = new System.Drawing.Size(100, 20);
            this.bvalue.TabIndex = 34;
            // 
            // cvalue
            // 
            this.cvalue.Location = new System.Drawing.Point(332, 381);
            this.cvalue.Name = "cvalue";
            this.cvalue.Size = new System.Drawing.Size(100, 20);
            this.cvalue.TabIndex = 35;
            // 
            // resetPythagoreanTheoremFormButton
            // 
            this.resetPythagoreanTheoremFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPythagoreanTheoremFormButton.Location = new System.Drawing.Point(332, 442);
            this.resetPythagoreanTheoremFormButton.Name = "resetPythagoreanTheoremFormButton";
            this.resetPythagoreanTheoremFormButton.Size = new System.Drawing.Size(100, 23);
            this.resetPythagoreanTheoremFormButton.TabIndex = 36;
            this.resetPythagoreanTheoremFormButton.Text = "Clear";
            this.resetPythagoreanTheoremFormButton.UseVisualStyleBackColor = true;
            this.resetPythagoreanTheoremFormButton.Click += new System.EventHandler(this.ResetPythagoreanTheoremForm);
            // 
            // calculatePythagoreanTheoremButton
            // 
            this.calculatePythagoreanTheoremButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatePythagoreanTheoremButton.Location = new System.Drawing.Point(332, 413);
            this.calculatePythagoreanTheoremButton.Name = "calculatePythagoreanTheoremButton";
            this.calculatePythagoreanTheoremButton.Size = new System.Drawing.Size(100, 23);
            this.calculatePythagoreanTheoremButton.TabIndex = 37;
            this.calculatePythagoreanTheoremButton.Text = "Calculate";
            this.calculatePythagoreanTheoremButton.UseVisualStyleBackColor = true;
            this.calculatePythagoreanTheoremButton.Click += new System.EventHandler(this.CalculatePythagoreanTheorem);
            // 
            // quadraticEquationLabel
            // 
            this.quadraticEquationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quadraticEquationLabel.Location = new System.Drawing.Point(24, 503);
            this.quadraticEquationLabel.Name = "quadraticEquationLabel";
            this.quadraticEquationLabel.Size = new System.Drawing.Size(452, 16);
            this.quadraticEquationLabel.TabIndex = 39;
            this.quadraticEquationLabel.Text = "Roots of a Quadratic Equation                           ax^2 + bx + c = 0";
            this.quadraticEquationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(-3, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(636, 3);
            this.label4.TabIndex = 38;
            // 
            // calculateRootsButton
            // 
            this.calculateRootsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateRootsButton.Location = new System.Drawing.Point(332, 591);
            this.calculateRootsButton.Name = "calculateRootsButton";
            this.calculateRootsButton.Size = new System.Drawing.Size(100, 23);
            this.calculateRootsButton.TabIndex = 41;
            this.calculateRootsButton.Text = "Calculate";
            this.calculateRootsButton.UseVisualStyleBackColor = true;
            this.calculateRootsButton.Click += new System.EventHandler(this.CalculateRootsOfQuadraticEquation);
            // 
            // resetEquationButton
            // 
            this.resetEquationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetEquationButton.Location = new System.Drawing.Point(332, 620);
            this.resetEquationButton.Name = "resetEquationButton";
            this.resetEquationButton.Size = new System.Drawing.Size(100, 23);
            this.resetEquationButton.TabIndex = 40;
            this.resetEquationButton.Text = "Clear";
            this.resetEquationButton.UseVisualStyleBackColor = true;
            this.resetEquationButton.Click += new System.EventHandler(this.ResetQuadraticEquationForm);
            // 
            // aconst
            // 
            this.aconst.Location = new System.Drawing.Point(101, 540);
            this.aconst.Name = "aconst";
            this.aconst.Size = new System.Drawing.Size(63, 20);
            this.aconst.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "x^2 + ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "x +";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(379, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "= 0";
            // 
            // bconst
            // 
            this.bconst.Location = new System.Drawing.Point(212, 540);
            this.bconst.Name = "bconst";
            this.bconst.Size = new System.Drawing.Size(63, 20);
            this.bconst.TabIndex = 47;
            // 
            // cconst
            // 
            this.cconst.Location = new System.Drawing.Point(310, 540);
            this.cconst.Name = "cconst";
            this.cconst.Size = new System.Drawing.Size(63, 20);
            this.cconst.TabIndex = 48;
            // 
            // firstRootLabel
            // 
            this.firstRootLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstRootLabel.Location = new System.Drawing.Point(6, 29);
            this.firstRootLabel.Name = "firstRootLabel";
            this.firstRootLabel.Size = new System.Drawing.Size(40, 20);
            this.firstRootLabel.TabIndex = 51;
            this.firstRootLabel.Text = "x1 =";
            this.firstRootLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondRootLabel
            // 
            this.secondRootLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondRootLabel.Location = new System.Drawing.Point(6, 58);
            this.secondRootLabel.Name = "secondRootLabel";
            this.secondRootLabel.Size = new System.Drawing.Size(40, 20);
            this.secondRootLabel.TabIndex = 52;
            this.secondRootLabel.Text = "x2 =";
            this.secondRootLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstRoot
            // 
            this.firstRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstRoot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.firstRoot.Location = new System.Drawing.Point(52, 29);
            this.firstRoot.Name = "firstRoot";
            this.firstRoot.Size = new System.Drawing.Size(195, 20);
            this.firstRoot.TabIndex = 53;
            this.firstRoot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // secondRoot
            // 
            this.secondRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondRoot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.secondRoot.Location = new System.Drawing.Point(50, 58);
            this.secondRoot.Name = "secondRoot";
            this.secondRoot.Size = new System.Drawing.Size(197, 20);
            this.secondRoot.TabIndex = 54;
            this.secondRoot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rootsBox
            // 
            this.rootsBox.Controls.Add(this.noRootsLabel);
            this.rootsBox.Controls.Add(this.firstRoot);
            this.rootsBox.Controls.Add(this.secondRoot);
            this.rootsBox.Controls.Add(this.firstRootLabel);
            this.rootsBox.Controls.Add(this.secondRootLabel);
            this.rootsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootsBox.Location = new System.Drawing.Point(54, 575);
            this.rootsBox.Name = "rootsBox";
            this.rootsBox.Size = new System.Drawing.Size(253, 89);
            this.rootsBox.TabIndex = 55;
            this.rootsBox.TabStop = false;
            this.rootsBox.Text = "Roots";
            // 
            // noRootsLabel
            // 
            this.noRootsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noRootsLabel.Location = new System.Drawing.Point(6, 21);
            this.noRootsLabel.Name = "noRootsLabel";
            this.noRootsLabel.Size = new System.Drawing.Size(241, 57);
            this.noRootsLabel.TabIndex = 56;
            this.noRootsLabel.Text = "If the discriminant is less than zero, then the quadratic has no real solutions.";
            this.noRootsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noRootsLabel.UseMnemonic = false;
            this.noRootsLabel.Visible = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 752);
            this.Controls.Add(this.rootsBox);
            this.Controls.Add(this.cconst);
            this.Controls.Add(this.bconst);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aconst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calculateRootsButton);
            this.Controls.Add(this.resetEquationButton);
            this.Controls.Add(this.quadraticEquationLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculatePythagoreanTheoremButton);
            this.Controls.Add(this.resetPythagoreanTheoremFormButton);
            this.Controls.Add(this.cvalue);
            this.Controls.Add(this.bvalue);
            this.Controls.Add(this.avalue);
            this.Controls.Add(this.labelc);
            this.Controls.Add(this.labelb);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.negative);
            this.Controls.Add(this.point);
            this.Controls.Add(this.deleteLast);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.expression);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.result);
            this.Name = "Calculator";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.rootsBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label expression;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button deleteLast;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button negative;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label labela;
        private Label labelb;
        private Label labelc;
        private TextBox avalue;
        private TextBox bvalue;
        private TextBox cvalue;
        private Button resetPythagoreanTheoremFormButton;
        private Button calculatePythagoreanTheoremButton;
        private Label quadraticEquationLabel;
        private Label label4;
        private Button calculateRootsButton;
        private Button resetEquationButton;
        private TextBox aconst;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox bconst;
        private TextBox cconst;
        private Label firstRootLabel;
        private Label secondRootLabel;
        private Label firstRoot;
        private Label secondRoot;
        private GroupBox rootsBox;
        private Label noRootsLabel;
    }
}

