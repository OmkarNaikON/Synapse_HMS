using System.Data;
using System.Data.SQLite;
using System.IO;

namespace HMS.UI
{
    public partial class OPDRegistrationForm : Form
    {
        public OPDRegistrationForm()
        {
            InitializeComponent();
        }

        private void CreatePatientTable()
        {
            string dbPath = Path.Combine(Application.StartupPath, "Database", "HMS.db");

            using (var con = new SQLiteConnection($"Data Source={dbPath}"))
            {
                con.Open();

                string sql = @"CREATE TABLE IF NOT EXISTS Patients (
                        PatientId INTEGER PRIMARY KEY AUTOINCREMENT,
                        UHID TEXT,
                        Name TEXT,
                        Age INTEGER,
                        Gender TEXT,
                        Mobile TEXT,
                        Address TEXT,
                        VisitDate TEXT
                      )";

                new SQLiteCommand(sql, con).ExecuteNonQuery();
            }
        }

        private void OPDRegistrationForm_Load(object sender, EventArgs e)
        {
            CreatePatientTable();
            LoadPatients();
        }
        private string GenerateUHID()
        {
            return "UHID-" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string dbPath = Path.Combine(Application.StartupPath, "Database", "HMS.db");
            string uhid = GenerateUHID();

            using (var con = new SQLiteConnection($"Data Source={dbPath}"))
            {
                con.Open();

                string sql = @"INSERT INTO Patients
                      (UHID, Name, Age, Gender, Mobile, Address, VisitDate)
                       VALUES
                      (@uhid,@name,@age,@gender,@mobile,@address,@date)";

                var cmd = new SQLiteCommand(sql, con);
                cmd.Parameters.AddWithValue("@uhid", uhid);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Patient Registered Successfully");
            ClearForm();
            LoadPatients();
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtAge.Clear();
            txtMobile.Clear();
            txtAddress.Clear();
            cmbGender.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void LoadPatients()
        {
            string dbPath = Path.Combine(Application.StartupPath, "Database", "HMS.db");

            using (var con = new SQLiteConnection($"Data Source={dbPath}"))
            {
                con.Open();

                string sql = "SELECT UHID, Name, Age, Gender, Mobile, VisitDate FROM Patients";
                var da = new SQLiteDataAdapter(sql, con);
                var dt = new DataTable();
                da.Fill(dt);

                dgvPatients.DataSource = dt;
            }
        }

    }
}
