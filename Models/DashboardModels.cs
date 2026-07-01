namespace GridTest.Models;

/// <summary>
/// Represents a single data point for chart rendering.
/// </summary>
public class ChartDataPoint
{
    public string XValue { get; set; } = string.Empty;
    public double YValue { get; set; }
}

/// <summary>
/// Represents a recent activity item displayed in the activity timeline.
/// </summary>
public class ActivityItem
{
    public string TimeAgo { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ColorHex { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
}

/// <summary>
/// Represents an order row in the order status table.
/// </summary>
public class OrderItem
{
    public string Invoice { get; set; } = string.Empty;
    public string Customer { get; set; } = string.Empty;
    public string From { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string StatusColor { get; set; } = string.Empty;
}
