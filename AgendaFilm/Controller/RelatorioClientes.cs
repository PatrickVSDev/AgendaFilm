using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using AgendaFilm.Model;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;
using AgendaFilm.Model.DTO;

namespace AgendaFilm.Controller
{
    public class RelatorioClientes : IDocument
    {

        private readonly List<ClienteRelatorioDTO> _clientes;
        private readonly string _titulo;

        public RelatorioClientes(List<ClienteRelatorioDTO> clientes, string titulo)
        {
            _clientes = clientes;
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
                    columns.RelativeColumn(3); 
                    columns.RelativeColumn(2); 
                    columns.RelativeColumn(2);  
                    columns.RelativeColumn(2);  
                    columns.RelativeColumn(2);  
                });

                table.Header(header =>
                {
                    header.Cell().Element(CellStyle).Text("ID").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Tipo do cliente").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Documento").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Nome").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Telefone").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Funcionário").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Data Alteração").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Data Criação").FontSize(9).SemiBold();
                });

                bool alternate = false;
                foreach (var cliente in _clientes)
                {
                    var backgroundColor = alternate ? Colors.Grey.Lighten3 : Colors.White;
                    alternate = !alternate;

                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(cliente.Id.ToString()).FontSize(7).AlignRight();
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(cliente.TipoCliente).FontSize(7);
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(cliente.Documento).FontSize(7).AlignRight();
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(cliente.Nome).FontSize(7);
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(cliente.Telefone).FontSize(7).AlignRight();
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(cliente.NomeFuncionario).FontSize(7);
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(cliente.DataAlteracao.ToString("yyyy/MM/dd")).FontSize(7).AlignRight();
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(cliente.DataCriacao.ToString("yyyy/MM/dd")).FontSize(7).AlignRight();
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
