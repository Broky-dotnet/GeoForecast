using System;

namespace GeoForecast
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ResultTabPage = new System.Windows.Forms.TabPage();
            this.ResultTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ResultDataGridView = new System.Windows.Forms.DataGridView();
            this.ResultMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ResultTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveResultToTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveResultToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeoTableTabPage = new System.Windows.Forms.TabPage();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GeotableMenuStrip = new System.Windows.Forms.MenuStrip();
            this.TableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UploadExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearGeoTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveLastColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeoTableDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameChangeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ChangeColumnNameButton = new System.Windows.Forms.Button();
            this.GetResultsTableButton = new System.Windows.Forms.Button();
            this.NameChangeInputTextBox = new System.Windows.Forms.TextBox();
            this.CurrentColumnNameTextBox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.MainTabPage = new System.Windows.Forms.TabPage();
            this.AdaptiveSizeСheckBox = new System.Windows.Forms.CheckBox();
            this.NumericRangeTextBox = new System.Windows.Forms.TextBox();
            this.InstructionButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.NumberOfColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEvaluation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageColumnSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeOfGradesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfColumns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProspectiveGOBs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultTabPage.SuspendLayout();
            this.ResultTableLayoutPanel.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).BeginInit();
            this.ResultMenuStrip.SuspendLayout();
            this.GeoTableTabPage.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            this.GeotableMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeoTableDataGridView)).BeginInit();
            this.NameChangeTableLayoutPanel.SuspendLayout();
            this.MainTabPage.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultTabPage
            // 
            this.ResultTabPage.Controls.Add(this.ResultTableLayoutPanel);
            this.ResultTabPage.Location = new System.Drawing.Point(4, 25);
            this.ResultTabPage.Name = "ResultTabPage";
            this.ResultTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ResultTabPage.Size = new System.Drawing.Size(1069, 494);
            this.ResultTabPage.TabIndex = 4;
            this.ResultTabPage.Text = "Результат";
            this.ResultTabPage.UseVisualStyleBackColor = true;
            // 
            // ResultTableLayoutPanel
            // 
            this.ResultTableLayoutPanel.ColumnCount = 1;
            this.ResultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ResultTableLayoutPanel.Controls.Add(this.TableLayoutPanel, 0, 1);
            this.ResultTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ResultTableLayoutPanel.Name = "ResultTableLayoutPanel";
            this.ResultTableLayoutPanel.RowCount = 2;
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 503F));
            this.ResultTableLayoutPanel.Size = new System.Drawing.Size(1063, 488);
            this.ResultTableLayoutPanel.TabIndex = 1;
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 1;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Controls.Add(this.ResultDataGridView, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.ResultMenuStrip, 0, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 2;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(1057, 497);
            this.TableLayoutPanel.TabIndex = 2;
            // 
            // ResultDataGridView
            // 
            this.ResultDataGridView.AllowUserToAddRows = false;
            this.ResultDataGridView.AllowUserToDeleteRows = false;
            this.ResultDataGridView.AllowUserToOrderColumns = true;
            this.ResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberOfColumn,
            this.ColumnValue,
            this.ColumnEvaluation,
            this.AverageColumnSum,
            this.Column55,
            this.RangeOfGradesColumn,
            this.NumberOfColumns,
            this.ProspectiveGOBs});
            this.ResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultDataGridView.Location = new System.Drawing.Point(3, 37);
            this.ResultDataGridView.Name = "ResultDataGridView";
            this.ResultDataGridView.ReadOnly = true;
            this.ResultDataGridView.RowHeadersWidth = 55;
            this.ResultDataGridView.Size = new System.Drawing.Size(1051, 457);
            this.ResultDataGridView.TabIndex = 1;
            // 
            // ResultMenuStrip
            // 
            this.ResultMenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResultTableToolStripMenuItem});
            this.ResultMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ResultMenuStrip.Name = "ResultMenuStrip";
            this.ResultMenuStrip.Size = new System.Drawing.Size(1057, 34);
            this.ResultMenuStrip.TabIndex = 2;
            this.ResultMenuStrip.Text = "menuStrip1";
            // 
            // ResultTableToolStripMenuItem
            // 
            this.ResultTableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveResultToTxtToolStripMenuItem,
            this.SaveResultToExcelToolStripMenuItem});
            this.ResultTableToolStripMenuItem.Name = "ResultTableToolStripMenuItem";
            this.ResultTableToolStripMenuItem.Size = new System.Drawing.Size(65, 30);
            this.ResultTableToolStripMenuItem.Text = "Таблица";
            // 
            // SaveResultToTxtToolStripMenuItem
            // 
            this.SaveResultToTxtToolStripMenuItem.Name = "SaveResultToTxtToolStripMenuItem";
            this.SaveResultToTxtToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.SaveResultToTxtToolStripMenuItem.Text = "Сохранить в txt";
            this.SaveResultToTxtToolStripMenuItem.Click += new System.EventHandler(this.SaveResultToTxtToolStripMenuItem_Click);
            // 
            // SaveResultToExcelToolStripMenuItem
            // 
            this.SaveResultToExcelToolStripMenuItem.Name = "SaveResultToExcelToolStripMenuItem";
            this.SaveResultToExcelToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.SaveResultToExcelToolStripMenuItem.Text = "Сохранить в Excel";
            this.SaveResultToExcelToolStripMenuItem.Click += new System.EventHandler(this.SaveResultToExcelToolStripMenuItem_Click);
            // 
            // GeoTableTabPage
            // 
            this.GeoTableTabPage.Controls.Add(this.MainTableLayoutPanel);
            this.GeoTableTabPage.Location = new System.Drawing.Point(4, 25);
            this.GeoTableTabPage.Name = "GeoTableTabPage";
            this.GeoTableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GeoTableTabPage.Size = new System.Drawing.Size(1069, 494);
            this.GeoTableTabPage.TabIndex = 1;
            this.GeoTableTabPage.Text = "Таблица";
            this.GeoTableTabPage.UseVisualStyleBackColor = true;
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.GeotableMenuStrip, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.GeoTableDataGridView, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.NameChangeTableLayoutPanel, 0, 3);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 4;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.5F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.5F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(1063, 488);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // GeotableMenuStrip
            // 
            this.GeotableMenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeotableMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TableToolStripMenuItem,
            this.ColumnsToolStripMenuItem});
            this.GeotableMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.GeotableMenuStrip.Name = "GeotableMenuStrip";
            this.GeotableMenuStrip.Size = new System.Drawing.Size(1063, 24);
            this.GeotableMenuStrip.TabIndex = 1;
            this.GeotableMenuStrip.Text = "menuStrip1";
            // 
            // TableToolStripMenuItem
            // 
            this.TableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToExcelToolStripMenuItem,
            this.UploadExcelToolStripMenuItem,
            this.ClearGeoTableToolStripMenuItem});
            this.TableToolStripMenuItem.Name = "TableToolStripMenuItem";
            this.TableToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.TableToolStripMenuItem.Text = "Таблица";
            // 
            // SaveToExcelToolStripMenuItem
            // 
            this.SaveToExcelToolStripMenuItem.Name = "SaveToExcelToolStripMenuItem";
            this.SaveToExcelToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.SaveToExcelToolStripMenuItem.Text = "Сохранить в Excel";
            this.SaveToExcelToolStripMenuItem.Click += new System.EventHandler(this.SaveToExcelToolStripMenuItem_Click);
            // 
            // UploadExcelToolStripMenuItem
            // 
            this.UploadExcelToolStripMenuItem.Name = "UploadExcelToolStripMenuItem";
            this.UploadExcelToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.UploadExcelToolStripMenuItem.Text = "Открыть через Excel";
            this.UploadExcelToolStripMenuItem.Click += new System.EventHandler(this.UploadExcelToolStripMenuItem_Click);
            // 
            // ClearGeoTableToolStripMenuItem
            // 
            this.ClearGeoTableToolStripMenuItem.Name = "ClearGeoTableToolStripMenuItem";
            this.ClearGeoTableToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ClearGeoTableToolStripMenuItem.Text = "Очистить таблицу";
            this.ClearGeoTableToolStripMenuItem.Click += new System.EventHandler(this.ClearGeoTableToolStripMenuItem_Click);
            // 
            // ColumnsToolStripMenuItem
            // 
            this.ColumnsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddColumnToolStripMenuItem,
            this.RemoveLastColumnToolStripMenuItem});
            this.ColumnsToolStripMenuItem.Name = "ColumnsToolStripMenuItem";
            this.ColumnsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ColumnsToolStripMenuItem.Text = "Столбцы";
            // 
            // AddColumnToolStripMenuItem
            // 
            this.AddColumnToolStripMenuItem.Name = "AddColumnToolStripMenuItem";
            this.AddColumnToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.AddColumnToolStripMenuItem.Text = "Добавить новый столбец";
            this.AddColumnToolStripMenuItem.Click += new System.EventHandler(this.AddColumnToolStripMenuItem_Click);
            // 
            // RemoveLastColumnToolStripMenuItem
            // 
            this.RemoveLastColumnToolStripMenuItem.Name = "RemoveLastColumnToolStripMenuItem";
            this.RemoveLastColumnToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.RemoveLastColumnToolStripMenuItem.Text = "Удалить последний столбец";
            this.RemoveLastColumnToolStripMenuItem.Click += new System.EventHandler(this.RemoveLastColumnToolStripMenuItem_Click);
            // 
            // GeoTableDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GeoTableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GeoTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GeoTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25,
            this.Column26,
            this.Column27,
            this.Column28,
            this.Column29,
            this.Column30,
            this.Column31,
            this.Column32,
            this.Column33,
            this.Column34,
            this.Column35,
            this.Column36,
            this.Column37,
            this.Column38,
            this.Column39,
            this.Column40,
            this.Column41,
            this.Column42,
            this.Column43,
            this.Column44,
            this.Column45,
            this.Column46,
            this.Column47,
            this.Column48,
            this.Column49,
            this.Column50});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GeoTableDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.GeoTableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeoTableDataGridView.Location = new System.Drawing.Point(3, 27);
            this.GeoTableDataGridView.Name = "GeoTableDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GeoTableDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GeoTableDataGridView.RowHeadersWidth = 55;
            this.GeoTableDataGridView.Size = new System.Drawing.Size(1057, 347);
            this.GeoTableDataGridView.TabIndex = 2;
            this.GeoTableDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.GeoTableDataGridView_CellBeginEdit);
            this.GeoTableDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.GeoTableDataGridView_CellValidated);
            this.GeoTableDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.GeoTableDataGridView_EditingControlShowing);
            this.GeoTableDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.GeoTableDataGridView_RowPrePaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "7";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "8";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "9";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "10";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "11";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "12";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "13";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "14";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "15";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "16";
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.HeaderText = "17";
            this.Column17.Name = "Column17";
            // 
            // Column18
            // 
            this.Column18.HeaderText = "18";
            this.Column18.Name = "Column18";
            // 
            // Column19
            // 
            this.Column19.HeaderText = "19";
            this.Column19.Name = "Column19";
            // 
            // Column20
            // 
            this.Column20.HeaderText = "20";
            this.Column20.Name = "Column20";
            // 
            // Column21
            // 
            this.Column21.HeaderText = "21";
            this.Column21.Name = "Column21";
            // 
            // Column22
            // 
            this.Column22.HeaderText = "22";
            this.Column22.Name = "Column22";
            // 
            // Column23
            // 
            this.Column23.HeaderText = "23";
            this.Column23.Name = "Column23";
            // 
            // Column24
            // 
            this.Column24.HeaderText = "24";
            this.Column24.Name = "Column24";
            // 
            // Column25
            // 
            this.Column25.HeaderText = "25";
            this.Column25.Name = "Column25";
            // 
            // Column26
            // 
            this.Column26.HeaderText = "26";
            this.Column26.Name = "Column26";
            // 
            // Column27
            // 
            this.Column27.HeaderText = "27";
            this.Column27.Name = "Column27";
            // 
            // Column28
            // 
            this.Column28.HeaderText = "28";
            this.Column28.Name = "Column28";
            // 
            // Column29
            // 
            this.Column29.HeaderText = "29";
            this.Column29.Name = "Column29";
            // 
            // Column30
            // 
            this.Column30.HeaderText = "30";
            this.Column30.Name = "Column30";
            // 
            // Column31
            // 
            this.Column31.HeaderText = "31";
            this.Column31.Name = "Column31";
            // 
            // Column32
            // 
            this.Column32.HeaderText = "32";
            this.Column32.Name = "Column32";
            // 
            // Column33
            // 
            this.Column33.HeaderText = "33";
            this.Column33.Name = "Column33";
            // 
            // Column34
            // 
            this.Column34.HeaderText = "34";
            this.Column34.Name = "Column34";
            // 
            // Column35
            // 
            this.Column35.HeaderText = "35";
            this.Column35.Name = "Column35";
            // 
            // Column36
            // 
            this.Column36.HeaderText = "36";
            this.Column36.Name = "Column36";
            // 
            // Column37
            // 
            this.Column37.HeaderText = "37";
            this.Column37.Name = "Column37";
            // 
            // Column38
            // 
            this.Column38.HeaderText = "38";
            this.Column38.Name = "Column38";
            // 
            // Column39
            // 
            this.Column39.HeaderText = "39";
            this.Column39.Name = "Column39";
            // 
            // Column40
            // 
            this.Column40.HeaderText = "40";
            this.Column40.Name = "Column40";
            // 
            // Column41
            // 
            this.Column41.HeaderText = "41";
            this.Column41.Name = "Column41";
            // 
            // Column42
            // 
            this.Column42.HeaderText = "42";
            this.Column42.Name = "Column42";
            // 
            // Column43
            // 
            this.Column43.HeaderText = "43";
            this.Column43.Name = "Column43";
            // 
            // Column44
            // 
            this.Column44.HeaderText = "44";
            this.Column44.Name = "Column44";
            // 
            // Column45
            // 
            this.Column45.HeaderText = "45";
            this.Column45.Name = "Column45";
            // 
            // Column46
            // 
            this.Column46.HeaderText = "46";
            this.Column46.Name = "Column46";
            // 
            // Column47
            // 
            this.Column47.HeaderText = "47";
            this.Column47.Name = "Column47";
            // 
            // Column48
            // 
            this.Column48.HeaderText = "48";
            this.Column48.Name = "Column48";
            // 
            // Column49
            // 
            this.Column49.HeaderText = "49";
            this.Column49.Name = "Column49";
            // 
            // Column50
            // 
            this.Column50.HeaderText = "50";
            this.Column50.Name = "Column50";
            // 
            // NameChangeTableLayoutPanel
            // 
            this.NameChangeTableLayoutPanel.ColumnCount = 3;
            this.NameChangeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.NameChangeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            this.NameChangeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.NameChangeTableLayoutPanel.Controls.Add(this.ChangeColumnNameButton, 2, 1);
            this.NameChangeTableLayoutPanel.Controls.Add(this.GetResultsTableButton, 2, 0);
            this.NameChangeTableLayoutPanel.Controls.Add(this.NameChangeInputTextBox, 1, 1);
            this.NameChangeTableLayoutPanel.Controls.Add(this.CurrentColumnNameTextBox, 1, 0);
            this.NameChangeTableLayoutPanel.Controls.Add(this.Label4, 0, 1);
            this.NameChangeTableLayoutPanel.Controls.Add(this.Label3, 0, 0);
            this.NameChangeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameChangeTableLayoutPanel.Location = new System.Drawing.Point(3, 401);
            this.NameChangeTableLayoutPanel.Name = "NameChangeTableLayoutPanel";
            this.NameChangeTableLayoutPanel.RowCount = 2;
            this.NameChangeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NameChangeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NameChangeTableLayoutPanel.Size = new System.Drawing.Size(1057, 84);
            this.NameChangeTableLayoutPanel.TabIndex = 3;
            // 
            // ChangeColumnNameButton
            // 
            this.ChangeColumnNameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeColumnNameButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeColumnNameButton.Location = new System.Drawing.Point(819, 45);
            this.ChangeColumnNameButton.Name = "ChangeColumnNameButton";
            this.ChangeColumnNameButton.Size = new System.Drawing.Size(235, 36);
            this.ChangeColumnNameButton.TabIndex = 7;
            this.ChangeColumnNameButton.Text = "Изменить название столбца";
            this.ChangeColumnNameButton.UseVisualStyleBackColor = true;
            this.ChangeColumnNameButton.Click += new System.EventHandler(this.ChangeColumnNameButton_Click);
            // 
            // GetResultsTableButton
            // 
            this.GetResultsTableButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GetResultsTableButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetResultsTableButton.Location = new System.Drawing.Point(819, 3);
            this.GetResultsTableButton.Name = "GetResultsTableButton";
            this.GetResultsTableButton.Size = new System.Drawing.Size(235, 36);
            this.GetResultsTableButton.TabIndex = 7;
            this.GetResultsTableButton.Text = "Рассчитать";
            this.GetResultsTableButton.UseVisualStyleBackColor = true;
            this.GetResultsTableButton.Click += new System.EventHandler(this.GetResultsTableButton_Click);
            // 
            // NameChangeInputTextBox
            // 
            this.NameChangeInputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameChangeInputTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameChangeInputTextBox.Location = new System.Drawing.Point(387, 45);
            this.NameChangeInputTextBox.Name = "NameChangeInputTextBox";
            this.NameChangeInputTextBox.Size = new System.Drawing.Size(426, 35);
            this.NameChangeInputTextBox.TabIndex = 6;
            this.NameChangeInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameChangeInputTextBox_KeyDown);
            // 
            // CurrentColumnNameTextBox
            // 
            this.CurrentColumnNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentColumnNameTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentColumnNameTextBox.Location = new System.Drawing.Point(387, 3);
            this.CurrentColumnNameTextBox.Name = "CurrentColumnNameTextBox";
            this.CurrentColumnNameTextBox.Size = new System.Drawing.Size(426, 35);
            this.CurrentColumnNameTextBox.TabIndex = 5;
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label4.Location = new System.Drawing.Point(29, 42);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(352, 27);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Новое наименование столбца:\r\n";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label3.Location = new System.Drawing.Point(3, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(378, 27);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Текущее наименование столбца:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainTabPage
            // 
            this.MainTabPage.Controls.Add(this.AdaptiveSizeСheckBox);
            this.MainTabPage.Controls.Add(this.NumericRangeTextBox);
            this.MainTabPage.Controls.Add(this.InstructionButton);
            this.MainTabPage.Controls.Add(this.Label1);
            this.MainTabPage.Controls.Add(this.Label2);
            this.MainTabPage.Location = new System.Drawing.Point(4, 25);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPage.Size = new System.Drawing.Size(1069, 494);
            this.MainTabPage.TabIndex = 0;
            this.MainTabPage.Text = "СГИ";
            this.MainTabPage.UseVisualStyleBackColor = true;
            // 
            // AdaptiveSizeСheckBox
            // 
            this.AdaptiveSizeСheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AdaptiveSizeСheckBox.AutoSize = true;
            this.AdaptiveSizeСheckBox.Checked = true;
            this.AdaptiveSizeСheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AdaptiveSizeСheckBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdaptiveSizeСheckBox.Location = new System.Drawing.Point(637, 361);
            this.AdaptiveSizeСheckBox.Name = "AdaptiveSizeСheckBox";
            this.AdaptiveSizeСheckBox.Size = new System.Drawing.Size(402, 28);
            this.AdaptiveSizeСheckBox.TabIndex = 15;
            this.AdaptiveSizeСheckBox.Text = "Адаптивный размер диапазона оценок";
            this.AdaptiveSizeСheckBox.UseVisualStyleBackColor = true;
            // 
            // NumericRangeTextBox
            // 
            this.NumericRangeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NumericRangeTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumericRangeTextBox.Location = new System.Drawing.Point(637, 329);
            this.NumericRangeTextBox.Name = "NumericRangeTextBox";
            this.NumericRangeTextBox.Size = new System.Drawing.Size(54, 26);
            this.NumericRangeTextBox.TabIndex = 14;
            this.NumericRangeTextBox.Text = "3";
            this.NumericRangeTextBox.TextChanged += new System.EventHandler(this.NumericRangeTextBox_TextChanged);
            // 
            // InstructionButton
            // 
            this.InstructionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InstructionButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstructionButton.Location = new System.Drawing.Point(921, 6);
            this.InstructionButton.Name = "InstructionButton";
            this.InstructionButton.Size = new System.Drawing.Size(140, 84);
            this.InstructionButton.TabIndex = 12;
            this.InstructionButton.Text = "Инструкция";
            this.InstructionButton.UseVisualStyleBackColor = true;
            this.InstructionButton.Click += new System.EventHandler(this.InstructionButton_Click);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label1.Location = new System.Drawing.Point(8, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(739, 65);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Программа обработки информации при количественном геологическом прогнозировании";
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label2.Location = new System.Drawing.Point(8, 322);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(635, 165);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Количество цифр после запятой в результате:\r\nПрограмма считает:\r\nРасчет натуральн" +
    "ых оценок\r\nПриведения и упорядочивания\r\nОбработки оценок перспективности ГОБ (3К" +
    ")\r\n";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.MainTabPage);
            this.MainTabControl.Controls.Add(this.GeoTableTabPage);
            this.MainTabControl.Controls.Add(this.ResultTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1077, 523);
            this.MainTabControl.TabIndex = 6;
            // 
            // NumberOfColumn
            // 
            this.NumberOfColumn.Frozen = true;
            this.NumberOfColumn.HeaderText = "Номер столбца (название)";
            this.NumberOfColumn.Name = "NumberOfColumn";
            this.NumberOfColumn.ReadOnly = true;
            this.NumberOfColumn.Width = 125;
            // 
            // ColumnValue
            // 
            this.ColumnValue.Frozen = true;
            this.ColumnValue.HeaderText = "Значение";
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.ReadOnly = true;
            this.ColumnValue.Width = 125;
            // 
            // ColumnEvaluation
            // 
            this.ColumnEvaluation.Frozen = true;
            this.ColumnEvaluation.HeaderText = "Оценка";
            this.ColumnEvaluation.Name = "ColumnEvaluation";
            this.ColumnEvaluation.ReadOnly = true;
            this.ColumnEvaluation.Width = 125;
            // 
            // AverageColumnSum
            // 
            this.AverageColumnSum.Frozen = true;
            this.AverageColumnSum.HeaderText = "Средняя сумма";
            this.AverageColumnSum.Name = "AverageColumnSum";
            this.AverageColumnSum.ReadOnly = true;
            this.AverageColumnSum.Width = 125;
            // 
            // Column55
            // 
            this.Column55.Frozen = true;
            this.Column55.HeaderText = "";
            this.Column55.Name = "Column55";
            this.Column55.ReadOnly = true;
            this.Column55.Width = 20;
            // 
            // RangeOfGradesColumn
            // 
            this.RangeOfGradesColumn.Frozen = true;
            this.RangeOfGradesColumn.HeaderText = "Диапазон оценок";
            this.RangeOfGradesColumn.Name = "RangeOfGradesColumn";
            this.RangeOfGradesColumn.ReadOnly = true;
            this.RangeOfGradesColumn.Width = 85;
            // 
            // NumberOfColumns
            // 
            this.NumberOfColumns.FillWeight = 35F;
            this.NumberOfColumns.Frozen = true;
            this.NumberOfColumns.HeaderText = "Количество столбцов";
            this.NumberOfColumns.Name = "NumberOfColumns";
            this.NumberOfColumns.ReadOnly = true;
            this.NumberOfColumns.Width = 85;
            // 
            // ProspectiveGOBs
            // 
            this.ProspectiveGOBs.Frozen = true;
            this.ProspectiveGOBs.HeaderText = "Перспективные ГОБ (столбец)";
            this.ProspectiveGOBs.Name = "ProspectiveGOBs";
            this.ProspectiveGOBs.ReadOnly = true;
            this.ProspectiveGOBs.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 523);
            this.Controls.Add(this.MainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1093, 562);
            this.Name = "MainForm";
            this.Text = "СГИ - Геопрогноз";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResultTabPage.ResumeLayout(false);
            this.ResultTableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).EndInit();
            this.ResultMenuStrip.ResumeLayout(false);
            this.ResultMenuStrip.PerformLayout();
            this.GeoTableTabPage.ResumeLayout(false);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            this.GeotableMenuStrip.ResumeLayout(false);
            this.GeotableMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeoTableDataGridView)).EndInit();
            this.NameChangeTableLayoutPanel.ResumeLayout(false);
            this.NameChangeTableLayoutPanel.PerformLayout();
            this.MainTabPage.ResumeLayout(false);
            this.MainTabPage.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage ResultTabPage;
        private System.Windows.Forms.TabPage GeoTableTabPage;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.MenuStrip GeotableMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UploadExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearGeoTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColumnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveLastColumnToolStripMenuItem;
        private System.Windows.Forms.DataGridView GeoTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column29;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column30;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column31;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column32;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column33;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column34;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column35;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column36;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column37;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column38;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column39;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column40;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column41;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column42;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column43;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column44;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column45;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column46;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column47;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column48;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column49;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column50;
        private System.Windows.Forms.TabPage MainTabPage;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TableLayoutPanel ResultTableLayoutPanel;
        private System.Windows.Forms.TextBox NumericRangeTextBox;
        private System.Windows.Forms.Button InstructionButton;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.DataGridView ResultDataGridView;
        private System.Windows.Forms.MenuStrip ResultMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ResultTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveResultToTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveResultToExcelToolStripMenuItem;
        private System.Windows.Forms.Button GetResultsTableButton;
        private System.Windows.Forms.TableLayoutPanel NameChangeTableLayoutPanel;
        private System.Windows.Forms.TextBox NameChangeInputTextBox;
        private System.Windows.Forms.TextBox CurrentColumnNameTextBox;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Button ChangeColumnNameButton;
        private System.Windows.Forms.CheckBox AdaptiveSizeСheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEvaluation;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageColumnSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column55;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeOfGradesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfColumns;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProspectiveGOBs;
    }
}