namespace Riesgos
{
    partial class FormMatriz
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
            this.cmb_proceso = new System.Windows.Forms.ComboBox();
            this.txt_actividad = new System.Windows.Forms.TextBox();
            this.txt_evento = new System.Windows.Forms.TextBox();
            this.txt_consecuencias = new System.Windows.Forms.TextBox();
            this.txt_causas = new System.Windows.Forms.TextBox();
            this.lb_procedimiento = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_evento = new System.Windows.Forms.Label();
            this.lbl_causas = new System.Windows.Forms.Label();
            this.lbl_consecuencias = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_prob = new System.Windows.Forms.TextBox();
            this.txt_impacto = new System.Windows.Forms.TextBox();
            this.lbl_probabilidad = new System.Windows.Forms.Label();
            this.lbl_impacto = new System.Windows.Forms.Label();
            this.lbl_nivel = new System.Windows.Forms.Label();
            this.btn_actividad = new System.Windows.Forms.Button();
            this.lbl_indicador = new System.Windows.Forms.Label();
            this.txt_indicador = new System.Windows.Forms.TextBox();
            this.lbl_fuente = new System.Windows.Forms.Label();
            this.txt_fuente = new System.Windows.Forms.TextBox();
            this.lbl_propuesta = new System.Windows.Forms.Label();
            this.txt_propuesta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtg_actividad = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_actividad)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_proceso
            // 
            this.cmb_proceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_proceso.FormattingEnabled = true;
            this.cmb_proceso.Location = new System.Drawing.Point(47, 77);
            this.cmb_proceso.Name = "cmb_proceso";
            this.cmb_proceso.Size = new System.Drawing.Size(227, 21);
            this.cmb_proceso.TabIndex = 0;
            this.cmb_proceso.SelectedIndexChanged += new System.EventHandler(this.cmb_proceso_SelectedIndexChanged);
            this.cmb_proceso.ValueMemberChanged += new System.EventHandler(this.cmb_proceso_ValueMemberChanged);
            // 
            // txt_actividad
            // 
            this.txt_actividad.Location = new System.Drawing.Point(749, 58);
            this.txt_actividad.Multiline = true;
            this.txt_actividad.Name = "txt_actividad";
            this.txt_actividad.Size = new System.Drawing.Size(274, 123);
            this.txt_actividad.TabIndex = 2;
            this.txt_actividad.TextChanged += new System.EventHandler(this.txt_actividad_TextChanged);
            // 
            // txt_evento
            // 
            this.txt_evento.Location = new System.Drawing.Point(47, 300);
            this.txt_evento.Multiline = true;
            this.txt_evento.Name = "txt_evento";
            this.txt_evento.Size = new System.Drawing.Size(274, 123);
            this.txt_evento.TabIndex = 3;
            this.txt_evento.Visible = false;
            this.txt_evento.TextChanged += new System.EventHandler(this.txt_evento_TextChanged);
            // 
            // txt_consecuencias
            // 
            this.txt_consecuencias.Location = new System.Drawing.Point(749, 300);
            this.txt_consecuencias.Multiline = true;
            this.txt_consecuencias.Name = "txt_consecuencias";
            this.txt_consecuencias.Size = new System.Drawing.Size(274, 123);
            this.txt_consecuencias.TabIndex = 5;
            this.txt_consecuencias.Visible = false;
            this.txt_consecuencias.TextChanged += new System.EventHandler(this.txt_consecuencias_TextChanged);
            // 
            // txt_causas
            // 
            this.txt_causas.Location = new System.Drawing.Point(398, 300);
            this.txt_causas.Multiline = true;
            this.txt_causas.Name = "txt_causas";
            this.txt_causas.Size = new System.Drawing.Size(274, 123);
            this.txt_causas.TabIndex = 4;
            this.txt_causas.Visible = false;
            this.txt_causas.TextChanged += new System.EventHandler(this.txt_causas_TextChanged);
            // 
            // lb_procedimiento
            // 
            this.lb_procedimiento.FormattingEnabled = true;
            this.lb_procedimiento.Location = new System.Drawing.Point(354, 58);
            this.lb_procedimiento.Name = "lb_procedimiento";
            this.lb_procedimiento.Size = new System.Drawing.Size(317, 121);
            this.lb_procedimiento.TabIndex = 6;
            this.lb_procedimiento.SelectedIndexChanged += new System.EventHandler(this.lb_proceamiento_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(746, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Actividad";
            // 
            // lbl_evento
            // 
            this.lbl_evento.AutoSize = true;
            this.lbl_evento.Location = new System.Drawing.Point(44, 275);
            this.lbl_evento.Name = "lbl_evento";
            this.lbl_evento.Size = new System.Drawing.Size(83, 13);
            this.lbl_evento.TabIndex = 8;
            this.lbl_evento.Text = "Evento Adverso";
            this.lbl_evento.Visible = false;
            // 
            // lbl_causas
            // 
            this.lbl_causas.AutoSize = true;
            this.lbl_causas.Location = new System.Drawing.Point(395, 275);
            this.lbl_causas.Name = "lbl_causas";
            this.lbl_causas.Size = new System.Drawing.Size(42, 13);
            this.lbl_causas.TabIndex = 9;
            this.lbl_causas.Text = "Causas";
            this.lbl_causas.Visible = false;
            // 
            // lbl_consecuencias
            // 
            this.lbl_consecuencias.AutoSize = true;
            this.lbl_consecuencias.Location = new System.Drawing.Point(746, 275);
            this.lbl_consecuencias.Name = "lbl_consecuencias";
            this.lbl_consecuencias.Size = new System.Drawing.Size(80, 13);
            this.lbl_consecuencias.TabIndex = 10;
            this.lbl_consecuencias.Text = "Consecuencias";
            this.lbl_consecuencias.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mapa de Procesos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Procedimiento";
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(809, 567);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(102, 39);
            this.btn_enviar.TabIndex = 13;
            this.btn_enviar.Text = "Enviar Evento";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Visible = false;
            this.btn_enviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(929, 567);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(94, 39);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "Cerrar";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_prob
            // 
            this.txt_prob.Location = new System.Drawing.Point(885, 486);
            this.txt_prob.MaxLength = 1;
            this.txt_prob.Name = "txt_prob";
            this.txt_prob.Size = new System.Drawing.Size(26, 20);
            this.txt_prob.TabIndex = 15;
            this.txt_prob.Visible = false;
            this.txt_prob.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_prob.Validating += new System.ComponentModel.CancelEventHandler(this.txt_prob_Validating_1);
            // 
            // txt_impacto
            // 
            this.txt_impacto.Location = new System.Drawing.Point(885, 512);
            this.txt_impacto.MaxLength = 1;
            this.txt_impacto.Name = "txt_impacto";
            this.txt_impacto.Size = new System.Drawing.Size(26, 20);
            this.txt_impacto.TabIndex = 16;
            this.txt_impacto.Visible = false;
            this.txt_impacto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txt_impacto.Validating += new System.ComponentModel.CancelEventHandler(this.txt_impacto_Validating_1);
            // 
            // lbl_probabilidad
            // 
            this.lbl_probabilidad.AutoSize = true;
            this.lbl_probabilidad.Location = new System.Drawing.Point(794, 486);
            this.lbl_probabilidad.Name = "lbl_probabilidad";
            this.lbl_probabilidad.Size = new System.Drawing.Size(68, 13);
            this.lbl_probabilidad.TabIndex = 17;
            this.lbl_probabilidad.Text = "Probabilidad:";
            this.lbl_probabilidad.Visible = false;
            // 
            // lbl_impacto
            // 
            this.lbl_impacto.AutoSize = true;
            this.lbl_impacto.Location = new System.Drawing.Point(794, 512);
            this.lbl_impacto.Name = "lbl_impacto";
            this.lbl_impacto.Size = new System.Drawing.Size(48, 13);
            this.lbl_impacto.TabIndex = 18;
            this.lbl_impacto.Text = "Impacto:";
            this.lbl_impacto.Visible = false;
            // 
            // lbl_nivel
            // 
            this.lbl_nivel.AutoSize = true;
            this.lbl_nivel.Location = new System.Drawing.Point(976, 497);
            this.lbl_nivel.Name = "lbl_nivel";
            this.lbl_nivel.Size = new System.Drawing.Size(10, 13);
            this.lbl_nivel.TabIndex = 19;
            this.lbl_nivel.Text = " ";
            this.lbl_nivel.Visible = false;
            // 
            // btn_actividad
            // 
            this.btn_actividad.Location = new System.Drawing.Point(800, 175);
            this.btn_actividad.Name = "btn_actividad";
            this.btn_actividad.Size = new System.Drawing.Size(83, 39);
            this.btn_actividad.TabIndex = 21;
            this.btn_actividad.Text = "Crear Actividad";
            this.btn_actividad.UseVisualStyleBackColor = true;
            this.btn_actividad.Click += new System.EventHandler(this.btn_actividad_Click);
            // 
            // lbl_indicador
            // 
            this.lbl_indicador.AutoSize = true;
            this.lbl_indicador.Location = new System.Drawing.Point(44, 458);
            this.lbl_indicador.Name = "lbl_indicador";
            this.lbl_indicador.Size = new System.Drawing.Size(51, 13);
            this.lbl_indicador.TabIndex = 23;
            this.lbl_indicador.Text = "Indicador";
            this.lbl_indicador.Visible = false;
            // 
            // txt_indicador
            // 
            this.txt_indicador.Location = new System.Drawing.Point(47, 483);
            this.txt_indicador.Multiline = true;
            this.txt_indicador.Name = "txt_indicador";
            this.txt_indicador.Size = new System.Drawing.Size(164, 79);
            this.txt_indicador.TabIndex = 22;
            this.txt_indicador.Visible = false;
            this.txt_indicador.TextChanged += new System.EventHandler(this.txt_indicador_TextChanged);
            // 
            // lbl_fuente
            // 
            this.lbl_fuente.AutoSize = true;
            this.lbl_fuente.Location = new System.Drawing.Point(243, 458);
            this.lbl_fuente.Name = "lbl_fuente";
            this.lbl_fuente.Size = new System.Drawing.Size(100, 13);
            this.lbl_fuente.TabIndex = 25;
            this.lbl_fuente.Text = "Herramienta Fuente";
            this.lbl_fuente.Visible = false;
            // 
            // txt_fuente
            // 
            this.txt_fuente.Location = new System.Drawing.Point(246, 483);
            this.txt_fuente.Multiline = true;
            this.txt_fuente.Name = "txt_fuente";
            this.txt_fuente.Size = new System.Drawing.Size(164, 79);
            this.txt_fuente.TabIndex = 24;
            this.txt_fuente.Visible = false;
            this.txt_fuente.TextChanged += new System.EventHandler(this.txt_fuente_TextChanged);
            // 
            // lbl_propuesta
            // 
            this.lbl_propuesta.AutoSize = true;
            this.lbl_propuesta.Location = new System.Drawing.Point(432, 458);
            this.lbl_propuesta.Name = "lbl_propuesta";
            this.lbl_propuesta.Size = new System.Drawing.Size(99, 13);
            this.lbl_propuesta.TabIndex = 27;
            this.lbl_propuesta.Text = "Propuesta Solucion";
            this.lbl_propuesta.Visible = false;
            // 
            // txt_propuesta
            // 
            this.txt_propuesta.Location = new System.Drawing.Point(435, 483);
            this.txt_propuesta.Multiline = true;
            this.txt_propuesta.Name = "txt_propuesta";
            this.txt_propuesta.Size = new System.Drawing.Size(274, 123);
            this.txt_propuesta.TabIndex = 26;
            this.txt_propuesta.Visible = false;
            this.txt_propuesta.TextChanged += new System.EventHandler(this.txt_propuesta_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_actividad);
            this.groupBox2.Location = new System.Drawing.Point(28, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1011, 231);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(910, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 39);
            this.button1.TabIndex = 30;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dtg_actividad
            // 
            this.dtg_actividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_actividad.Location = new System.Drawing.Point(33, 311);
            this.dtg_actividad.Name = "dtg_actividad";
            this.dtg_actividad.Size = new System.Drawing.Size(1005, 241);
            this.dtg_actividad.TabIndex = 30;
            this.dtg_actividad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_actividad_CellClick);
            this.dtg_actividad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_actividad_CellContentClick);
            // 
            // FormMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 637);
            this.Controls.Add(this.dtg_actividad);
            this.Controls.Add(this.lbl_propuesta);
            this.Controls.Add(this.txt_propuesta);
            this.Controls.Add(this.lbl_fuente);
            this.Controls.Add(this.txt_fuente);
            this.Controls.Add(this.lbl_indicador);
            this.Controls.Add(this.txt_indicador);
            this.Controls.Add(this.lbl_nivel);
            this.Controls.Add(this.lbl_impacto);
            this.Controls.Add(this.lbl_probabilidad);
            this.Controls.Add(this.txt_impacto);
            this.Controls.Add(this.txt_prob);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_consecuencias);
            this.Controls.Add(this.lbl_causas);
            this.Controls.Add(this.lbl_evento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_procedimiento);
            this.Controls.Add(this.txt_consecuencias);
            this.Controls.Add(this.txt_causas);
            this.Controls.Add(this.txt_evento);
            this.Controls.Add(this.txt_actividad);
            this.Controls.Add(this.cmb_proceso);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormMatriz";
            this.Text = "FormMatriz";
            this.Load += new System.EventHandler(this.FormMatriz_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_actividad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_proceso;
        private System.Windows.Forms.TextBox txt_actividad;
        private System.Windows.Forms.TextBox txt_evento;
        private System.Windows.Forms.TextBox txt_consecuencias;
        private System.Windows.Forms.TextBox txt_causas;
        private System.Windows.Forms.ListBox lb_procedimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_evento;
        private System.Windows.Forms.Label lbl_causas;
        private System.Windows.Forms.Label lbl_consecuencias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_prob;
        private System.Windows.Forms.TextBox txt_impacto;
        private System.Windows.Forms.Label lbl_probabilidad;
        private System.Windows.Forms.Label lbl_impacto;
        private System.Windows.Forms.Label lbl_nivel;
        private System.Windows.Forms.Button btn_actividad;
        private System.Windows.Forms.Label lbl_indicador;
        private System.Windows.Forms.TextBox txt_indicador;
        private System.Windows.Forms.Label lbl_fuente;
        private System.Windows.Forms.TextBox txt_fuente;
        private System.Windows.Forms.Label lbl_propuesta;
        private System.Windows.Forms.TextBox txt_propuesta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtg_actividad;
    }
}