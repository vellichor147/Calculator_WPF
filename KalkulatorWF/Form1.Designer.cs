namespace KalkulatorWF
{
    partial class mainWindow
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
            this.calculatorScreen = new System.Windows.Forms.TextBox();
            this.b0 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.sub_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.multi_button = new System.Windows.Forms.Button();
            this.div_button = new System.Windows.Forms.Button();
            this.enter_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.com_button = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculatorScreen
            // 
            this.calculatorScreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculatorScreen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculatorScreen.Location = new System.Drawing.Point(12, 12);
            this.calculatorScreen.Name = "calculatorScreen";
            this.calculatorScreen.Size = new System.Drawing.Size(303, 20);
            this.calculatorScreen.TabIndex = 0;
            this.calculatorScreen.TextChanged += new System.EventHandler(this.textBox1);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(12, 59);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(50, 50);
            this.b0.TabIndex = 1;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b1
            // 
            this.b1.AutoEllipsis = true;
            this.b1.Location = new System.Drawing.Point(68, 59);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(50, 50);
            this.b1.TabIndex = 2;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(124, 59);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(50, 50);
            this.b2.TabIndex = 3;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(12, 115);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(50, 50);
            this.b3.TabIndex = 4;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(68, 115);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(50, 50);
            this.b4.TabIndex = 5;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(124, 115);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(50, 50);
            this.b5.TabIndex = 6;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(12, 171);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(50, 50);
            this.b6.TabIndex = 7;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(68, 171);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(50, 50);
            this.b7.TabIndex = 8;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(124, 171);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(50, 50);
            this.b8.TabIndex = 9;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(12, 227);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(50, 50);
            this.b9.TabIndex = 10;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // sub_button
            // 
            this.sub_button.Location = new System.Drawing.Point(256, 59);
            this.sub_button.Name = "sub_button";
            this.sub_button.Size = new System.Drawing.Size(50, 50);
            this.sub_button.TabIndex = 11;
            this.sub_button.Text = "-";
            this.sub_button.UseVisualStyleBackColor = true;
            this.sub_button.Click += new System.EventHandler(this.sub_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(203, 59);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(50, 50);
            this.add_button.TabIndex = 11;
            this.add_button.Text = "+";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // multi_button
            // 
            this.multi_button.Location = new System.Drawing.Point(203, 115);
            this.multi_button.Name = "multi_button";
            this.multi_button.Size = new System.Drawing.Size(50, 50);
            this.multi_button.TabIndex = 12;
            this.multi_button.Text = "*";
            this.multi_button.UseVisualStyleBackColor = true;
            this.multi_button.Click += new System.EventHandler(this.multi_button_Click);
            // 
            // div_button
            // 
            this.div_button.Location = new System.Drawing.Point(256, 115);
            this.div_button.Name = "div_button";
            this.div_button.Size = new System.Drawing.Size(50, 50);
            this.div_button.TabIndex = 13;
            this.div_button.Text = "/";
            this.div_button.UseVisualStyleBackColor = true;
            this.div_button.Click += new System.EventHandler(this.div_button_Click);
            // 
            // enter_button
            // 
            this.enter_button.Location = new System.Drawing.Point(68, 227);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(106, 50);
            this.enter_button.TabIndex = 14;
            this.enter_button.Text = "Enter";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(256, 230);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(50, 50);
            this.del_button.TabIndex = 15;
            this.del_button.Text = "Delete";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // com_button
            // 
            this.com_button.Location = new System.Drawing.Point(203, 230);
            this.com_button.Name = "com_button";
            this.com_button.Size = new System.Drawing.Size(50, 50);
            this.com_button.TabIndex = 16;
            this.com_button.Text = ",";
            this.com_button.UseVisualStyleBackColor = true;
            this.com_button.Click += new System.EventHandler(this.com_button_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(203, 171);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(50, 50);
            this.testButton.TabIndex = 17;
            this.testButton.Text = "test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // mainWindow
            // 
            this.AcceptButton = this.enter_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(323, 334);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.com_button);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.div_button);
            this.Controls.Add(this.multi_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.sub_button);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.calculatorScreen);
            this.Name = "mainWindow";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainWindow_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainWindow_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calculatorScreen;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button sub_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button multi_button;
        private System.Windows.Forms.Button div_button;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Button com_button;
        private System.Windows.Forms.Button testButton;
    }
}

