namespace SchoolGradeSystem
{
    public class Assignment : IGradeCalculator
    {
        private double _maxScore;
        private double _scoreAchieved;

        public double MaxScore
        {
            get { return _maxScore; }
            private set { _maxScore = value; }
        }

        public double ScoreAchieved
        {
            get { return _scoreAchieved; }
            private set { _scoreAchieved = value; }
        }

        public Assignment(double maxScore, double scoreAchieved)
        {
            MaxScore = maxScore;
            ScoreAchieved = scoreAchieved;
        }

        public double CalculateGrade()
        {
            return (ScoreAchieved / MaxScore * 100);
        }
    }
}