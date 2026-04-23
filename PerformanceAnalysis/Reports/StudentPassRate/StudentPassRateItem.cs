namespace PerformanceAnalysis.Reports.StudentPassRate
{
    public class StudentPassRateItem
    {
        public int StudentId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Group { get; set; } = string.Empty;
        public int TestAvailable { get; set; }
        public int TestPassed { get; set; }
        public decimal PassRate { get; set; }
    }
}
