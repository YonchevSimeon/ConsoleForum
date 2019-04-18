namespace Forum.App.ViewModels
{
    using System.Linq;
    using System.Collections.Generic;

    public abstract class ContentViewModel
    {
        private const int lineLength = 37;

        protected ContentViewModel(string content)
        {
            this.Content = this.GetLines(content);
        }

        public string[] Content { get; }

        private string[] GetLines(string content)
        {
            char[] contentChars = content.ToCharArray();

            ICollection<string> lines = new List<string>();

            for (int i = 0; i < content.Length; i += lineLength)
            {
                char[] row = contentChars.Skip(i).Take(lineLength).ToArray();

                string rowString = string.Join("", row);

                lines.Add(rowString);
            }

            return lines.ToArray();
        }
    }
}
