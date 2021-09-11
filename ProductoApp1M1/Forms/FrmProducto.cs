using Domain.Entitys;
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
    public partial class FrmProducto : Form
    {
        private ProductoModel PModel { get; set; }
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            {
                Id = PModel.GetLastProductoId() + 1,

            };
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cmbMeasureUnit.Items.AddRange(Enum.GetValues(typeof(UnidadMedida))
                                               .Cast<object()>)
        }
    }
}
