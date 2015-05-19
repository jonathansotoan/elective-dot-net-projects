namespace ParkNow.Application
{
    using PdfSharp.Drawing;
    using PdfSharp.Pdf;
    using System.Diagnostics;

    public class PdfService
    {
        private const int LineHeight = 20;
        private const int Margin = 30;

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

            for (int lineIndex = 0; lineIndex < lines.Length; ++lineIndex)
            {
                gfx.DrawString(lines[lineIndex], bodyFont, XBrushes.Black, new XRect(Margin, page.Height * 0.3 + Margin + lineIndex * LineHeight, page.Width - 2 * Margin, page.Height * 0.7), XStringFormats.TopLeft);
            }

            report.Save(filename);
            Process.Start(filename);
        }
    }
}
