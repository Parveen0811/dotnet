namespace To_do_list
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
            dataGridView = new DataGridView();
            newbutton = new Button();
            savebutton = new Button();
            editbutton = new Button();
            deletebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.BorderStyle = BorderStyle.None;
            textBox.Font = new Font("Segoe UI", 20F);
            textBox.Location = new Point(12, 30);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.PlaceholderText = "Text ";
            textBox.Size = new Size(426, 58);
            textBox.TabIndex = 0;
            textBox.TextAlign = HorizontalAlignment.Right;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(13, 162);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(425, 276);
            dataGridView.TabIndex = 5;
            // 
            // newbutton
            // 
            newbutton.Location = new Point(13, 98);
            newbutton.Name = "newbutton";
            newbutton.Size = new Size(94, 49);
            newbutton.TabIndex = 6;
            newbutton.Text = "NEW";
            newbutton.UseVisualStyleBackColor = true;
            newbutton.Click += newbutton_Click;
            // 
            // savebutton
            // 
            savebutton.Location = new Point(123, 98);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(94, 49);
            savebutton.TabIndex = 7;
            savebutton.Text = "SAVE";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += savebutton_Click;
            // 
            // editbutton
            // 
            editbutton.Location = new Point(237, 98);
            editbutton.Name = "editbutton";
            editbutton.Size = new Size(94, 49);
            editbutton.TabIndex = 8;
            editbutton.Text = "Edit";
            editbutton.UseVisualStyleBackColor = true;
            editbutton.Click += editbutton_Click;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(344, 98);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(94, 49);
            deletebutton.TabIndex = 9;
            deletebutton.Text = "DELETE";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(450, 450);
            Controls.Add(deletebutton);
            Controls.Add(editbutton);
            Controls.Add(savebutton);
            Controls.Add(newbutton);
            Controls.Add(dataGridView);
            Controls.Add(textBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private DataGridView dataGridView;
        private Button newbutton;
        private Button savebutton;
        private Button editbutton;
        private Button deletebutton;
    }
}
