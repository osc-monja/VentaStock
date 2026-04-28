using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CargarUsuarios()
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-MM6H6D6;Database=puntoventa;Trusted_Connection=True;");

            SqlDataAdapter da = new SqlDataAdapter("SELECT nombre, email, password FROM dbo.usuarios_login", con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            gridview_usuario.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void boton_usuario_Click(object sender, EventArgs e)
        {
            tabUsuario.Location = new Point(120, 95);
            tabUsuario.BringToFront();
        }

        private void boton_productos_Click(object sender, EventArgs e)
        {
            tabProductos.Location = new Point(120, 95);
            tabProductos.BringToFront();
        }
        private void boton_categorias_Click(object sender, EventArgs e)
        {
            tabCategorias.Location = new Point(120, 95);
            tabCategorias.BringToFront();
        }
        private void boton_clientes_Click(object sender, EventArgs e)
        {
            tabClientes.Location = new Point(120, 95);
            tabClientes.BringToFront();
        }
        private void boton_proveedor_Click(object sender, EventArgs e)
        {
            tabProveedor.Location = new Point(120, 95);
            tabProveedor.BringToFront();
        }
        private void boton_unidades_Click(object sender, EventArgs e)
        {
            tabUnidades.Location = new Point(120, 95);
            tabUnidades.BringToFront();
        }

        private void boton_ventas_Click(object sender, EventArgs e)
        {

        }

        private void boton_ayuda_Click(object sender, EventArgs e)
        {

        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void box_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregar_usuario_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-MM6H6D6;Database=puntoventa;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand(
       "INSERT INTO dbo.usuarios_login (nombre, email, password) VALUES (@nombre, @correo, @password)",
        con
    );

            cmd.Parameters.AddWithValue("@nombre", box_usuario.Text);
            cmd.Parameters.AddWithValue("@correo", box_correo.Text);
            cmd.Parameters.AddWithValue("@password", box_contrasena.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Usuario guardado✅");
            CargarUsuarios();
        }
        int idUsuarioSeleccionado;

        private void gridview_usuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idUsuarioSeleccionado = Convert.ToInt32(gridview_usuario.CurrentRow.Cells["id_usuarios"].Value);

            box_usuario.Text = gridview_usuario.CurrentRow.Cells["nombre"].Value.ToString();
            box_correo.Text = gridview_usuario.CurrentRow.Cells["email"].Value.ToString();
            box_contrasena.Text = gridview_usuario.CurrentRow.Cells["password"].Value.ToString();
        }
    }
}
