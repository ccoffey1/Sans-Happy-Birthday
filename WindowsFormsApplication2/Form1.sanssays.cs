using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public partial class Form1
    {
        void SansSays(string s, int speed, bool lastMessage, int endDelay, string sansType)
        {
            switch (sansType)
            {
                case "normal":
                    sansBox.Image = Properties.Resources.sans_normal;
                    break;
                case "smirk":
                    sansBox.Image = Properties.Resources.sans_smirk;
                    break;
                case "wink":
                    sansBox.Image = Properties.Resources.sans_wink;
                    break;
            }
        }
}
