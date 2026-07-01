namespace GridTest.Components;

public partial class CardView : ContentView
{
    // ==================== BINDABLE PROPERTIES ====================

    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(nameof(Title), typeof(string), typeof(CardView), string.Empty);

    public static readonly BindableProperty ValueProperty =
        BindableProperty.Create(nameof(Value), typeof(string), typeof(CardView), string.Empty);

    public static readonly BindableProperty AccentColorProperty =
        BindableProperty.Create(nameof(AccentColor), typeof(Brush), typeof(CardView), new SolidColorBrush(Colors.Blue));

    public static readonly BindableProperty GraphDataProperty =
        BindableProperty.Create(nameof(GraphData), typeof(string), typeof(CardView), string.Empty);

    public static readonly BindableProperty TrendTextProperty =
        BindableProperty.Create(nameof(TrendText), typeof(string), typeof(CardView), string.Empty);

    public static readonly BindableProperty CardBackgroundColorProperty =
        BindableProperty.Create(nameof(CardBackgroundColor), typeof(Color), typeof(CardView), Colors.White);

    // ==================== CLR PROPERTIES ====================

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public string Value
    {
        get => (string)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }

    public Brush AccentColor
    {
        get => (Brush)GetValue(AccentColorProperty);
        set => SetValue(AccentColorProperty, value);
    }

    public string GraphData
    {
        get => (string)GetValue(GraphDataProperty);
        set => SetValue(GraphDataProperty, value);
    }

    public string TrendText
    {
        get => (string)GetValue(TrendTextProperty);
        set => SetValue(TrendTextProperty, value);
    }

    public Color CardBackgroundColor
    {
        get => (Color)GetValue(CardBackgroundColorProperty);
        set => SetValue(CardBackgroundColorProperty, value);
    }

    public CardView()
    {
        InitializeComponent();
    }
}
