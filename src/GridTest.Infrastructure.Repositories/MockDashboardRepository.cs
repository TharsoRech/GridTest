using GridTest.Domain.Entities;
using GridTest.Domain.Interfaces;

namespace GridTest.Infrastructure.Repositories;

public class MockDashboardRepository : IDashboardRepository
{
    public Task<DashboardMetrics> GetDashboardDataAsync()
    {
        var metrics = new DashboardMetrics
        {
            TotalEarnings = 3468.96m,
            TotalSales = 82,

            EarningsChartData = new List<ChartDataPoint>
            {
                new() { Label = "Jan", Value = 30 },
                new() { Label = "Feb", Value = 55 },
                new() { Label = "Mar", Value = 40 },
                new() { Label = "Apr", Value = 70 },
                new() { Label = "May", Value = 50 },
                new() { Label = "Jun", Value = 85 },
                new() { Label = "Jul", Value = 60 },
                new() { Label = "Aug", Value = 90 },
                new() { Label = "Sep", Value = 75 },
                new() { Label = "Oct", Value = 95 },
                new() { Label = "Nov", Value = 80 },
                new() { Label = "Dec", Value = 100 }
            },

            SalesChartData = new List<ChartDataPoint>
            {
                new() { Label = "Jan", Value = 20 },
                new() { Label = "Feb", Value = 35 },
                new() { Label = "Mar", Value = 50 },
                new() { Label = "Apr", Value = 45 },
                new() { Label = "May", Value = 60 },
                new() { Label = "Jun", Value = 55 },
                new() { Label = "Jul", Value = 70 },
                new() { Label = "Aug", Value = 65 },
                new() { Label = "Sep", Value = 80 },
                new() { Label = "Oct", Value = 75 },
                new() { Label = "Nov", Value = 90 },
                new() { Label = "Dec", Value = 85 }
            },

            TrafficData = new List<TrafficDataPoint>
            {
                new() { Label = "Desktop", Percentage = 34, Color = "#4A90D9" },
                new() { Label = "Mobile", Percentage = 55, Color = "#FF5722" },
                new() { Label = "Tablet", Percentage = 11, Color = "#FFC107" }
            },

            RecentActivities = new List<ActivityItem>
            {
                new() { TimeAgo = "Just now", Title = "Task Updated", Description = "Task has been updated successfully", ColorHex = "#4A90D9", Icon = "📋" },
                new() { TimeAgo = "5 mins ago", Title = "Deal Added", Description = "New deal has been added to the pipeline", ColorHex = "#FF5722", Icon = "💼" },
                new() { TimeAgo = "1 hour ago", Title = "Published Article", Description = "Article has been published successfully", ColorHex = "#4CAF50", Icon = "📄" },
                new() { TimeAgo = "2 hours ago", Title = "Dock Updated", Description = "Dock configuration has been updated", ColorHex = "#9C27B0", Icon = "🔧" },
                new() { TimeAgo = "3 hours ago", Title = "Replyed Comment", Description = "New comment reply has been posted", ColorHex = "#FF9800", Icon = "💬" }
            },

            Orders = new List<OrderItem>
            {
                new() { Invoice = "Invoice 12336", Customer = "Charty Duns", From = "Brazil", Price = "$2299", Status = "Pending", StatusColor = "#FF5722" },
                new() { Invoice = "Invoice 12346", Customer = "Matko", From = "Italy", Price = "$23642", Status = "Done", StatusColor = "#4CAF50" },
                new() { Invoice = "Invoice 12306", Customer = "Denyel", From = "USA", Price = "$3181", Status = "Progress", StatusColor = "#2196F3" },
                new() { Invoice = "Invoice 12586", Customer = "Belgio Bastana", From = "Kenya", Price = "$3369", Status = "Open", StatusColor = "#F44336" },
                new() { Invoice = "Invoice 12311", Customer = "Sarli", From = "Japan", Price = "$13240", Status = "Done", StatusColor = "#4CAF50" }
            },

            CardMetrics = new List<CardMetric>
            {
                new() { Title = "Revenue", Value = "$12,450", AccentColor = "#4A90D9", BackgroundColor = "#E3F2FD" },
                new() { Title = "Orders", Value = "245", AccentColor = "#FFC107", BackgroundColor = "#FFFDE7" },
                new() { Title = "Customers", Value = "1,234", AccentColor = "#FF5722", BackgroundColor = "#FDF2E9" },
                new() { Title = "Growth", Value = "+23%", AccentColor = "#9C27B0", BackgroundColor = "#F3E5F5" }
            }
        };

        return Task.FromResult(metrics);
    }
}
