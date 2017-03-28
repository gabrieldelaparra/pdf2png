using System.IO;

namespace pdf2png
{
    public static class PDF2PNG
    {
        public static void Convert(FileInfo inputPdfFileInfo, DirectoryInfo outputDirectoryInfo, int dpi)
        {
            var images = new Rasterizer(dpi, dpi).Rasterize(inputPdfFileInfo.FullName);

            Export.SaveImages(images, inputPdfFileInfo, outputDirectoryInfo);
        }
    }
}
