namespace porzioneUI
{
    partial class FrmLogin
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
            txtCorreo = new TextBox();
            txtClave = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnIngresar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(72, 53);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(143, 23);
            txtCorreo.TabIndex = 0;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(72, 91);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(143, 23);
            txtClave.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 56);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 91);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Clave";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(txtClave);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(150, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 153);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(140, 120);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 313);
            Controls.Add(groupBox1);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCorreo;
        private TextBox txtClave;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnIngresar;
    }
}