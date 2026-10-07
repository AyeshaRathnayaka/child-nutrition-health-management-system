using System.Windows.Forms;

namespace child_clinic
{
    public static class NavigationHelper
    {
        // Logout
        public static void Logout(Form currentForm)
        {
            Session.UserId = 0;
            Session.FullName = "";
            Session.Role = "";

            LoginForm login = new LoginForm();
            login.Show();

            currentForm.Close();
        }

        // Dashboard
        public static void OpenDashboard(Form currentForm)
        {
            dashboard db = new dashboard();
            db.Show();

            currentForm.Close();


        }

        // Child List
        public static void OpenChildList(Form currentForm)
        {
            Child_List child = new Child_List();
            child.Show();

            currentForm.Close();

        }

        // Mother List
        public static void OpenMotherList(Form currentForm)
        {
            Mother_List mother = new Mother_List();
            mother.Show();

            currentForm.Close();
        }
    }
}