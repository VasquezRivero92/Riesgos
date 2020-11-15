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
    public partial class FormBuscar : Form
    {
        string id_proceso, id_actividad, id_procesamiento, id_riesgo;

        void cargar_proceso()
        {
            using (SqlConnection conn = new SqlConnection(Program.cnn67))
            {
                string query = "select ps.id_proceso,ps.nombre_proceso from M_RIESGO_procedimiento pm inner join M_RIESGO_proceso ps on pm.id_proceso=ps.id_proceso group by ps.nombre_proceso,ps.id_proceso;"; // where id_unidad='" + FormLogin.id_unidad + "'
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmb_proceso.ValueMember = "id_proceso";
                cmb_proceso.DisplayMember = "nombre_proceso";
                cmb_proceso.DataSource = dt;
                id_proceso = cmb_proceso.Text.ToString();
            }
        }

        void cargar_procesamiento()
        {
            using (SqlConnection conn = new SqlConnection(Program.cnn67))
            {
                string query = "select id_procedimiento,nombre_procedimiento from M_RIESGO_procedimiento where id_proceso='" + cmb_proceso.SelectedValue.ToString() + "';"; // 
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmb_procesamiento.ValueMember = "id_procedimiento";
                cmb_procesamiento.DisplayMember = "nombre_procedimiento";
                cmb_procesamiento.DataSource = dt;
                id_procesamiento = cmb_procesamiento.Text.ToString();
            }
        }

        private void chk_proceso_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_proceso.Checked == true)
            {
                cmb_proceso.Enabled = true;
                cargar_proceso();
                
            }
            else
            {
                cmb_proceso.Enabled = false;
                cmb_procesamiento.Enabled = false;
                chk_procesamiento.Checked = false;
            }
        }

        private void chk_procesamiento_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_procesamiento.Checked == true)
            {
                cmb_procesamiento.Enabled = true;
                if (chk_proceso.Checked == true)
                {
                    cargar_procesamiento();
                }
                else
                {
                    MessageBox.Show("Activar Proceso");
                    cmb_procesamiento.Enabled = false;
                    chk_procesamiento.Checked = false;
                }
            }
            else
            {
                cmb_procesamiento.Enabled = false;
            }
        }

        private void cmb_proceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chk_procesamiento.Checked == true) {
                cargar_procesamiento();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (chk_proceso.Checked == true)
                {
                consulta("where pm.id_proceso = '" + cmb_proceso.SelectedValue.ToString() + "'", "");
                if (chk_procesamiento.Checked == true)
                {
                    consulta("where pm.id_proceso = '" + cmb_proceso.SelectedValue.ToString() + "'", "and ac.id_procedimiento = '" + cmb_procesamiento.SelectedValue.ToString() + "'");
                }
            }
            else
            {
                consulta("","");
            }
                           
        }

        private void consulta(string var,string var2)
        {
            dtg_actividad.AllowUserToAddRows = false;
            using (SqlConnection conn = new SqlConnection(Program.cnn67))
            {
                string query1 = "select ac.id_actividad,(select nombre_proceso from M_RIESGO_proceso where id_proceso= pm.id_proceso),pm.nombre_procedimiento,ac.actividad,pm.id_proceso,pm.id_procedimiento from M_RIESGO_actividad ac inner join M_RIESGO_procedimiento pm on ac.id_procedimiento=pm.id_procedimiento "+var+" "+var2+";";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
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
                Console.WriteLine(query1);
            }
            
            dtg_actividad.AllowUserToAddRows = false;
            dtg_actividad.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg_actividad.Columns["id_proceso"].Visible = false;
            dtg_actividad.Columns["id_procedimiento"].Visible = false;
        }

        void consulta_evento(string var,string var2) {
            using (SqlConnection conn = new SqlConnection(Program.cnn67))
            {
                string query1 = "select et.id_evento,ac.actividad,et.evento,et.causas,et.consecuencias,al.nivel,et.indicador,et.fuente,et.propuesta_solucion from M_RIESGO_evento et inner join M_RIESGO_analisis al on et.id_analisis=al.id_analisis inner join M_RIESGO_actividad ac on et.id_actividad=ac.id_actividad where et.id_actividad='" + var + "' "+var2+";";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                da1.Fill(ds, "tabla");
                dtg_evento.DataSource = ds;
                dtg_evento.DataMember = "tabla";
                dtg_evento.AutoResizeColumns();
                dtg_evento.Columns[0].HeaderText = "ID";
                dtg_evento.Columns[1].HeaderText = "ACTIVIDAD";
                dtg_evento.Columns[2].HeaderText = "EVENTO";
                dtg_evento.Columns[3].HeaderText = "CAUSAS";
                dtg_evento.Columns[4].HeaderText = "CONSECUENCIAS";
                dtg_evento.Columns[5].HeaderText = "NIVEL";
                dtg_evento.Columns[6].HeaderText = "INDICADOR";
                dtg_evento.Columns[7].HeaderText = "FUENTE";
                dtg_evento.Columns[8].HeaderText = "PROPUESTA SOLUCION";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal promo = new FormMenuPrincipal();
            promo.Text = FormLogin.nom_unidad;
            promo.StartPosition = FormStartPosition.CenterScreen;
            promo.Show();

            this.Close();
        }

        private void cmb_riesgo_SelectedIndexChanged(object sender, EventArgs e)
        {
            consulta_evento(id_actividad, "and al.nivel='" + cmb_riesgo.Text + "'");
            for (int i = 0; i < (dtg_evento.Rows.Count); i++)
            {
                if (dtg_evento.Rows[i].Cells[5].Value.ToString() == "BAJO")
                {
                    dtg_evento.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else if (dtg_evento.Rows[i].Cells[5].Value.ToString() == "MEDIO")
                {
                    dtg_evento.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (dtg_evento.Rows[i].Cells[5].Value.ToString() == "ALTO")
                {
                    dtg_evento.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void dtg_actividad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex <= -1)
            {

            }
            else
            {
                id_actividad = dtg_actividad.Rows[e.RowIndex].Cells[0].Value.ToString();
                consulta_evento(id_actividad,"");
                dtg_evento.AllowUserToAddRows = false;
                dtg_evento.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg_evento.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg_evento.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg_evento.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg_evento.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg_evento.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg_evento.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg_evento.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 0; i < (dtg_evento.Rows.Count); i++) 
                {
                    if (dtg_evento.Rows[i].Cells[5].Value.ToString() == "BAJO")
                    {
                        dtg_evento.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    else if (dtg_evento.Rows[i].Cells[5].Value.ToString() == "MEDIO")
                    {
                        dtg_evento.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if(dtg_evento.Rows[i].Cells[5].Value.ToString() == "ALTO")
                    {
                        dtg_evento.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                    
            }
        }

        private void dtg_evento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBuscar_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenuPrincipal promo = new FormMenuPrincipal();
            promo.Text = FormLogin.nom_unidad;
            promo.StartPosition = FormStartPosition.CenterScreen;
            promo.Show();

            this.Close();
        }

        private void chk_riesgo_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_riesgo.Checked == true)
            {
                cmb_riesgo.Enabled = true;
                using (SqlConnection conn = new SqlConnection(Program.cnn67))
                {
                    string query = "select nivel from M_RIESGO_analisis group by nivel";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmb_riesgo.ValueMember = "nivel";
                    cmb_riesgo.DisplayMember = "nivel";
                    cmb_riesgo.DataSource = dt;
                    id_riesgo = cmb_riesgo.Text.ToString();
                }
                consulta_evento(id_actividad,"and al.nivel='"+cmb_riesgo.Text+"'");

            }
            else
            {
                cmb_riesgo.Enabled = false;
                consulta_evento(id_actividad,"");
            }
        }

        public FormBuscar()
        {
            InitializeComponent();
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {

            
        }
    }
}
