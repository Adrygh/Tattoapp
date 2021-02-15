namespace TattooAppAdry
{
    partial class ModificarVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarVendedor));
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncargarImagen = new System.Windows.Forms.Button();
            this.checkfestivos = new System.Windows.Forms.CheckBox();
            this.checkvacaciones = new System.Windows.Forms.CheckBox();
            this.checkfinesdesemana = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(23, 482);
            this.cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(104, 37);
            this.cancelar.TabIndex = 27;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(561, 482);
            this.aceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(110, 37);
            this.aceptar.TabIndex = 10;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncargarImagen);
            this.groupBox1.Controls.Add(this.checkfestivos);
            this.groupBox1.Controls.Add(this.checkvacaciones);
            this.groupBox1.Controls.Add(this.checkfinesdesemana);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.DNI);
            this.groupBox1.Controls.Add(this.apellidos);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 409);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introduce los datos para modificar un vendedor";
            // 
            // btncargarImagen
            // 
            this.btncargarImagen.Location = new System.Drawing.Point(439, 263);
            this.btncargarImagen.Name = "btncargarImagen";
            this.btncargarImagen.Size = new System.Drawing.Size(160, 37);
            this.btncargarImagen.TabIndex = 8;
            this.btncargarImagen.Text = "Cargar Imagen";
            this.btncargarImagen.UseVisualStyleBackColor = true;
            // 
            // checkfestivos
            // 
            this.checkfestivos.AutoSize = true;
            this.checkfestivos.Location = new System.Drawing.Point(258, 370);
            this.checkfestivos.Name = "checkfestivos";
            this.checkfestivos.Size = new System.Drawing.Size(113, 29);
            this.checkfestivos.TabIndex = 6;
            this.checkfestivos.Text = "Festivos:";
            this.checkfestivos.UseVisualStyleBackColor = true;
            this.checkfestivos.CheckedChanged += new System.EventHandler(this.checkfestivos_CheckedChanged);
            // 
            // checkvacaciones
            // 
            this.checkvacaciones.AutoSize = true;
            this.checkvacaciones.Location = new System.Drawing.Point(439, 370);
            this.checkvacaciones.Name = "checkvacaciones";
            this.checkvacaciones.Size = new System.Drawing.Size(143, 29);
            this.checkvacaciones.TabIndex = 7;
            this.checkvacaciones.Text = "Vacaciones:";
            this.checkvacaciones.UseVisualStyleBackColor = true;
            this.checkvacaciones.CheckedChanged += new System.EventHandler(this.checkvacaciones_CheckedChanged);
            // 
            // checkfinesdesemana
            // 
            this.checkfinesdesemana.AutoSize = true;
            this.checkfinesdesemana.Location = new System.Drawing.Point(11, 370);
            this.checkfinesdesemana.Name = "checkfinesdesemana";
            this.checkfinesdesemana.Size = new System.Drawing.Size(190, 29);
            this.checkfinesdesemana.TabIndex = 5;
            this.checkfinesdesemana.Text = "Fines de semana:";
            this.checkfinesdesemana.UseVisualStyleBackColor = true;
            this.checkfinesdesemana.CheckedChanged += new System.EventHandler(this.checkfinesdesemana_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(439, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 214);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(178, 134);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 30);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 30);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.btnbuscar.Location = new System.Drawing.Point(270, 443);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(156, 63);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // ModificarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 530);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.cancelar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ModificarVendedor";
            this.Text = "Modificar Vendedor";
            this.Load += new System.EventHandler(this.ModificarVendedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkfestivos;
        private System.Windows.Forms.CheckBox checkvacaciones;
        private System.Windows.Forms.CheckBox checkfinesdesemana;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label apellidos;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Button btncargarImagen;
        private System.Windows.Forms.Button btnbuscar;
    }
}