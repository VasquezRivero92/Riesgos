using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riesgos
{
    public partial class FormMatriz : Form
    {
        string id_proceso,id_analisis, id_procedimiento, id_actividad, nombre_procedimiento,nombre_actividad;
        int i;

        public FormMatriz()
        {
            InitializeComponent();
        }

        void ocultar_llenado()
        {
            dtg_actividad.Show();
            txt_evento.Hide();
            lbl_evento.Hide();
            lbl_causas.Hide();
            txt_causas.Hide();
            lbl_consecuencias.Hide();
            txt_consecuencias.Hide();
            lbl_indicador.Hide();
            txt_consecuencias.Hide();
            lbl_indicador.Hide();
            txt_indicador.Hide();
            txt_consecuencias.Hide();
            lbl_fuente.Hide();
            txt_fuente.Hide();
            lbl_propuesta.Hide();
            txt_propuesta.Hide();
            lbl_probabilidad.Hide();
            txt_prob.Hide();
            lbl_impacto.Hide();
            txt_impacto.Hide();
            lbl_nivel.Hide();
            btn_enviar.Hide();
            //gb_evento.Hide();
        }
        void mostrar_llenado()
        {
            dtg_actividad.Hide();
            txt_evento.Show();
            lbl_evento.Show();
            lbl_causas.Show();
            txt_causas.Show();
            lbl_consecuencias.Show();
            txt_consecuencias.Show();
            lbl_indicador.Show();
            txt_consecuencias.Show();
            lbl_indicador.Show();
            txt_indicador.Show();
            txt_consecuencias.Show();
            lbl_fuente.Show();
            txt_fuente.Show();
            lbl_propuesta.Show();
            txt_propuesta.Show();
            lbl_probabilidad.Show();
            txt_prob.Show();
            lbl_impacto.Show();
            txt_impacto.Show();
            lbl_nivel.Show();
            btn_enviar.Show();
            //gb_evento.Show();
        }

        private void FormMatriz_Load(object sender, EventArgs e)
        {
            dtg_actividad.AllowUserToAddRows = false;
            
            using (SqlConnection conn = new SqlConnection(Program.cnn67))
            {
                //string querys = "select * from M_RIESGO_procedimiento;";
                //SqlCommand cmd12 = new SqlCommand(querys, conn);
                //SqlDataAdapter da12 = new SqlDataAdapter(cmd12);
                ////DataTable dt = new DataTable();
                //da12.Fill(dtgen);
                

                string query = "select ps.id_proceso,ps.nombre_proceso from M_RIESGO_procedimiento pm inner join M_RIESGO_proceso ps on pm.id_proceso=ps.id_proceso where id_unidad='"+FormLogin.id_unidad+ "' group by ps.nombre_proceso,ps.id_proceso;";
                string query1 = "select ac.id_actividad,(select nombre_proceso from M_RIESGO_proceso where id_proceso= pm.id_proceso),pm.nombre_procedimiento,ac.actividad,pm.id_proceso,pm.id_procedimiento from M_RIESGO_actividad ac inner join M_RIESGO_procedimiento pm on ac.id_procedimiento=pm.id_procedimiento where ac.id_unidad='" + FormLogin.id_unidad + "';";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                da1.Fill(ds, "tabla");
                dtg_actividad.DataSource = ds;
                dtg_actividad.DataMember = "tabla";
                dtg_actividad.AutoResizeColumns();
                dtg_actividad.Columns[0].HeaderText = "ID";
                dtg_actividad.Columns[1].HeaderText = "NOMBRE DE PROCESO";
                dtg_actividad.Columns[2].HeaderText = "NOMBRE PROCEDIMIENTO";
                dtg_actividad.Columns[3].HeaderText = "ACTIVIDAD";
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmb_proceso.ValueMember = "id_proceso";
                cmb_proceso.DisplayMember = "nombre_proceso";
                cmb_proceso.DataSource = dt;
            }
            dtg_actividad.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg_actividad.Columns["id_proceso"].Visible = false;
            dtg_actividad.Columns["id_procedimiento"].Visible = false;
        }

        private void cmb_proceso_ValueMemberChanged(object sender, EventArgs e)
        {
        }

        private void lb_proceamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Program.cnn67))
            {
                if (lb_procedimiento.SelectedItem != null) {
                    string query = "select * from M_RIESGO_procedimiento where nombre_procedimiento='" + lb_procedimiento.SelectedItem.ToString() + "';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    id_procedimiento = dt.Rows[0]["id_procedimiento"].ToString();
                }
                else
                {

                }
                
            }
        }

        private void cmb_proceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_proceso = cmb_proceso.Text.ToString();
            lb_procedimiento.Items.Clear();
            using (SqlConnection conn = new SqlConnection(Program.cnn67))
            {
                string query = "select pm.id_procedimiento,pc.nombre_proceso,pm.nombre_procedimiento from M_RIESGO_procedimiento pm inner join M_RIESGO_proceso pc on pm.id_proceso=pc.id_proceso where pm.id_unidad='" + FormLogin.id_unidad + "' and pc.nombre_proceso='" + id_proceso + "';";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        this.lb_procedimiento.Items.Add(dr.GetString(2));
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            using (SqlConnection conn = new SqlConnection(Program.cnn67))
            {
                string query = "select * from M_RIESGO_analisis where probabilidad='" + txt_prob.Text + "' and impacto='" + txt_impacto.Text + "';";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1) {
                    lbl_nivel.Text = dt.Rows[0]["nivel"].ToString();
                    id_analisis = dt.Rows[0]["id_analisis"].ToString();
                }
                
            }
        }

        private void btn_actividad_Click(object sender, EventArgs e)
        {
            if (lb_procedimiento.Text != "" ) {
                mostrar_llenado();
                using (SqlConnection conn = new SqlConnection(Program.cnn67))
                {
                    nombre_actividad = txt_actividad.Text;
                    string query = "select * from M_RIESGO_actividad where actividad='" + nombre_actividad + "';";
                    SqlCommand cmd0 = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd0);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    

                    if (dt.Rows.Count>=1){
                        
                        id_actividad = dt.Rows[0]["id_actividad"].ToString();
                    }
                    else{
                        
                        SqlCommand cmd = conn.CreateCommand();
                        conn.Open();
                        cmd.CommandText = "INSERT INTO M_RIESGO_actividad(id_procedimiento,id_unidad,actividad,id_usuario) VALUES(@id_procedimiento,@id_unidad,@actividad,@id_usuario)";

                        cmd.Parameters.Add("@id_procedimiento", SqlDbType.Int).Value = Convert.ToInt32(id_procedimiento);
                        cmd.Parameters.Add("@id_unidad", SqlDbType.Int).Value = FormLogin.id_unidad;
                        cmd.Parameters.Add("@actividad", SqlDbType.VarChar).Value = txt_actividad.Text;
                        cmd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = FormLogin.id_user;

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                }
                lb_procedimiento.Enabled = false;
                cmb_proceso.Enabled = false;
                txt_actividad.Enabled = false;
                
            }
            else
            {
                MessageBox.Show("Seleccionar Procedimiento");
            }
           
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal promo = new FormMenuPrincipal();
            promo.Text = FormLogin.nom_unidad;
            promo.StartPosition = FormStartPosition.CenterScreen;
            promo.Show();

            this.Close();
        }

        private void dtg_actividad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
            }
            else
            {
                id_proceso = dtg_actividad.Rows[e.RowIndex].Cells[4].Value.ToString();
                id_procedimiento = dtg_actividad.Rows[e.RowIndex].Cells[5].Value.ToString();
                nombre_procedimiento = dtg_actividad.CurrentRow.Cells[2].Value.ToString();
                id_actividad = dtg_actividad.Rows[e.RowIndex].Cells[0].Value.ToString();
                nombre_actividad = dtg_actividad.CurrentRow.Cells[3].Value.ToString();
                cmb_proceso.SelectedValue = Convert.ToInt32(id_proceso);
                txt_actividad.Text = dtg_actividad.Rows[e.RowIndex].Cells[3].Value.ToString();
                lb_procedimiento.SelectedItem = nombre_procedimiento;
                cmb_proceso.Enabled = false;
                txt_actividad.Enabled = false;
                lb_procedimiento.Enabled = false;
                btn_actividad.Text = "Agregar Evento";
            }
        }


        private void txt_prob_Validating(object sender, CancelEventArgs e)
        {

           
                
        }

        private void txt_impacto_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txt_prob_Validating_1(object sender, CancelEventArgs e)
        {
        //    if (txt_prob.Text == "1" || txt_prob.Text == "2" || txt_prob.Text == "3" || txt_prob.Text == "4" || txt_prob.Text == "5")
        //    {

        //    }
        //    else
        //    {
        //        txt_prob.Text = "";
        //        e.Cancel = true;
        //    }
        }

        private void txt_impacto_Validating_1(object sender, CancelEventArgs e)
        {
            //if (txt_prob.Text == "1" || txt_prob.Text == "2" || txt_prob.Text == "3" || txt_prob.Text == "4" || txt_prob.Text == "5")
            //{

            //}
            //else
            //{
            //    txt_prob.Text = "";
            //    e.Cancel = true;
            //}
        }

        private void txt_actividad_TextChanged(object sender, EventArgs e)
        {
            txt_actividad.Text = txt_actividad.Text.ToUpper().ToString();
        }

        private void txt_propuesta_TextChanged(object sender, EventArgs e)
        {
            txt_propuesta.Text = txt_propuesta.Text.ToUpper().ToString();
        }

        private void txt_fuente_TextChanged(object sender, EventArgs e)
        {
            txt_fuente.Text = txt_fuente.Text.ToUpper().ToString();
        }

        private void txt_indicador_TextChanged(object sender, EventArgs e)
        {
            txt_indicador.Text = txt_indicador.Text.ToUpper().ToString();
        }

        private void txt_evento_TextChanged(object sender, EventArgs e)
        {
            txt_evento.Text = txt_evento.Text.ToUpper().ToString();
        }

        private void txt_causas_TextChanged(object sender, EventArgs e)
        {
            txt_causas.Text = txt_causas.Text.ToUpper().ToString();
        }

        private void txt_consecuencias_TextChanged(object sender, EventArgs e)
        {
            txt_consecuencias.Text = txt_consecuencias.Text.ToUpper().ToString();
        }
        void limpiar()
        {
            txt_actividad.Text = "";
            txt_evento.Text = "";
            txt_causas.Text = "";
            txt_consecuencias.Text = "";
            txt_indicador.Text = "";
            txt_fuente.Text = "";
            txt_propuesta.Text = "";
            txt_prob.Text = "";
            txt_impacto.Text = "";
            lbl_nivel.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormMatriz_Load(sender, e);
            cmb_proceso.Enabled = true;
            txt_actividad.Enabled = true;
            lb_procedimiento.Enabled = true;
            ocultar_llenado();

            limpiar();
            btn_actividad.Text = "Crear Actividad";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtg_actividad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            using (SqlConnection conn = new SqlConnection(Program.cnn67))
            {
                string query = "select * from M_RIESGO_analisis where probabilidad='" + txt_prob.Text + "' and impacto='" + txt_impacto.Text + "';";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    lbl_nivel.Text = dt.Rows[0]["nivel"].ToString();
                    id_analisis = dt.Rows[0]["id_analisis"].ToString();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Program.cnn67))
            {
                string query = "select * from M_RIESGO_actividad where actividad='" + nombre_actividad + "';";
                SqlCommand cmd0 = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd0);
                DataTable dt = new DataTable();
                da.Fill(dt);
                id_actividad = dt.Rows[0]["id_actividad"].ToString();


                DialogResult dialogResult = MessageBox.Show("¿Esta seguro ingresar el registro?", FormLogin.nom_unidad, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SqlCommand cmd = conn.CreateCommand();
                        conn.Open();
                        cmd.CommandText = "INSERT INTO M_RIESGO_evento(id_actividad,evento,causas,consecuencias,id_analisis,indicador,fuente,propuesta_solucion,id_usuario) VALUES(@id_actividad,@evento,@causas,@consecuencias,@id_analisis,@indicador,@fuente,@propuesta_solucion,@id_usuario)";

                        cmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = Convert.ToInt32(id_actividad);
                        cmd.Parameters.Add("@evento", SqlDbType.VarChar).Value = txt_evento.Text;
                        cmd.Parameters.Add("@causas", SqlDbType.VarChar).Value = txt_causas.Text;
                        cmd.Parameters.Add("@consecuencias", SqlDbType.VarChar).Value = txt_consecuencias.Text;
                        cmd.Parameters.Add("@id_analisis", SqlDbType.Int).Value = id_analisis;
                        cmd.Parameters.Add("@indicador", SqlDbType.VarChar).Value = txt_indicador.Text;
                        cmd.Parameters.Add("@fuente", SqlDbType.VarChar).Value = txt_fuente.Text;
                        cmd.Parameters.Add("@propuesta_solucion", SqlDbType.VarChar).Value = id_analisis;
                        cmd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = FormLogin.id_user;

                        cmd.ExecuteNonQuery();
                        conn.Close();

                        //DialogResult dialogResult2 = MessageBox.Show("¿Desea ingresar la medicion de la actividad?", FormLogin.nom_unidad, MessageBoxButtons.YesNo);
                        //if (dialogResult == DialogResult.Yes)
                        //{ 

                        //}
                    }
            }
        
        }

    }
}
