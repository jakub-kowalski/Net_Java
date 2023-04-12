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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(381, 60);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Kontynuuj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // displayData
            // 
            displayData.Location = new Point(905, 60);
            displayData.Multiline = true;
            displayData.Name = "displayData";
            displayData.ScrollBars = ScrollBars.Vertical;
            displayData.Size = new Size(305, 604);
            displayData.TabIndex = 1;
            displayData.TextChanged += textBox1_TextChanged;
            // 
            // readName
            // 
            readName.Location = new Point(10, 60);
            readName.Name = "readName";
            readName.PlaceholderText = "ID lub nazwa";
            readName.Size = new Size(240, 27);
            readName.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.Location = new Point(10, 12);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(240, 27);
            textBox3.TabIndex = 3;
            textBox3.Text = "Podaj numer lub nazwę Pokemona:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 705);
            Controls.Add(textBox3);
            Controls.Add(readName);
            Controls.Add(displayData);
            Controls.Add(button1);
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
    }
}