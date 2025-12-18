namespace Tyuiu.KruchininEP.Sprint6.Task7.V10
{
    partial class FormMain
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            dataGridViewInKEP = new DataGridView();
            groupBoxInKEP = new GroupBox();
            labelInKEP = new Label();
            dataGridViewOutKEP = new DataGridView();
            groupBoxOutKEP = new GroupBox();
            labelOutKEP = new Label();
            panelButtonsKEP = new Panel();
            buttonHelpKEP = new Button();
            buttonSaveKEP = new Button();
            buttonDoneKEP = new Button();
            buttonOpenKEP = new Button();
            statusStripKEP = new StatusStrip();
            toolStripStatusLabelInfo = new ToolStripStatusLabel();
            toolStripStatusLabelRows = new ToolStripStatusLabel();
            toolStripStatusLabelCols = new ToolStripStatusLabel();
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogTask = new SaveFileDialog();
            toolTipButton = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInKEP).BeginInit();
            groupBoxInKEP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutKEP).BeginInit();
            groupBoxOutKEP.SuspendLayout();
            panelButtonsKEP.SuspendLayout();
            statusStripKEP.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(16, 131);
            splitContainer1.Margin = new Padding(4, 5, 4, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridViewInKEP);
            splitContainer1.Panel1.Controls.Add(groupBoxInKEP);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridViewOutKEP);
            splitContainer1.Panel2.Controls.Add(groupBoxOutKEP);
            splitContainer1.Size = new Size(1280, 692);
            splitContainer1.SplitterDistance = 633;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridViewInKEP
            // 
            dataGridViewInKEP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewInKEP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInKEP.Location = new Point(4, 85);
            dataGridViewInKEP.Margin = new Padding(4, 5, 4, 5);
            dataGridViewInKEP.Name = "dataGridViewInKEP";
            dataGridViewInKEP.RowHeadersWidth = 51;
            dataGridViewInKEP.Size = new Size(625, 603);
            dataGridViewInKEP.TabIndex = 1;
            // 
            // groupBoxInKEP
            // 
            groupBoxInKEP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInKEP.Controls.Add(labelInKEP);
            groupBoxInKEP.Location = new Point(4, 5);
            groupBoxInKEP.Margin = new Padding(4, 5, 4, 5);
            groupBoxInKEP.Name = "groupBoxInKEP";
            groupBoxInKEP.Padding = new Padding(4, 5, 4, 5);
            groupBoxInKEP.Size = new Size(625, 71);
            groupBoxInKEP.TabIndex = 0;
            groupBoxInKEP.TabStop = false;
            groupBoxInKEP.Text = "Исходная матрица";
            groupBoxInKEP.Enter += groupBoxInKEP_Enter;
            // 
            // labelInKEP
            // 
            labelInKEP.AutoSize = true;
            labelInKEP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInKEP.Location = new Point(8, 29);
            labelInKEP.Margin = new Padding(4, 0, 4, 0);
            labelInKEP.Name = "labelInKEP";
            labelInKEP.Size = new Size(302, 18);
            labelInKEP.TabIndex = 0;
            labelInKEP.Text = "Загрузите файл для отображения данных";
            labelInKEP.Click += labelInKEP_Click;
            // 
            // dataGridViewOutKEP
            // 
            dataGridViewOutKEP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOutKEP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutKEP.Location = new Point(4, 85);
            dataGridViewOutKEP.Margin = new Padding(4, 5, 4, 5);
            dataGridViewOutKEP.Name = "dataGridViewOutKEP";
            dataGridViewOutKEP.RowHeadersWidth = 51;
            dataGridViewOutKEP.Size = new Size(633, 603);
            dataGridViewOutKEP.TabIndex = 1;
            // 
            // groupBoxOutKEP
            // 
            groupBoxOutKEP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxOutKEP.Controls.Add(labelOutKEP);
            groupBoxOutKEP.Location = new Point(4, 5);
            groupBoxOutKEP.Margin = new Padding(4, 5, 4, 5);
            groupBoxOutKEP.Name = "groupBoxOutKEP";
            groupBoxOutKEP.Padding = new Padding(4, 5, 4, 5);
            groupBoxOutKEP.Size = new Size(633, 71);
            groupBoxOutKEP.TabIndex = 0;
            groupBoxOutKEP.TabStop = false;
            groupBoxOutKEP.Text = "Обработанная матрица";
            // 
            // labelOutKEP
            // 
            labelOutKEP.AutoSize = true;
            labelOutKEP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOutKEP.Location = new Point(8, 29);
            labelOutKEP.Margin = new Padding(4, 0, 4, 0);
            labelOutKEP.Name = "labelOutKEP";
            labelOutKEP.Size = new Size(378, 18);
            labelOutKEP.TabIndex = 0;
            labelOutKEP.Text = "Нажмите \"Выполнить\" для обработки второй строки";
            labelOutKEP.Click += labelOutKEP_Click;
            // 
            // panelButtonsKEP
            // 
            panelButtonsKEP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelButtonsKEP.Controls.Add(buttonHelpKEP);
            panelButtonsKEP.Controls.Add(buttonSaveKEP);
            panelButtonsKEP.Controls.Add(buttonDoneKEP);
            panelButtonsKEP.Controls.Add(buttonOpenKEP);
            panelButtonsKEP.Location = new Point(16, 18);
            panelButtonsKEP.Margin = new Padding(4, 5, 4, 5);
            panelButtonsKEP.Name = "panelButtonsKEP";
            panelButtonsKEP.Size = new Size(1280, 103);
            panelButtonsKEP.TabIndex = 1;
            // 
            // buttonHelpKEP
            // 
            buttonHelpKEP.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHelpKEP.Location = new Point(541, 5);
            buttonHelpKEP.Margin = new Padding(4, 5, 4, 5);
            buttonHelpKEP.Name = "buttonHelpKEP";
            buttonHelpKEP.Size = new Size(160, 92);
            buttonHelpKEP.TabIndex = 3;
            buttonHelpKEP.Text = "Справка";
            buttonHelpKEP.TextAlign = ContentAlignment.MiddleRight;
            buttonHelpKEP.UseVisualStyleBackColor = true;
            buttonHelpKEP.Click += buttonHelp_Click;
            buttonHelpKEP.MouseEnter += buttonHelp_MouseEnter;
            // 
            // buttonSaveKEP
            // 
            buttonSaveKEP.Enabled = false;
            buttonSaveKEP.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveKEP.Location = new Point(373, 5);
            buttonSaveKEP.Margin = new Padding(4, 5, 4, 5);
            buttonSaveKEP.Name = "buttonSaveKEP";
            buttonSaveKEP.Size = new Size(160, 92);
            buttonSaveKEP.TabIndex = 2;
            buttonSaveKEP.Text = "Сохранить";
            buttonSaveKEP.TextAlign = ContentAlignment.MiddleRight;
            buttonSaveKEP.UseVisualStyleBackColor = true;
            buttonSaveKEP.Click += buttonSave_Click;
            buttonSaveKEP.MouseEnter += buttonSave_MouseEnter;
            // 
            // buttonDoneKEP
            // 
            buttonDoneKEP.Enabled = false;
            buttonDoneKEP.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDoneKEP.Location = new Point(205, 5);
            buttonDoneKEP.Margin = new Padding(4, 5, 4, 5);
            buttonDoneKEP.Name = "buttonDoneKEP";
            buttonDoneKEP.Size = new Size(160, 92);
            buttonDoneKEP.TabIndex = 1;
            buttonDoneKEP.Text = "Выполнить";
            buttonDoneKEP.TextAlign = ContentAlignment.MiddleRight;
            buttonDoneKEP.UseVisualStyleBackColor = true;
            buttonDoneKEP.Click += buttonDone_Click;
            buttonDoneKEP.MouseEnter += buttonDone_MouseEnter;
            // 
            // buttonOpenKEP
            // 
            buttonOpenKEP.ImageAlign = ContentAlignment.MiddleLeft;
            buttonOpenKEP.Location = new Point(37, 5);
            buttonOpenKEP.Margin = new Padding(4, 5, 4, 5);
            buttonOpenKEP.Name = "buttonOpenKEP";
            buttonOpenKEP.Size = new Size(160, 92);
            buttonOpenKEP.TabIndex = 0;
            buttonOpenKEP.Text = "Открыть файл";
            buttonOpenKEP.TextAlign = ContentAlignment.MiddleRight;
            buttonOpenKEP.UseVisualStyleBackColor = true;
            buttonOpenKEP.Click += buttonOpen_Click;
            buttonOpenKEP.MouseEnter += buttonOpen_MouseEnter;
            // 
            // statusStripKEP
            // 
            statusStripKEP.ImageScalingSize = new Size(20, 20);
            statusStripKEP.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInfo, toolStripStatusLabelRows, toolStripStatusLabelCols });
            statusStripKEP.Location = new Point(0, 832);
            statusStripKEP.Name = "statusStripKEP";
            statusStripKEP.Padding = new Padding(1, 0, 19, 0);
            statusStripKEP.Size = new Size(1312, 30);
            statusStripKEP.TabIndex = 2;
            statusStripKEP.Text = "statusStrip1";
            // 
            // toolStripStatusLabelInfo
            // 
            toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            toolStripStatusLabelInfo.Size = new Size(197, 24);
            toolStripStatusLabelInfo.Text = "Загрузите файл для начала";
            // 
            // toolStripStatusLabelRows
            // 
            toolStripStatusLabelRows.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabelRows.Name = "toolStripStatusLabelRows";
            toolStripStatusLabelRows.Size = new Size(68, 24);
            toolStripStatusLabelRows.Text = "Строк: 0";
            // 
            // toolStripStatusLabelCols
            // 
            toolStripStatusLabelCols.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabelCols.Name = "toolStripStatusLabelCols";
            toolStripStatusLabelCols.Size = new Size(95, 24);
            toolStripStatusLabelCols.Text = "Столбцов: 0";
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 862);
            Controls.Add(statusStripKEP);
            Controls.Add(panelButtonsKEP);
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1327, 896);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Обработка матрицы - Замена кратных 4 на 4 во второй строке ";
            Load += FormMain_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInKEP).EndInit();
            groupBoxInKEP.ResumeLayout(false);
            groupBoxInKEP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutKEP).EndInit();
            groupBoxOutKEP.ResumeLayout(false);
            groupBoxOutKEP.PerformLayout();
            panelButtonsKEP.ResumeLayout(false);
            statusStripKEP.ResumeLayout(false);
            statusStripKEP.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewInKEP;
        private System.Windows.Forms.GroupBox groupBoxInKEP;
        private System.Windows.Forms.Label labelInKEP;
        private System.Windows.Forms.DataGridView dataGridViewOutKEP;
        private System.Windows.Forms.GroupBox groupBoxOutKEP;
        private System.Windows.Forms.Label labelOutKEP;
        private System.Windows.Forms.Panel panelButtonsKEP;
        private System.Windows.Forms.Button buttonHelpKEP;
        private System.Windows.Forms.Button buttonSaveKEP;
        private System.Windows.Forms.Button buttonDoneKEP;
        private System.Windows.Forms.Button buttonOpenKEP;
        private System.Windows.Forms.StatusStrip statusStripKEP;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRows;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCols;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask;
        private System.Windows.Forms.ToolTip toolTipButton;
    }
}
