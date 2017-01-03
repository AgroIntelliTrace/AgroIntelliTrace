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
using CapaDatosAvotrace;

namespace AvoTrace
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
                            //if (Convert.ToBoolean(sLogin.Datos.Rows[0][2].ToString()))
                            //{
                            //    txtPass.Enabled = false;
                            //    txtRecPass.Visible = true;
                            //    txtConfimPass.Visible = true;
                            //    lblRecupera.Visible = true;
                            //    lblConfirma.Visible = true;
                            //    btnAcceso.Text = "Cambiar";
                            //    txtRecPass.Focus();
                            //}
                            //else
                            //{
                                Frm_Principal frmP = new Frm_Principal() {IdUsuario = vIdUsuario};
                                sLogin.IdUsuario = vIdUsuario;
                                //sLogin.MtdModificarUsuarioFechaAcceso();
                                if (sLogin.Exito)
                                {
                                    MSRegistro RegIn = new MSRegistro();
                                    if (cERecordarContrasenia.Checked)
                                    {
                                        RegIn.SaveSetting("Avotrace", "Login", "Email", txtUser.Text);
                                    }else
                                    {
                                        RegIn.SaveSetting("Avotrace", "Login", "Email", "");
                                    }
                                    frmP.Show();
                                    this.Hide();
                                }
                            //}
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
            else
            {
                if (txtUser.Text != string.Empty)
                {
                    if (txtRecPass.Text != string.Empty && txtConfimPass.Text != string.Empty)
                    {
                        if(txtRecPass.Text==txtConfimPass.Text)
                        {
                            Crypto Encrip = new Crypto();
                            SEG_Login sLogin = new SEG_Login() { IdUsuario = vIdUsuario, Contrasenia = Encrip.Encriptar(txtRecPass.Text), IsRestablecerContrasenia = 0 };
                            sLogin.MtdModificarUsuarioRestablecerContrasenia();
                            if(sLogin.Exito)
                            {
                                Application.Restart();
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Recuparar Password y Confirmar Password no son Iguales");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Recuperar Password y/o Confirmar Password no pueden estar sin Datos");
                    }
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
                if (btnAcceso.Text == "Acceso")
                {
                    btnAcceso.Focus();
                }
                else
                {
                    txtRecPass.Focus();
                }
            }
        }

        private void txtRecPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && txtRecPass.Text != string.Empty)
            {
                txtConfimPass.Focus();
            }

        }

        private void txtConfimPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && txtConfimPass.Text != string.Empty)
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
                txtUser.Text=RegOut.GetSetting("Avotrace", "Login", "Email");
                cERecordarContrasenia.Checked=true;
            }
            txtUser.Focus();
        }
    }
}