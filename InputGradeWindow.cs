
namespace GradeApp
{
    internal class InputGradeWindow
    {
        private string selectedDiscipline;

        public InputGradeWindow(string selectedDiscipline)
        {
            this.selectedDiscipline = selectedDiscipline;
        }

        public int Grade { get; internal set; }

        internal bool ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}