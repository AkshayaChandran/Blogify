using System.Text.RegularExpressions;

namespace Blogify.Helpers
{
    public class RemoveHtmlTagHelper
    {
        public static string RemoveHtmlTags(string input)
        {
            return Regex.Replace(input, "<.*?>|&.*?;>", string.Empty);
        }
    }
}
