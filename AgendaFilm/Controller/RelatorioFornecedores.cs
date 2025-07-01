﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using AgendaFilm.Model;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace AgendaFilm.Controller
{
    public class RelatorioFornecedores : IDocument
    {

        private readonly List<Fornecedor> _fornecedores;
        private readonly List<Funcionario> _funcionarios;
        private readonly string _titulo;

        public RelatorioFornecedores(List<Fornecedor> fornecedores, string titulo, List<Funcionario> funcionarios)
        {
            _fornecedores = fornecedores;
            _titulo = titulo;
            _funcionarios = funcionarios;
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
                    header.Cell().Element(CellStyle).Text("Documento").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Nome").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Telefone").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Email").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Funcionário").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Data Alteração").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Data Criação").FontSize(9).SemiBold();
                });

                bool alternate = false;
                foreach (var fornecedor in _fornecedores)
                {
                    var backgroundColor = alternate ? Colors.Grey.Lighten3 : Colors.White;
                    alternate = !alternate;

                    string nomeFuncionario = _funcionarios.FirstOrDefault(f => f.id == fornecedor.funcionario_fk)?.nome ?? "Desconhecido";

                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(fornecedor.id.ToString()).FontSize(7).AlignRight();
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(fornecedor.documento).FontSize(7).AlignRight();
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(fornecedor.nome).FontSize(7);
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(fornecedor.telefone).FontSize(7).AlignRight();
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(fornecedor.email).FontSize(7);
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(nomeFuncionario).FontSize(7);
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(fornecedor.dataAlteracao.ToString("yyyy/MM/dd")).FontSize(7).AlignRight();
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(fornecedor.dataCriacao.ToString("yyyy/MM/dd")).FontSize(7).AlignRight();
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
                    text.Span("Página ");
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
