namespace LAB2
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
            button1 = new Button();
            displayData = new TextBox();
            readName = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(137, 72);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 0;
            button1.Text = "Kontynuuj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // displayData
            // 
            displayData.Location = new Point(9, 107);
            displayData.Margin = new Padding(3, 2, 3, 2);
            displayData.Multiline = true;
            displayData.Name = "displayData";
            displayData.Size = new Size(210, 88);
            displayData.TabIndex = 1;
            displayData.TextChanged += textBox1_TextChanged;
            // 
            // readName
            // 
            readName.Location = new Point(9, 45);
            readName.Margin = new Padding(3, 2, 3, 2);
            readName.Name = "readName";
            readName.PlaceholderText = "ID lub nazwa";
            readName.Size = new Size(210, 23);
            readName.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.Location = new Point(9, 11);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(210, 23);
            textBox3.TabIndex = 3;
            textBox3.Text = "Podaj numer lub nazwę Pokemona:";
            // 
            // button2
            // 
            button2.Location = new Point(9, 72);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(119, 22);
            button2.TabIndex = 4;
            button2.Text = "Generuj losowo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 215);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(readName);
            Controls.Add(displayData);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Pokedex";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox displayData;
        private TextBox readName;
        private TextBox textBox3;
        private Button button2;
    }
}