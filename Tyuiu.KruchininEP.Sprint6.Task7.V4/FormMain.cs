using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Tyuiu.KruchininEP.Sprint6.Task7.V10
{
    public partial class FormMain : Form
    {
        private int rows, columns;
        private string openFilePath;

        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialogTask.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonDoneKEP.Enabled = false;
            buttonSaveKEP.Enabled = false;

            // Добавляем суффикс KEP к кнопкам
            buttonOpenKEP.Text += "";
            buttonDoneKEP.Text += "";
            buttonSaveKEP.Text += "";
            buttonHelpKEP.Text += "";
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    openFilePath = openFileDialogTask.FileName;

                    string[] allLines = File.ReadAllLines(openFilePath);
                    var lines = allLines
                        .Where(line => !string.IsNullOrWhiteSpace(line))
                        .Where(line => line.Split(';').Any(x => !string.IsNullOrWhiteSpace(x)))
                        .ToArray();

                    if (lines.Length == 0)
                    {
                        MessageBox.Show("Файл пуст или содержит только пустые строки", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string[] firstLineValues = lines[0].Split(';')
                        .Where(x => !string.IsNullOrWhiteSpace(x))
                        .ToArray();

                    rows = lines.Length;
                    columns = Math.Max(firstLineValues.Length, 1);

                    // Проверяем, что есть минимум 1 строка для обработки второй строки
                    if (rows < 2)
                    {
                        MessageBox.Show("Файл должен содержать минимум 2 строки", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Настраиваем DataGridView для ввода
                    SetupDataGridView(dataGridViewInKEP, rows, columns);

                    // Отображаем исходные данные
                    DisplayMatrixFromFile(dataGridViewInKEP, openFilePath);

                    // Подсвечиваем вторую строку
                    HighlightSecondRow(dataGridViewInKEP);

                    buttonDoneKEP.Enabled = true;
                    buttonSaveKEP.Enabled = false;

                    // Обновляем информацию
                    UpdateStatus($"Загружено: {rows}×{columns} | Вторая строка будет обработана");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки файла: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetupDataGridView(DataGridView dgv, int rowCount, int columnCount)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            for (int i = 0; i < columnCount; i++)
            {
                dgv.Columns.Add($"Col{i}", $"Col{i}");
                dgv.Columns[i].Width = 50;
                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgv.RowCount = rowCount;

            for (int i = 0; i < rowCount; i++)
            {
                dgv.Rows[i].HeaderCell.Value = $"Row{i}";
            }

            dgv.RowHeadersWidth = 60;
        }

        private void DisplayMatrixFromFile(DataGridView dgv, string filePath)
        {
            string[] allLines = File.ReadAllLines(filePath);
            var lines = allLines
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Where(line => line.Split(';').Any(x => !string.IsNullOrWhiteSpace(x)))
                .ToArray();

            string[] firstLineValues = lines[0].Split(';')
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .ToArray();

            int cols = Math.Max(firstLineValues.Length, 1);

            for (int i = 0; i < lines.Length && i < rows; i++)
            {
                string[] values = lines[i].Split(';')
                    .Where(x => !string.IsNullOrWhiteSpace(x))
                    .ToArray();

                for (int j = 0; j < cols; j++)
                {
                    if (j < values.Length && int.TryParse(values[j], out int parsedValue))
                    {
                        dgv.Rows[i].Cells[j].Value = parsedValue;
                    }
                    else
                    {
                        dgv.Rows[i].Cells[j].Value = 0;
                    }
                }
            }
        }

        private void HighlightSecondRow(DataGridView dgv)
        {
            if (dgv.Rows.Count >= 2)
            {
                // Подсвечиваем заголовок второй строки
                dgv.Rows[1].HeaderCell.Style.BackColor = System.Drawing.Color.LightBlue;
                dgv.Rows[1].HeaderCell.Style.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);

                // Подсвечиваем ячейки второй строки
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv.Rows[1].Cells[j].Value != null)
                    {
                        int value;
                        if (int.TryParse(dgv.Rows[1].Cells[j].Value.ToString(), out value))
                        {
                            if (value % 4 == 0 && value != 0)
                            {
                                dgv.Rows[1].Cells[j].Style.BackColor = System.Drawing.Color.LightYellow;
                            }
                        }
                    }
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем копию матрицы из dataGridViewIn
                int[,] originalMatrix = new int[rows, columns];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        object cellValue = dataGridViewInKEP.Rows[i].Cells[j].Value;
                        int value = 0;
                        if (cellValue != null && int.TryParse(cellValue.ToString(), out int parsedValue))
                        {
                            value = parsedValue;
                        }
                        originalMatrix[i, j] = value;
                    }
                }

                // Обрабатываем матрицу: во второй строке числа кратные 4 заменяем на 4
                int[,] processedMatrix = ProcessMatrix(originalMatrix);

                // Настраиваем DataGridView для вывода
                SetupDataGridView(dataGridViewOutKEP, rows, columns);

                // Отображаем обработанную матрицу
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewOutKEP.Rows[i].Cells[j].Value = processedMatrix[i, j];

                        // Подсвечиваем измененные ячейки во второй строке
                        if (i == 1 && originalMatrix[i, j] % 4 == 0 && originalMatrix[i, j] != 0)
                        {
                            dataGridViewOutKEP.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.LightGreen;
                            dataGridViewOutKEP.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
                        }
                    }
                }

                // Подсвечиваем вторую строку в выводе
                if (dataGridViewOutKEP.Rows.Count >= 2)
                {
                    dataGridViewOutKEP.Rows[1].HeaderCell.Style.BackColor = System.Drawing.Color.LightBlue;
                    dataGridViewOutKEP.Rows[1].HeaderCell.Style.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
                }

                buttonSaveKEP.Enabled = true;

                // Статистика обработки
                int changedCount = 0;
                for (int j = 0; j < columns; j++)
                {
                    if (originalMatrix[1, j] % 4 == 0 && originalMatrix[1, j] != 0)
                    {
                        changedCount++;
                    }
                }

                UpdateStatus($"Обработано. Во второй строке заменено {changedCount} значений (кратные 4 → 4)");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обработки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int[,] ProcessMatrix(int[,] matrix)
        {
            // Создаем копию матрицы
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            // Копируем все значения
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j];
                }
            }

            // Обрабатываем вторую строку (индекс 1)
            for (int j = 0; j < cols; j++)
            {
                if (matrix[1, j] % 4 == 0)
                {
                    result[1, j] = 4;
                }
            }

            return result;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogTask.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask.InitialDirectory = Directory.GetCurrentDirectory();

            if (saveFileDialogTask.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = saveFileDialogTask.FileName;

                    // Удаляем существующий файл, если есть
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    // Сохраняем данные из dataGridViewOut
                    using (StreamWriter writer = new StreamWriter(path, false))
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            string[] rowValues = new string[columns];

                            for (int j = 0; j < columns; j++)
                            {
                                object cellValue = dataGridViewOutKEP.Rows[i].Cells[j].Value;
                                rowValues[j] = cellValue?.ToString() ?? "0";
                            }

                            writer.WriteLine(string.Join(";", rowValues));
                        }
                    }

                    MessageBox.Show($"Файл успешно сохранен:\n{path}", "Сохранение ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateStatus($"Сохранено: {Path.GetFileName(path)}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка ",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateStatus(string message)
        {
            toolStripStatusLabelInfo.Text = message;
            toolStripStatusLabelRows.Text = $"Строк: {rows}";
            toolStripStatusLabelCols.Text = $"Столбцов: {columns}";
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string helpText = "Программа для обработки матриц из CSV файлов\n\n" +
                            "Формат файла: значения разделяются точкой с запятой (;)\n" +
                            "Поддерживается любое количество строк и столбцов\n\n" +
                            "Алгоритм работы:\n" +
                            "1. Загрузите CSV файл с матрицей (минимум 2 строки)\n" +
                            "2. Программа обработает вторую строку (индекс 1):\n" +
                            "   - Все числа, кратные 4, заменяются на значение 4\n" +
                            "   - Остальные значения остаются без изменений\n" +
                            "3. Сохраните результат в новый CSV файл.\n\n";
 

            MessageBox.Show(helpText, "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.SetToolTip(buttonOpenKEP, "Загрузить CSV файл с матрицей ");
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.SetToolTip(buttonDoneKEP, "Изменить во второй строке числа кратные 4 на 4 ");
        }

        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.SetToolTip(buttonSaveKEP, "Сохранить результат в CSV файл ");
        }

        private void buttonHelp_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.SetToolTip(buttonHelpKEP, "Показать справку по программе");
        }

        private void groupBoxInKEP_Enter(object sender, EventArgs e)
        {

        }

        private void labelInKEP_Click(object sender, EventArgs e)
        {

        }

        private void labelOutKEP_Click(object sender, EventArgs e)
        {

        }
    }
}
