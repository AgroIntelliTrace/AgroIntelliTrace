using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CapadeDatos;

namespace Agro_IntelliTrace
{
    public partial class Frm_Login : DevExpress.XtraEditors.XtraForm
    {
        int vIdUsuario = 0;
        int vIdPerfil = 0;
        public Boolean habilitado = true;
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = XtraMessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
        private void btnAcceso_Click(object sender, EventArgs e)
        {
            if (btnAcceso.Text == "Acceso")
            {
                if (txtUser.Text != string.Empty && txtPass.Text != string.Empty)
                {
                    Crypto Encrip = new Crypto();
                    SEG_Login sLogin = new SEG_Login() { Correo = txtUser.Text, Contrasenia = Encrip.Encriptar(txtPass.Text) };
                    sLogin.MtdSeleccionarUsuarioLogin();
                    if (sLogin.Exito)
                    {
                        if (sLogin.Datos.Rows.Count > 0)
                        {
                            vIdUsuario = Convert.ToInt32(sLogin.Datos.Rows[0][0].ToString());
                            vIdPerfil = Convert.ToInt32(sLogin.Datos.Rows[0][3].ToString());

                            FrmPrincipal frmP = new FrmPrincipal() { IdUsuario = vIdUsuario };
                            sLogin.IdUsuario = vIdUsuario;
                            //sLogin.MtdModificarUsuarioFechaAcceso();
                            if (sLogin.Exito)
                            {
                                MSRegistro RegIn = new MSRegistro();
                                if (cERecordarContrasenia.Checked)
                                {
                                    RegIn.SaveSetting("Agro_IntelliTrace", "Login", "Email", txtUser.Text);
                                }
                                else
                                {
                                    RegIn.SaveSetting("Agro_IntelliTrace", "Login", "Email", "");
                                }
                                frmP.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Usuario o Contraseña Incorrectos o El Usuario Esta Inactivo");
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Faltan Datos por Capturar Usuario y/o Password");
                }
            }
        }

        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            Frm_Conexiones frm = new Frm_Conexiones();
            frm.ShowDialog();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13 && txtUser.Text!=string.Empty)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && txtPass.Text != string.Empty)
            {
                btnAcceso.Focus();
            }
        }
        
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            cERecordarContrasenia.Enabled = habilitado;
            if (habilitado == true)
            {
                MSRegistro RegOut = new MSRegistro();
                txtUser.Text=RegOut.GetSetting("Agro_IntelliTrace", "Login", "Email");
                cERecordarContrasenia.Checked=true;
            }
            txtUser.Focus();
        }
    }
}