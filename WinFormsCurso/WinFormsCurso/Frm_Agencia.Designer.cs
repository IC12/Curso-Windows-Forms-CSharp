
namespace WinFormsCurso
{
    partial class Frm_Agencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Agencia));
            this.Tls_Principal = new System.Windows.Forms.ToolStrip();
            this.ApagaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.byteBankDataSet = new WinFormsCurso.ByteBankDataSet();
            this.tB_AgenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_AgenciaTableAdapter = new WinFormsCurso.ByteBankDataSetTableAdapters.TB_AgenciaTableAdapter();
            this.tableAdapterManager = new WinFormsCurso.ByteBankDataSetTableAdapters.TableAdapterManager();
            this.tB_AgenciaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tB_AgenciaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tB_AgenciaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tls_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.byteBankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_AgenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_AgenciaBindingNavigator)).BeginInit();
            this.tB_AgenciaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tB_AgenciaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Tls_Principal
            // 
            this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApagaToolStripButton});
            this.Tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tls_Principal.Name = "Tls_Principal";
            this.Tls_Principal.Size = new System.Drawing.Size(466, 25);
            this.Tls_Principal.TabIndex = 31;
            this.Tls_Principal.Text = "toolStrip1";
            // 
            // ApagaToolStripButton
            // 
            this.ApagaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ApagaToolStripButton.Image = global::WinFormsCurso.Properties.Resources.ExcluirBarra;
            this.ApagaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ApagaToolStripButton.Name = "ApagaToolStripButton";
            this.ApagaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ApagaToolStripButton.Text = "toolStripButton1";
            this.ApagaToolStripButton.Click += new System.EventHandler(this.ApagaToolStripButton_Click);
            // 
            // byteBankDataSet
            // 
            this.byteBankDataSet.DataSetName = "ByteBankDataSet";
            this.byteBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_AgenciaBindingSource
            // 
            this.tB_AgenciaBindingSource.DataMember = "TB_Agencia";
            this.tB_AgenciaBindingSource.DataSource = this.byteBankDataSet;
            // 
            // tB_AgenciaTableAdapter
            // 
            this.tB_AgenciaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TB_AgenciaTableAdapter = this.tB_AgenciaTableAdapter;
            this.tableAdapterManager.TB_ClienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WinFormsCurso.ByteBankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tB_AgenciaBindingNavigator
            // 
            this.tB_AgenciaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tB_AgenciaBindingNavigator.BindingSource = this.tB_AgenciaBindingSource;
            this.tB_AgenciaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tB_AgenciaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tB_AgenciaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tB_AgenciaBindingNavigatorSaveItem});
            this.tB_AgenciaBindingNavigator.Location = new System.Drawing.Point(0, 25);
            this.tB_AgenciaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tB_AgenciaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tB_AgenciaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tB_AgenciaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tB_AgenciaBindingNavigator.Name = "tB_AgenciaBindingNavigator";
            this.tB_AgenciaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tB_AgenciaBindingNavigator.Size = new System.Drawing.Size(466, 25);
            this.tB_AgenciaBindingNavigator.TabIndex = 32;
            this.tB_AgenciaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tB_AgenciaBindingNavigatorSaveItem
            // 
            this.tB_AgenciaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tB_AgenciaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tB_AgenciaBindingNavigatorSaveItem.Image")));
            this.tB_AgenciaBindingNavigatorSaveItem.Name = "tB_AgenciaBindingNavigatorSaveItem";
            this.tB_AgenciaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tB_AgenciaBindingNavigatorSaveItem.Text = "Save Data";
            this.tB_AgenciaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tB_AgenciaBindingNavigatorSaveItem_Click);
            // 
            // tB_AgenciaDataGridView
            // 
            this.tB_AgenciaDataGridView.AutoGenerateColumns = false;
            this.tB_AgenciaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tB_AgenciaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tB_AgenciaDataGridView.DataSource = this.tB_AgenciaBindingSource;
            this.tB_AgenciaDataGridView.Location = new System.Drawing.Point(12, 67);
            this.tB_AgenciaDataGridView.Name = "tB_AgenciaDataGridView";
            this.tB_AgenciaDataGridView.Size = new System.Drawing.Size(443, 300);
            this.tB_AgenciaDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Agencia";
            this.dataGridViewTextBoxColumn1.FillWeight = 150F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Código da Agência";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.FillWeight = 280F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome da Agência";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // Frm_Agencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 377);
            this.Controls.Add(this.tB_AgenciaDataGridView);
            this.Controls.Add(this.tB_AgenciaBindingNavigator);
            this.Controls.Add(this.Tls_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Agencia";
            this.Text = "Frm_Agencia";
            this.Load += new System.EventHandler(this.Frm_Agencia_Load);
            this.Tls_Principal.ResumeLayout(false);
            this.Tls_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.byteBankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_AgenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_AgenciaBindingNavigator)).EndInit();
            this.tB_AgenciaBindingNavigator.ResumeLayout(false);
            this.tB_AgenciaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tB_AgenciaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tls_Principal;
        private System.Windows.Forms.ToolStripButton ApagaToolStripButton;
        private ByteBankDataSet byteBankDataSet;
        private System.Windows.Forms.BindingSource tB_AgenciaBindingSource;
        private ByteBankDataSetTableAdapters.TB_AgenciaTableAdapter tB_AgenciaTableAdapter;
        private ByteBankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tB_AgenciaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tB_AgenciaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tB_AgenciaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}