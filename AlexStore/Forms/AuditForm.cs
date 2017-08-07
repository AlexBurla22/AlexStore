using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectDB;

namespace AlexStore.Forms
{
    public partial class AuditForm : Form
    {
        DataTable audit;

        public AuditForm()
        {
            InitializeComponent();
            audit = ConnectSQL.ReturnDataTable("GetAudit");
            dataAuditView.DataSource = audit;
        }

    }
}
