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
    public partial class Frm_Agencia : Form
    {
        public Frm_Agencia()
        {
            InitializeComponent();
            this.Text = "Cadastro de Agência";
            Tls_Principal.Items[0].ToolTipText = "Fechar a caixa de diálogo";
        }

        private void ApagaToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tB_AgenciaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tB_AgenciaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.byteBankDataSet);

        }

        private void Frm_Agencia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'byteBankDataSet.TB_Agencia' table. You can move, or remove it, as needed.
            this.tB_AgenciaTableAdapter.Fill(this.byteBankDataSet.TB_Agencia);

        }
    }
}
