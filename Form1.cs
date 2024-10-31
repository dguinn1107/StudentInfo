using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.ComponentModel;

namespace StudentInfo
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "students.json");
        private static readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };

        public Form1()
        {
            InitializeComponent();
            //hi
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentsFromFile();
            InitializeGrid();
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int CensusId { get; set; }
            public string CellPhoneNumber { get; set; }
            public string DegreePursued { get; set; }

            public Student(string firstName, string lastName, int censusId, string cellPhoneNumber, string degreePursued)
            {
                FirstName = firstName;
                LastName = lastName;
                CensusId = censusId;
                CellPhoneNumber = cellPhoneNumber;
                DegreePursued = degreePursued;
            }
        }

        private void InitializeGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new BindingList<Student>(students);
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtCensusId.Text) ||
                string.IsNullOrWhiteSpace(txtCellPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtDegreePursued.Text))
            {
                MessageBox.Show("All fields are required.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsPhoneNumberValid(txtCellPhoneNumber.Text))
            {
                MessageBox.Show("Invalid phone number format.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (!int.TryParse(txtCensusId.Text, out int censusId))
                {
                    MessageBox.Show("Census ID must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var student = new Student(
                    txtFirstName.Text,
                    txtLastName.Text,
                    censusId,
                    txtCellPhoneNumber.Text,
                    txtDegreePursued.Text
                );

                students.Add(student);
                SaveStudentsToFile();
                InitializeGrid();
                ClearTextFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a valid student to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selectedStudent = (Student)dataGridView1.CurrentRow.DataBoundItem;

                var confirmResult = MessageBox.Show($"Are you sure you want to delete {selectedStudent.FirstName} {selectedStudent.LastName}?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    students.Remove(selectedStudent);
                    SaveStudentsToFile();
                    InitializeGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            string pattern = @"^(\(\d{3}\)\s?|\d{3}[-.\s]?)?\d{3}[-.\s]?\d{4}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void ClearTextFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCensusId.Text = "";
            txtCellPhoneNumber.Text = "";
            txtDegreePursued.Text = "";
        }

        private void SaveStudentsToFile()
        {
            try
            {
                string json = JsonSerializer.Serialize(students, jsonOptions);
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving students: " + ex.Message);
            }
        }

        private void LoadStudentsFromFile()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    students = JsonSerializer.Deserialize<List<Student>>(json, jsonOptions) ?? new List<Student>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }
    }
}
