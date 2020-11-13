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
        string id_proceso, id_analisis, id_procesamiento, id_riesgo;

        private void chk_proceso_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_proceso.Checked == true)
            {
                cmb_proceso.Enabled = true;
                using (SqlConnection conn = new SqlConnection(Program.cnn67))
                {
                    string query = "select ps.id_proceso,ps.nombre_proceso from M_RIESGO_procedimiento pm inner join M_RIESGO_proceso ps on pm.id_proceso=ps.id_proceso where id_unidad='" + FormLogin.id_unidad + "' group by ps.nombre_proceso,ps.id_proceso;";
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
            else
            {
                cmb_proceso.Enabled = false;
                using (SqlConnection conn = new SqlConnection(Program.cnn67))
                {
                    string query = "select id_procedimiento,nombre_procedimiento from M_RIESGO_procedimiento where id_unidad='" + FormLogin.id_unidad + "';";
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
        }

        private void chk_procesamiento_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_procesamiento.Checked == true)
            {
                cmb_procesamiento.Enabled = true;
                using (SqlConnection conn = new SqlConnection(Program.cnn67))
                {
                    string query = "select id_procedimiento,nombre_procedimiento from M_RIESGO_procedimiento where id_unidad='" + FormLogin.id_unidad + "';";
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
            else
            {
                cmb_procesamiento.Enabled = false;
            }
        }

        private void cmb_proceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chk_procesamiento.Checked == true) {
                id_proceso = cmb_proceso.Text;

                using (SqlConnection conn = new SqlConnection(Program.cnn67))
                {
                    string query = "select pm.id_procedimiento,pc.nombre_proceso,pm.nombre_procedimiento from M_RIESGO_procedimiento pm inner join M_RIESGO_proceso pc on pm.id_proceso=pc.id_proceso where pm.id_unidad='" + FormLogin.id_unidad + "' and pc.nombre_proceso='" + id_proceso + "';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmb_procesamiento.ValueMember = "id_procedimiento";
                    cmb_procesamiento.DisplayMember = "nombre_procedimiento";
                    cmb_procesamiento.DataSource = dt;
                    Console.WriteLine("asdasdasdasdasdasdas");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

                if (chk_proceso.Checked == true)
                {
                    consulta(cmb_proceso.SelectedValue.ToString(), "", "");
                }
                else if(chk_procesamiento.Checked == true) {
                    consulta("", cmb_procesamiento.SelectedValue.ToString(), "");
                }
                else if (chk_riesgo.Checked == true)
                {
                    consulta("", "", cmb_riesgo.Text);
                }
            consulta("","","");
           
        }

        private void consulta(string var,string var2, string var3)
        {
            dtg_actividad.AllowUserToAddRows = false;
            using (SqlConnection conn = new SqlConnection(Program.cnn67))
            {
                //string query1 = "select et.id_evento,(select ud.nombre_unidad from M_RIESGO_procedimiento pt inner join M_RIESGO_unidad ud on pt.id_unidad=ud.id_unidad where pt.id_procedimiento=ad.id_procedimiento),(select pc.nombre_proceso from M_RIESGO_procedimiento pt inner join M_RIESGO_proceso pc on pt.id_proceso=pc.id_proceso where pt.id_procedimiento=ad.id_procedimiento),et.evento,et.causas,et.consecuencias,al.nivel,et.indicador,et.fuente,et.propuesta_solucion from M_RIESGO_evento et inner join M_RIESGO_actividad ad on et.id_actividad = ad.id_actividad inner join M_RIESGO_analisis al on et.id_analisis = al.id_analisis;";
                //SqlCommand cmd1 = new SqlCommand(query1, conn);
                //SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                //DataSet ds = new DataSet();
                //da1.Fill(ds, "tabla");
                //dtg_actividad.DataSource = ds;
                //dtg_actividad.DataMember = "tabla";
                //dtg_actividad.AutoResizeColumns();
                //dtg_buscar.Columns[0].HeaderText = "ID EVENTO";
                //dtg_buscar.Columns[1].HeaderText = "NOMBRE DE PROCESO";
                //dtg_buscar.Columns[2].HeaderText = "NOMBRE PROCEDIMIENTO";
                //dtg_buscar.Columns[3].HeaderText = "ACTIVIDAD";
            }

            dtg_actividad.AllowUserToAddRows = false;

            using (SqlConnection conn = new SqlConnection(Program.cnn67))
            {
                //string querys = "select * from M_RIESGO_procedimiento;";
                //SqlCommand cmd12 = new SqlCommand(querys, conn);
                //SqlDataAdapter da12 = new SqlDataAdapter(cmd12);
                ////DataTable dt = new DataTable();
                //da12.Fill(dtgen);


                string query1 = "select ac.id_actividad,(select nombre_proceso from M_RIESGO_proceso where id_proceso= pm.id_proceso),pm.nombre_procedimiento,ac.actividad,pm.id_proceso,pm.id_procedimiento from M_RIESGO_actividad ac inner join M_RIESGO_procedimiento pm on ac.id_procedimiento=pm.id_procedimiento where ac.id_unidad='" + FormLogin.id_unidad + "';";
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
            }
            else
            {
                cmb_riesgo.Enabled = false;
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
