using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManagementSystem.DAL;

namespace BankManagementSystem.BLL
{
    public static class dbHandler
    {
        public static void addNewUser(user _user)
        {
            try
            {
                using (var db = new DBContexDataContext())
                {
                    db.users.InsertOnSubmit(_user);
                    db.SubmitChanges();
                    MessageBox.Show("New User Successfully added.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void removeUser(int id)
        {
            try
            {
                using (var db = new DBContexDataContext())
                {
                    db.users.DeleteOnSubmit(db.users.SingleOrDefault(_tempUser => _tempUser.id == id));
                    db.SubmitChanges();
                    MessageBox.Show("User remove successful.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void addNewStuff(stuff _stuff)
        {
            try
            {
                using (var db = new DBContexDataContext())
                {
                    db.stuffs.InsertOnSubmit(_stuff);
                    db.SubmitChanges();
                    MessageBox.Show("New Stuff Successfully added.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void removeStuff(int id)
        {
            try
            {
                using (var db = new DBContexDataContext())
                {
                    db.stuffs.DeleteOnSubmit(db.stuffs.SingleOrDefault(_tempStuff => _tempStuff.id == id));
                    db.SubmitChanges();
                    MessageBox.Show("Stuff remove successful.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void deposit(int id, double amount)
        {
            try
            {
                using (var db = new DBContexDataContext())
                {
                    if (amount > 0)
                    {
                        db.users.SingleOrDefault(_tempUser => _tempUser.id == id).amount += amount;
                        db.SubmitChanges();
                        MessageBox.Show("Deposit successful.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Deposit was unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void withdraw(int id, double amount)
        {
            try
            {
                using (var db = new DBContexDataContext())
                {
                    if (amount > 0 && db.users.SingleOrDefault(_tempUser => _tempUser.id == id).amount >= amount)
                    {
                        db.users.SingleOrDefault(_tempUser => _tempUser.id == id).amount -= amount;
                        db.SubmitChanges();
                        MessageBox.Show("Withdraw successful.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Withdraw was unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
