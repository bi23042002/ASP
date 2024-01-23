namespace Demo_Session3_MVC.Helpers
{
    public class FileHelper
    {
        public static string generateFileName(string filename)
        {
            var lastIndex = filename.LastIndexOf(".");
            var name = Guid.NewGuid().ToString().Replace("-", "");
            var ext = filename.Substring(lastIndex);
            return name + ext;
        }
    }
}
