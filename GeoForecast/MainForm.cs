using Microsoft.Office.Interop.Excel;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;

namespace GeoForecast
{
    public partial class MainForm : Form
    {
        private readonly DataTable startGeoTableDataSource = new DataTable();
        private string textOfResultTable = "";
        private byte decimalPoint = 3;

        public MainForm()
        {
            InitializeComponent();
        }

        // Отключает сортировку у всех столбцов определённой таблицы.
        private void TurnOffSorting(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        // Добавление изначального расположение столбцов и строк.
        private void MainForm_Load(object sender, EventArgs e)
        {
            TurnOffSorting(GeoTableDataGridView);

            foreach (DataGridViewColumn column in GeoTableDataGridView.Columns)
            {
                // Добавление столбцов в mainDataSource.
                startGeoTableDataSource.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in GeoTableDataGridView.Rows)
            {
                // Добавление строк в mainDataSource.
                DataRow dataRow = startGeoTableDataSource.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value as DataRow;
                }
            }
        }

        // Нумерация строк в GeoTableDataGridView
        private void GeoTableDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            ushort index = (ushort)e.RowIndex;
            string indexStr = (index + 1).ToString();
            if (!(GeoTableDataGridView.Rows[index].HeaderCell.Value is string header) || !header.Equals(indexStr))
            {
                GeoTableDataGridView.Rows[index].HeaderCell.Value = indexStr;
            }
        }

        /// <summary>
        /// Переходит к следующей строке и возвращается к прошлой, чтобы вызвать событие "GeoTableDataGridView_CellValidated".
        /// </summary>
        private void UpdateCellGeoTableDataGridView()
        {
            DataGridViewCell currentCell = GeoTableDataGridView.CurrentCell ?? GeoTableDataGridView.Rows[0].Cells[0];
            ushort currentRowIndex = (ushort)currentCell.RowIndex;
            ushort currentColumnIndex = (ushort)currentCell.ColumnIndex;

            ushort nextColumnIndex = (ushort)(currentColumnIndex + 1);
            if (nextColumnIndex >= GeoTableDataGridView.ColumnCount)
            {
                nextColumnIndex = 0;
                currentRowIndex++;
            }

            GeoTableDataGridView.CurrentCell = GeoTableDataGridView.Rows[currentRowIndex].Cells[nextColumnIndex];
            GeoTableDataGridView.CurrentCell = currentCell;
        }

        /// <summary>
        /// Импортирует данные из DataGridView в Excel файл.
        /// </summary>
        /// <param name="DataGridView"></param>
        private void SaveToExcel(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Таблица пустая!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog excelFile = new SaveFileDialog())
            {
                excelFile.DefaultExt = "*.xlsx";
                excelFile.Filter = "Excel Files|*.xlsx";
                excelFile.FilterIndex = 1;
                excelFile.Title = "Выберите excel файл для сохранения";

                if (excelFile.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    UpdateCellGeoTableDataGridView();

                    string excelPath = excelFile.FileName;
                    Excel.Application excelApplication = new Excel.Application();
                    Workbook excelWorkBook = excelApplication.Workbooks.Add();
                    Worksheet excelWorkSheet = excelWorkBook.ActiveSheet;

                    for (ushort columnNumber = 0; columnNumber < dataGridView.Columns.Count; columnNumber++)
                    {
                        excelApplication.Cells[1, columnNumber + 1] = dataGridView.Columns[columnNumber].HeaderText;
                    }

                    for (ushort rowNumber = 0; rowNumber < dataGridView.Rows.Count; rowNumber++)
                    {
                        for (ushort columnNumber = 0; columnNumber < dataGridView.Columns.Count; columnNumber++)
                        {
                            excelApplication.Cells[rowNumber + 2, columnNumber + 1] = dataGridView.Rows[rowNumber].Cells[columnNumber].Value as string;
                        }
                    }
                    excelApplication.AlertBeforeOverwriting = false;

                    excelWorkBook.SaveAs(excelPath, XlFileFormat.xlOpenXMLWorkbook);

                    CompletingExcelProcesses(excelWorkBook, excelApplication);
                    MessageBox.Show("Успешно сохранено!", "СГИ - Геопрогноз", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void InstructionButton_Click(object sender, EventArgs e)
        {
            InstructionForm instructionForm = new InstructionForm();
            instructionForm.Show();
        }

        /// <summary>
        /// Удаляет последний символ из "NumericRangeTextBox".
        /// </summary>
        /// <param name="text"></param>
        private string RemoveLastСharacter(string text)
        {
            MessageBox.Show(text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            NumericRangeTextBox.Text = NumericRangeTextBox.Text.Remove(NumericRangeTextBox.Text.Length - 1);
            NumericRangeTextBox.SelectionStart = NumericRangeTextBox.Text.Length;

            return text;
        }

        private void NumericRangeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(NumericRangeTextBox.Text, "[^0-9]"))
                {
                    RemoveLastСharacter("Только цифры от 0 до 9!");
                }

                if (byte.Parse(NumericRangeTextBox.Text) > 15)
                {
                    RemoveLastСharacter("Слишком много цифр после запятой! Максимум 15!");
                }

                if (NumericRangeTextBox.Text[0] == '0')
                {
                    RemoveLastСharacter("Нельзя вводить первым символом цифру ноль!");
                }

                decimalPoint = byte.TryParse(NumericRangeTextBox.Text, out decimalPoint) ? decimalPoint : (byte)0;
            }
            catch (Exception)
            {

            }
        }
            
        private void SaveToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToExcel(GeoTableDataGridView);
        }

