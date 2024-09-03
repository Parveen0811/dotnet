namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox = new TextBox();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            button30 = new Button();
            button31 = new Button();
            button32 = new Button();
            button33 = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.BorderStyle = BorderStyle.None;
            textBox.Font = new Font("Segoe UI", 30F);
            textBox.Location = new Point(12, 93);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.PlaceholderText = "0";
            textBox.ReadOnly = true;
            textBox.RightToLeft = RightToLeft.Yes;
            textBox.Size = new Size(363, 66);
            textBox.TabIndex = 30;
            // 
            // button17
            // 
            button17.Location = new Point(289, 245);
            button17.Name = "button17";
            button17.Size = new Size(86, 45);
            button17.TabIndex = 32;
            button17.Text = "/";
            button17.UseVisualStyleBackColor = true;
            button17.Click += operator_click;
            // 
            // button18
            // 
            button18.Location = new Point(197, 245);
            button18.Name = "button18";
            button18.Size = new Size(86, 45);
            button18.TabIndex = 31;
            button18.Text = "9";
            button18.UseVisualStyleBackColor = true;
            button18.Click += digit_click;
            // 
            // button19
            // 
            button19.Location = new Point(105, 245);
            button19.Name = "button19";
            button19.Size = new Size(86, 45);
            button19.TabIndex = 30;
            button19.Text = "8";
            button19.UseVisualStyleBackColor = true;
            button19.Click += digit_click;
            // 
            // button20
            // 
            button20.Location = new Point(13, 245);
            button20.Name = "button20";
            button20.Size = new Size(86, 45);
            button20.TabIndex = 29;
            button20.Text = "7";
            button20.UseVisualStyleBackColor = true;
            button20.Click += digit_click;
            // 
            // button21
            // 
            button21.Location = new Point(289, 296);
            button21.Name = "button21";
            button21.Size = new Size(86, 45);
            button21.TabIndex = 28;
            button21.Text = "*";
            button21.UseVisualStyleBackColor = true;
            button21.Click += operator_click;
            // 
            // button22
            // 
            button22.Location = new Point(197, 296);
            button22.Name = "button22";
            button22.Size = new Size(86, 45);
            button22.TabIndex = 27;
            button22.Text = "6";
            button22.UseVisualStyleBackColor = true;
            button22.Click += digit_click;
            // 
            // button23
            // 
            button23.Location = new Point(105, 296);
            button23.Name = "button23";
            button23.Size = new Size(86, 45);
            button23.TabIndex = 26;
            button23.Text = "5";
            button23.UseVisualStyleBackColor = true;
            button23.Click += digit_click;
            // 
            // button24
            // 
            button24.Location = new Point(13, 296);
            button24.Name = "button24";
            button24.Size = new Size(86, 45);
            button24.TabIndex = 25;
            button24.Text = "4";
            button24.UseVisualStyleBackColor = true;
            button24.Click += digit_click;
            // 
            // button25
            // 
            button25.Location = new Point(289, 347);
            button25.Name = "button25";
            button25.Size = new Size(86, 45);
            button25.TabIndex = 24;
            button25.Text = "-";
            button25.UseVisualStyleBackColor = true;
            button25.Click += operator_click;
            // 
            // button26
            // 
            button26.Location = new Point(197, 347);
            button26.Name = "button26";
            button26.Size = new Size(86, 45);
            button26.TabIndex = 23;
            button26.Text = "3";
            button26.UseVisualStyleBackColor = true;
            button26.Click += digit_click;
            // 
            // button27
            // 
            button27.Location = new Point(105, 347);
            button27.Name = "button27";
            button27.Size = new Size(86, 45);
            button27.TabIndex = 22;
            button27.Text = "2";
            button27.UseVisualStyleBackColor = true;
            button27.Click += digit_click;
            // 
            // button28
            // 
            button28.Location = new Point(13, 347);
            button28.Name = "button28";
            button28.Size = new Size(86, 45);
            button28.TabIndex = 21;
            button28.Text = "1";
            button28.UseVisualStyleBackColor = true;
            button28.Click += digit_click;
            // 
            // button29
            // 
            button29.Location = new Point(289, 398);
            button29.Name = "button29";
            button29.Size = new Size(86, 45);
            button29.TabIndex = 20;
            button29.Text = "+";
            button29.UseVisualStyleBackColor = true;
            button29.Click += operator_click;
            // 
            // button30
            // 
            button30.Location = new Point(197, 398);
            button30.Name = "button30";
            button30.Size = new Size(86, 45);
            button30.TabIndex = 19;
            button30.Text = "=";
            button30.UseVisualStyleBackColor = true;
            button30.Click += equalto_click;
            // 
            // button31
            // 
            button31.Location = new Point(105, 398);
            button31.Name = "button31";
            button31.Size = new Size(86, 45);
            button31.TabIndex = 18;
            button31.Text = "0";
            button31.UseVisualStyleBackColor = true;
            button31.Click += digit_click;
            // 
            // button32
            // 
            button32.Location = new Point(13, 398);
            button32.Name = "button32";
            button32.Size = new Size(86, 45);
            button32.TabIndex = 17;
            button32.Text = ".";
            button32.UseVisualStyleBackColor = true;
            button32.Click += digit_click;
            // 
            // button33
            // 
            button33.Location = new Point(266, 176);
            button33.Name = "button33";
            button33.Size = new Size(109, 63);
            button33.TabIndex = 33;
            button33.Text = "C";
            button33.UseVisualStyleBackColor = true;
            button33.Click += clear_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 450);
            Controls.Add(button33);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button21);
            Controls.Add(button22);
            Controls.Add(button23);
            Controls.Add(button24);
            Controls.Add(button25);
            Controls.Add(button26);
            Controls.Add(button27);
            Controls.Add(button28);
            Controls.Add(button29);
            Controls.Add(button30);
            Controls.Add(button31);
            Controls.Add(button32);
            Controls.Add(textBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private TextBox textBox;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button button30;
        private Button button31;
        private Button button32;
        private Button button33;
    }
}
