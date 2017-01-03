namespace AvoTrace
{
    partial class Frm_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.SkinForm = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnAcceso = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblRecupera = new DevExpress.XtraEditors.LabelControl();
            this.txtRecPass = new DevExpress.XtraEditors.TextEdit();
            this.lblConfirma = new DevExpress.XtraEditors.LabelControl();
            this.txtConfimPass = new DevExpress.XtraEditors.TextEdit();
            this.cERecordarContrasenia = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfimPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cERecordarContrasenia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.Properties.InitialImage")));
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(140, 140);
            this.pictureEdit1.TabIndex = 6;
            this.pictureEdit1.DoubleClick += new System.EventHandler(this.pictureEdit1_DoubleClick);
            // 
            // SkinForm
            // 
            this.SkinForm.EnableBonusSkins = true;
            this.SkinForm.LookAndFeel.SkinName = "VS2010";
            // 
            // btnAcceso
            // 
            this.btnAcceso.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceso.Appearance.Options.UseFont = true;
            this.btnAcceso.Image = ((System.Drawing.Image)(resources.GetObject("btnAcceso.Image")));
            this.btnAcceso.Location = new System.Drawing.Point(521, 22);
            this.btnAcceso.Name = "btnAcceso";
            this.btnAcceso.Size = new System.Drawing.Size(109, 51);
            this.btnAcceso.TabIndex = 4;
            this.btnAcceso.Text = "Acceso";
            this.btnAcceso.Click += new System.EventHandler(this.btnAcceso_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Appearance.Options.UseFont = true;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(521, 80);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 51);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(311, 24);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(170, 20);
            this.txtUser.TabIndex = 0;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            // 
            // txtPass
            // 
            this.txtPass.EditValue = "abcdefg";
            this.txtPass.Location = new System.Drawing.Point(311, 53);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(170, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(175, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Usuario:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(175, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Contraseña:";
            // 
            // lblRecupera
            // 
            this.lblRecupera.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecupera.Location = new System.Drawing.Point(175, 89);
            this.lblRecupera.Name = "lblRecupera";
            this.lblRecupera.Size = new System.Drawing.Size(130, 13);
            this.lblRecupera.TabIndex = 8;
            this.lblRecupera.Text = "Recuperar Contraseña:";
            this.lblRecupera.Visible = false;
            // 
            // txtRecPass
            // 
            this.txtRecPass.EditValue = "";
            this.txtRecPass.Location = new System.Drawing.Point(311, 82);
            this.txtRecPass.Name = "txtRecPass";
            this.txtRecPass.Properties.PasswordChar = '*';
            this.txtRecPass.Size = new System.Drawing.Size(170, 20);
            this.txtRecPass.TabIndex = 2;
            this.txtRecPass.Visible = false;
            this.txtRecPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRecPass_KeyDown);
            // 
            // lblConfirma
            // 
            this.lblConfirma.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirma.Location = new System.Drawing.Point(175, 118);
            this.lblConfirma.Name = "lblConfirma";
            this.lblConfirma.Size = new System.Drawing.Size(127, 13);
            this.lblConfirma.TabIndex = 10;
            this.lblConfirma.Text = "Confirmar Contraseña:";
            this.lblConfirma.Visible = false;
            // 
            // txtConfimPass
            // 
            this.txtConfimPass.EditValue = "";
            this.txtConfimPass.Location = new System.Drawing.Point(311, 111);
            this.txtConfimPass.Name = "txtConfimPass";
            this.txtConfimPass.Properties.PasswordChar = '*';
            this.txtConfimPass.Size = new System.Drawing.Size(170, 20);
            this.txtConfimPass.TabIndex = 3;
            this.txtConfimPass.Visible = false;
            this.txtConfimPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfimPass_KeyDown);
            // 
            // cERecordarContrasenia
            // 
            this.cERecordarContrasenia.Enabled = false;
            this.cERecordarContrasenia.Location = new System.Drawing.Point(311, 86);
            this.cERecordarContrasenia.Name = "cERecordarContrasenia";
            this.cERecordarContrasenia.Properties.Caption = "Recordar Contraseña";
            this.cERecordarContrasenia.Size = new System.Drawing.Size(131, 19);
            this.cERecordarContrasenia.TabIndex = 12;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 164);
            this.Controls.Add(this.cERecordarContrasenia);
            this.Controls.Add(this.lblConfirma);
            this.Controls.Add(this.txtConfimPass);
            this.Controls.Add(this.lblRecupera);
            this.Controls.Add(this.txtRecPass);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAcceso);
            this.Controls.Add(this.pictureEdit1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso AvoTrace";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfimPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cERecordarContrasenia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel SkinForm;
        private DevExpress.XtraEditors.SimpleButton btnAcceso;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblRecupera;
        private DevExpress.XtraEditors.TextEdit txtRecPass;
        private DevExpress.XtraEditors.LabelControl lblConfirma;
        private DevExpress.XtraEditors.TextEdit txtConfimPass;
        private DevExpress.XtraEditors.CheckEdit cERecordarContrasenia;
    }
}