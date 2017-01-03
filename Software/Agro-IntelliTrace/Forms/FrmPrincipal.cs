using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Agro_IntelliTrace
{
    public partial class FrmPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int IdUsuario { get; set; }
        public FrmPrincipal()
        {
            InitializeComponent();
        }
    }
}