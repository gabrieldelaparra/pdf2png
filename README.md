# pdf2png
Simple PDF to PNG Library and Console Application. 

For each page of a PDF file, creates a .PNG image file in the output directory 

Uses Ghostscript.NET. 

Rasterizer inspired by dampee/ImageProcessor.Plugins.Pdf

## Usage
pdf2png -i \<input pdf file\> -o \<output directory\> [-p dpi]

## Arguments
-i, --input       Required. Input file to be processed.

-o, --output      Required. Output directory for output files.

-p, --pixelDpi    (Default: 300) Output PNG image dpis
