using Proiect_Space_Invaders.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Space_Invaders.Game
{
    internal static class UITools
    {
        public static Game game { get; set; }

        public static void refreshGamePanel(string name, string text)
        {
            Label label = (Label)game.gamePanel.Controls.Find(name, true)[0];
            label.Invoke(new MethodInvoker(delegate () {
                label.Text = text;
            }));
        }

        public static void refreshEndPanel(string name, string text)
        {
            Label label = (Label)game.endPanel.Controls.Find(name, true)[0];
            label.Invoke(new MethodInvoker(delegate () {
                label.Text = text;
            }));
        }
    }
}
