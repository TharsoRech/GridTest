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
                new() { Title = "Revenue Status", Trend = " $432", SubText = "Jan 01 - Jan 10", ChartType = "bar", AccentColor = "#4A90D9", BackgroundColor = "#E3F2FD", BarValues = new List<double> { 60, 35, 80, 45, 70 } },
                new() { Title = "Page View", Trend = " $432", ChartType = "line", AccentColor = "#FFC107", BackgroundColor = "#FFFDE7", PathData = "M 0,30 L 20,10 L 40,25 L 60,5 L 80,20 L 100,8 L 120,15" },
                new() { Title = "Bounce Rate", Trend = " $432", SubText = "Monthly", ChartType = "spline", AccentColor = "#FF5722", BackgroundColor = "#FDF2E9", PathData = "M 0,25 Q 15,10 30,20 T 60,15 T 90,10 T 120,18", PickerOptions = new List<string> { "Daily", "Weekly", "Monthly", "Yearly" }, SelectedOptionIndex = 2 },
                new() { Title = "Revenue Status", Trend = " $432", SubText = "Jan 01 - Jan 10", ChartType = "bar", AccentColor = "#9C27B0", BackgroundColor = "#F3E5F5", BarValues = new List<double> { 50, 75, 30, 65, 85 } }
            },

            MiniCardMetrics = new List<MiniCardMetric>
            {
                new() { Icon = "💰", Label = "Wallet Balance", Value = "$4,567.53", Color = "#FF3B30", BackgroundColor = "#FFEBEE" },
                new() { Icon = "❤️", Label = "Referral Earning", Value = "$1,689.53", Color = "#4A90D9", BackgroundColor = "#E3F2FD" },
                new() { Icon = "📈", Label = "Estimate Sales", Value = "$2,851.53", Color = "#4CAF50", BackgroundColor = "#E8F5E9" },
                new() { Icon = "🥧", Label = "Earning", Value = "$52,567.53", Color = "#E91E63", BackgroundColor = "#FCE4EC" }
            },

            PeriodMetrics = new Dictionary<string, PeriodMetrics>
            {
                ["DAILY"] = new PeriodMetrics
                {
                    PeriodName = "DAILY",
                    TotalEarnings = 1245.50m,
                    TotalSales = 28,
                    EarningsLabel = "Today's Earnings",
                    SalesLabel = "Today's Sales",
                    ButtonText = "Yesterday Summary",
                    XAxisLabels = new List<string> { "6am", "9am", "12pm", "3pm", "6pm", "9pm" },
                    YAxisValues = new List<double> { 0, 50, 100, 150, 200 },
                    EarningsChartData = new List<ChartDataPoint>
                    {
                        new() { Label = "6am", Value = 20 },
                        new() { Label = "9am", Value = 85 },
                        new() { Label = "12pm", Value = 150 },
                        new() { Label = "3pm", Value = 120 },
                        new() { Label = "6pm", Value = 180 },
                        new() { Label = "9pm", Value = 95 }
                    },
                    SalesChartData = new List<ChartDataPoint>
                    {
                        new() { Label = "6am", Value = 10 },
                        new() { Label = "9am", Value = 45 },
                        new() { Label = "12pm", Value = 80 },
                        new() { Label = "3pm", Value = 65 },
                        new() { Label = "6pm", Value = 100 },
                        new() { Label = "9pm", Value = 55 }
                    }
                },
                ["WEEKLY"] = new PeriodMetrics
                {
                    PeriodName = "WEEKLY",
                    TotalEarnings = 8734.25m,
                    TotalSales = 156,
                    EarningsLabel = "This Week Earnings",
                    SalesLabel = "This Week Sales",
                    ButtonText = "Last Week Summary",
                    XAxisLabels = new List<string> { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" },
                    YAxisValues = new List<double> { 0, 500, 1000, 1500, 2000 },
                    EarningsChartData = new List<ChartDataPoint>
                    {
                        new() { Label = "Mon", Value = 1200 },
                        new() { Label = "Tue", Value = 1800 },
                        new() { Label = "Wed", Value = 1500 },
                        new() { Label = "Thu", Value = 1900 },
                        new() { Label = "Fri", Value = 1700 },
                        new() { Label = "Sat", Value = 800 },
                        new() { Label = "Sun", Value = 600 }
                    },
                    SalesChartData = new List<ChartDataPoint>
                    {
                        new() { Label = "Mon", Value = 800 },
                        new() { Label = "Tue", Value = 1200 },
                        new() { Label = "Wed", Value = 1000 },
                        new() { Label = "Thu", Value = 1400 },
                        new() { Label = "Fri", Value = 1100 },
                        new() { Label = "Sat", Value = 500 },
                        new() { Label = "Sun", Value = 400 }
                    }
                },
                ["MONTHLY"] = new PeriodMetrics
                {
                    PeriodName = "MONTHLY",
                    TotalEarnings = 34568.96m,
                    TotalSales = 682,
                    EarningsLabel = "This Month Earnings",
                    SalesLabel = "This Month Sales",
                    ButtonText = "Last Month Summary",
                    XAxisLabels = new List<string> { "Week 1", "Week 2", "Week 3", "Week 4" },
                    YAxisValues = new List<double> { 0, 2000, 4000, 6000, 8000, 10000 },
                    EarningsChartData = new List<ChartDataPoint>
                    {
                        new() { Label = "Week 1", Value = 7500 },
                        new() { Label = "Week 2", Value = 9200 },
                        new() { Label = "Week 3", Value = 8800 },
                        new() { Label = "Week 4", Value = 9068 }
                    },
                    SalesChartData = new List<ChartDataPoint>
                    {
                        new() { Label = "Week 1", Value = 150 },
                        new() { Label = "Week 2", Value = 180 },
                        new() { Label = "Week 3", Value = 175 },
                        new() { Label = "Week 4", Value = 177 }
                    }
                },
                ["YEARLY"] = new PeriodMetrics
                {
                    PeriodName = "YEARLY",
                    TotalEarnings = 425680.50m,
                    TotalSales = 8542,
                    EarningsLabel = "This Year Earnings",
                    SalesLabel = "This Year Sales",
                    ButtonText = "Last Year Summary",
                    XAxisLabels = new List<string> { "Jan", "Mar", "May", "Jul", "Sep", "Nov" },
                    YAxisValues = new List<double> { 0, 10000, 20000, 30000, 40000, 50000 },
                    EarningsChartData = new List<ChartDataPoint>
                    {
                        new() { Label = "Jan", Value = 28000 },
                        new() { Label = "Mar", Value = 35000 },
                        new() { Label = "May", Value = 42000 },
                        new() { Label = "Jul", Value = 38000 },
                        new() { Label = "Sep", Value = 45000 },
                        new() { Label = "Nov", Value = 48000 }
                    },
                    SalesChartData = new List<ChartDataPoint>
                    {
                        new() { Label = "Jan", Value = 550 },
                        new() { Label = "Mar", Value = 720 },
                        new() { Label = "May", Value = 880 },
                        new() { Label = "Jul", Value = 790 },
                        new() { Label = "Sep", Value = 950 },
                        new() { Label = "Nov", Value = 1020 }
                    }
                }
            }
        };

        return Task.FromResult(metrics);
    }
}
