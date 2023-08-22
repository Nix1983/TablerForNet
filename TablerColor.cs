namespace TablerForNet.Tabler
{
    public enum TablerColor
    {
        Default,
        Blue,
        Azure,
        Indigo,
        Purple,
        Pink,
        Red,
        Orange,
        Yellow,
        Lime,
        Green,
        Teal,
        Cyan,
        White,
        Primary,
        Secondary,
        Success,
        Info,
        Warning,
        Danger,
        Light,
        Dark
    }

    public enum ColorType
    {
        Default,
        Outline,
        Ghost
    }

    public static class ColorsExtensions
    {
        public static string GetColorClass(this TablerColor color, string type,
            ColorType colorType = ColorType.Default, string suffix = "")
        {
            var colorClass = $"{type}";

            colorClass += colorType switch
            {
                ColorType.Default => "",
                _ => $"-{Enum.GetName(typeof(ColorType), colorType)?.ToLower()}"
            };

            colorClass = color switch
            {
                TablerColor.Default => "",
                _ => $"{colorClass}-{Enum.GetName(typeof(TablerColor), color)?.ToLower()}"
            };

            if (color != TablerColor.Light && colorClass.ToLower().EndsWith("light"))
            {
                colorClass = colorClass.Replace("light", "-lt", StringComparison.InvariantCultureIgnoreCase);
            }

            if (!string.IsNullOrWhiteSpace(suffix) && !string.IsNullOrWhiteSpace(colorClass))
                colorClass += $"-{suffix}";

            return colorClass;
        }
    }
}