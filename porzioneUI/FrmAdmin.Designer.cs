namespace porzioneUI
{
    partial class FrmAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Productos = new TabControl();
            tabPage1 = new TabPage();
            btnRetroceder = new Button();
            btnSiguiente = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtId = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            txtNombreProducto = new TextBox();
            btnAgregar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewProductos = new DataGridView();
            tabPage2 = new TabPage();
            Productos.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // Productos
            // 
            Productos.Controls.Add(tabPage1);
            Productos.Controls.Add(tabPage2);
            Productos.Dock = DockStyle.Fill;
            Productos.Location = new Point(0, 0);
            Productos.Name = "Productos";
            Productos.SelectedIndex = 0;
            Productos.Size = new Size(800, 450);
            Productos.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRetroceder);
            tabPage1.Controls.Add(btnSiguiente);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Productos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRetroceder
            // 
            btnRetroceder.Location = new Point(514, 382);
            btnRetroceder.Name = "btnRetroceder";
            btnRetroceder.Size = new Size(33, 23);
            btnRetroceder.TabIndex = 3;
            btnRetroceder.Text = "<";
            btnRetroceder.UseVisualStyleBackColor = true;
            btnRetroceder.Click += btnRetroceder_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(562, 382);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(33, 23);
            btnSiguiente.TabIndex = 2;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombreProducto);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Location = new Point(55, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 291);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 36);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 7;
            label2.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(44, 54);
            txtId.Name = "txtId";
            txtId.Size = new Size(104, 23);
            txtId.TabIndex = 6;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(27, 212);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(27, 174);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(27, 136);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 23);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 80);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre del producto";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(27, 98);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(139, 23);
            txtNombreProducto.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(27, 250);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Habilitar guardado";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(dataGridViewProductos, 0, 0);
            tableLayoutPanel1.Location = new Point(325, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(464, 373);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.BackgroundColor = Color.FromArgb(128, 128, 255);
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Dock = DockStyle.Fill;
            dataGridViewProductos.EnableHeadersVisualStyles = false;
            dataGridViewProductos.Location = new Point(3, 3);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersVisible = false;
            dataGridViewProductos.RowTemplate.Height = 25;
            dataGridViewProductos.Size = new Size(458, 367);
            dataGridViewProductos.TabIndex = 0;
            dataGridViewProductos.CellClick += dataGridViewProductos_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Productos);
            Name = "FrmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAdmin";
            Load += FrmAdmin_Load;
            Productos.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Productos;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private DataGridView dataGridViewProductos;
        private Button btnAgregar;
        private Label label1;
        private TextBox txtNombreProducto;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnRetroceder;
        private Button btnSiguiente;
        private Label label2;
        private TextBox txtId;
    }
}