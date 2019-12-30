using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CompleteApp
{
    public partial class AppManager : IDisposable
    {
        public void InitAppManager()
        {
            _names = new List<string>();
            _safeFileNames = new List<string>();
        }

        public void SaveSettings(string adress, string keyword, string companyName)
        {
            if (string.IsNullOrEmpty(adress)  || 
                string.IsNullOrEmpty(keyword) || 
                string.IsNullOrEmpty(companyName))
            {
                MessageBox.Show($"Поля обязательно должны быть заполнены!", $"Invalid data.");
                return;
            }

            this.adress = adress;
            this.keyword = keyword;
            this.companyName = companyName;

            WriteConfig();
        }

        public void SaveUISettings(int backgroundTeam, int backgroundHead) 
        {
            if(backgroundTeam == 0 || backgroundTeam == 1)
                this.backgroundTeam = backgroundTeam;
            if(backgroundHead > 0)
                this.backgroundHead = backgroundHead;

            ChangeTeam(this.backgroundTeam);
            ChangeHead(this.backgroundHead);
            WriteConfig();
        }

        public void RefreshList()
        {

            try
            {
                _cellPage = Int32.Parse(cellPage.Text);
                _cellBegin = Int32.Parse(cellBegin.Text);
                _cellEnd = Int32.Parse(cellEnd.Text);
            }
            catch { MessageBox.Show("Выберите Excel файл заново...", "Invalid Excel file."); return; }

            try
            {
                listNamesRichText.Clear();
                _names.Clear();

                _objWorkSheet = (Excel.Worksheet)_objWorkBook.Sheets[_cellPage];

                
                for (int i = _cellBegin; i < _cellEnd; i++)
                {
                    // Выбираем область таблицы. (в нашем случае просто ячейку)
                    Excel.Range range1 = _objWorkSheet.get_Range(cellColumn1TextBox.Text + i);
                    Excel.Range range2 = _objWorkSheet.get_Range(cellColumn2TextBox.Text + i);
                    Excel.Range range3 = _objWorkSheet.get_Range(cellColumn3TextBox.Text + i);
                    // Добавляем полученный из ячейки текст.
                    string column1, column2, column3;
                    switch (_abc)
                    {
                        case "A":
                            column1 = range1.Text.ToString();
                            listNamesRichText.Text += $"{column1}\n";
                            _names.Add(column1);
                            break;
                        case "AB":
                            column1 = range1.Text.ToString();
                            column2 = range2.Text.ToString();
                            listNamesRichText.Text += $"{column1} {column2}\n";
                            _names.Add($"{column1} {column2}");
                            break;
                        case "ABC":
                            column1 = range1.Text.ToString();
                            column2 = range2.Text.ToString();
                            column3 = range3.Text.ToString();
                            listNamesRichText.Text += $"{column1} {column2} {column3}\n";
                            _names.Add($"{column1} {column2} {column3}");
                            break;
                        default:
                            break;

                    }
                    // Это чтобы форма прорисовывалась (не подвисала).
                    Application.DoEvents();
                }
                //Удаляем приложение (выходим из экселя) - а то будет висеть в процессах!
                CloseAllExcelProcesses();

            }
            catch { }

        }

        public void CloseAllExcelProcesses()
        {
            List<int> processesbeforegen = GetRunningProcessesExcel();
            List<int> processesaftergen = GetRunningProcessesExcel();
            KillProcesses(processesbeforegen, processesaftergen);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _objExcel.Quit();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
