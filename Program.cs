using IronPdf;

var renderOptions = new ChromePdfRenderOptions();

// Example that changes the height of the table in JavaScript:
renderOptions.Javascript = "document.getElementById('ganttDefault').style['height']  = 'auto';";

// Make sure to use the render options object that you created:
var renderer = new ChromePdfRenderer { RenderingOptions = renderOptions };

renderer.RenderingOptions.PaperOrientation = IronPdf.Rendering.PdfPaperOrientation.Landscape;
renderer.RenderingOptions.EnableJavaScript = true;
renderer.RenderingOptions.PaperFit.UseScaledRendering(20);
renderer.RenderingOptions.Timeout = 500; // seconds
renderer.RenderingOptions.RenderDelay = 300000; //milliseconds=30seconds
renderer.RenderingOptions.MarginBottom = 0;
renderer.RenderingOptions.MarginLeft = 0;
renderer.RenderingOptions.MarginRight = 0;
renderer.RenderingOptions.MarginTop = 0;
//renderer.RenderingOptions.SetCustomPaperSizeInInches(8, 24);
renderer.RenderUrlAsPdf(@"https://techext-001-site75.itempurl.com/").SaveAs("url.pdf");

//https://ironpdf.com/blog/using-ironpdf/csharp-download-pdf-from-url-tutorial/#trial-license-form-sent
//https://blog.aspose.com/html/convert-url-to-pdf-in-csharp/
//https://sautinsoft.com/products/pdf-vision/examples/convert-web-site-url-to-pdf-file-csharp-vb-net.php
//https://www.syncfusion.com/blogs/post/html-to-pdf-conversion-in-csharp.aspx#convert-url-to-pdf