namespace ProductoApp1M1.Forms
{
    partial class FrmProductoManage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbFinder = new System.Windows.Forms.ComboBox();
            this.pnlFindById = new System.Windows.Forms.Panel();
            this.pnlMeasureUnit = new System.Windows.Forms.Panel();
            this.pnlRangePrice = new System.Windows.Forms.Panel();
            this.nupToPrice = new System.Windows.Forms.NumericUpDown();
            this.nupFromPrice = new System.Windows.Forms.NumericUpDown();
            this.cmbMeasureUnit = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlCaducity = new System.Windows.Forms.Panel();
            this.dtpCaducity = new System.Windows.Forms.DateTimePicker();
            this.rtbProductoView = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlFindById.SuspendLayout();
            this.pnlMeasureUnit.SuspendLayout();
            this.pnlRangePrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupToPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFromPrice)).BeginInit();
            this.pnlCaducity.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnAgregar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 604);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1042, 39);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 30);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(109, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(215, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // cmbFinder
            // 
            this.cmbFinder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinder.FormattingEnabled = true;
            this.cmbFinder.Items.AddRange(new object[] {
            "Id",
            "Unidad de Medida",
            "Rango de Precio",
            "Fecha de Vencimiemiento"});
            this.cmbFinder.Location = new System.Drawing.Point(12, 23);
            this.cmbFinder.Name = "cmbFinder";
            this.cmbFinder.Size = new System.Drawing.Size(184, 21);
            this.cmbFinder.TabIndex = 1;
            this.cmbFinder.SelectedIndexChanged += new System.EventHandler(this.cmbFinder_SelectedIndexChanged);
            // 
            // pnlFindById
            // 
            this.pnlFindById.Controls.Add(this.txtId);
            this.pnlFindById.Location = new System.Drawing.Point(213, 23);
            this.pnlFindById.Name = "pnlFindById";
            this.pnlFindById.Size = new System.Drawing.Size(471, 21);
            this.pnlFindById.TabIndex = 2;
            this.pnlFindById.Visible = false;
            // 
            // pnlMeasureUnit
            // 
            this.pnlMeasureUnit.Controls.Add(this.cmbMeasureUnit);
            this.pnlMeasureUnit.Location = new System.Drawing.Point(210, 77);
            this.pnlMeasureUnit.Name = "pnlMeasureUnit";
            this.pnlMeasureUnit.Size = new System.Drawing.Size(471, 28);
            this.pnlMeasureUnit.TabIndex = 4;
            this.pnlMeasureUnit.Visible = false;
            // 
            // pnlRangePrice
            // 
            this.pnlRangePrice.Controls.Add(this.nupToPrice);
            this.pnlRangePrice.Controls.Add(this.nupFromPrice);
            this.pnlRangePrice.Location = new System.Drawing.Point(210, 50);
            this.pnlRangePrice.Name = "pnlRangePrice";
            this.pnlRangePrice.Size = new System.Drawing.Size(471, 21);
            this.pnlRangePrice.TabIndex = 3;
            this.pnlRangePrice.Visible = false;
            // 
            // nupToPrice
            // 
            this.nupToPrice.Location = new System.Drawing.Point(268, 0);
            this.nupToPrice.Name = "nupToPrice";
            this.nupToPrice.Size = new System.Drawing.Size(200, 20);
            this.nupToPrice.TabIndex = 1;
            // 
            // nupFromPrice
            // 
            this.nupFromPrice.Location = new System.Drawing.Point(3, -2);
            this.nupFromPrice.Name = "nupFromPrice";
            this.nupFromPrice.Size = new System.Drawing.Size(200, 20);
            this.nupFromPrice.TabIndex = 0;
            // 
            // cmbMeasureUnit
            // 
            this.cmbMeasureUnit.FormattingEnabled = true;
            this.cmbMeasureUnit.Location = new System.Drawing.Point(4, 0);
            this.cmbMeasureUnit.Name = "cmbMeasureUnit";
            this.cmbMeasureUnit.Size = new System.Drawing.Size(464, 21);
            this.cmbMeasureUnit.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(4, 0);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(464, 20);
            this.txtId.TabIndex = 0;
            // 
            // pnlCaducity
            // 
            this.pnlCaducity.Controls.Add(this.dtpCaducity);
            this.pnlCaducity.Location = new System.Drawing.Point(213, 111);
            this.pnlCaducity.Name = "pnlCaducity";
            this.pnlCaducity.Size = new System.Drawing.Size(471, 21);
            this.pnlCaducity.TabIndex = 3;
            this.pnlCaducity.Visible = false;
            // 
            // dtpCaducity
            // 
            this.dtpCaducity.Location = new System.Drawing.Point(4, 0);
            this.dtpCaducity.Name = "dtpCaducity";
            this.dtpCaducity.Size = new System.Drawing.Size(241, 20);
            this.dtpCaducity.TabIndex = 0;
            // 
            // rtbProductoView
            // 
            this.rtbProductoView.Location = new System.Drawing.Point(12, 138);
            this.rtbProductoView.Name = "rtbProductoView";
            this.rtbProductoView.ReadOnly = true;
            this.rtbProductoView.Size = new System.Drawing.Size(1042, 460);
            this.rtbProductoView.TabIndex = 3;
            this.rtbProductoView.Text = "";
            // 
            // FrmProductoManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 647);
            this.Controls.Add(this.pnlMeasureUnit);
            this.Controls.Add(this.pnlCaducity);
            this.Controls.Add(this.pnlRangePrice);
            this.Controls.Add(this.rtbProductoView);
            this.Controls.Add(this.pnlFindById);
            this.Controls.Add(this.cmbFinder);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmProductoManage";
            this.Text = "FrmProductoManage";
            this.Load += new System.EventHandler(this.FrmProductoManage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlFindById.ResumeLayout(false);
            this.pnlFindById.PerformLayout();
            this.pnlMeasureUnit.ResumeLayout(false);
            this.pnlRangePrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupToPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFromPrice)).EndInit();
            this.pnlCaducity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbFinder;
        private System.Windows.Forms.Panel pnlFindById;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel pnlMeasureUnit;
        private System.Windows.Forms.Panel pnlRangePrice;
        private System.Windows.Forms.NumericUpDown nupToPrice;
        private System.Windows.Forms.NumericUpDown nupFromPrice;
        private System.Windows.Forms.ComboBox cmbMeasureUnit;
        private System.Windows.Forms.Panel pnlCaducity;
        private System.Windows.Forms.DateTimePicker dtpCaducity;
        private System.Windows.Forms.RichTextBox rtbProductoView;
    }
}