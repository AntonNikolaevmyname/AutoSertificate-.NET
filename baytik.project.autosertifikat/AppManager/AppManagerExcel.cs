using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CompleteApp
{
    public partial class AppManager
    {
        public void ExcelReader()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Microsoft Excel (*.xls*)|*.xls*",
                FilterIndex = 2,
                Title = "Выберите таблицу Excel"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _objExcel = new Excel.Application();                                                                                                                  
                    _objWorkBook = 
                        _objExcel.Workbooks.Open
                        (
                            openFileDialog1.FileName, 0, false, 5, 
                            "", "", false, Excel.XlPlatform.xlWindows,
                            "", true, false, 0, true, false, false
                        );

                }
                catch { MessageBox.Show("Не удалось открыть Excel file", "Invalid input file."); }
            }

        }
    }
}
