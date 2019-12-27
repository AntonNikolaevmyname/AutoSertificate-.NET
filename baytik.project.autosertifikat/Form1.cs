using System;
using MetroFramework.Forms;

namespace CompleteApp
{
    public partial class Form1 : MetroForm
    {
        /*
         * TO DO:
         *      AppManagerVar -> Хранить в конфиге название компании.
         *      Баг с висящим процессом Excel остался.
         *      Хранить в конфиге, выбранные цвета темы и шапки.
         * */
        private static AppManager instance = null;
        public Form1()
        {
            InitializeComponent();

            if (instance == null)
            {
                instance = new AppManager();
                instance.InitAppManager();
            }
            instance.ReadConfig();
            InitAppConfig();
        }

        public void InitAppConfig()
        {
            instance.metroStyleManager = metroStyleManager1;
            this.StyleManager = metroStyleManager1;
            ComboBox_changeTeam.SelectedIndex = instance.backgroundTeam;
            ComboBox_changeHead.SelectedIndex = instance.backgroundHead;
            CellColumn2TextBox.Enabled = false;
            CellColumn3TextBox.Enabled = false;
            textBoxAdress.Text = instance.adress;
            textBoxKeyword.Text = instance.keyword;

            instance.cellPage = CellPage;
            instance.cellBegin = CellBegin;
            instance.cellEnd = CellEnd;
            instance.progressBar = pg1;
            instance.richText = richTextBox1;
            instance.activeBoxB = ActiveBox2;
            instance.activeBoxC = ActiveBox3;
            instance.cellColumn1TextBox = CellColumn1TextBox;
            instance.cellColumn2TextBox = CellColumn2TextBox;
            instance.cellColumn3TextBox = CellColumn3TextBox;
        }

        private void BtnSaveSetting_Click(object sender, EventArgs e)
        {
            instance.SaveSettings(textBoxAdress.Text, textBoxKeyword.Text);
        }
        private void BtnRefreshList_Click(object sender, EventArgs e)
        {
            instance.RefreshList();
        }
        private void Excel_click(object sender, EventArgs e)
        {
            instance.ExcelReader();
        }
        private void Word_click(object sender, EventArgs e)
        {
            instance.WordReader();
        }
        private void ChangeTeam(object sender, EventArgs e)
        {
            instance.ChangeTeam(ComboBox_changeTeam.SelectedIndex);
        }
        private void ChangeHead(object sender, EventArgs e)
        {
            instance.ChangeHead(ComboBox_changeHead.SelectedIndex);
        }
        private void ActiveBox2_CheckedChanged(object sender, EventArgs e)
        {
            instance.ActiveBoxChecker(ActiveBox2.Checked, ActiveBox3.Checked);
        }
        private void ActiveBox3_CheckedChanged(object sender, EventArgs e)
        {
            instance.ActiveBoxChecker(ActiveBox2.Checked, ActiveBox3.Checked);
        }
        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            instance.CloseForm();
        }
    }
}
  

 

