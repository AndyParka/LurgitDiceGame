using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndrewParkinsonAssgt
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btn1Player_Click(object sender, EventArgs e)
        {
            //create a new Game form with the appropriate perameter
            frmGame Game = new frmGame(0);
            //show said Game form
            Game.ShowDialog();

        }

        private void btn2PlayerCPU_Click(object sender, EventArgs e)
        {
            //create a new Game form with the appropriate perameter
            frmGame Game = new frmGame(1);
            //show said Game form
            Game.ShowDialog();
        }

        private void btn2PlayerVS_Click(object sender, EventArgs e)
        {
            //create a new Game form with the appropriate perameter
            frmGame Game = new frmGame(2);
            //show said Game form
            Game.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Quit the app
            Application.Exit();
        }

        private void lblCredits_Click(object sender, EventArgs e)
        {
            //Shhh
            MessageBox.Show("Secret message box!! w00t w00t");
        }
    }
}
