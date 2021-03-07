namespace Ejercicio
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
            this.grillaPersona = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre_persona = new System.Windows.Forms.TextBox();
            this.btn_serializar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaPersona
            // 
            this.grillaPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPersona.Location = new System.Drawing.Point(41, 39);
            this.grillaPersona.MultiSelect = false;
            this.grillaPersona.Name = "grillaPersona";
            this.grillaPersona.ReadOnly = true;
            this.grillaPersona.RowTemplate.Height = 24;
            this.grillaPersona.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaPersona.Size = new System.Drawing.Size(684, 162);
            this.grillaPersona.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.UseWaitCursor = true;
            // 
            // txt_nombre_persona
            // 
            this.txt_nombre_persona.Location = new System.Drawing.Point(153, 344);
            this.txt_nombre_persona.Name = "txt_nombre_persona";
            this.txt_nombre_persona.Size = new System.Drawing.Size(205, 22);
            this.txt_nombre_persona.TabIndex = 2;
            // 
            // btn_serializar
            // 
            this.btn_serializar.Location = new System.Drawing.Point(41, 242);
            this.btn_serializar.Name = "btn_serializar";
            this.btn_serializar.Size = new System.Drawing.Size(101, 34);
            this.btn_serializar.TabIndex = 3;
            this.btn_serializar.Text = "Serializar";
            this.btn_serializar.UseVisualStyleBackColor = true;
            this.btn_serializar.Click += new System.EventHandler(this.btn_serializar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_serializar);
            this.Controls.Add(this.txt_nombre_persona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre_persona;
        private System.Windows.Forms.Button btn_serializar;
    }
}

