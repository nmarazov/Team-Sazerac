namespace OOPTeamwork.Common
{
    using System.Drawing;
    using System.IO;

    public static class Images
    {
        public static string path = Directory.GetCurrentDirectory();
        // heare need Valiadtion

        public static Bitmap imageBack = new Bitmap(path + @"\..\..\..\images\boardSmall.tif");
        public static Bitmap imageO = new Bitmap(path + @"\..\..\..\images\basicO.tif");
        public static Bitmap imageX = new Bitmap(path + @"\..\..\..\images\basicX.tif");
    }
}
