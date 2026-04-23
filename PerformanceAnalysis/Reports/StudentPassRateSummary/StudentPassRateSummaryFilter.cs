namespace PerformanceAnalysis.Reports.StudentPassRateSummary
{
    public class StudentPassRateSummaryFilter
    {
        /// <summary>
        /// ID студента (обязательный параметр). Если не указан, берётся из токена/cookie для студентов
        /// </summary>
        public int? StudentId { get; set; }


    }
}
