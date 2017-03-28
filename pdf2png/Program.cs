using System.IO;
using NLog;

namespace pdf2png
{
    class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            var options = new Options();
            if (!CommandLine.Parser.Default.ParseArguments(args, options))
                return;

            if (options.Verbose)
                logger.Info($"Input PDF: {options.InputPDFFile}");

            var inputFile = new FileInfo(options.InputPDFFile);
            if (!inputFile.Exists)
                throw new FileNotFoundException($"File does not exists: {inputFile.FullName}");

            var outputDirectory = new DirectoryInfo(options.OutputDirectory);
            if (!outputDirectory.Exists)
                outputDirectory.Create();

            PDF2PNG.Convert(inputFile, outputDirectory);
        }
    }
}
