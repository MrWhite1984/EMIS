using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Forms.AdminFormDirectory;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataDeleterDescendants.AdminForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.AdminForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataRefresher;

namespace Enterprise_Managment_IS.Classes.FormClasses.AdminForm
{
    class UserPanelClass
    {
        public static void AddUserButton_Click(DataGridView userDataGridView)
        {
            AddNewUserForm addNewUserForm = new AddNewUserForm();
            addNewUserForm.ShowDialog();
            DataRefresher.RefreshTable_Users(userDataGridView, DataLoader_Users.GetAllUsers());
        }
        public static void ChangeUserButton_Click(DataGridView userDataGridView)
        {
            int index = userDataGridView.CurrentRow.Index;
            ChangeUserForm changeUserForm = new ChangeUserForm();
            changeUserForm.index = index;
            changeUserForm.ShowDialog();
            DataRefresher.RefreshTable_Users(userDataGridView, DataLoader_Users.GetAllUsers());
        }
        public static void DeleteUserButton_Click(DataGridView userDataGridView)
        {
            int index = userDataGridView.CurrentRow.Index;
            DataDeleter_Users.DeleteUserFromDB(Convert.ToInt32(DataLoader_Users.GetAllUsers()[index][0]));
            DataRefresher.RefreshTable_Users(userDataGridView, DataLoader_Users.GetAllUsers());
        }
    }
}
