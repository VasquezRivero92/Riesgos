using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riesgos
{
    public partial class FormMenuPrincipal : Form
    {

        string nivel,usuario;
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMatriz promo = new FormMatriz();
            promo.Text = FormLogin.nom_usuario;
            promo.StartPosition = FormStartPosition.CenterScreen;
            promo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBuscar promo = new FormBuscar();
            promo.Text = FormLogin.nom_usuario;
            promo.StartPosition = FormStartPosition.CenterScreen;
            promo.ShowDialog();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            nivel = FormLogin.nivel;
            usuario = FormLogin.nom_unidad;
            txt_nombre.Text = FormLogin.nom_usuario;
        }


    }
}
