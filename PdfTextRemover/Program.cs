using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

public class Program
{
    public static void Main(string[] args)
    {
        string inputPdf = @"C:\Users\Amin\Desktop\HTML-to-PDF.pdf";
        string outputPdf = @"pdf.pdf";

        using (PdfReader reader = new PdfReader(inputPdf))
        using (PdfWriter writer = new PdfWriter(outputPdf))
        using (PdfDocument pdfDoc = new PdfDocument(reader, writer))
        {

            for (int i = 1; i <= pdfDoc.GetNumberOfPages(); i++)
            {
                var page = pdfDoc.GetPage(i);

                PdfCanvas canvas = new PdfCanvas(page);

                
                float x = 0; 
                float y = 780; 
                float width = 500; 
                float height = 20;

                canvas.SetFillColor(iText.Kernel.Colors.ColorConstants.WHITE);
                canvas.Rectangle(x, y, width, height);
                canvas.Fill();
            }
        }
    }
}
