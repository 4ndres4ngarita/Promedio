namespace Promedio
{
    partial class Notas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Promedio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.PanelFormulario = new System.Windows.Forms.Panel();
            this.btnQuitTaller = new System.Windows.Forms.Button();
            this.btnQuitQuiz = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.RadioButton();
            this.btnM = new System.Windows.Forms.RadioButton();
            this.NumEdad = new System.Windows.Forms.NumericUpDown();
            this.btnFormulario = new System.Windows.Forms.Button();
            this.txtBoxQuiz = new System.Windows.Forms.TextBox();
            this.listQuices = new System.Windows.Forms.ListBox();
            this.txtBoxTaller = new System.Windows.Forms.TextBox();
            this.btnAddQuiz = new System.Windows.Forms.Button();
            this.txtBoxParcial = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listTalleres = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddTaller = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PanelTabla = new System.Windows.Forms.Panel();
            this.PanelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumEdad)).BeginInit();
            this.PanelTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Nombre,
            this.Promedio,
            this.Estado});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(8, 10);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(364, 237);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "No.";
            this.id.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Promedio
            // 
            this.Promedio.Text = "Promedio";
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            this.Estado.Width = 70;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(294, 257);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 257);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(158, 257);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // PanelFormulario
            // 
            this.PanelFormulario.Controls.Add(this.btnQuitTaller);
            this.PanelFormulario.Controls.Add(this.btnQuitQuiz);
            this.PanelFormulario.Controls.Add(this.btnF);
            this.PanelFormulario.Controls.Add(this.btnM);
            this.PanelFormulario.Controls.Add(this.NumEdad);
            this.PanelFormulario.Controls.Add(this.btnFormulario);
            this.PanelFormulario.Controls.Add(this.txtBoxQuiz);
            this.PanelFormulario.Controls.Add(this.listQuices);
            this.PanelFormulario.Controls.Add(this.txtBoxTaller);
            this.PanelFormulario.Controls.Add(this.btnAddQuiz);
            this.PanelFormulario.Controls.Add(this.txtBoxParcial);
            this.PanelFormulario.Controls.Add(this.txtBoxNombre);
            this.PanelFormulario.Controls.Add(this.label12);
            this.PanelFormulario.Controls.Add(this.label11);
            this.PanelFormulario.Controls.Add(this.listTalleres);
            this.PanelFormulario.Controls.Add(this.label10);
            this.PanelFormulario.Controls.Add(this.label9);
            this.PanelFormulario.Controls.Add(this.btnAddTaller);
            this.PanelFormulario.Controls.Add(this.label8);
            this.PanelFormulario.Controls.Add(this.label7);
            this.PanelFormulario.Location = new System.Drawing.Point(0, 0);
            this.PanelFormulario.Name = "PanelFormulario";
            this.PanelFormulario.Size = new System.Drawing.Size(385, 291);
            this.PanelFormulario.TabIndex = 34;
            this.PanelFormulario.Visible = false;
            // 
            // btnQuitTaller
            // 
            this.btnQuitTaller.Location = new System.Drawing.Point(293, 224);
            this.btnQuitTaller.Name = "btnQuitTaller";
            this.btnQuitTaller.Size = new System.Drawing.Size(75, 23);
            this.btnQuitTaller.TabIndex = 55;
            this.btnQuitTaller.Text = "Quitar";
            this.btnQuitTaller.UseVisualStyleBackColor = true;
            this.btnQuitTaller.Click += new System.EventHandler(this.btnQuitTaller_Click);
            // 
            // btnQuitQuiz
            // 
            this.btnQuitQuiz.Location = new System.Drawing.Point(85, 224);
            this.btnQuitQuiz.Name = "btnQuitQuiz";
            this.btnQuitQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnQuitQuiz.TabIndex = 54;
            this.btnQuitQuiz.Text = "Quitar";
            this.btnQuitQuiz.UseVisualStyleBackColor = true;
            this.btnQuitQuiz.Click += new System.EventHandler(this.btnQuitQuiz_Click);
            // 
            // btnF
            // 
            this.btnF.AutoSize = true;
            this.btnF.Location = new System.Drawing.Point(99, 46);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(31, 17);
            this.btnF.TabIndex = 53;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            // 
            // btnM
            // 
            this.btnM.AutoSize = true;
            this.btnM.Location = new System.Drawing.Point(59, 45);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(34, 17);
            this.btnM.TabIndex = 52;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            // 
            // NumEdad
            // 
            this.NumEdad.Location = new System.Drawing.Point(297, 5);
            this.NumEdad.Name = "NumEdad";
            this.NumEdad.Size = new System.Drawing.Size(55, 20);
            this.NumEdad.TabIndex = 51;
            // 
            // btnFormulario
            // 
            this.btnFormulario.Location = new System.Drawing.Point(292, 257);
            this.btnFormulario.Name = "btnFormulario";
            this.btnFormulario.Size = new System.Drawing.Size(75, 23);
            this.btnFormulario.TabIndex = 35;
            this.btnFormulario.Text = "Aceptar";
            this.btnFormulario.UseVisualStyleBackColor = true;
            this.btnFormulario.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtBoxQuiz
            // 
            this.txtBoxQuiz.Location = new System.Drawing.Point(12, 198);
            this.txtBoxQuiz.Name = "txtBoxQuiz";
            this.txtBoxQuiz.Size = new System.Drawing.Size(56, 20);
            this.txtBoxQuiz.TabIndex = 50;
            // 
            // listQuices
            // 
            this.listQuices.FormattingEnabled = true;
            this.listQuices.Location = new System.Drawing.Point(12, 94);
            this.listQuices.Name = "listQuices";
            this.listQuices.Size = new System.Drawing.Size(148, 95);
            this.listQuices.TabIndex = 44;
            // 
            // txtBoxTaller
            // 
            this.txtBoxTaller.Location = new System.Drawing.Point(220, 197);
            this.txtBoxTaller.Name = "txtBoxTaller";
            this.txtBoxTaller.Size = new System.Drawing.Size(56, 20);
            this.txtBoxTaller.TabIndex = 49;
            // 
            // btnAddQuiz
            // 
            this.btnAddQuiz.Location = new System.Drawing.Point(85, 195);
            this.btnAddQuiz.Name = "btnAddQuiz";
            this.btnAddQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnAddQuiz.TabIndex = 35;
            this.btnAddQuiz.Text = "Añadir";
            this.btnAddQuiz.UseVisualStyleBackColor = true;
            this.btnAddQuiz.Click += new System.EventHandler(this.btnAddQuiz_Click);
            // 
            // txtBoxParcial
            // 
            this.txtBoxParcial.Location = new System.Drawing.Point(296, 45);
            this.txtBoxParcial.Name = "txtBoxParcial";
            this.txtBoxParcial.Size = new System.Drawing.Size(56, 20);
            this.txtBoxParcial.TabIndex = 48;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(59, 9);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(132, 20);
            this.txtBoxNombre.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Nombre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Genero:";
            // 
            // listTalleres
            // 
            this.listTalleres.FormattingEnabled = true;
            this.listTalleres.Location = new System.Drawing.Point(220, 94);
            this.listTalleres.Name = "listTalleres";
            this.listTalleres.Size = new System.Drawing.Size(148, 95);
            this.listTalleres.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Edad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Nota de parcial:";
            // 
            // btnAddTaller
            // 
            this.btnAddTaller.Location = new System.Drawing.Point(293, 195);
            this.btnAddTaller.Name = "btnAddTaller";
            this.btnAddTaller.Size = new System.Drawing.Size(75, 23);
            this.btnAddTaller.TabIndex = 43;
            this.btnAddTaller.Text = "Añadir";
            this.btnAddTaller.UseVisualStyleBackColor = true;
            this.btnAddTaller.Click += new System.EventHandler(this.btnAddTaller_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Quices:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Talleres:";
            // 
            // PanelTabla
            // 
            this.PanelTabla.Controls.Add(this.listView1);
            this.PanelTabla.Controls.Add(this.btnEliminar);
            this.PanelTabla.Controls.Add(this.btnEditar);
            this.PanelTabla.Controls.Add(this.btnAgregar);
            this.PanelTabla.Location = new System.Drawing.Point(0, 0);
            this.PanelTabla.Name = "PanelTabla";
            this.PanelTabla.Size = new System.Drawing.Size(385, 291);
            this.PanelTabla.TabIndex = 35;
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 292);
            this.Controls.Add(this.PanelTabla);
            this.Controls.Add(this.PanelFormulario);
            this.Name = "Notas";
            this.Text = "Notas";
            this.PanelFormulario.ResumeLayout(false);
            this.PanelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumEdad)).EndInit();
            this.PanelTabla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Promedio;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel PanelFormulario;
        private System.Windows.Forms.RadioButton btnF;
        private System.Windows.Forms.RadioButton btnM;
        private System.Windows.Forms.NumericUpDown NumEdad;
        private System.Windows.Forms.Button btnFormulario;
        private System.Windows.Forms.TextBox txtBoxQuiz;
        private System.Windows.Forms.ListBox listQuices;
        private System.Windows.Forms.TextBox txtBoxTaller;
        private System.Windows.Forms.Button btnAddQuiz;
        private System.Windows.Forms.TextBox txtBoxParcial;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listTalleres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddTaller;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PanelTabla;
        private System.Windows.Forms.Button btnQuitQuiz;
        private System.Windows.Forms.Button btnQuitTaller;
    }
}

