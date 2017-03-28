using System.Collections.Generic;
using System.Drawing;
using Ghostscript.NET;
using Ghostscript.NET.Rasterizer;

namespace pdf2png
{
    public class Rasterizer
    {
        private readonly int _desiredXDpi;
        private readonly int _desiredYDpi;
        private readonly GhostscriptVersionInfo _lastInstalledVersion;
        private readonly GhostscriptRasterizer _rasterizer;

        public Rasterizer(int xDpi = 96, int yDpi = 96)
        {
            _desiredXDpi = xDpi;
            _desiredYDpi = yDpi;

            // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
            _lastInstalledVersion = GhostscriptVersionInfo.GetLastInstalledVersion( GhostscriptLicense.GPL | GhostscriptLicense.AFPL, licensePriority: GhostscriptLicense.GPL);

            _rasterizer = new GhostscriptRasterizer();
        }

        public IEnumerable<Image> Rasterize(string pdfUri)
        {
            _rasterizer.Open(pdfUri, _lastInstalledVersion, false);

            for (var i = 1; i <= _rasterizer.PageCount; i++)
            {
                yield return _rasterizer.GetPage(_desiredXDpi, _desiredYDpi, i);
            }
            _rasterizer.Close();
        }
    }
}