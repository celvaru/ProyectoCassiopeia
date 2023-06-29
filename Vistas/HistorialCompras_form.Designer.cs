namespace CeluCenter.Vistas
{
    partial class HistorialCompras_form
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

        private System.Windows.Forms.Button hcompras_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menu_btn;
        private System.Windows.Forms.Button cerrarsesion_btn;
        private System.Windows.Forms.Button inventario_btn;
        private System.Windows.Forms.Button gusuario_btn;
        private System.Windows.Forms.Button hventas_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox buscarpor_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView compras_tabla;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.TextBox buscar_txt;
        private CeluCenterDataSet celuCenterDataSet;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private CeluCenterDataSetTableAdapters.ComprasTableAdapter comprasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
    }
}