        /// <summary>
        /// Выключает все процессы Excel.
        /// </summary>
        /// <param name="excelWorkbook"></param>
        /// <param name="excelApplication"></param>
        private void CompletingExcelProcesses(Workbook excelWorkbook, Excel.Application excelApplication)
        {
            excelWorkbook.Close(false);
            Marshal.ReleaseComObject(excelWorkbook);
            excelApplication.Quit();
            Marshal.ReleaseComObject(excelApplication);
        }

        /// <summary>
        /// Загрузка данных из Excel в GeoTableDataGridView. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UploadExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog excelFile = new OpenFileDialog())
            {
                excelFile.DefaultExt = "*.xls;*.xlsx";
                excelFile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                excelFile.FilterIndex = 1;
                excelFile.Title = "Выберете excel файл для импорта в таблицу";

                if (excelFile.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Excel.Application excelApplication = new Excel.Application();
                    Workbook excelWorkbook;
                    Worksheet excelWorkSheet;
                    Range excelRange;

                    string excelPath = excelFile.FileName;
                    excelWorkbook = excelApplication.Workbooks.Open(excelPath, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                                                                            Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                    excelWorkSheet = (Worksheet)excelWorkbook.Sheets.get_Item(1);
                    excelRange = excelWorkSheet.UsedRange;

                    if (excelRange.Columns.Count < 2)
                    {
                        MessageBox.Show("Столбцов слишком мало! Необходимо минимум 2 столбца, чтобы импортировать Excel в таблицу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DataTable updateData = new DataTable();
                    string[] columnNames = new string[excelRange.Columns.Count];

                    ushort numberOfDivisions = 1;
                    for (ushort columnNumber = 0; columnNumber < excelRange.Columns.Count; columnNumber++)
                    {
                        string columnName = (excelRange.Cells[1, columnNumber + 1] as Range).Value2?.ToString();
                        if (!string.IsNullOrEmpty(columnName))
                        {
                            if (!updateData.Columns.Contains(columnName))
                            {
                                updateData.Columns.Add(new DataColumn(columnName));
                                columnNames[columnNumber] = columnName;
                            }
                            else
                            {
                                ushort notContainsNumber = 1;
                                string notContainsColumnName = columnName;

                                // Проверка на количество одинаковых имён в Excel таблице и добавления нового.
                                while (updateData.Columns.Contains(notContainsColumnName))
                                {
                                    notContainsColumnName = columnName;
                                    notContainsColumnName += $" {notContainsNumber++}";
                                }
                                columnName = notContainsColumnName;

                                updateData.Columns.Add(new DataColumn(columnName));
                                columnNames[columnNumber] = columnName;
                            }
                        }
                        else
                        {
                            string emptyColumnName = "*Разделение " + $"{numberOfDivisions++}*";
                            updateData.Columns.Add(new DataColumn(emptyColumnName));
                            columnNames[columnNumber] = emptyColumnName;
                        }
                    }
                    updateData.AcceptChanges();

                    for (ushort rowNumber = 2; rowNumber <= excelRange.Rows.Count; rowNumber++)
                    {
                        DataRow updatedRow = updateData.NewRow();
                        for (ushort columnNumber = 0; columnNumber < excelRange.Columns.Count; columnNumber++)
                        {
                            if ((excelRange.Cells[rowNumber, columnNumber + 1] as Range).Value2 != null)
                            {
                                updatedRow[columnNumber] = (excelRange.Cells[rowNumber, columnNumber + 1] as Range).Value2.ToString();
                            }
                        }

                        for (ushort columnNumber = 0; columnNumber < updateData.Columns.Count; columnNumber++)
                        {
                            if (columnNames[columnNumber].StartsWith("*Разделение"))
                            {
                                updatedRow[columnNumber] = (excelRange.Cells[rowNumber, columnNumber + 1] as Range).Value2 = null;
                                continue;
                            }
                            StringBuilder updatedRowInString = new StringBuilder(updatedRow[columnNumber]?.ToString() ?? "");

                            if (!string.IsNullOrEmpty(updatedRowInString.ToString()))
                            {
                                ushort commasCount = 0;
                                for (ushort i = 0; i < updatedRowInString.Length; i++)
                                {
                                    char c = updatedRowInString[i];
                                    if (c == ',')
                                    {
                                        commasCount++;
                                        if (commasCount > 1)
                                        {
                                            MessageBox.Show("Нельзя добавить данные! В импортируемой таблице в одной из ячеек не ясно что является дробной частью числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                            CompletingExcelProcesses(excelWorkbook, excelApplication);
                                            return;
                                        }
                                    }

                                    if (c == ';' || c == ' ')
                                    {
                                        commasCount = 0;
                                    }
                                }
                            }

                            if (columnNumber > 0 && !string.IsNullOrEmpty(updatedRow[columnNumber].ToString()) && (!string.IsNullOrEmpty(updatedRow[columnNumber - 1].ToString())))
                            {
                                MessageBox.Show("Нельзя добавить данные! В импортируемой таблице соседние ячейки в одной строке заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                CompletingExcelProcesses(excelWorkbook, excelApplication);
                                return;
                            }

                            if (Regex.IsMatch(updatedRow[columnNumber].ToString(), @"[^0-9,;\s]"))
                            {
                                MessageBox.Show("Нельзя добавить данные! В импортируемой таблице есть символы отличающие от цифр, запятой, точки с запятой и пробела!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                CompletingExcelProcesses(excelWorkbook, excelApplication);
                                return;
                            }

                            if (Regex.IsMatch(updatedRow[columnNumber].ToString(), @"\s\s|;;|;\s|\s;|,,|,;|,\s|;,|\s,"))
                            {
                                MessageBox.Show("Нельзя добавить данные! В импортируемой таблице в одной из ячеек расположены два разделителя рядом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                CompletingExcelProcesses(excelWorkbook, excelApplication);
                                return;
                            }

                            if (updatedRow[columnNumber].ToString().StartsWith(",") || updatedRow[columnNumber].ToString().EndsWith(","))
                            {
                                MessageBox.Show("Нельзя добавить данные! В импортируемой таблице первым или последним символом одной из ячеек является запятая!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                CompletingExcelProcesses(excelWorkbook, excelApplication);
                                return;
                            }
                        }
                        updateData.Rows.Add(updatedRow);
                        updateData.AcceptChanges();
                    }

                    ClearGeoTableToolStripMenuItem_Click(ClearGeoTableToolStripMenuItem, null);
                    GeoTableDataGridView.DataSource = updateData;

                    CompletingExcelProcesses(excelWorkbook, excelApplication);
                }
            }

            TurnOffSorting(GeoTableDataGridView);
        }

        /// <summary>
        /// Добавляет столбец к GeoTableDataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GeoTableDataGridView.Columns.Count == ushort.MaxValue)
            {
                MessageBox.Show("Достигнут лимит количества столбцов (65535)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GeoTableDataGridView.Columns.Add("Column" + GeoTableDataGridView.Columns.Count, $"{GeoTableDataGridView.Columns.Count + 1}");
            TurnOffSorting(GeoTableDataGridView);
        }

        /// <summary>
        /// Удаляет последний столбец у GeoTableDataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveLastColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GeoTableDataGridView.Columns.Count == 2)
            {
                MessageBox.Show("Дальнейшее удаление столбцов невозможно - таблица имеет всего 2 столбца!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GeoTableDataGridView.Columns.RemoveAt(GeoTableDataGridView.Columns.Count - 1);
        }

        private void NameChangeInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                ChangeColumnNameButton_Click(ChangeColumnNameButton, null);
            }
        }

        private void RestoreCellBeginEditEvent()
        {
            GeoTableDataGridView.CellBeginEdit += GeoTableDataGridView_CellBeginEdit;
        }

        /// <summary>
        /// Очищение таблицы и присваивание изначального состояния.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearGeoTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ushort dataGridViewColumnsCounter = (ushort)GeoTableDataGridView.Columns.Count;
            for (ushort columnNumber = 0; columnNumber < dataGridViewColumnsCounter; columnNumber++)
            {
                GeoTableDataGridView.Columns.RemoveAt(GeoTableDataGridView.Columns.Count - 1);
            }

            GeoTableDataGridView.CellBeginEdit -= GeoTableDataGridView_CellBeginEdit;

            GeoTableDataGridView.DataSource = null;

            textOfResultTable = null;
            ResultDataGridView.Rows.Clear();

            GeoTableDataGridView.DataSource = startGeoTableDataSource;
            RestoreCellBeginEditEvent();

            while (GeoTableDataGridView.Rows.Count > 1)
            {
                GeoTableDataGridView.Rows.RemoveAt(0);
            }

            TurnOffSorting(GeoTableDataGridView);
        }

        /// <summary>
        /// Проверяет заполненность соседних ячеек и запрещает писать в них.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeoTableDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            ushort currentRow = (ushort)e.RowIndex;
            ushort currentColumn = (ushort)e.ColumnIndex;

            if (currentColumn > 0 && !string.IsNullOrEmpty(GeoTableDataGridView.Rows[currentRow].Cells[currentColumn - 1].Value?.ToString()) ||
                currentColumn < GeoTableDataGridView.Columns.Count - 1 && !string.IsNullOrEmpty(GeoTableDataGridView.Rows[currentRow].Cells[currentColumn + 1].Value?.ToString()))
            {
                e.Cancel = true;
            }
        }

        private void GeoTableDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= CheckKey;
            e.Control.KeyPress += new KeyPressEventHandler(CheckKey);
        }

        private char lastChar;

        /// <summary>
        /// Проверяет введённый символ и его разрешает ввод.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != ';' && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;

                if (e.KeyChar == '+')
                {
                    AddColumnToolStripMenuItem_Click(AddColumnToolStripMenuItem, null);
                    return;
                }

                if (e.KeyChar == '-')
                {
                    RemoveLastColumnToolStripMenuItem_Click(RemoveLastColumnToolStripMenuItem, null);
                    return;
                }

                return;
            }

            if ((lastChar == ',' || lastChar == ';' || lastChar == ' ') && (e.KeyChar == ',' || e.KeyChar == ';' || e.KeyChar == ' '))
            {
                e.Handled = true;
            }

            lastChar = e.KeyChar;
        }

        /// <summary>
        /// При выходе из ячейки изменяет лишние знаки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeoTableDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            string cellValue = GeoTableDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString().TrimStart(',').TrimEnd(',') ?? "";

            StringBuilder correctedCellValue = new StringBuilder(cellValue);
            ushort commasCount = 0;

            for (ushort numberOfChar = 0; numberOfChar < correctedCellValue.Length; numberOfChar++)
            {
                if (correctedCellValue[numberOfChar] == ',')
                {
                    commasCount++;

                    if (commasCount > 1)
                    {
                        correctedCellValue.Remove(numberOfChar, 1);
                        numberOfChar--;
                    }
                }

                if (correctedCellValue[numberOfChar] == ';' || correctedCellValue[numberOfChar] == ' ')
                {
                    commasCount = 0;
                }
            }
            cellValue = correctedCellValue.ToString();

            GeoTableDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellValue;
        }

        /// <summary>
        /// Изменяет наименование определённого столбца в GeoTableDataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeColumnNameButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameChangeInputTextBox.Text) || string.IsNullOrEmpty(CurrentColumnNameTextBox.Text))
            {
                MessageBox.Show("Изменения в наименованиях столбцов должно быть внесены в соответствующие строчки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ushort nonMatchCount = 0;
            for (ushort columnNumber = 0; columnNumber < GeoTableDataGridView.Columns.Count; columnNumber++)
            {
                if (CurrentColumnNameTextBox.Text != GeoTableDataGridView.Columns[columnNumber].HeaderText)
                {
                    nonMatchCount++;
                }
                else
                {
                    break;
                }
            }

            if (nonMatchCount == GeoTableDataGridView.Columns.Count)
            {
                MessageBox.Show("Такого имени нет в таблице!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (ushort columnNumber = 0; columnNumber < GeoTableDataGridView.Columns.Count; columnNumber++)
            {
                if (NameChangeInputTextBox.Text == GeoTableDataGridView.Columns[columnNumber].HeaderText)
                {
                    MessageBox.Show("Такое имя уже существует в таблице!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            for (ushort columnNumber = 0; columnNumber < GeoTableDataGridView.Columns.Count; columnNumber++)
            {
                if (CurrentColumnNameTextBox.Text == GeoTableDataGridView.Columns[columnNumber].HeaderText)
                {
                    GeoTableDataGridView.Columns[columnNumber].HeaderText = NameChangeInputTextBox.Text;
                }
            }
        }

        /// <summary>
        /// Получает результат по данным из ячеек и переходит на таблицу с результатом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetResultsTableButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            UpdateCellGeoTableDataGridView();

            if (decimalPoint == 0)
            {
                decimalPoint = 3;
            }

            bool tableIsNull = true;
            float[,] numbersFromTable = new float[GeoTableDataGridView.Columns.Count, GeoTableDataGridView.Rows.Count];
            for (ushort columnNumber = 0; columnNumber < GeoTableDataGridView.Columns.Count; columnNumber++)
            {
                for (ushort rowNumber = 0; rowNumber < GeoTableDataGridView.Rows.Count; rowNumber++)
                {

                    if (GeoTableDataGridView.Rows[rowNumber].Cells[columnNumber].Value as string == null)
                    {
                        continue;
                    }

                    string valuesInCell = GeoTableDataGridView.Rows[rowNumber].Cells[columnNumber].Value.ToString();
                    string[] cellValue = valuesInCell.Split(new char[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string value in cellValue)
                    {
                        // Нахождение суммы в каждой ячейке.
                        if (float.TryParse(value, out float number))
                        {
                            numbersFromTable[columnNumber, rowNumber] += number;
                            tableIsNull = false;
                        }
                    }
                }
            }

            if (tableIsNull)
            {
                MessageBox.Show("Таблица пустая! Необходимо заполнить таблицу, чтобы получить результат!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ushort currentIndex = 0;
            ushort columnsCount = 0;

            float[] totalColumnSums = new float[GeoTableDataGridView.Columns.Count];

            float[,] averageNumber = new float[GeoTableDataGridView.Columns.Count, GeoTableDataGridView.Rows.Count];
            float[] averageSum = new float[GeoTableDataGridView.Columns.Count];

            float[] inverseСoefficientOfVariation = new float[GeoTableDataGridView.Columns.Count];
            float[] coefficientOfOre = new float[GeoTableDataGridView.Columns.Count];

            float[] columnSums = new float[GeoTableDataGridView.Columns.Count];
            float[] columnFilledCellsCount = new float[GeoTableDataGridView.Columns.Count];

            float[] gradeScore = new float[GeoTableDataGridView.Columns.Count];

            ushort[] emptyColumns = new ushort[GeoTableDataGridView.Columns.Count + 1];
            for (ushort columnNumber = 0; columnNumber < GeoTableDataGridView.Columns.Count + 1; columnNumber++)
            {
                ushort numberOfFilledCellsCount = 0;
                if (GeoTableDataGridView.Columns.Count > columnNumber)
                {
                    for (ushort rowNumber = 0; rowNumber < numbersFromTable.GetLength(1); rowNumber++)
                    {
                        if (numbersFromTable[columnNumber, rowNumber] > 0)
                        {
                            columnFilledCellsCount[columnNumber] = ++numberOfFilledCellsCount;
                            columnSums[columnNumber] += numbersFromTable[columnNumber, rowNumber];
                        }
                    }

                    if (columnSums[columnNumber] == 0)
                    {
                        emptyColumns[columnNumber] = columnNumber;
                    }
                }
                else
                {
                    emptyColumns[columnNumber] = columnNumber;
                }
            }
            emptyColumns = emptyColumns.Where(x => x != 0).ToArray();

            if (columnFilledCellsCount.Where(x => x != 0).Count() == 1)
            {
                MessageBox.Show("Столбцов слишком мало! Необходимо заполнить минимум 2 столбца, чтобы получить данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float[] averageAmount = new float[columnSums.Length];
            for (ushort columnNumber = 0; columnNumber < columnSums.Length; columnNumber++)
            {
                averageAmount[columnNumber] = columnSums[columnNumber] / columnFilledCellsCount[columnNumber];
            }

            while (columnsCount < GeoTableDataGridView.Columns.Count)
            {
                while (columnsCount < columnSums.Length && columnSums[columnsCount] == 0)
                {
                    // Проверка на пустой столбик.
                    columnsCount = (ushort)(emptyColumns[currentIndex] + 1);
                    currentIndex++;
                }

                for (ushort columnNumber = columnsCount; columnNumber < emptyColumns[currentIndex]; columnNumber++)
                {
                    // Нахождение всей сумму в столбце.
                    totalColumnSums[currentIndex] += columnSums[columnNumber];
                }

                for (ushort columnNumber = columnsCount; columnNumber < emptyColumns[currentIndex]; columnNumber++)
                {
                    for (ushort rowNumber = 0; rowNumber < numbersFromTable.GetLength(1); rowNumber++)
                    {
                        // Нахождение суммы дисперсии.
                        if (numbersFromTable[columnNumber, rowNumber] > 0 && columnSums[columnNumber] > 0)
                        {
                            averageNumber[columnNumber, rowNumber] = (float)Math.Pow(numbersFromTable[columnNumber, rowNumber] - averageAmount[columnNumber], 2);
                            averageSum[columnNumber] += averageNumber[columnNumber, rowNumber];
                        }
                    }
                }

                for (ushort columnNumber = columnsCount; columnNumber < emptyColumns[currentIndex]; columnNumber++)
                {
                    // Нахождение среднего квадратичного отклонения.
                    if (averageSum[columnNumber] > 0)
                    {
                        averageSum[columnNumber] = (float)Math.Sqrt(averageSum[columnNumber] / columnFilledCellsCount[columnNumber]);
                    }
                }

                for (ushort columnNumber = columnsCount; columnNumber < emptyColumns[currentIndex]; columnNumber++)
                {
                    // Нахождение Коэффициента обратной вариации.
                    if (averageAmount[columnNumber] > 0 && averageSum[columnNumber] > 0)
                    {
                        inverseСoefficientOfVariation[columnNumber] = 1 / (averageSum[columnNumber] / averageAmount[columnNumber]);
                    }
                }

                for (ushort columnNumber = columnsCount; columnNumber < emptyColumns[currentIndex]; columnNumber++)
                {
                    // Нахождения Коэффициента рудоносности.
                    if (columnSums[columnNumber] > 0)
                    {
                        coefficientOfOre[columnNumber] = columnSums[columnNumber] / totalColumnSums[currentIndex];
                    }
                }

                for (ushort columnNumber = columnsCount; columnNumber < emptyColumns[currentIndex]; columnNumber++)
                {
                    // Нахождение натуральной оценки значимости градаций.
                    if (averageAmount[columnNumber] > 0)
                    {
                        gradeScore[columnNumber] = averageAmount[columnNumber] * inverseСoefficientOfVariation[columnNumber] * coefficientOfOre[columnNumber];
                    }
                }

                columnsCount = (ushort)(emptyColumns[currentIndex] + 1);
                currentIndex++;
            }

            float[] copyGradeScore = gradeScore;
            gradeScore = gradeScore.Where(x => x != 0).ToArray();
            gradeScore = gradeScore.OrderByDescending(x => x).ToArray();

            if (gradeScore.Length == 0)
            {
                MessageBox.Show($"В таблице нет натуральных оценок значимости!", "СГИ - Геопрогноз", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (gradeScore.Length == 1)
            {
                MessageBox.Show($"Только одна натуральная оценка значимости ({gradeScore[0]})! Необходимо два или больше значения, чтобы получить данные!", "СГИ - Геопрогноз", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            float[] gradationRatings = new float[gradeScore.Length];
            for (ushort i = 0; i < gradeScore.Length; i++)
            {
                if (gradeScore[i] / gradeScore[1] * 10 >= 10)
                {
                    gradationRatings[i] = 10;
                }
                else
                {
                    gradationRatings[i] = gradeScore[i] / gradeScore[1] * 10;
                }
            }

            ushort[] columnGradesScores = new ushort[gradeScore.Length];
            ushort searchValue = 0; ushort currentValue = 0;

            // Нахождение начальной нумерации столбцов.
            while (currentValue < copyGradeScore.Length && columnGradesScores.Last() <= 0)
            {
                if (gradeScore[searchValue] == copyGradeScore[currentValue])
                {
                    columnGradesScores[searchValue] = (ushort)(currentValue + 1);
                    searchValue++;
                    currentValue = 0;
                }
                else
                {
                    currentValue++;
                }
            }

            float[] reducedGradeScore = gradeScore;
            for (ushort i = 0; i < 2; i++)
            {
                float numberRange = reducedGradeScore.Sum() / reducedGradeScore.Count();
                reducedGradeScore = reducedGradeScore.Where(x => x > numberRange).ToArray();
            }

            ResultDataGridView.Rows.Clear();

            ushort rowsCounter = (ushort)(gradationRatings.Length < 10 ? 10 : gradeScore.Length);
            for (ushort rowNumber = 0; rowNumber < rowsCounter; rowNumber++)
            {
                ResultDataGridView.Rows.Add();
            }
            TurnOffSorting(ResultDataGridView);

            // Округление элементов массива до цифры, который написал пользователь.
            float averageSumGradationRatings = (float)Math.Round(gradationRatings.Sum() / gradationRatings.Count(), decimalPoint);
            for (ushort i = 0; i < rowsCounter; i++)
            {
                if (reducedGradeScore.Length > i)
                {
                    reducedGradeScore[i] = (float)Math.Round(reducedGradeScore[i], decimalPoint);
                }

                if (gradeScore.Length > i)
                {
                    gradeScore[i] = (float)Math.Round(gradeScore[i], decimalPoint);
                    gradationRatings[i] = (float)Math.Round(gradationRatings[i], decimalPoint);
                }
            }

            for (ushort rowNumber = 0; rowNumber < gradationRatings.Length; rowNumber++)
            {
                ResultDataGridView.Rows[rowNumber].Cells[0].Value = columnGradesScores[rowNumber] + $" ({GeoTableDataGridView.Columns[columnGradesScores[rowNumber] - 1].HeaderText})";
                ResultDataGridView.Rows[rowNumber].Cells[1].Value = gradeScore[rowNumber];
                ResultDataGridView.Rows[rowNumber].Cells[2].Value = gradationRatings[rowNumber];
            }
            ResultDataGridView.Rows[0].Cells[3].Value = averageSumGradationRatings;

            string[] rages = { "9.1-10", "8.1-9", "7.1-8", "6.1-7", "5.1-6", "4.1-5", "3.1-4", "2.1-3", "1.1-2", "0.01-1" };
            float[] startRange = { 9.1F, 8.1F, 7.1F, 6.1F, 5.1F, 4.1F, 3.1F, 2.1F, 1.1F, 0.01F };
            sbyte[] endRange = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            do
            {
                if (AdaptiveSizeСheckBox.Checked)
                {
                    if (decimalPoint == 1)
                    {
                        startRange[9] = 0.1F;
                        rages[9] = "0.1-1";
                        break;
                    }

                    sbyte arrayElementCounter = (sbyte)startRange.Length;
                    for (sbyte i = 0; i < startRange.Length; i++)
                    {
                        sbyte numberOfZero = 0;
                        string stringNumber = startRange[i].ToString();
                        numberOfZero = (sbyte)(startRange[i] == startRange.Last() ? decimalPoint - 2 : decimalPoint - 1);

                        string zeros = string.Empty;
                        for (sbyte j = 0; j < numberOfZero; j++)
                        {
                            zeros += '0';
                        }
                        stringNumber = stringNumber.Insert(2, zeros);

                        startRange[i] = float.Parse(stringNumber);
                        rages[i] = stringNumber + $"-{arrayElementCounter--}";

                        RangeOfGradesColumn.Width += 3;
                    }
                }
            } while (false);

            for (sbyte rowNumber = 0; rowNumber < rages.Length; rowNumber++)
            {
                ResultDataGridView.Rows[rowNumber].Cells[5].Value = rages[rowNumber];
                ResultDataGridView.Rows[rowNumber].Cells[6].Value = gradationRatings.Count(x => x >= startRange[rowNumber] && x <= endRange[rowNumber]);

                if (reducedGradeScore.Length > rowNumber)
                {
                    ResultDataGridView.Rows[rowNumber].Cells[7].Value = reducedGradeScore[rowNumber] + $" ({GeoTableDataGridView.Columns[columnGradesScores[rowNumber] - 1].HeaderText})";
                }
            }

            if (reducedGradeScore.Length <= 0)
            {
                ResultDataGridView.Rows[0].Cells[7].Value = "Отсутствуют";
            }

            // Заполнение textOfResultTable.
            StringBuilder resultText = new StringBuilder();
            resultText.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30} {4,-30} {5,-30} {6,-30}\n", "Номер столбца (название)", "Значение", "Оценка", "Средняя сумма",
                                    "Диапазон оценок", "Количество столбцов", "Перспективные ГОБ (столбец)");
            for (ushort i = 0; i < ResultDataGridView.Rows.Count; i++)
            {
                if (i == 0 && reducedGradeScore.Length <= 0)
                {
                    resultText.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30} {4,-30} {5,-30} {6,-30}\n", columnGradesScores[i] + $" ({GeoTableDataGridView.Columns[columnGradesScores[i] - 1].HeaderText})",
                    gradeScore[i], gradationRatings[i], averageSumGradationRatings, rages[i], gradationRatings.Count(x => x >= startRange[i] && x <= endRange[i]), "Отсутствуют");
                }
                else if (i == 0 && i < reducedGradeScore.Length)
                {
                    resultText.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30} {4,-30} {5,-30} {6,-30}\n", columnGradesScores[i] + $" ({GeoTableDataGridView.Columns[columnGradesScores[i] - 1].HeaderText})",
                        gradeScore[i], gradationRatings[i], averageSumGradationRatings, rages[i], gradationRatings.Count(x => x >= startRange[i] && x <= endRange[i]),
                        reducedGradeScore[i] + $" ({GeoTableDataGridView.Columns[columnGradesScores[i] - 1].HeaderText})");
                }
                else if (i < reducedGradeScore.Length)
                {
                    resultText.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30} {4,-30} {5,-30} {6,-30}\n", columnGradesScores[i] + $" ({GeoTableDataGridView.Columns[columnGradesScores[i] - 1].HeaderText})",
                        gradeScore[i], gradationRatings[i], string.Empty, rages[i], gradationRatings.Count(x => x >= startRange[i] && x <= endRange[i]),
                        reducedGradeScore[i] + $" ({GeoTableDataGridView.Columns[columnGradesScores[i] - 1].HeaderText})");
                }
                else if (i < columnGradesScores.Length)
                {
                    if (columnGradesScores.Length > 9)
                    {
                        resultText.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30} {4,-30} {5,-30} {6,-30}\n", columnGradesScores[i] + $" ({GeoTableDataGridView.Columns[columnGradesScores[i] - 1].HeaderText})",
                            gradeScore[i], gradationRatings[i], string.Empty, string.Empty, string.Empty, string.Empty);
                    }
                    else
                    {
                        resultText.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30} {4,-30} {5,-30} {6,-30}\n", columnGradesScores[i] + $" ({GeoTableDataGridView.Columns[columnGradesScores[i] - 1].HeaderText})",
                            gradeScore[i], gradationRatings[i], string.Empty, rages[i], gradationRatings.Count(x => x >= startRange[i] && x <= endRange[i]), string.Empty);
                    }
                }
                else
                {
                    resultText.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30} {4,-30} {5,-30} {6,-30}\n", string.Empty, string.Empty, string.Empty, string.Empty,
                        rages[i], gradationRatings.Count(x => x >= startRange[i] && x <= endRange[i]), string.Empty);
                }
            }
            textOfResultTable = resultText.ToString();

            MainTabControl.SelectedTab = ResultTabPage;
        }

        /// <summary>
        /// Сохранение результата в .txt формат.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveResultToTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textOfResultTable))
            {
                MessageBox.Show("Нельзя экспортировать пустую таблицу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog openFileDialog = new SaveFileDialog())
            {
                openFileDialog.DefaultExt = "*.txt;*.doc;*.docx";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Title = "Выберите excel файл для сохранения";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    string excelPath = openFileDialog.FileName;
                    using (StreamWriter streamWriter = new StreamWriter(excelPath))
                    {
                        streamWriter.WriteLine(textOfResultTable);
                    }
                    MessageBox.Show("Успешно сохранено!", "СГИ - Геопрогноз", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void SaveResultToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToExcel(ResultDataGridView);
        }
    }
}