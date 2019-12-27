namespace CompleteApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ComboBox_changeTeam = new MetroFramework.Controls.MetroComboBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ComboBox_changeHead = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPageMain = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.pg1 = new MetroFramework.Controls.MetroProgressBar();
            this.btnRefreshList = new MetroFramework.Controls.MetroButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.ActiveBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.ActiveBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.CellColumn3TextBox = new System.Windows.Forms.TextBox();
            this.CellColumn2TextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.CellEnd = new System.Windows.Forms.TextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.CellPage = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.CellColumn1TextBox = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.CellBegin = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnExcel = new MetroFramework.Controls.MetroButton();
            this.btnWord = new MetroFramework.Controls.MetroButton();
            this.tabPagePrint = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.tabPageSettings = new MetroFramework.Controls.MetroTabPage();
            this.btnSaveSetting = new MetroFramework.Controls.MetroButton();
            this.textBoxKeyword = new MetroFramework.Controls.MetroTextBox();
            this.textBoxAdress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxOrganName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPagePrint.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBox_changeTeam
            // 
            this.ComboBox_changeTeam.FormattingEnabled = true;
            this.ComboBox_changeTeam.ItemHeight = 23;
            this.ComboBox_changeTeam.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.ComboBox_changeTeam.Location = new System.Drawing.Point(5, 353);
            this.ComboBox_changeTeam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBox_changeTeam.Name = "ComboBox_changeTeam";
            this.ComboBox_changeTeam.Size = new System.Drawing.Size(160, 29);
            this.ComboBox_changeTeam.TabIndex = 1;
            this.ComboBox_changeTeam.UseSelectable = true;
            this.ComboBox_changeTeam.SelectedIndexChanged += new System.EventHandler(this.ChangeTeam);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // ComboBox_changeHead
            // 
            this.ComboBox_changeHead.FormattingEnabled = true;
            this.ComboBox_changeHead.ItemHeight = 23;
            this.ComboBox_changeHead.Items.AddRange(new object[] {
            "Default",
            "Black",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red",
            "Yellow"});
            this.ComboBox_changeHead.Location = new System.Drawing.Point(185, 353);
            this.ComboBox_changeHead.Name = "ComboBox_changeHead";
            this.ComboBox_changeHead.Size = new System.Drawing.Size(160, 29);
            this.ComboBox_changeHead.TabIndex = 2;
            this.ComboBox_changeHead.UseSelectable = true;
            this.ComboBox_changeHead.SelectedIndexChanged += new System.EventHandler(this.ChangeHead);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroTabControl1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(27, 69);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(881, 489);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPageMain);
            this.metroTabControl1.Controls.Add(this.tabPagePrint);
            this.metroTabControl1.Controls.Add(this.tabPageSettings);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(879, 487);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPageMain.Controls.Add(this.metroLabel11);
            this.tabPageMain.Controls.Add(this.pg1);
            this.tabPageMain.Controls.Add(this.btnRefreshList);
            this.tabPageMain.Controls.Add(this.metroLabel10);
            this.tabPageMain.Controls.Add(this.ActiveBox3);
            this.tabPageMain.Controls.Add(this.ActiveBox2);
            this.tabPageMain.Controls.Add(this.CellColumn3TextBox);
            this.tabPageMain.Controls.Add(this.CellColumn2TextBox);
            this.tabPageMain.Controls.Add(this.richTextBox1);
            this.tabPageMain.Controls.Add(this.metroLabel8);
            this.tabPageMain.Controls.Add(this.CellEnd);
            this.tabPageMain.Controls.Add(this.metroLabel7);
            this.tabPageMain.Controls.Add(this.CellPage);
            this.tabPageMain.Controls.Add(this.metroLabel5);
            this.tabPageMain.Controls.Add(this.CellColumn1TextBox);
            this.tabPageMain.Controls.Add(this.metroLabel4);
            this.tabPageMain.Controls.Add(this.CellBegin);
            this.tabPageMain.Controls.Add(this.metroLabel3);
            this.tabPageMain.Controls.Add(this.btnExcel);
            this.tabPageMain.Controls.Add(this.btnWord);
            this.tabPageMain.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMain.HorizontalScrollbar = true;
            this.tabPageMain.HorizontalScrollbarBarColor = true;
            this.tabPageMain.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageMain.HorizontalScrollbarSize = 14;
            this.tabPageMain.Location = new System.Drawing.Point(4, 38);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Size = new System.Drawing.Size(871, 445);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Главная";
            this.tabPageMain.VerticalScrollbar = true;
            this.tabPageMain.VerticalScrollbarBarColor = true;
            this.tabPageMain.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageMain.VerticalScrollbarSize = 10;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(3, 15);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(237, 19);
            this.metroLabel11.TabIndex = 30;
            this.metroLabel11.Text = "Файл нужно выбрать лишь один раз:";
            // 
            // pg1
            // 
            this.pg1.Location = new System.Drawing.Point(3, 415);
            this.pg1.Name = "pg1";
            this.pg1.Size = new System.Drawing.Size(337, 30);
            this.pg1.TabIndex = 29;
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Location = new System.Drawing.Point(3, 323);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(337, 30);
            this.btnRefreshList.TabIndex = 28;
            this.btnRefreshList.Text = "Обновить и отобразить выбранные поля списком";
            this.btnRefreshList.UseSelectable = true;
            this.btnRefreshList.Click += new System.EventHandler(this.BtnRefreshList_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(3, 110);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(60, 19);
            this.metroLabel10.TabIndex = 27;
            this.metroLabel10.Text = "Строки :";
            // 
            // ActiveBox3
            // 
            this.ActiveBox3.AutoSize = true;
            this.ActiveBox3.Location = new System.Drawing.Point(266, 288);
            this.ActiveBox3.Name = "ActiveBox3";
            this.ActiveBox3.Size = new System.Drawing.Size(31, 15);
            this.ActiveBox3.TabIndex = 26;
            this.ActiveBox3.Text = "+";
            this.ActiveBox3.UseSelectable = true;
            this.ActiveBox3.CheckedChanged += new System.EventHandler(this.ActiveBox3_CheckedChanged);
            // 
            // ActiveBox2
            // 
            this.ActiveBox2.AutoSize = true;
            this.ActiveBox2.Location = new System.Drawing.Point(266, 253);
            this.ActiveBox2.Name = "ActiveBox2";
            this.ActiveBox2.Size = new System.Drawing.Size(31, 15);
            this.ActiveBox2.TabIndex = 25;
            this.ActiveBox2.Text = "+";
            this.ActiveBox2.UseSelectable = true;
            this.ActiveBox2.CheckedChanged += new System.EventHandler(this.ActiveBox2_CheckedChanged);
            // 
            // CellColumn3TextBox
            // 
            this.CellColumn3TextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CellColumn3TextBox.Location = new System.Drawing.Point(171, 288);
            this.CellColumn3TextBox.Name = "CellColumn3TextBox";
            this.CellColumn3TextBox.Size = new System.Drawing.Size(89, 29);
            this.CellColumn3TextBox.TabIndex = 24;
            this.CellColumn3TextBox.Text = "D";
            // 
            // CellColumn2TextBox
            // 
            this.CellColumn2TextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CellColumn2TextBox.Location = new System.Drawing.Point(171, 253);
            this.CellColumn2TextBox.Name = "CellColumn2TextBox";
            this.CellColumn2TextBox.Size = new System.Drawing.Size(89, 29);
            this.CellColumn2TextBox.TabIndex = 23;
            this.CellColumn2TextBox.Text = "C";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(365, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(506, 445);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(132, 180);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(33, 19);
            this.metroLabel8.TabIndex = 19;
            this.metroLabel8.Text = "До :";
            // 
            // CellEnd
            // 
            this.CellEnd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CellEnd.Location = new System.Drawing.Point(171, 180);
            this.CellEnd.Name = "CellEnd";
            this.CellEnd.Size = new System.Drawing.Size(89, 29);
            this.CellEnd.TabIndex = 18;
            this.CellEnd.Text = "10";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 73);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(162, 19);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "Страница в Excel файле :";
            // 
            // CellPage
            // 
            this.CellPage.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CellPage.Location = new System.Drawing.Point(171, 73);
            this.CellPage.Name = "CellPage";
            this.CellPage.Size = new System.Drawing.Size(89, 29);
            this.CellPage.TabIndex = 16;
            this.CellPage.Text = "1";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 218);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(70, 19);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Столбцы :";
            // 
            // CellColumn1TextBox
            // 
            this.CellColumn1TextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CellColumn1TextBox.Location = new System.Drawing.Point(171, 218);
            this.CellColumn1TextBox.Name = "CellColumn1TextBox";
            this.CellColumn1TextBox.Size = new System.Drawing.Size(89, 29);
            this.CellColumn1TextBox.TabIndex = 14;
            this.CellColumn1TextBox.Text = "B";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(133, 145);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(32, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "От :";
            // 
            // CellBegin
            // 
            this.CellBegin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CellBegin.Location = new System.Drawing.Point(171, 145);
            this.CellBegin.Name = "CellBegin";
            this.CellBegin.Size = new System.Drawing.Size(89, 29);
            this.CellBegin.TabIndex = 11;
            this.CellBegin.Text = "2";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(8, 77);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Файлы :";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(3, 37);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(337, 30);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Выбрать Excel файл ";
            this.btnExcel.UseSelectable = true;
            this.btnExcel.Click += new System.EventHandler(this.Excel_click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(3, 359);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(337, 30);
            this.btnWord.TabIndex = 4;
            this.btnWord.Text = "Выбрать Word файл с шаблоном сертификата";
            this.btnWord.UseSelectable = true;
            this.btnWord.Click += new System.EventHandler(this.Word_click);
            // 
            // tabPagePrint
            // 
            this.tabPagePrint.Controls.Add(this.metroLabel12);
            this.tabPagePrint.HorizontalScrollbarBarColor = true;
            this.tabPagePrint.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagePrint.HorizontalScrollbarSize = 9;
            this.tabPagePrint.Location = new System.Drawing.Point(4, 38);
            this.tabPagePrint.Name = "tabPagePrint";
            this.tabPagePrint.Size = new System.Drawing.Size(871, 445);
            this.tabPagePrint.TabIndex = 3;
            this.tabPagePrint.Text = "Печать";
            this.tabPagePrint.VerticalScrollbarBarColor = true;
            this.tabPagePrint.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagePrint.VerticalScrollbarSize = 8;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(292, 197);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(254, 19);
            this.metroLabel12.TabIndex = 2;
            this.metroLabel12.Text = "Этот функционал сейчас в разработке...";
            this.metroLabel12.UseWaitCursor = true;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.textBoxOrganName);
            this.tabPageSettings.Controls.Add(this.metroLabel13);
            this.tabPageSettings.Controls.Add(this.btnSaveSetting);
            this.tabPageSettings.Controls.Add(this.textBoxKeyword);
            this.tabPageSettings.Controls.Add(this.textBoxAdress);
            this.tabPageSettings.Controls.Add(this.metroLabel6);
            this.tabPageSettings.Controls.Add(this.metroLabel9);
            this.tabPageSettings.Controls.Add(this.metroLabel2);
            this.tabPageSettings.Controls.Add(this.metroLabel1);
            this.tabPageSettings.Controls.Add(this.ComboBox_changeHead);
            this.tabPageSettings.Controls.Add(this.ComboBox_changeTeam);
            this.tabPageSettings.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSettings.HorizontalScrollbar = true;
            this.tabPageSettings.HorizontalScrollbarBarColor = true;
            this.tabPageSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageSettings.HorizontalScrollbarSize = 14;
            this.tabPageSettings.Location = new System.Drawing.Point(4, 38);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(871, 445);
            this.tabPageSettings.TabIndex = 2;
            this.tabPageSettings.Text = "Настройки";
            this.tabPageSettings.VerticalScrollbar = true;
            this.tabPageSettings.VerticalScrollbarBarColor = true;
            this.tabPageSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageSettings.VerticalScrollbarSize = 10;
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.Location = new System.Drawing.Point(7, 232);
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(160, 45);
            this.btnSaveSetting.TabIndex = 23;
            this.btnSaveSetting.Text = "Сохранить";
            this.btnSaveSetting.UseSelectable = true;
            this.btnSaveSetting.Click += new System.EventHandler(this.BtnSaveSetting_Click);
            // 
            // textBoxKeyword
            // 
            // 
            // 
            // 
            this.textBoxKeyword.CustomButton.Image = null;
            this.textBoxKeyword.CustomButton.Location = new System.Drawing.Point(709, 1);
            this.textBoxKeyword.CustomButton.Name = "";
            this.textBoxKeyword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxKeyword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxKeyword.CustomButton.TabIndex = 1;
            this.textBoxKeyword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxKeyword.CustomButton.UseSelectable = true;
            this.textBoxKeyword.CustomButton.Visible = false;
            this.textBoxKeyword.Lines = new string[0];
            this.textBoxKeyword.Location = new System.Drawing.Point(5, 116);
            this.textBoxKeyword.MaxLength = 32767;
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.PasswordChar = '\0';
            this.textBoxKeyword.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxKeyword.SelectedText = "";
            this.textBoxKeyword.SelectionLength = 0;
            this.textBoxKeyword.SelectionStart = 0;
            this.textBoxKeyword.ShortcutsEnabled = true;
            this.textBoxKeyword.Size = new System.Drawing.Size(731, 23);
            this.textBoxKeyword.TabIndex = 6;
            this.textBoxKeyword.UseSelectable = true;
            this.textBoxKeyword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxKeyword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxAdress
            // 
            // 
            // 
            // 
            this.textBoxAdress.CustomButton.Image = null;
            this.textBoxAdress.CustomButton.Location = new System.Drawing.Point(709, 1);
            this.textBoxAdress.CustomButton.Name = "";
            this.textBoxAdress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxAdress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxAdress.CustomButton.TabIndex = 1;
            this.textBoxAdress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxAdress.CustomButton.UseSelectable = true;
            this.textBoxAdress.CustomButton.Visible = false;
            this.textBoxAdress.Lines = new string[0];
            this.textBoxAdress.Location = new System.Drawing.Point(5, 38);
            this.textBoxAdress.MaxLength = 32767;
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.PasswordChar = '\0';
            this.textBoxAdress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxAdress.SelectedText = "";
            this.textBoxAdress.SelectionLength = 0;
            this.textBoxAdress.SelectionStart = 0;
            this.textBoxAdress.ShortcutsEnabled = true;
            this.textBoxAdress.Size = new System.Drawing.Size(731, 23);
            this.textBoxAdress.TabIndex = 21;
            this.textBoxAdress.UseSelectable = true;
            this.textBoxAdress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxAdress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 83);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(467, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Ключевое слово, которое будет изменено в шаблоне на слова из списка :";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(5, 10);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(379, 19);
            this.metroLabel9.TabIndex = 22;
            this.metroLabel9.Text = "Скопируйте сюда путь для сохранения полученных файлов:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(185, 318);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Цвет :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(5, 318);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Тема :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxOrganName
            // 
            // 
            // 
            // 
            this.textBoxOrganName.CustomButton.Image = null;
            this.textBoxOrganName.CustomButton.Location = new System.Drawing.Point(709, 1);
            this.textBoxOrganName.CustomButton.Name = "";
            this.textBoxOrganName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxOrganName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxOrganName.CustomButton.TabIndex = 1;
            this.textBoxOrganName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxOrganName.CustomButton.UseSelectable = true;
            this.textBoxOrganName.CustomButton.Visible = false;
            this.textBoxOrganName.Lines = new string[0];
            this.textBoxOrganName.Location = new System.Drawing.Point(7, 194);
            this.textBoxOrganName.MaxLength = 32767;
            this.textBoxOrganName.Name = "textBoxOrganName";
            this.textBoxOrganName.PasswordChar = '\0';
            this.textBoxOrganName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOrganName.SelectedText = "";
            this.textBoxOrganName.SelectionLength = 0;
            this.textBoxOrganName.SelectionStart = 0;
            this.textBoxOrganName.ShortcutsEnabled = true;
            this.textBoxOrganName.Size = new System.Drawing.Size(731, 23);
            this.textBoxOrganName.TabIndex = 24;
            this.textBoxOrganName.UseSelectable = true;
            this.textBoxOrganName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxOrganName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(5, 161);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(199, 19);
            this.metroLabel13.TabIndex = 25;
            this.metroLabel13.Text = "Название вашей организации:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 581);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Script MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(27, 69, 27, 23);
            this.Text = "Сертификат";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPagePrint.ResumeLayout(false);
            this.tabPagePrint.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox ComboBox_changeTeam;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroComboBox ComboBox_changeHead;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabPageMain;
        private MetroFramework.Controls.MetroTabPage tabPageSettings;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnExcel;
        private MetroFramework.Controls.MetroButton btnWord;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox textBoxKeyword;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox CellBegin;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox CellColumn1TextBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox CellPage;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.TextBox CellEnd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox textBoxAdress;
        private System.Windows.Forms.TextBox CellColumn3TextBox;
        private System.Windows.Forms.TextBox CellColumn2TextBox;
        private MetroFramework.Controls.MetroCheckBox ActiveBox3;
        private MetroFramework.Controls.MetroCheckBox ActiveBox2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton btnSaveSetting;
        private MetroFramework.Controls.MetroButton btnRefreshList;
        private MetroFramework.Controls.MetroProgressBar pg1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTabPage tabPagePrint;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox textBoxOrganName;
        private MetroFramework.Controls.MetroLabel metroLabel13;
    }
}

