using CRUDExcelAnaliseDeDados.Models;
using OfficeOpenXml;
using System.Collections.ObjectModel;
using System.IO;

namespace CRUDExcelAnaliseDeDados.Helpers;

    public class ExcelParser
    {
        public Collection<Client> ParseExcelFile(Stream excelStrem)
        {

            Collection<Client> result = new Collection<Client>();

            using(var package = new ExcelPackage(excelStrem))
            {
                var workbook = package.Workbook;
                var worksheet = workbook.Worksheets.FirstOrDefault();

                if(worksheet != null)
                {
                    for(int row = worksheet.Dimension.Start.Row; row <= worksheet.Dimension.End.Row; row++)
                    {
                    Client client = new Client();

                    client.Name = worksheet.Cells[row, 1].Value.ToString();
                    client.Phone = worksheet.Cells[row, 2].Value.ToString();
                    client.Address = worksheet.Cells[row, 3].Value.ToString();

                    result.Add(client);

                    //for (int col = worksheet.Dimension.Start.Column; col <= worksheet.Dimension.End.Column; col++)
                    //{
                    //    var cellValue = worksheet.Cells[row, col].Value;
                    //    Console.WriteLine(cellValue + "\n" + col + "\n");
                    //}
                }
                }
            }

            return result;
        }
    }

