namespace Playground.Ant.Components.Flexbox
{
    public class Direction
    {
        public static readonly Direction Row = new("flex-container--direction--row");
        public static readonly Direction Column = new("flex-container--direction--column");

        private Direction(string clazz)
        {
            this.Class = clazz;
        }

        public string Class { get; }
    }
}
