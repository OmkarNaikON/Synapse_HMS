using System.Data.SQLite;
using System.IO;

namespace HMS.UI
{
    public partial class LoginForm : Form
    {
        private void CreateDatabase()
        {
            string folder = Path.Combine(Application.StartupPath, "Database");
            string db = Path.Combine(folder, "HMS.db");

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            if (!File.Exists(db))
                SQLiteConnection.CreateFile(db);

            using var con = new SQLiteConnection($"Data Source={db}");
            con.Open();

            string sql = @"CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT,
                    Password TEXT
                  )";

            new SQLiteCommand(sql, con).ExecuteNonQuery();

            string admin = @"INSERT INTO Users (Username,Password)
                     SELECT 'admin','admin123'
                     WHERE NOT EXISTS
                     (SELECT 1 FROM Users WHERE Username='admin')";

            new SQLiteCommand(admin, con).ExecuteNonQuery();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            CreateDatabase();
        }

        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string db = Path.Combine(Application.StartupPath, "Database", "HMS.db");

            using (var con = new SQLiteConnection($"Data Source={db}"))
            {
                con.Open();

                string q = "SELECT 1 FROM Users WHERE Username=@u AND Password=@p";
                var cmd = new SQLiteCommand(q, con);
                cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);

                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("Login Successful");

                    // ?????? THIS IS WHERE IT GOES
                    DashboardForm dashboard = new DashboardForm();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login");
                }
            }
        }



    }
}
