namespace SchoolGradeSystem
{
    internal class Exam : IGradeCalculator
    {
        private double _maxMarks;
        private double _marksObtained;

        public double MaxMarks
        {
            get { return _maxMarks; }
            private set { _maxMarks = value; }
        }

        public double MarksObtained
        {
            get { return _marksObtained; }
            private set { _marksObtained = value; }
        }

        public Exam(double maxMarks, double marksObtained)
        {
            MaxMarks = maxMarks;
            MarksObtained = marksObtained;
        }

        public double CalculateGrade()
        {
            return (MarksObtained / MaxMarks * 100);
        }
    }
}
