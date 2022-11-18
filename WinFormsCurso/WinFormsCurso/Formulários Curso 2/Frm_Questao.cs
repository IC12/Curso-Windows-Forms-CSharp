using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCurso
{
    public partial class Frm_Questao : Form
    {
        public Frm_Questao(string nomeImg, string msg)
        {
            InitializeComponent();

            Image myImage = (Image)Properties.Resources.ResourceManager.GetObject(nomeImg);
            Pic_img.Image = myImage;

            Lbl_Questao.Text = msg;
        }

        private void Btm_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Btm_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
