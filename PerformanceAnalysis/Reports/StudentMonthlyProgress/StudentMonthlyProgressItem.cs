namespace PerformanceAnalysis.Reports.StudentMonthyProgress
{
    public class StudentMonthlyProgressItem
    {
        public DateTime Mounth {  get; set; }
        public string MounthLabel { get; set; } = string.Empty;
        public int Score { get; set; }
        public int CumulativeScore { get; set; }
        
    }
}
