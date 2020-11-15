namespace Riesgos
{
    partial class FormBuscar
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
            this.dtg_actividad = new System.Windows.Forms.DataGridView();
            this.cmb_proceso = new System.Windows.Forms.ComboBox();
            this.chk_proceso = new System.Windows.Forms.CheckBox();
            this.cmb_procesamiento = new System.Windows.Forms.ComboBox();
            this.chk_procesamiento = new System.Windows.Forms.CheckBox();
            this.chk_riesgo = new System.Windows.Forms.CheckBox();
            this.cmb_riesgo = new System.Windows.Forms.ComboBox();
            this.gp_proceso = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtg_evento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_actividad)).BeginInit();
            this.gp_proceso.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_evento)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_actividad
            // 
            this.dtg_actividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_actividad.Location = new System.Drawing.Point(63, 118);
            this.dtg_actividad.Name = "dtg_actividad";
            this.dtg_actividad.Size = new System.Drawing.Size(866, 203);
            this.dtg_actividad.TabIndex = 0;
            this.dtg_actividad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_actividad_CellClick);
            // 
            // cmb_proceso
            // 
            this.cmb_proceso.Enabled = false;
            this.cmb_proceso.FormattingEnabled = true;
            this.cmb_proceso.Location = new System.Drawing.Point(73, 63);
            this.cmb_proceso.Name = "cmb_proceso";
            this.cmb_proceso.Size = new System.Drawing.Size(227, 21);
            this.cmb_proceso.TabIndex = 12;
            this.cmb_proceso.SelectedIndexChanged += new System.EventHandler(this.cmb_proceso_SelectedIndexChanged);
            // 
            // chk_proceso
            // 
            this.chk_proceso.AutoSize = true;
            this.chk_proceso.Location = new System.Drawing.Point(52, 10);
            this.chk_proceso.Name = "chk_proceso";
            this.chk_proceso.Size = new System.Drawing.Size(15, 14);
            this.chk_proceso.TabIndex = 14;
            this.chk_proceso.UseVisualStyleBackColor = true;
            this.chk_proceso.CheckedChanged += new System.EventHandler(this.chk_proceso_CheckedChanged);
            // 
            // cmb_procesamiento
            // 
            this.cmb_procesamiento.Enabled = false;
            this.cmb_procesamiento.FormattingEnabled = true;
            this.cmb_procesamiento.Location = new System.Drawing.Point(338, 63);
            this.cmb_procesamiento.Name = "cmb_procesamiento";
            this.cmb_procesamiento.Size = new System.Drawing.Size(322, 21);
            this.cmb_procesamiento.TabIndex = 15;
            // 
            // chk_procesamiento
            // 
            this.chk_procesamiento.AutoSize = true;
            this.chk_procesamiento.Location = new System.Drawing.Point(83, 9);
            this.chk_procesamiento.Name = "chk_procesamiento";
            this.chk_procesamiento.Size = new System.Drawing.Size(15, 14);
            this.chk_procesamiento.TabIndex = 17;
            this.chk_procesamiento.UseVisualStyleBackColor = true;
            this.chk_procesamiento.CheckedChanged += new System.EventHandler(this.chk_procesamiento_CheckedChanged);
            // 
            // chk_riesgo
            // 
            this.chk_riesgo.AutoSize = true;
            this.chk_riesgo.Location = new System.Drawing.Point(60, 10);
            this.chk_riesgo.Name = "chk_riesgo";
            this.chk_riesgo.Size = new System.Drawing.Size(15, 14);
            this.chk_riesgo.TabIndex = 18;
            this.chk_riesgo.UseVisualStyleBackColor = true;
            this.chk_riesgo.CheckedChanged += new System.EventHandler(this.chk_riesgo_CheckedChanged);
            // 
            // cmb_riesgo
            // 
            this.cmb_riesgo.Enabled = false;
            this.cmb_riesgo.FormattingEnabled = true;
            this.cmb_riesgo.Location = new System.Drawing.Point(420, 357);
            this.cmb_riesgo.Name = "cmb_riesgo";
            this.cmb_riesgo.Size = new System.Drawing.Size(100, 21);
            this.cmb_riesgo.TabIndex = 20;
            this.cmb_riesgo.SelectedIndexChanged += new System.EventHandler(this.cmb_riesgo_SelectedIndexChanged);
            // 
            // gp_proceso
            // 
            this.gp_proceso.Controls.Add(this.chk_proceso);
            this.gp_proceso.Location = new System.Drawing.Point(63, 33);
            this.gp_proceso.Name = "gp_proceso";
            this.gp_proceso.Size = new System.Drawing.Size(246, 69);
            this.gp_proceso.TabIndex = 21;
            this.gp_proceso.TabStop = false;
            this.gp_proceso.Text = "Proceso";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_procesamiento);
            this.groupBox1.Location = new System.Drawing.Point(328, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 69);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procesamiento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_riesgo);
            this.groupBox2.Location = new System.Drawing.Point(411, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 69);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Riesgo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(816, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtg_evento
            // 
            this.dtg_evento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_evento.Location = new System.Drawing.Point(63, 412);
            this.dtg_evento.Name = "dtg_evento";
            this.dtg_evento.Size = new System.Drawing.Size(866, 203);
            this.dtg_evento.TabIndex = 26;
            this.dtg_evento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_evento_CellContentClick);
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 648);
            this.Controls.Add(this.dtg_evento);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_riesgo);
            this.Controls.Add(this.cmb_procesamiento);
            this.Controls.Add(this.cmb_proceso);
            this.Controls.Add(this.dtg_actividad);
            this.Controls.Add(this.gp_proceso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormBuscar";
            this.Text = "FormBuscar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBuscar_FormClosed);
            this.Load += new System.EventHandler(this.FormBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_actividad)).EndInit();
            this.gp_proceso.ResumeLayout(false);
            this.gp_proceso.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_evento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_actividad;
        private System.Windows.Forms.ComboBox cmb_proceso;
        private System.Windows.Forms.CheckBox chk_proceso;
        private System.Windows.Forms.ComboBox cmb_procesamiento;
        private System.Windows.Forms.CheckBox chk_procesamiento;
        private System.Windows.Forms.CheckBox chk_riesgo;
        private System.Windows.Forms.ComboBox cmb_riesgo;
        private System.Windows.Forms.GroupBox gp_proceso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtg_evento;
    }
}