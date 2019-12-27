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
                _sr =
                   new StreamReader(configFileName, System.Text.Encoding.Default);
                isConfigFileFind = true;
            }
            catch { isConfigFileFind = false; }

            if (!ConfigFileChecker())
            {
                return;
            }

            int i = 0;
            string line;
            while ((line = _sr.ReadLine()) != null)
            {
                switch(i)
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
            _sr.Close();
        }


        private void WriteConfig()
        {
            if (!ConfigFileChecker())
            {
                return;
            }

            _sw =
                 new StreamWriter(configFileName, false, System.Text.Encoding.Default);

            _sw.WriteLine(adress);
            _sw.WriteLine(keyword);
            _sw.WriteLine(companyName);
            _sw.WriteLine(backgroundTeam);
            _sw.WriteLine(backgroundHead);

            _sw.Close();
        }
        private bool ConfigFileChecker()
        {
            if (!isConfigFileFind)
            {
                MessageBox.Show($"Файл {configFileName} не найден", $"{configFileName}.txt not found");
                return false;
            }
            return true;
        }
    }
}
