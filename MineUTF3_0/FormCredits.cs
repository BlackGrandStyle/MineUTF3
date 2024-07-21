using System.Diagnostics;
using System.Windows.Forms;

namespace MineUTF3_0
{
    public partial class FormCredits : Form
    {
        public FormCredits()
        {
            InitializeComponent();
        }

        private void buttonSpigot_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://spigotmc.ru/members/blackgrandstyle.1348");
        }

        private void buttonIcons_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://www.flaticon.com");
        }
    }
}
