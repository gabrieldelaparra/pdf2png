using CommandLine;
using CommandLine.Text;

namespace pdf2png
{
    internal class Options
    {
        [Option('i', "input", Required = true,
            HelpText = "Input file to be processed.")]
        public string InputPDFFile { get; set; }

        [Option('o', "output", Required = true,
            HelpText = "Output directory for output files.")]
        public string OutputDirectory { get; set; }

        [Option('v', "verbose", DefaultValue = true,
            HelpText = "Prints all messages to standard output.")]
        public bool Verbose { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, current => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}