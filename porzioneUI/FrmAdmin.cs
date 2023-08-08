using Entidades;
using System.Configuration;

namespace porzioneUI
{
    public partial class FrmAdmin : Form
    {
        List<Producto> productos;
        ConexionProducto conexionProducto;
        string url;
        int page;
        string token;

        public FrmAdmin(AutorizacionResponse autorizacion)
        {
            InitializeComponent();
            productos = new List<Producto>();
            conexionProducto = new ConexionProducto();
            url = "http://localhost:5109/api/Producto";
            page = 1;
            token = autorizacion.Token;
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            CargarDataGrid(ref page);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            _ = SearchProducto(e.RowIndex);

        }

        //busco prodcutos segun presione en el datagrid
        private Producto SearchProducto(int dataGridIndice)
        {
            if (dataGridIndice >= 0)
            {
                int valorId = 0;
                foreach (DataGridViewRow row in dataGridViewProductos.Rows)
                {
                    if (row.Index == dataGridIndice)
                    {
                        valorId = (int)row.Cells[0].Value;
                        break;
                    }
                }
                if (valorId != 0)
                {
                    foreach (Producto producto in productos)
                    {
                        if (producto.Id == valorId)
                        {
                            txtNombreProducto.Text = producto.NombreProducto;
                            txtId.Text = producto.Id.ToString();
                            txtId.Enabled = false;
                            btnGuardar.Enabled = false;
                            return producto;
                        }
                    }
                }

            }
            return null;
        }

        //HTTP GET
        private void CargarDataGrid(ref int page)
        {
            productos = conexionProducto.GetAll($"http://localhost:5109/api/Producto?page={page}&pageSize=5", token);
            dataGridViewProductos.DataSource = productos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            txtNombreProducto.Text = "";
            txtId.Text = "";
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
        }

        //HTTP POST
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto modelo = new() { NombreProducto = txtNombreProducto.Text };

            if (conexionProducto.Add(modelo, url, token))
            {
                MessageBox.Show("Producto creado con exito!");
            }

            RestablecerUrl();
            CargarDataGrid(ref page);
        }

        //PUT
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Producto modelo = new() { Id = int.Parse(txtId.Text), NombreProducto = txtNombreProducto.Text };
            url += $"/{txtId.Text}";
            if (conexionProducto.Update(modelo, url, token))
            {
                MessageBox.Show("Actualizado con exito");
            }

            RestablecerUrl();
            CargarDataGrid(ref page);
        }

        //DELETE
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            url += $"/{txtId.Text}";
            if (conexionProducto.Remove(url, token))
            {
                MessageBox.Show("Eliminado con exito");
            }
            RestablecerUrl();
            CargarDataGrid(ref page);
        }

        //----PAGINACION----//
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGridViewProductos.Rows)
            {
                total++;
            }
            if (total != 5)
                return;

            page++;
            CargarDataGrid(ref page);

        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            if (page == 1)
                return;

            page--;
            CargarDataGrid(ref page);
        }
        //----PAGINACION----//


        private void RestablecerUrl()
        {
            url = "http://localhost:5109/api/Producto"; 
        }  
    }
}