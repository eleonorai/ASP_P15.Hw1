using System.Text;

namespace ASP_P15.Services.FileName
{
    public class FileNameService : IFileNameService
    {
        private static readonly Random rnd = new Random();
        private static readonly string lowerChars = "abcdefghijklmnopqrstuvwxyz";
        private static readonly string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly string numberChars = "0123456789";

        public string GenerateRandomFileName(int length,
            bool includeUpperCase = false, bool includeNumbers = false)
        {
            string chars = lowerChars;

            if (includeUpperCase)
                chars += upperChars;

            if (includeNumbers)
                chars += numberChars;

            var sb = new StringBuilder(length);

            for (int i = 0; i < length; i++)
                sb.Append(chars[rnd.Next(chars.Length)]);

            return sb.ToString();
        }
    }
}
