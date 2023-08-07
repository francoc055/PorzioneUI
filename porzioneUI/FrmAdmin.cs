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
        public FrmAdmin()
        {
            InitializeComponent();
            productos = new List<Producto>();
            conexionProducto = new ConexionProducto();
            url = "http://localhost:5109/api/Producto";
            page = 1;
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            CargarDataGrid(ref page);

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
            productos = conexionProducto.GetAll($"http://localhost:5109/api/Producto?page={page}&pageSize=5");
            dataGridViewProductos.DataSource = productos;
        }

        //HTTP POST
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            txtNombreProducto.Text = "";
            txtId.Text = "";
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto modelo = new() { NombreProducto = txtNombreProducto.Text };

            if (conexionProducto.Add(modelo, url))
            {
                MessageBox.Show("Producto creado con exito!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            url += $"/{txtId.Text}";
            if(conexionProducto.Remove(url))
            {
                MessageBox.Show("Eliminado con exito");
            }
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

    }
}