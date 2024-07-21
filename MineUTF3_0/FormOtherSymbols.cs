using System.Diagnostics;
using System.Windows.Forms;

namespace MineUTF3_0
{
    public partial class FormOtherSymbols : Form
    {
        public FormOtherSymbols()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://spigotmc.ru/resources/unicode-simvoly-dlja-minecraft-by-rgferg1.385");
        }
    }
}
