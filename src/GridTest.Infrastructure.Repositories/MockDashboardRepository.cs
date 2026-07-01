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
                new() { Invoice = "12386", Customer = "Charly Dues", From = "Brazil", Price = "$299", Status = "Process", StatusColor = "#F44336" },
                new() { Invoice = "12386", Customer = "Marko", From = "Italy", Price = "$2642", Status = "Open", StatusColor = "#4CAF50" },
                new() { Invoice = "12386", Customer = "Deniyel Onak", From = "Russia", Price = "$981", Status = "On Hold", StatusColor = "#2196F3" },
                new() { Invoice = "12386", Customer = "Belgiri Bastana", From = "Korea", Price = "$369", Status = "Process", StatusColor = "#F44336" },
                new() { Invoice = "12386", Customer = "Sarti Onuska", From = "Japan", Price = "$1240", Status = "Open", StatusColor = "#4CAF50" }
            },

            CardMetrics = new List<CardMetric>
            {
                new() { Title = "Revenue Status", Value = "$4,567.53", Trend = " $432", AccentColor = "#4A90D9", BackgroundColor = "#E3F2FD" },
                new() { Title = "Page View", Value = "$1,689.53", Trend = " $432", AccentColor = "#FFC107", BackgroundColor = "#FFFDE7" },
                new() { Title = "Bounce Rate", Value = "$2,851.53", Trend = " $432", AccentColor = "#FF5722", BackgroundColor = "#FDF2E9" },
                new() { Title = "Revenue Status", Value = "$52,567.53", Trend = " $432", AccentColor = "#9C27B0", BackgroundColor = "#F3E5F5" }
            },

            MiniCardMetrics = new List<MiniCardMetric>
            {
                new() { Icon = "💰", Label = "Wallet Balance", Value = "$4,567.53", Color = "#FF3B30" },
                new() { Icon = "❤️", Label = "Referral Earning", Value = "$1,689.53", Color = "#4A90D9" },
                new() { Icon = "📈", Label = "Estimate Sales", Value = "$2,851.53", Color = "#4CAF50" },
                new() { Icon = "🥧", Label = "Earning", Value = "$52,567.53", Color = "#E91E63" }
            }
        };

        return Task.FromResult(metrics);
    }
}
