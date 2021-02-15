namespace TattooAppAdry
{
    partial class EliminarVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarVendedor));
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkfestivos = new System.Windows.Forms.CheckBox();
            this.checkvacaciones = new System.Windows.Forms.CheckBox();
            this.checkfinesdesemana = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3DNI = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DNI = new System.Windows.Forms.Label();
            this.apellidos = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(13, 439);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(92, 41);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Red;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btneliminar.FlatAppearance.BorderSize = 2;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(517, 412);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(154, 68);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkfestivos);
            this.groupBox1.Controls.Add(this.checkvacaciones);
            this.groupBox1.Controls.Add(this.checkfinesdesemana);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3DNI);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.DNI);
            this.groupBox1.Controls.Add(this.apellidos);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 394);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introduce los datos para eliminar un vendedor";
            // 
            // checkfestivos
            // 
            this.checkfestivos.AutoSize = true;
            this.checkfestivos.Location = new System.Drawing.Point(258, 354);
            this.checkfestivos.Name = "checkfestivos";
            this.checkfestivos.Size = new System.Drawing.Size(113, 29);
            this.checkfestivos.TabIndex = 14;
            this.checkfestivos.Text = "Festivos:";
            this.checkfestivos.UseVisualStyleBackColor = true;
            // 
            // checkvacaciones
            // 
            this.checkvacaciones.AutoSize = true;
            this.checkvacaciones.Location = new System.Drawing.Point(439, 354);
            this.checkvacaciones.Name = "checkvacaciones";
            this.checkvacaciones.Size = new System.Drawing.Size(143, 29);
            this.checkvacaciones.TabIndex = 13;
            this.checkvacaciones.Text = "Vacaciones:";
            this.checkvacaciones.UseVisualStyleBackColor = true;
            // 
            // checkfinesdesemana
            // 
            this.checkfinesdesemana.AutoSize = true;
            this.checkfinesdesemana.Location = new System.Drawing.Point(11, 354);
            this.checkfinesdesemana.Name = "checkfinesdesemana";
            this.checkfinesdesemana.Size = new System.Drawing.Size(190, 29);
            this.checkfinesdesemana.TabIndex = 12;
            this.checkfinesdesemana.Text = "Fines de semana:";
            this.checkfinesdesemana.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(439, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 214);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(178, 134);
            this.textBox4.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Disponibilidad:";
            // 
            // textBox3DNI
            // 
            this.textBox3DNI.Location = new System.Drawing.Point(110, 167);
            this.textBox3DNI.Name = "textBox3DNI";
            this.textBox3DNI.Size = new System.Drawing.Size(219, 30);
            this.textBox3DNI.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 30);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 30);
            this.textBox1.TabIndex = 3;
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(6, 170);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(51, 25);
            this.DNI.TabIndex = 2;
            this.DNI.Text = "DNI:";
            // 
            // apellidos
            // 
            this.apellidos.AutoSize = true;
            this.apellidos.Location = new System.Drawing.Point(6, 113);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(98, 25);
            this.apellidos.TabIndex = 1;
            this.apellidos.Text = "Apellidos:";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(6, 52);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(87, 25);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnbuscar.FlatAppearance.BorderSize = 2;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(247, 432);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(145, 49);
            this.btnbuscar.TabIndex = 30;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // EliminarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 493);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EliminarVendedor";
            this.Text = "Eliminar Vendedor";
            this.Load += new System.EventHandler(this.EliminarVendedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkfestivos;
        private System.Windows.Forms.CheckBox checkvacaciones;
        private System.Windows.Forms.CheckBox checkfinesdesemana;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3DNI;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label apellidos;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Button btnbuscar;
    }
}