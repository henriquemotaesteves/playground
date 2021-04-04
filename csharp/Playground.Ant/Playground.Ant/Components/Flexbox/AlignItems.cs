namespace Playground.Ant.Components.Flexbox
{
    public class AlignItems
    {
        public static readonly AlignItems Stretch = new("flex-container--align-items--stretch");
        public static readonly AlignItems Center = new("flex-container--align-items--center");

        private AlignItems(string clazz)
        {
            this.Class = clazz;
        }

        public string Class { get; }
    }
}
