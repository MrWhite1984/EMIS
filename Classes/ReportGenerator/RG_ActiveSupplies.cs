using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace Enterprise_Managment_IS.Classes.ReportGenerator
{
    internal class RG_ActiveSupplies
    {
        public async static Task<string> GenerateReport(string path)
        {
            List<string[]> result = DataLoader_Supplies.GetAllSupplies();
            foreach (string[] partOfData in result)
            {
                if (partOfData[5] == "Материалы")
                {
                    partOfData[4] = DataLoader_Providers.GetProviderByCode(Convert.ToInt32(partOfData[4])).ProviderName;
                }
                else
                {
                    partOfData[4] = DataLoader_Providers.GetProviderByCode(Convert.ToInt32(partOfData[4])).ProviderName;
                }
            }
            Application word = new Application();
            Microsoft.Office.Interop.Word.Document doc = word.Documents.Add();
            Microsoft.Office.Interop.Word.Range range = doc.Paragraphs[doc.Paragraphs.Count].Range;
            doc.Tables.Add(range, result.Count + 2, 7);
            doc.Tables[1].Rows[1].Cells[1].Merge(doc.Tables[1].Rows[1].Cells[7]);
            doc.Tables[1].Rows[1].Range.Text = $"Список активных поставок на {DateTime.Now}\n";
            doc.Tables[1].Cell(2, 1).Range.Text = "Код";
            doc.Tables[1].Cell(2, 2).Range.Text = "Дата";
            doc.Tables[1].Cell(2, 3).Range.Text = "Продукт";
            doc.Tables[1].Cell(2, 4).Range.Text = "Количество";
            doc.Tables[1].Cell(2, 5).Range.Text = "Поставщик";
            doc.Tables[1].Cell(2, 6).Range.Text = "Тип";
            doc.Tables[1].Cell(2, 7).Range.Text = "Сумма";
            Table table = doc.Tables[1];
            int j = 3;
            for (int i = 0; i < result.Count; i++)
            {
                doc.Tables[1].Cell(j, 1).Range.Text = result[i][0];
                doc.Tables[1].Cell(j, 2).Range.Text = result[i][1];
                doc.Tables[1].Cell(j, 3).Range.Text = result[i][2];
                doc.Tables[1].Cell(j, 4).Range.Text = result[i][3];
                doc.Tables[1].Cell(j, 5).Range.Text = result[i][4];
                doc.Tables[1].Cell(j, 6).Range.Text = result[i][5];
                doc.Tables[1].Cell(j, 7).Range.Text = result[i][6];
                j++;
            }
            for (int i = 2; i < result.Count + 3; i++)
            {
                for (int f = 1; f < 8; f++)
                {
                    table.Cell(i, f).Range.Borders[WdBorderType.wdBorderBottom].LineStyle = WdLineStyle.wdLineStyleSingle;
                    table.Cell(i, f).Range.Borders[WdBorderType.wdBorderRight].LineStyle = WdLineStyle.wdLineStyleSingle;
                    table.Cell(i, f).Range.Borders[WdBorderType.wdBorderTop].LineStyle = WdLineStyle.wdLineStyleSingle;
                    table.Cell(i, f).Range.Borders[WdBorderType.wdBorderLeft].LineStyle = WdLineStyle.wdLineStyleSingle;
                }
            }
            doc.SaveAs(path + $@"\ОтчетПоОтмененнымПоставкам({DateTime.Now.Day}_{DateTime.Now.Month}_{DateTime.Now.Year}).doc");
            doc.Close();
            word.Quit();
            MessageBox.Show($"Сохранено в файл: ОтчетПоОтмененнымПоставкам({DateTime.Now}).doc");
            return "Ok";
        }
    }
}
