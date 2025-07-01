using AgendaFilm.Model.Repositories;
using AgendaFilm.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using AgendaFilm.Model.DTO;

namespace AgendaFilm.Controller
{
    internal class PdfOrdemServico
    {
        public static string GerarPdfOrdemServico(OrdemServico ordem, AgendamentoDTO agendamento, List<OrdemProduto> produtos)
        {
            string caminho = Path.Combine(Path.GetTempPath(), $"OrdemServico_{ordem.AgendamentoId}_{DateTime.Now.Ticks}.pdf");

            using (FileStream stream = new FileStream(caminho, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 40, 40, 40, 30);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();

                var fontTitle = iTextSharp.text.FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD, BaseColor.GREEN);
                var fontSub = iTextSharp.text.FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL);
                var fontHeader = iTextSharp.text.FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD);
                var fontCell = iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL);

                string logoPath = "C:\\Users\\patri\\source\\repos\\AgendaFilm\\AgendaFilm\\AgendaFilm\\Resources\\LogoAgendaFilm.png";
                if (File.Exists(logoPath))
                {
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                    logo.ScaleToFit(120f, 40f);
                    logo.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(logo);
                }

                Paragraph titulo = new Paragraph("Ordem de Serviço", fontTitle)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 10
                };
                pdfDoc.Add(titulo);

                pdfDoc.Add(new Paragraph($"Data de Criação: {ordem.DataCriacao:dd/MM/yyyy HH:mm}", fontSub));
                pdfDoc.Add(new Paragraph($"Cliente: {agendamento.nome_cliente}", fontSub));
                pdfDoc.Add(new Paragraph($"Veículo: {agendamento.modelo_veiculo}", fontSub));
                pdfDoc.Add(new Paragraph($"Placa: {agendamento.placa_veiculo}", fontSub));
                pdfDoc.Add(new Paragraph($"Funcionário: {agendamento.nome_funcionario}", fontSub));
                pdfDoc.Add(new Paragraph($"Data Agendada: {agendamento.dataHoraAgendamento:dd/MM/yyyy HH:mm}", fontSub));
                pdfDoc.Add(new Paragraph($"Observações: {ordem.Observacoes}", fontSub));
                var statusParagrafo = new Paragraph($"Status: {ordem.Status}", fontSub)
                {
                    SpacingBefore = 5,
                    SpacingAfter = 10
                };
                pdfDoc.Add(statusParagrafo);

                pdfDoc.Add(new Paragraph("\n"));

                PdfPTable tabela = new PdfPTable(4)
                {
                    WidthPercentage = 100
                };
                tabela.SetWidths(new float[] { 15f, 45f, 20f, 20f });

                string[] headers = { "Produto ID", "Nome", "Preço Unitário", "Quantidade" };
                foreach (string header in headers)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(header, fontHeader))
                    {
                        BackgroundColor = new BaseColor(230, 230, 230),
                        Padding = 5,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    tabela.AddCell(cell);
                }

                bool alternar = false;
                decimal total = 0;
                foreach (var item in produtos)
                {
                    var produto = new ProdutoRepositorio().getById(item.ProdutoId);
                    BaseColor bgColor = alternar ? new BaseColor(245, 245, 245) : BaseColor.WHITE;
                    alternar = !alternar;

                    tabela.AddCell(new PdfPCell(new Phrase(item.ProdutoId.ToString(), fontCell)) { BackgroundColor = bgColor, Padding = 5 });
                    tabela.AddCell(new PdfPCell(new Phrase(produto?.nome ?? "Desconhecido", fontCell)) { BackgroundColor = bgColor, Padding = 5 });
                    tabela.AddCell(new PdfPCell(new Phrase(item.PrecoUnitario.ToString("C"), fontCell)) { BackgroundColor = bgColor, Padding = 5 });
                    tabela.AddCell(new PdfPCell(new Phrase(item.Quantidade.ToString(), fontCell)) { BackgroundColor = bgColor, Padding = 5 });

                    total += item.PrecoUnitario * item.Quantidade;
                }

                PdfPCell totalLabel = new PdfPCell(new Phrase("Total", fontHeader))
                {
                    Colspan = 3,
                    HorizontalAlignment = Element.ALIGN_RIGHT,
                    Padding = 5
                };
                tabela.AddCell(totalLabel);
                tabela.AddCell(new PdfPCell(new Phrase(total.ToString("C"), fontHeader)) { Padding = 5 });

                pdfDoc.Add(tabela);

                Paragraph rodape = new Paragraph($"\n\nGerado em: {DateTime.Now:dd/MM/yyyy HH:mm}", fontSub)
                {
                    Alignment = Element.ALIGN_RIGHT
                };
                pdfDoc.Add(rodape);

                pdfDoc.Close();
            }

            return caminho;
        }
    }
}
