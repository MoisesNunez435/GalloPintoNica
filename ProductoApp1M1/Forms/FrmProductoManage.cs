using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductoApp1M1.Forms
{
    public partial class FrmProductoManage : Form
    {
        private ProductoModel productomodel;
        public FrmProductoManage()
        {
            productomodel = new ProductoModel();
            InitializeComponent();
        }

        private void FrmProductoManage_Load(object sender, EventArgs e)
        {

        }

        private void cmbFinder_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFinder.SelectedIndex)
            {
                case 0:
                    pnlFindById.Visible = true;
                    pnlMeasureUnit.Visible = false;
                    pnlRangePrice.Visible = false;
                    pnlCaducity.Visible = false;
                    break;

                case 1:
                    pnlFindById.Visible = false;
                    pnlMeasureUnit.Visible = true;
                    pnlRangePrice.Visible = false;
                    pnlCaducity.Visible = false;
                    break;

                case 2:
                    pnlFindById.Visible = false;
                    pnlMeasureUnit.Visible = false;
                    pnlRangePrice.Visible = true;
                    pnlCaducity.Visible = false;
                    break;

                case 3:
                    pnlFindById.Visible = false;
                    pnlMeasureUnit.Visible = false;
                    pnlRangePrice.Visible = false;
                    pnlCaducity.Visible = true;
                    break;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            FrmProducto.PModel = productomodel;
            frm.ShowDialog();

            rtbProductoView.Text = 
        }
    }
}
