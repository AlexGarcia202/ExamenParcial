using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaDatos.CDConexion;

namespace CapaDatos
{
    public class CD_GestionPedidos
    {
        CDconexion connn = new CDconexion();

        public DataTable MtdConsultar()
        {
            string Query = "SELECT * FROM tbl_GestionPedidos";

            SqlDataAdapter adapter = new SqlDataAdapter(Query, connn.MtdAbrirConexion());

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            connn.MtdCerrarConexion();

            return dt;
        }


        //Metodo para Agregar un Nuevo Empleado
        public void MtdAgregarGestionesP(DateTime Fecha, string MenuProducto, int Cantidad, double Precio, double PrecioTotal, double Propina, double TotalPedido)
        {
            string QueryAgregar = "Insert into tbl_GestionPedidos (Fecha, MenuProducto, Cantidad, Precio, PrecioTotal, Propina, TotalPedido) values (@Fecha, @MenuProducto, @Cantidad, @Precio, @PrecioTotal, @Propina, @TotalPedido)";
            SqlCommand cmd = new SqlCommand(QueryAgregar, connn.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            cmd.Parameters.AddWithValue("@MenuProducto", MenuProducto);
            cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("@Precio", Precio);
            cmd.Parameters.AddWithValue("@PrecioTotal", PrecioTotal);
            cmd.Parameters.AddWithValue("@Propina", Propina);
            cmd.Parameters.AddWithValue("@TotalPedido", TotalPedido);

            cmd.ExecuteNonQuery();
            connn.MtdCerrarConexion();
        }


        // Para editar o actualizar 
        public void MtdEditarGestionesP(int CodigoPedido, DateTime Fecha, string MenuProducto, int Cantidad, double Precio, double PrecioTotal, double Propina, double TotalPedido)
        {
            string QueryActualizar = "Update tbl_GestionPedidos set Fecha=@Fecha, MenuProducto=@MenuProducto, Cantidad=@Cantidad, Precio=@Precio, PrecioTotal=@PrecioTotal, Propina=@Propina, TotalPedido=@TotalPedido where CodigoPedido=@CodigoPedido";
            SqlCommand cmd = new SqlCommand(QueryActualizar, connn.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPedido", CodigoPedido);
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            cmd.Parameters.AddWithValue("@MenuProducto", MenuProducto);
            cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("@Precio", Precio);
            cmd.Parameters.AddWithValue("@PrecioTotal", PrecioTotal);
            cmd.Parameters.AddWithValue("@Propina", Propina);
            cmd.Parameters.AddWithValue("@TotalPedido", TotalPedido);

            cmd.ExecuteNonQuery();
            connn.MtdCerrarConexion();
        }


        public void MtdEliminarGestionP(int CodigoPedido)
        {
            string QueryEliminar = "Delete from tbl_GestionPedidos where CodigoPedido=@CodigoPedido";
            SqlCommand cmd = new SqlCommand(QueryEliminar, connn.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPedido", CodigoPedido);
            cmd.ExecuteNonQuery();
            connn.MtdCerrarConexion();
        }

    }
}
