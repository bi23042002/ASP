namespace Demo_Session3_MVC.Helpers
{
    public class FileHelper
    {
        public static string generateFileName(string fileName)
        {
            // photo1.doc.txt.gif.png
            var name = Guid.NewGuid().ToString().Replace("-", "");
            var lastIndex = fileName.LastIndexOf(".");
            var ext = fileName.Substring(lastIndex);
            return name + ext;
        }
    }
}
