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
    public partial class ViewAllUser : UserControl
    {
        public ViewAllUser()
        {
            InitializeComponent();
        }

        private void ViewAllUser_Load(object sender, EventArgs e)
        {
            using (var db = new DBContexDataContext())
            {
                this.dataGridView.DataSource = db.users;
            }
        }
    }
}
