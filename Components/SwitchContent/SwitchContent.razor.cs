namespace TablerForNet.Components
{  
    public enum SwitchAnimation
    {
        None = 0,
        Fade = 1,
        Flip = 2,
        Scale = 3,
        SlideUp = 4,
        SlideLeft = 5,
        SlideDown = 6,
        SlideRight = 7
    }

    public static class SwithExtensions
    {

        public static string GetCssClass(this SwitchAnimation animation)
        {
            return animation switch
            {
                SwitchAnimation.Flip => "switch-icon-flip",
                SwitchAnimation.Fade => "switch-icon-fade",
                SwitchAnimation.Scale => "switch-icon-scale",
                SwitchAnimation.SlideUp => "switch-icon-slide-up",
                SwitchAnimation.SlideLeft => "switch-icon-slide-left",
                SwitchAnimation.SlideDown => "switch-icon-slide-down",
                SwitchAnimation.SlideRight => "switch-icon-slide-right",
                _ => "",
            };
        }
    }
}
