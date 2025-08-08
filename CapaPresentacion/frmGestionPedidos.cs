using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using CapaLogica;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class frmGestionPedidos : KryptonForm
    {

        CD_GestionPedidos cd_GestionPedidos = new CD_GestionPedidos();
        CL_GestionPedidos cl_GestionPedidos = new CL_GestionPedidos();


        public frmGestionPedidos()
        {
            InitializeComponent();
        }


        private void frmGestionPedidos_Load(object sender, EventArgs e)
        {
            MtdConsultar();
        }


        private void MtdConsultar()
        {
            DataTable DTFrom = cd_GestionPedidos.MtdConsultar();
            dgvGestionPedidos.DataSource = DTFrom;
        }


        private void cboxMenuProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxMenuProducto.Text))
            {
                MessageBox.Show("Seleccione un tipo De Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                   //Obtiene valores
                    double Precio = cl_GestionPedidos.MtdPrecio(cboxMenuProducto.Text);
                    int Cantidad = Convert.ToInt32(txtCantidad.Text);

                    double PrecioTotal = cl_GestionPedidos.MtdPrecioTotal(Precio, Cantidad);
                    double Propina = cl_GestionPedidos.MtdPropina(cboxMenuProducto.Text, PrecioTotal);
                    double TotalPedido = cl_GestionPedidos.MtdTotalPedido(PrecioTotal, Propina);

                 //Imprime Valores 
                    txtPrecio.Text = Precio.ToString("c");
                    txtPrecioTotal.Text = PrecioTotal.ToString("c");
                    txtPropina.Text = Propina.ToString("c");
                    txtTotalPedido.Text = TotalPedido.ToString("c");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error en los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void MtdLimpiarCampos()
        {
            txtCodigoPedido.Text = "";
            dtpFecha.Text = "";
            txtCantidad.Text = "";
            cboxMenuProducto.Text = "";
            txtPrecio.Text = "";
            txtPrecioTotal.Text = "";
            txtPropina.Text = "";
            txtTotalPedido.Text = "";

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtpFecha.Text) || string.IsNullOrEmpty(txtCantidad.Text) || string.IsNullOrEmpty(cboxMenuProducto.Text) || string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtPrecioTotal.Text) || string.IsNullOrEmpty(txtPropina.Text) || string.IsNullOrEmpty(txtTotalPedido.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Obtiene valores
                DateTime Fecha = dtpFecha.Value;
                string MenuProducto = cboxMenuProducto.Text;

                int Cantidad = Convert.ToInt32(txtCantidad.Text);
                double Precio = cl_GestionPedidos.MtdPrecio(MenuProducto);

                double PrecioTotal = cl_GestionPedidos.MtdPrecioTotal(Precio, Cantidad);
                double Propina = cl_GestionPedidos.MtdPropina(MenuProducto, PrecioTotal);
                double TotalPedido = cl_GestionPedidos.MtdTotalPedido(PrecioTotal, Propina);

                //Imprime valores
                txtPrecio.Text = Precio.ToString("c");
                txtPrecioTotal.Text = PrecioTotal.ToString("c");
                txtPropina.Text = Propina.ToString("c");
                txtTotalPedido.Text = TotalPedido.ToString("c");


                //Envia Datos a La capa
                try
                {
                    cd_GestionPedidos.MtdAgregarGestionesP(Fecha, MenuProducto, Cantidad, Precio, PrecioTotal, Propina, TotalPedido);//se pueden enviar las variables txt
                    MessageBox.Show("Gestion Agregada Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultar();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoPedido.Text) || string.IsNullOrEmpty(dtpFecha.Text) || string.IsNullOrEmpty(txtCantidad.Text) || string.IsNullOrEmpty(cboxMenuProducto.Text) || string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtPrecioTotal.Text) || string.IsNullOrEmpty(txtPropina.Text) || string.IsNullOrEmpty(txtTotalPedido.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Obtiene valores
                int CodigoPedido = Convert.ToInt32(txtCodigoPedido.Text);
                DateTime Fecha = dtpFecha.Value;
                string MenuProducto = cboxMenuProducto.Text;

                int Cantidad = Convert.ToInt32(txtCantidad.Text);
                double Precio = cl_GestionPedidos.MtdPrecio(MenuProducto);

                double PrecioTotal = cl_GestionPedidos.MtdPrecioTotal(Precio, Cantidad);
                double Propina = cl_GestionPedidos.MtdPropina(MenuProducto, PrecioTotal);
                double TotalPedido = cl_GestionPedidos.MtdTotalPedido(PrecioTotal, Propina);

                //Imprime valores
                txtPrecio.Text = Precio.ToString("c");
                txtPrecioTotal.Text = PrecioTotal.ToString("c");
                txtPropina.Text = Propina.ToString("c");
                txtTotalPedido.Text = TotalPedido.ToString("c");


                //Envia Datos a La capa
                try
                {
                    cd_GestionPedidos.MtdEditarGestionesP(CodigoPedido,Fecha, MenuProducto, Cantidad, Precio, PrecioTotal, Propina, TotalPedido);//se pueden enviar las variables txt
                    MessageBox.Show("Gestion Editada Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultar();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvGestionPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvGestionPedidos.SelectedRows[0];//Representa las filas De la tabla

            if (FilaSeleccionada.Index == dgvGestionPedidos.Rows.Count - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoPedido.Text = dgvGestionPedidos.SelectedCells[0].Value.ToString();
                dtpFecha.Text = dgvGestionPedidos.SelectedCells[1].Value.ToString();
                txtCantidad.Text = dgvGestionPedidos.SelectedCells[3].Value.ToString();
                cboxMenuProducto.Text = dgvGestionPedidos.SelectedCells[2].Value.ToString();
                txtPrecio.Text = dgvGestionPedidos.SelectedCells[4].Value.ToString();
                txtPrecioTotal.Text = dgvGestionPedidos.SelectedCells[5].Value.ToString();
                txtPropina.Text = dgvGestionPedidos.SelectedCells[6].Value.ToString();
                txtTotalPedido.Text = dgvGestionPedidos.SelectedCells[7].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoPedido.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoPedido = int.Parse(txtCodigoPedido.Text);

                try
                {
                    cd_GestionPedidos.MtdEliminarGestionP(CodigoPedido);
                    MessageBox.Show("Dato eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultar();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
