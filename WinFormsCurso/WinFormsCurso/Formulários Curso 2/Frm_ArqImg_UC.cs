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
    public partial class Frm_ArqImg_UC : UserControl
    {
        public Frm_ArqImg_UC(string nomeArqImg)
        {
            InitializeComponent();
            Lbl_ArqImg.Text = nomeArqImg;
            Pic_ArqImg.Image = Image.FromFile(nomeArqImg);
        }

        private void Btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog CDb = new ColorDialog();
            if (CDb.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArqImg.ForeColor = CDb.Color;
            }
        }

        private void Btn_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog FDb = new FontDialog();
            if (FDb.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArqImg.Font = FDb.Font;
            }
        }
    }
}
