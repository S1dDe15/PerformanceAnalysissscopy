namespace PerformanceAnalysis.Infrastructure.Reports
{
    /// <summary>
    /// Обёртка над Dapper-методами. Позволяет мокать Dapper в unit-тестах,
    /// т.к. extension-методы Dapper нельзя мокать напрямую.
    /// </summary>

    public interface IDapperExecutor
    {
        Task<IEnumerable<T>> QueryAsync<T>(string sql, object? param = null);
        Task<T?> QueryFirstOrDefaultAsync<T>(string sql, object? param = null);

    }
}
