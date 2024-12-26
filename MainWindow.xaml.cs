using System.Windows;
using SemestroviiKontrol;

namespace GradeApp
{
    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAddGrade_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Пожалуйста, введите фамилию и имя студента.");
                return;
            }

            var selectedDiscipline = cbDiscipline.SelectedValue as string;
            if (selectedDiscipline == null)
            {
                MessageBox.Show("Пожалуйста, выберите дисциплину.");
                return;
            }


            var student = students.Find(s => s.LastName == txtLastName.Text && s.FirstName == txtFirstName.Text);
            if (student == null)
            {
                student = new Student
                {
                    LastName = txtLastName.Text,
                    FirstName = txtFirstName.Text
                };
                students.Add(student);
            }


            var gradeInput = new InputGradeWindow(selectedDiscipline);
            if (gradeInput.ShowDialog() == true)
            {
                int grade = gradeInput.Grade;
                if (!student.Grades.ContainsKey(selectedDiscipline))
                {
                    student.Grades.Add(selectedDiscipline, grade);
                }
                else
                { }
            }
        }
    }
}