using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPersonas
{
    public partial class FrmVisorDataTable : frmVisorPersona
    {
        private DataTable dataTable;

        public FrmVisorDataTable(DataTable dt) : base()
        {
            InitializeComponent();
            dataTable = dt;
        }

        
    }
}
