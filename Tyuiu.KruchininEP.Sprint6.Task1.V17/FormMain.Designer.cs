namespace Tyuiu.KruchininEP.Sprint6.Task1.V17
{
    partial class FormMain
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
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            buttonHelp_KEP = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            buttonExecute_KEP = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(358, 148);
            textBox1.TabIndex = 0;
            textBox1.Text = "Написать программу, которая выводит таблицу значений функции: на заданном диапазоне";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ФормулаТаск0;
            pictureBox1.Location = new Point(30, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 81);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // buttonHelp_KEP
            // 
            buttonHelp_KEP.Location = new Point(319, 400);
            buttonHelp_KEP.Name = "buttonHelp_KEP";
            buttonHelp_KEP.Size = new Size(78, 68);
            buttonHelp_KEP.TabIndex = 2;
            buttonHelp_KEP.Text = "Справка";
            buttonHelp_KEP.UseVisualStyleBackColor = true;
            buttonHelp_KEP.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(575, 32);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(282, 436);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(575, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 4;
            label1.Text = "Вывод данных";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(21, 441);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(174, 441);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 400);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 7;
            label2.Text = "Старт шага";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 400);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 8;
            label3.Text = "Конец шага";
            // 
            // buttonExecute_KEP
            // 
            buttonExecute_KEP.Location = new Point(417, 400);
            buttonExecute_KEP.Name = "buttonExecute_KEP";
            buttonExecute_KEP.Size = new Size(126, 68);
            buttonExecute_KEP.TabIndex = 9;
            buttonExecute_KEP.Text = "Выполнить";
            buttonExecute_KEP.UseVisualStyleBackColor = true;
            buttonExecute_KEP.Click += buttonExecute_KEP_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 480);
            Controls.Add(buttonExecute_KEP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(buttonHelp_KEP);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button buttonHelp_KEP;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Button buttonExecute_KEP;
    }
}
