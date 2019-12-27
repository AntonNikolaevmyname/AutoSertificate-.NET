using System.Windows.Forms;

namespace CompleteApp
{
    public partial class AppManager
    {
        public void WordReader()
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    Filter = "Microsoft Word  (*.doc*)|*.doc*",
                    FilterIndex = 2,
                    Title = "Выберите файл Word"
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    progressBar.Value = 0;
                    progressBar.PerformStep();
                    for (int i = 0; i < _names.Count; i++)
                    {
                        CreateWordDocument(openFileDialog1.FileName, $"{adress}{fileNamePattern}_{_names[i]}", i);
                        progressBar.PerformStep();
                    }
                    progressBar.PerformStep();
                    Cursor.Current = Cursors.Default;
                }


            }
            catch { MessageBox.Show("Попробуйте снова.", "Word error."); }
        }
    }
}
