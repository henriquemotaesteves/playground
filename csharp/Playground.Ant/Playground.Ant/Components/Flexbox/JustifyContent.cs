namespace Playground.Ant.Components.Flexbox
{
    public sealed class JustifyContent
    {
        public static readonly JustifyContent Start = new("flex-container--justify-content--start");
        public static readonly JustifyContent Center = new("flex-container--justify-content--center");
        public static readonly JustifyContent End = new("flex-container--justify-content--end");

        private JustifyContent(string clazz)
        {
            this.Class = clazz;
        }

        public string Class { get; }
    }
}
