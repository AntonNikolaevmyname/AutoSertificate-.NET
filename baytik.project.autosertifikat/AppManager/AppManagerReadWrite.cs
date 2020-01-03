using System;
using System.IO;
using System.Windows.Forms;

namespace CompleteApp
{
    public partial class AppManager
    {
        public void ReadConfig()
        {
            try
            {
                using (StreamReader sr =
                       new StreamReader(configFileName, System.Text.Encoding.Default))
                {
                    int i = 0;
                    string line = string.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        switch (i)
                        {
                            case 0:
                                adress = line;
                                break;
                            case 1:
                                keyword = line;
                                break;
                            case 2:
                                companyName = line;
                                break;
                            case 3:
                                backgroundTeam = Int32.Parse(line);
                                break;
                            case 4:
                                backgroundHead = Int32.Parse(line);
                                break;
                            default:
                                break;
                        }
                        i++;
                    }
                    sr.Close();
                }
            }
            catch (Exception e){ MessageBox.Show($"Ошибка: {e.Message}"); }
        }


        private void WriteConfig()
        {
            try
            {
                using (StreamWriter sw =
                     new StreamWriter(configFileName, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(adress);
                    sw.WriteLine(keyword);
                    sw.WriteLine(companyName);
                    sw.WriteLine(backgroundTeam);
                    sw.WriteLine(backgroundHead);
                    sw.Close();
                }
            }
            catch (Exception e) { MessageBox.Show($"Ошибка: {e.Message}"); }
        }
    }
}
