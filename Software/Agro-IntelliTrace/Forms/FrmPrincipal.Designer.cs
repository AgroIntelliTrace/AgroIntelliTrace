namespace Agro_IntelliTrace
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.SkinForm = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage7 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage8 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage9 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage10 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage11 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage12 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage13 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage14 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage15 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.AutoSizeItems = true;
            this.ribbon.ButtonGroupsLayout = DevExpress.XtraBars.ButtonGroupsLayout.TwoRows;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem1,
            this.ribbonGalleryBarItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3,
            this.ribbonPage6,
            this.ribbonPage7,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage8,
            this.ribbonPage9,
            this.ribbonPage10,
            this.ribbonPage11,
            this.ribbonPage12,
            this.ribbonPage13,
            this.ribbonPage14,
            this.ribbonPage15,
            this.ribbonPage2});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Size = new System.Drawing.Size(921, 147);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.CloseRadialMenuOnItemClick = true;
            // 
            // 
            // 
            this.skinRibbonGalleryBarItem1.Gallery.ImageSize = new System.Drawing.Size(48, 48);
            this.skinRibbonGalleryBarItem1.Id = 1;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "InplaceGallery1";
            this.ribbonGalleryBarItem1.Id = 2;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Seguridad";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Compras";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 417);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(921, 32);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // SkinForm
            // 
            this.SkinForm.EnableBonusSkins = true;
            this.SkinForm.LookAndFeel.SkinName = "Office 2010 Black";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage4.Image")));
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Cuentas x Cobrar";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage5.Image")));
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Cuentas x Pagar";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage6.Image")));
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Costos";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Interfaz";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Apariencia";
            // 
            // ribbonPage7
            // 
            this.ribbonPage7.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage7.Image")));
            this.ribbonPage7.Name = "ribbonPage7";
            this.ribbonPage7.Text = "Inventarios";
            // 
            // ribbonPage8
            // 
            this.ribbonPage8.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage8.Image")));
            this.ribbonPage8.Name = "ribbonPage8";
            this.ribbonPage8.Text = "Bancos";
            // 
            // ribbonPage9
            // 
            this.ribbonPage9.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage9.Image")));
            this.ribbonPage9.Name = "ribbonPage9";
            this.ribbonPage9.Text = "Contabilidad";
            // 
            // ribbonPage10
            // 
            this.ribbonPage10.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage10.Image")));
            this.ribbonPage10.Name = "ribbonPage10";
            this.ribbonPage10.Text = "Contabilidad Fiscal";
            // 
            // ribbonPage11
            // 
            this.ribbonPage11.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage11.Image")));
            this.ribbonPage11.Name = "ribbonPage11";
            this.ribbonPage11.Text = "Presupuestos";
            // 
            // ribbonPage12
            // 
            this.ribbonPage12.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage12.Image")));
            this.ribbonPage12.Name = "ribbonPage12";
            this.ribbonPage12.Text = "Activos";
            // 
            // ribbonPage13
            // 
            this.ribbonPage13.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage13.Image")));
            this.ribbonPage13.Name = "ribbonPage13";
            this.ribbonPage13.Text = "Facturacion";
            // 
            // ribbonPage14
            // 
            this.ribbonPage14.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage14.Image")));
            this.ribbonPage14.Name = "ribbonPage14";
            this.ribbonPage14.Text = "AgroQuimicos";
            // 
            // ribbonPage15
            // 
            this.ribbonPage15.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage15.Image")));
            this.ribbonPage15.Name = "ribbonPage15";
            this.ribbonPage15.Text = "Empaque / Embarques";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Agro-IntelliTrace";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel SkinForm;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage8;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage9;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage10;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage11;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage12;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage13;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage14;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage15;
    }
}