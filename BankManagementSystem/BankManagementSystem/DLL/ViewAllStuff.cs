using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManagementSystem.DAL;

namespace BankManagementSystem.DLL
{
    public partial class ViewAllStuff : UserControl
    {
        public ViewAllStuff()
        {
            InitializeComponent();
        }

        private void ViewAllStuff_Load(object sender, EventArgs e)
        {
            using (var db = new DBContexDataContext())
            {
                this.dataGridView.DataSource = db.stuffs;
            }
        }
    }
}
