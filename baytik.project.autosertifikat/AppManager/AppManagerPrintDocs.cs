using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace CompleteApp
{
    public partial class AppManager
    {
        public void GetWordFilesForPrint()
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    Multiselect = true,
                    Filter = "Microsoft Word  (*.doc*)|*.doc*",
                    FilterIndex = 2,
                    Title = "Выберите файл Word",
                    InitialDirectory = adress
                };

                _safeFileNames.Clear();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in openFileDialog1.SafeFileNames)
                    {
                        _safeFileNames.Add(file);
                    }
                    UpdateSafeFileNamesRichText();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message, "Повторите снова."); }
        }

        public void Print()
        {
            using (PrintDialog pd = new PrintDialog())
            {
                pd.ShowDialog();
                for (int i = 0; i < _safeFileNames.Count; i++)
                {
                    ProcessStartInfo info = new ProcessStartInfo($"{adress}{_safeFileNames[i]}")
                    {
                        Verb = "PrintTo",
                        Arguments = pd.PrinterSettings.PrinterName,
                        CreateNoWindow = true,
                        WindowStyle = ProcessWindowStyle.Hidden
                    };
                    Process.Start(info);
                }
            }
        }

        private void UpdateSafeFileNamesRichText()
        {
            saveFileNamesRichText.Clear();
            foreach (string file in _safeFileNames)
            {
                saveFileNamesRichText.Text += $"{file}\n";
            }
        }
    }

}
