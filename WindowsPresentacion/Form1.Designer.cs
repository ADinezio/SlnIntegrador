namespace WindowsPresentacion
{
    partial class Form1
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gridListasMedicos = new System.Windows.Forms.DataGridView();
            this.lstMedicosClinicos = new System.Windows.Forms.ListBox();
            this.btnCrearListas = new System.Windows.Forms.Button();
            this.gridListaPacientes = new System.Windows.Forms.DataGridView();
            this.lstHabitaciones = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridListasMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(742, 36);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(293, 84);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar Ejercicio 5";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // gridListasMedicos
            // 
            this.gridListasMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListasMedicos.Location = new System.Drawing.Point(12, 137);
            this.gridListasMedicos.Name = "gridListasMedicos";
            this.gridListasMedicos.Size = new System.Drawing.Size(614, 156);
            this.gridListasMedicos.TabIndex = 1;
            // 
            // lstMedicosClinicos
            // 
            this.lstMedicosClinicos.FormattingEnabled = true;
            this.lstMedicosClinicos.Location = new System.Drawing.Point(742, 137);
            this.lstMedicosClinicos.Name = "lstMedicosClinicos";
            this.lstMedicosClinicos.Size = new System.Drawing.Size(293, 173);
            this.lstMedicosClinicos.TabIndex = 2;
            // 
            // btnCrearListas
            // 
            this.btnCrearListas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearListas.Location = new System.Drawing.Point(12, 36);
            this.btnCrearListas.Name = "btnCrearListas";
            this.btnCrearListas.Size = new System.Drawing.Size(614, 84);
            this.btnCrearListas.TabIndex = 3;
            this.btnCrearListas.Text = "Crear Listas";
            this.btnCrearListas.UseVisualStyleBackColor = true;
            this.btnCrearListas.Click += new System.EventHandler(this.btnCrearListas_Click);
            // 
            // gridListaPacientes
            // 
            this.gridListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListaPacientes.Location = new System.Drawing.Point(12, 349);
            this.gridListaPacientes.Name = "gridListaPacientes";
            this.gridListaPacientes.Size = new System.Drawing.Size(614, 173);
            this.gridListaPacientes.TabIndex = 4;
            // 
            // lstHabitaciones
            // 
            this.lstHabitaciones.FormattingEnabled = true;
            this.lstHabitaciones.Location = new System.Drawing.Point(742, 349);
            this.lstHabitaciones.Name = "lstHabitaciones";
            this.lstHabitaciones.Size = new System.Drawing.Size(293, 173);
            this.lstHabitaciones.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 574);
            this.Controls.Add(this.lstHabitaciones);
            this.Controls.Add(this.gridListaPacientes);
            this.Controls.Add(this.btnCrearListas);
            this.Controls.Add(this.lstMedicosClinicos);
            this.Controls.Add(this.gridListasMedicos);
            this.Controls.Add(this.btnMostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridListasMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView gridListasMedicos;
        private System.Windows.Forms.ListBox lstMedicosClinicos;
        private System.Windows.Forms.Button btnCrearListas;
        private System.Windows.Forms.DataGridView gridListaPacientes;
        private System.Windows.Forms.ListBox lstHabitaciones;
    }
}

