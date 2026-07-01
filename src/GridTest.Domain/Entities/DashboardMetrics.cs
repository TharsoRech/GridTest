namespace GridTest.Domain.Entities;

public class DashboardMetrics
{
    public decimal TotalEarnings { get; set; }
    public string TotalEarningsFormatted => TotalEarnings.ToString("F2");
    public int TotalSales { get; set; }
    public List<ChartDataPoint> EarningsChartData { get; set; } = new();
    public List<ChartDataPoint> SalesChartData { get; set; } = new();
    public List<TrafficDataPoint> TrafficData { get; set; } = new();
    public List<ActivityItem> RecentActivities { get; set; } = new();
    public List<OrderItem> Orders { get; set; } = new();
    public List<CardMetric> CardMetrics { get; set; } = new();
    public List<MiniCardMetric> MiniCardMetrics { get; set; } = new();
}

public class ChartDataPoint
{
    public string Label { get; set; } = string.Empty;
    public double Value { get; set; }
}

public class TrafficDataPoint
{
    public string Label { get; set; } = string.Empty;
    public double Percentage { get; set; }
    public string Color { get; set; } = string.Empty;
}

public class CardMetric
{
    public string Title { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public string Trend { get; set; } = string.Empty;
    public string AccentColor { get; set; } = string.Empty;
    public string BackgroundColor { get; set; } = string.Empty;
}

public class MiniCardMetric
{
    public string Icon { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
}
