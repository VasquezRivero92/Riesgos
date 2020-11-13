using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace Riesgos
{
    public partial class FormLogin : Form
    {
        public static string id_user,nivel,nom_unidad,nom_usuario,id_unidad;
        /// <summary>
        /// Key for the crypto provider
        /// </summary>
        private static readonly byte[] _key = { 0xA1, 0xF1, 0xA6, 0xBB, 0xA2, 0x5A, 0x37, 0x6F, 0x81, 0x2E, 0x17, 0x41, 0x72, 0x2C, 0x43, 0x27 };
        /// <summary>
        /// Initialization vector for the crypto provider
        /// </summary>
        private static readonly byte[] _initVector = { 0xE1, 0xF1, 0xA6, 0xBB, 0xA9, 0x5B, 0x31, 0x2F, 0x81, 0x2E, 0x17, 0x4C, 0xA2, 0x81, 0x53, 0x61 };
        public FormLogin()
        {
            InitializeComponent();
        }
#if (DEBUG) //Only compile this method for local debugging.
        /// <summary>
        /// Decrypt a string
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        private static string Decrypt(string Value)
        {
            SymmetricAlgorithm mCSP;
            ICryptoTransform ct = null;
            MemoryStream ms = null;
            CryptoStream cs = null;
            byte[] byt;
            byte[] _result;
            mCSP = new RijndaelManaged();
            try
            {
                mCSP.Key = _key;
                mCSP.IV = _initVector;
                ct = mCSP.CreateDecryptor(mCSP.Key, mCSP.IV);
                byt = Convert.FromBase64String(Value);
                ms = new MemoryStream();
                cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
                cs.Write(byt, 0, byt.Length);
                cs.FlushFinalBlock();
                cs.Close();
                _result = ms.ToArray();
            }
            catch
            {
                _result = null;
            }
            finally
            {
                if (ct != null)
                    ct.Dispose();
                if (ms != null)
                    ms.Dispose();
                if (cs != null)
                    cs.Dispose();
            }
            return ASCIIEncoding.UTF8.GetString(_result);
        }
#endif
        /// <summary>
        /// Encrypt a string
        /// </summary>
        /// <param name="Password"></param>
        /// <returns></returns>
        private static string Encrypt(string Password)
        {
            if (string.IsNullOrEmpty(Password))
                return string.Empty;
            byte[] Value = Encoding.UTF8.GetBytes(Password);
            SymmetricAlgorithm mCSP = new RijndaelManaged();
            mCSP.Key = _key;
            mCSP.IV = _initVector;
            using (ICryptoTransform ct = mCSP.CreateEncryptor(mCSP.Key, mCSP.IV))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write))
                    {
                        cs.Write(Value, 0, Value.Length);
                        cs.FlushFinalBlock();
                        cs.Close();
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }
        /// <summary>
        /// Looks up the users password crypto string in the database
        /// </summary>
        /// <param name="Username"></param>
        /// <returns></returns>
        private static DataTable LookupUser(string Username)
        {
            /*
             * The reason I return a datatable here is so you can also bring back the user's full
             * name, email address, security rights in the application, etc. I have a "User" class
             * where I defined meta information for users.
             */
            string query = "Select id_usuario,password,nombrelargo From usuario Where login = @UserName";
            DataTable result = new DataTable();
            using (SqlConnection conn = new SqlConnection(Program.cnn212))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = Username;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        result.Load(dr);
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Obviously the .Focus() code doesn't apply to ASP.NET
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void FormLogin_Load(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = '*';
            //txt_username.Text = Properties.Settings.Default.username;
            //txt_pass.Text = Properties.Settings.Default.contraseña;
            //ChkUser.Checked = Properties.Settings.Default.chkuser;
            //ChkPass.Checked = Properties.Settings.Default.chkpass;
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
            //Application.Exit();
            //Console.WriteLine("asdasds");
            ////e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btc_login_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_username.Text))
            {
                //Focus box before showing a message
                txt_username.Focus();
                MessageBox.Show("Enter your username", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Focus again afterwards, sometimes people double click message boxes and select another control accidentally
                txt_username.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txt_pass.Text))
            {
                txt_pass.Focus();
                MessageBox.Show("Enter your password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_pass.Focus();
                return;
            }
            //OK they enter a user and pass, lets see if they can authenticate
            using (DataTable dt = LookupUser(txt_username.Text))
            {
                if (dt.Rows.Count == 0)
                {
                    txt_username.Focus();
                    MessageBox.Show("Invalid username.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Focus();
                    return;
                }
                else
                {
                    //Always compare the resulting crypto string or hash value, never the decrypted value
                    //By doing that you never make a call to Decrypt() and the application is harder to
                    //reverse engineer. I included the Decrypt() method here for informational purposes
                    //only. I do not recommend shipping an assembly with Decrypt() methods.
                    string dbPassword = Convert.ToString(dt.Rows[0]["password"]);
                    id_user = Convert.ToString(dt.Rows[0]["id_usuario"]);
                    nom_usuario = Convert.ToString(dt.Rows[0]["nombrelargo"]);
                    string appPassword = txt_pass.Text; //we store the password as encrypted in the DB
                    if (string.Compare(dbPassword, appPassword) == 0)
                    {
                        //Logged in


                        //try
                        //{
                        //    var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        //    var settings = configFile.AppSettings.Settings;
                        //    if (ChkUser.Checked)
                        //    {
                        //        Properties.Settings.Default.username = txt_username.Text;
                        //        Properties.Settings.Default.chkuser = ChkUser.Checked;
                        //    }
                        //    else
                        //    {
                        //        Properties.Settings.Default.username = "";
                        //        Properties.Settings.Default.chkuser = ChkUser.Checked;
                        //    }
                        //    if (ChkPass.Checked)
                        //    {
                        //        Properties.Settings.Default.contraseña = txt_pass.Text;
                        //        Properties.Settings.Default.chkpass = ChkPass.Checked;
                        //    }
                        //    else
                        //    {
                        //        Properties.Settings.Default.contraseña = "";
                        //        Properties.Settings.Default.chkpass = ChkPass.Checked;
                        //    }
                        //    configFile.Save(ConfigurationSaveMode.Modified);
                        //    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                        //}
                        //catch (ConfigurationErrorsException)
                        //{
                        //    Console.WriteLine("Error writing app settings");
                        //}

                        using (SqlConnection conn = new SqlConnection(Program.cnn67))
                        {
                            string query = "select ac.id_acceso,ac.id_unidad,un.nombre_unidad,ac.nivel from M_RIESGO_accesos ac inner join M_RIESGO_unidad un on ac.id_unidad = un.id_unidad where ac.id_acceso='"+id_user+"';";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            //DataTable dt = new DataTable();
                            DataSet ds = new DataSet();
                            da.Fill(ds, "tabla");
                            //string num;
                            //num = ds.Tables["tabla"].Select("nivel").ToString();
                            foreach (DataRow dr in ds.Tables["tabla"].Rows)
                            {
                                //Muestras los valores obteniendolos con el Índice o el Nombre de la columna, 
                                //   de la siguiente manera:
                                nivel = dr["nivel"].ToString();
                                nom_unidad = dr["nombre_unidad"].ToString();
                                id_unidad = dr["id_unidad"].ToString();
                            }
                        }

                        //FormMenuPrincipal.login = true;
                        this.Hide();
                        FormMenuPrincipal promo = new FormMenuPrincipal();
                        promo.Text = nom_unidad;
                        promo.StartPosition = FormStartPosition.CenterScreen;
                        promo.ShowDialog();

                    }
                    else
                    {
                        //You may want to use the same error message so they can't tell which field they got wrong
                        txt_pass.Focus();
                        MessageBox.Show("Invalid Password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_pass.Focus();
                        return;
                    }
                }
            }

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            //FormMenuPrincipal.login = false;
        }
    }
}
