# pdf2png
Simple PDF to PNG Library and Console Application. 

For each page of a PDF file, creates a .PNG image file in the output directory 

Uses [Ghostscript.NET](https://github.com/jhabjan/Ghostscript.NET), [NLog](https://github.com/NLog/NLog) and [commandline](https://github.com/gsscoder/commandline).

Rasterizer inspired by [dampee/PDFRasterizer](https://github.com/dampee/ImageProcessor.Plugins.Pdf)

## Usage
```
pdf2png -i <input pdf file> -o <output directory> [-p dpi]
```
## Arguments
```
-i, --input       Required. Input file to be processed.
-o, --output      Required. Output directory for output files.
-p, --pixelDpi    (Default: 300) Output PNG image dpis
```

## Missing
No tests available :(
