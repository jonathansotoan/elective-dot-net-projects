namespace ParkNow.Application
{
    using PdfSharp.Drawing;
    using PdfSharp.Pdf;
    using System.Diagnostics;

    public class PdfService
    {
        private const int LineHeight = 20;
        private const int Margin = 30;
        private const int LinesByPageLimit = 22;
        private const int LinesByPageWithoutTitle = 30;

        public void OpenPdfReport(string filename, string title, string body)
        {
            var report = new PdfDocument();
            report.Info.Title = title;

            PdfPage page = report.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            var titleFont = new XFont("Verdana", 20, XFontStyle.BoldItalic);
            var bodyFont = new XFont("Verdana", 15, XFontStyle.Regular);

            gfx.DrawString(title, titleFont, XBrushes.Black, new XRect(0, 0, page.Width, page.Height * 0.3), XStringFormats.Center);
            string[] lines = body.Split('\n');
            bool isCurrentPageTheFirst = true;

            for (int lineIndex = 0, currentPageLineIndex = 0; lineIndex < lines.Length; ++lineIndex, ++currentPageLineIndex)
            {
                if ((isCurrentPageTheFirst && currentPageLineIndex == LinesByPageLimit) ||
                    (!isCurrentPageTheFirst && currentPageLineIndex == LinesByPageWithoutTitle))
                {
                    page = report.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    currentPageLineIndex = 0;
                    isCurrentPageTheFirst = false;
                }

                gfx.DrawString(lines[lineIndex], bodyFont, XBrushes.Black,
                    new XRect(Margin,
                        (isCurrentPageTheFirst ? page.Height*0.3 : 0) + Margin + currentPageLineIndex*LineHeight,
                        page.Width - 2*Margin, page.Height*0.7), XStringFormats.TopLeft);
            }

            filename = filename.Replace('/', '_').Replace(':', '_');
            report.Save(filename);
            Process.Start(filename);
        }
    }
}
