using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using GridTest.Models;

namespace GridTest.ViewModels;

public class MainPageViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    // ==================== EARNINGS & SALES ====================
    private string _totalEarnings = "$3468.96";
    public string TotalEarnings
    {
        get => _totalEarnings;
        set { _totalEarnings = value; OnPropertyChanged(); }
    }

    private string _totalSales = "82";
    public string TotalSales
    {
        get => _totalSales;
        set { _totalSales = value; OnPropertyChanged(); }
    }

    // ==================== RECENT ACTIVITIES ====================
    public ObservableCollection<ActivityItem> RecentActivities { get; set; }

    // ==================== ORDER STATUS ====================
    public ObservableCollection<OrderItem> OrderStatusItems { get; set; }

    // ==================== CHART DATA ====================
    public ObservableCollection<ChartDataPoint> MainChartData { get; set; }
    public ObservableCollection<ChartDataPoint> MainChartDataSeries2 { get; set; }

    // ==================== SIDEBAR MENU ====================
    public List<string> SidebarMenuItems { get; set; }

    public MainPageViewModel()
    {
        RecentActivities = new ObservableCollection<ActivityItem>
        {
            new ActivityItem
            {
                TimeAgo = "5 min ago",
                Title = "Task Updated",
                Description = "Task has been updated successfully",
                ColorHex = "#3B82F6",
                Icon = "✓"
            },
            new ActivityItem
            {
                TimeAgo = "12 min ago",
                Title = "Deal Added",
                Description = "New deal has been added to pipeline",
                ColorHex = "#10B981",
                Icon = "+"
            },
            new ActivityItem
            {
                TimeAgo = "25 min ago",
                Title = "Published Article",
                Description = "Article has been published on blog",
                ColorHex = "#F59E0B",
                Icon = "📄"
            },
            new ActivityItem
            {
                TimeAgo = "1 hour ago",
                Title = "Dock Updated",
                Description = "Documentation has been updated",
                ColorHex = "#8B5CF6",
                Icon = "↻"
            },
            new ActivityItem
            {
                TimeAgo = "2 hours ago",
                Title = "Replyed Comment",
                Description = "New comment reply has been posted",
                ColorHex = "#EC4899",
                Icon = "💬"
            }
        };

        OrderStatusItems = new ObservableCollection<OrderItem>
        {
            new OrderItem
            {
                Invoice = "#12336",
                Customer = "Charty Duns",
                From = "Brazil",
                Price = "$2,299",
                Status = "Pending",
                StatusColor = "#F59E0B"
            },
            new OrderItem
            {
                Invoice = "#12337",
                Customer = "John Smith",
                From = "USA",
                Price = "$1,850",
                Status = "Success",
                StatusColor = "#10B981"
            },
            new OrderItem
            {
                Invoice = "#12338",
                Customer = "Maria Garcia",
                From = "Spain",
                Price = "$3,100",
                Status = "Success",
                StatusColor = "#10B981"
            },
            new OrderItem
            {
                Invoice = "#12339",
                Customer = "Hans Mueller",
                From = "Germany",
                Price = "$980",
                Status = "Pending",
                StatusColor = "#F59E0B"
            },
            new OrderItem
            {
                Invoice = "#12340",
                Customer = "Yuki Tanaka",
                From = "Japan",
                Price = "$4,500",
                Status = "Success",
                StatusColor = "#10B981"
            }
        };

        MainChartData = new ObservableCollection<ChartDataPoint>
        {
            new ChartDataPoint { XValue = "Jan", YValue = 30 },
            new ChartDataPoint { XValue = "Feb", YValue = 45 },
            new ChartDataPoint { XValue = "Mar", YValue = 35 },
            new ChartDataPoint { XValue = "Apr", YValue = 60 },
            new ChartDataPoint { XValue = "May", YValue = 50 },
            new ChartDataPoint { XValue = "Jun", YValue = 75 },
            new ChartDataPoint { XValue = "Jul", YValue = 65 },
            new ChartDataPoint { XValue = "Aug", YValue = 80 },
            new ChartDataPoint { XValue = "Sep", YValue = 70 },
            new ChartDataPoint { XValue = "Oct", YValue = 90 },
            new ChartDataPoint { XValue = "Nov", YValue = 85 },
            new ChartDataPoint { XValue = "Dec", YValue = 95 }
        };

        MainChartDataSeries2 = new ObservableCollection<ChartDataPoint>
        {
            new ChartDataPoint { XValue = "Jan", YValue = 20 },
            new ChartDataPoint { XValue = "Feb", YValue = 35 },
            new ChartDataPoint { XValue = "Mar", YValue = 25 },
            new ChartDataPoint { XValue = "Apr", YValue = 40 },
            new ChartDataPoint { XValue = "May", YValue = 55 },
            new ChartDataPoint { XValue = "Jun", YValue = 45 },
            new ChartDataPoint { XValue = "Jul", YValue = 60 },
            new ChartDataPoint { XValue = "Aug", YValue = 50 },
            new ChartDataPoint { XValue = "Sep", YValue = 65 },
            new ChartDataPoint { XValue = "Oct", YValue = 55 },
            new ChartDataPoint { XValue = "Nov", YValue = 70 },
            new ChartDataPoint { XValue = "Dec", YValue = 60 }
        };

        SidebarMenuItems = new List<string>
        {
            "Dashboard",
            "Widgets",
            "UI Elements",
            "Advanced UI",
            "Charts",
            "Tables",
            "Popups",
            "Notifications",
            "Icons",
            "Maps",
            "Forms",
            "Calendar"
        };
    }
}
