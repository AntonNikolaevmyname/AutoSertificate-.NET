using System;

namespace CompleteApp
{
    public partial class AppManager
    {
        private void ChangeTeam(int team)
        {
            
            switch (team)
            {
                case 0:
                    metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
                    break;
                case 1:
                    metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
                    break;
            }
        }

        private void ChangeHead(int head)
        {
            metroStyleManager.Style = 
                (MetroFramework.MetroColorStyle)Convert.ToInt32(head);
        }

        public void ActiveBoxChecker(bool boxB, bool boxC)
        {
            cellColumn2TextBox.Enabled = boxB;
            cellColumn3TextBox.Enabled = boxC;
            // boxA always true.
            if (boxB && boxC)
            {
                _abc = "ABC";
            }
            else if(!boxC)
            { 
                _abc.Replace("C", "");
                activeBoxC.Checked = false; 
            }
            else if(boxB)
            {
                _abc = "AB";
            }
            else if(!boxB)
            {
                _abc.Replace("B", "");
                activeBoxC.Checked = false;
            }
        }
    }
}
