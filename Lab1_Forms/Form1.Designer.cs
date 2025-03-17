namespace Lab1_Forms
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
            seedTextBox = new TextBox();
            numberOfItemsTextBox = new TextBox();
            capacityTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            instanceTextBox = new TextBox();
            resultTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(59, 208);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 0;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // seedTextBox
            // 
            seedTextBox.Location = new Point(59, 51);
            seedTextBox.Name = "seedTextBox";
            seedTextBox.Size = new Size(100, 23);
            seedTextBox.TabIndex = 1;
            // 
            // numberOfItemsTextBox
            // 
            numberOfItemsTextBox.Location = new Point(59, 104);
            numberOfItemsTextBox.Name = "numberOfItemsTextBox";
            numberOfItemsTextBox.Size = new Size(100, 23);
            numberOfItemsTextBox.TabIndex = 2;
            // 
            // capacityTextBox
            // 
            capacityTextBox.Location = new Point(59, 154);
            capacityTextBox.Name = "capacityTextBox";
            capacityTextBox.Size = new Size(100, 23);
            capacityTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 33);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 4;
            label1.Text = "Seed:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 86);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 5;
            label2.Text = "Number of Items:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 136);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "Capacity:";
            // 
            // instanceTextBox
            // 
            instanceTextBox.Location = new Point(201, 51);
            instanceTextBox.Multiline = true;
            instanceTextBox.Name = "instanceTextBox";
            instanceTextBox.ReadOnly = true;
            instanceTextBox.ScrollBars = ScrollBars.Vertical;
            instanceTextBox.Size = new Size(444, 535);
            instanceTextBox.TabIndex = 7;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(694, 51);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(444, 535);
            resultTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 33);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 9;
            label4.Text = "Instance:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(694, 33);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 10;
            label5.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 661);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(resultTextBox);
            Controls.Add(instanceTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(capacityTextBox);
            Controls.Add(numberOfItemsTextBox);
            Controls.Add(seedTextBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox seedTextBox;
        private TextBox numberOfItemsTextBox;
        private TextBox capacityTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox instanceTextBox;
        private TextBox resultTextBox;
        private Label label4;
        private Label label5;
    }
}
