namespace GridTest.Components;

public partial class CardView
{
    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(nameof(Title), typeof(string), typeof(CardView), string.Empty);

    public static readonly BindableProperty ValueProperty =
        BindableProperty.Create(nameof(Value), typeof(string), typeof(CardView), string.Empty);

    public static readonly BindableProperty TrendProperty =
        BindableProperty.Create(nameof(Trend), typeof(string), typeof(CardView), string.Empty);

    public static readonly BindableProperty SubTextProperty =
        BindableProperty.Create(nameof(SubText), typeof(string), typeof(CardView), string.Empty);

    public static readonly BindableProperty ChartTypeProperty =
        BindableProperty.Create(nameof(ChartType), typeof(string), typeof(CardView), "wave");

    public static readonly BindableProperty PickerOptionsProperty =
        BindableProperty.Create(nameof(PickerOptions), typeof(List<string>), typeof(CardView), new List<string>());

    public static readonly BindableProperty SelectedOptionIndexProperty =
        BindableProperty.Create(nameof(SelectedOptionIndex), typeof(int), typeof(CardView), 0);

    public static readonly BindableProperty PathDataProperty =
        BindableProperty.Create(nameof(PathData), typeof(string), typeof(CardView), string.Empty);

    public static readonly BindableProperty AccentColorProperty =
        BindableProperty.Create(nameof(AccentColor), typeof(Color), typeof(CardView), Colors.Blue);

    public new static readonly BindableProperty BackgroundColorProperty =
        BindableProperty.Create(nameof(BackgroundColor), typeof(Color), typeof(CardView), Colors.White);

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

    public string Trend
    {
        get => (string)GetValue(TrendProperty);
        set => SetValue(TrendProperty, value);
    }

    public string SubText
    {
        get => (string)GetValue(SubTextProperty);
        set => SetValue(SubTextProperty, value);
    }

    public string ChartType
    {
        get => (string)GetValue(ChartTypeProperty);
        set => SetValue(ChartTypeProperty, value);
    }

    public List<string> PickerOptions
    {
        get => (List<string>)GetValue(PickerOptionsProperty);
        set => SetValue(PickerOptionsProperty, value);
    }

    public int SelectedOptionIndex
    {
        get => (int)GetValue(SelectedOptionIndexProperty);
        set => SetValue(SelectedOptionIndexProperty, value);
    }

    public string PathData
    {
        get => (string)GetValue(PathDataProperty);
        set => SetValue(PathDataProperty, value);
    }

    public Color AccentColor
    {
        get => (Color)GetValue(AccentColorProperty);
        set => SetValue(AccentColorProperty, value);
    }

    public new Color BackgroundColor
    {
        get => (Color)GetValue(BackgroundColorProperty);
        set => SetValue(BackgroundColorProperty, value);
    }

    public CardView()
    {
        InitializeComponent();
    }
}
