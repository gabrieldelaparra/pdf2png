using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using NLog;

namespace pdf2png
{
    internal static class Export
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        internal static void SaveImages(IEnumerable<Image> images, FileInfo inputPdfFileInfo, DirectoryInfo outputDirectoryInfo)
        {
            foreach (var imageAndIndex in images.Select((image, i) => new { image, i }))
            {
                var newPNGFile = Path.Combine(outputDirectoryInfo.FullName, inputPdfFileInfo.Name.Replace(".pdf", $"_{imageAndIndex.i + 1:000}.png"));
                imageAndIndex.image.Save(newPNGFile);

                logger.Info($"New Image: {newPNGFile}");
            }
        }

        internal static void SaveImages(IEnumerable<Image> images, string inputPdfFilename, string outputDirectory)
        {
            SaveImages(images, new FileInfo(inputPdfFilename), new DirectoryInfo(outputDirectory));
        }

        internal static void SaveImages(IEnumerable<Image> images, Options options)
        {
            SaveImages(images, options.InputPDFFile, options.OutputDirectory);
        }
    }
}
