using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaFilm.Model;
using AgendaFilm.Model.DTO;

namespace AgendaFilm.Controller
{
    public class RelatorioVeiculos : IDocument
    {
        private readonly List<VeiculoDTO> _veiculos;
        private readonly string _titulo;

        public RelatorioVeiculos(List<VeiculoDTO> veiculos, string titulo)
        {
            _veiculos = veiculos;
            _titulo = titulo;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(30);
                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
                page.Footer().Element(ComposeFooter);
            });
        }

        private void ComposeHeader(IContainer container)
        {
            container.Column(column =>
            {
                column.Item().Row(row =>
                {
                    row.RelativeColumn().AlignCenter().Height(40).Image("C:\\Users\\patri\\source\\repos\\AgendaFilm\\AgendaFilm\\AgendaFilm\\Resources\\LogoAgendaFilm.png", ImageScaling.FitHeight);
                });

                column.Item().Height(30);

                column.Item().Row(row =>
                {
                    row.RelativeColumn().Text(_titulo).FontSize(10).SemiBold().FontColor(Colors.Green.Medium);
                    row.ConstantColumn(150).AlignRight().Text($"Data: {DateTime.Now:dd/MM/yyyy}").FontSize(10).Light();
                });
            });
        }

        private void ComposeContent(IContainer container)
        {
            container.PaddingVertical(10).Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(1); 
                    columns.RelativeColumn(3);  
                    columns.RelativeColumn(2);  
                    columns.RelativeColumn(2);  
                    columns.RelativeColumn(2);  
                    columns.RelativeColumn(2);  
                    columns.RelativeColumn(2); 
                    columns.RelativeColumn(2);  
                    columns.RelativeColumn(2);  
                });

                table.Header(header =>
                {
                    header.Cell().Element(CellStyle).Text("ID").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Placa").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Modelo").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Ano").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Marca").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Data Alteração").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Data Criação").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Funcionário").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Cliente Dono").FontSize(9).SemiBold();
                });

                bool alternate = false;
                foreach (var veiculo in _veiculos)
                {
                    var backgroundColor = alternate ? Colors.Grey.Lighten3 : Colors.White;
                    alternate = !alternate;

                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(veiculo.id.ToString()).FontSize(7).AlignRight();
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(veiculo.placa).FontSize(7);
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(veiculo.modelo).FontSize(7);
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(veiculo.ano).FontSize(7);
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(veiculo.marca.ToString()).FontSize(7).AlignRight();
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(veiculo.dataAlteracao.ToString("yyyy/MM/dd")).FontSize(7).AlignRight();
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(veiculo.dataCriacao.ToString("yyyy/MM/dd")).FontSize(7).AlignRight();
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(veiculo.nomeFuncionario).FontSize(7);
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(veiculo.clienteNome).FontSize(7);
                }
            });
        }

        private void ComposeFooter(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeColumn().AlignLeft().Text("\u00a9 2024 - AgendaFilm").FontSize(10).Light();
                row.ConstantColumn(50).AlignRight().Text(text =>
                {
                    text.Span("P\u00e1gina ");
                    text.CurrentPageNumber();
                });
            });
        }

        private static IContainer CellStyle(IContainer container)
        {
            return container.Padding(5).BorderBottom(1).BorderColor(Colors.Grey.Lighten2);
        }
    }
}
