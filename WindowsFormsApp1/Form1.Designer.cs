
namespace WindowsFormsApp1
{
    partial class FormBootstrap
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
            this.label = new System.Windows.Forms.Label();
            this.butMostrar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.chkAceptar = new System.Windows.Forms.CheckBox();
            this.radioHombre = new System.Windows.Forms.RadioButton();
            this.radioMujer = new System.Windows.Forms.RadioButton();
            this.groupGenero = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AccessibleDescription = "anchouva";
            this.label.AccessibleName = "anchouva";
            this.label.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label.Location = new System.Drawing.Point(120, 98);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(136, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Escribe tu mensaje :";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // butMostrar
            // 
            this.butMostrar.Location = new System.Drawing.Point(544, 361);
            this.butMostrar.Name = "butMostrar";
            this.butMostrar.Size = new System.Drawing.Size(184, 55);
            this.butMostrar.TabIndex = 1;
            this.butMostrar.Text = "mostrar mensaje";
            this.butMostrar.UseVisualStyleBackColor = true;
            this.butMostrar.Click += new System.EventHandler(this.butMostrar_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(262, 95);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(233, 22);
            this.txtMensaje.TabIndex = 2;
            // 
            // chkAceptar
            // 
            this.chkAceptar.AutoSize = true;
            this.chkAceptar.Location = new System.Drawing.Point(110, 185);
            this.chkAceptar.Name = "chkAceptar";
            this.chkAceptar.Size = new System.Drawing.Size(175, 21);
            this.chkAceptar.TabIndex = 3;
            this.chkAceptar.Text = "Acepto las condiciones";
            this.chkAceptar.UseVisualStyleBackColor = true;
            this.chkAceptar.CheckedChanged += new System.EventHandler(this.chkAceptar_CheckedChanged);
            // 
            // radioHombre
            // 
            this.radioHombre.AutoSize = true;
            this.radioHombre.Location = new System.Drawing.Point(13, 29);
            this.radioHombre.Name = "radioHombre";
            this.radioHombre.Size = new System.Drawing.Size(77, 21);
            this.radioHombre.TabIndex = 4;
            this.radioHombre.TabStop = true;
            this.radioHombre.Text = "hombre";
            this.radioHombre.UseVisualStyleBackColor = true;
            this.radioHombre.CheckedChanged += new System.EventHandler(this.radioHombre_CheckedChanged);
            // 
            // radioMujer
            // 
            this.radioMujer.AutoSize = true;
            this.radioMujer.Location = new System.Drawing.Point(13, 56);
            this.radioMujer.Name = "radioMujer";
            this.radioMujer.Size = new System.Drawing.Size(64, 21);
            this.radioMujer.TabIndex = 5;
            this.radioMujer.TabStop = true;
            this.radioMujer.Text = "mujer";
            this.radioMujer.UseVisualStyleBackColor = true;
            this.radioMujer.CheckedChanged += new System.EventHandler(this.radioMujer_CheckedChanged);
            // 
            // groupGenero
            // 
            this.groupGenero.Controls.Add(this.radioMujer);
            this.groupGenero.Controls.Add(this.radioHombre);
            this.groupGenero.Location = new System.Drawing.Point(110, 227);
            this.groupGenero.Name = "groupGenero";
            this.groupGenero.Size = new System.Drawing.Size(156, 88);
            this.groupGenero.TabIndex = 6;
            this.groupGenero.TabStop = false;
            this.groupGenero.Text = "Género";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "casa",
            "coche",
            "familia",
            "estudios"});
            this.listBox1.Location = new System.Drawing.Point(544, 227);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(75, 68);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gato",
            "Perro",
            "Iguana",
            "Cosa"});
            this.comboBox1.Location = new System.Drawing.Point(110, 361);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Animal...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormBootstrap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 485);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupGenero);
            this.Controls.Add(this.chkAceptar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.butMostrar);
            this.Controls.Add(this.label);
            this.Name = "FormBootstrap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "prueba de formulario";
            this.Load += new System.EventHandler(this.FormBootstrap_Load);
            this.groupGenero.ResumeLayout(false);
            this.groupGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button butMostrar;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.CheckBox chkAceptar;
        private System.Windows.Forms.RadioButton radioHombre;
        private System.Windows.Forms.RadioButton radioMujer;
        private System.Windows.Forms.GroupBox groupGenero;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

