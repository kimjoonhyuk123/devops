using ClosedXML.Excel;


namespace ERP.Inventory{
public static class ExportToExcel{
    public static void Export(List<Item> items){
    try{

        using (var workbook = new XLWorkbook()){
            var worksheet = workbook.Worksheets.Add("재고 목록");

            //해더
            worksheet.Cell(1, 1).Value = "상품명";
            worksheet.Cell(1, 2).Value = "수량";
            worksheet.Cell(1, 3).Value = "가격";

            //내용
            for(int i = 0 ; i<items.Count; i++){
                worksheet.Cell(i+2,1).Value = items[i].Name;
                worksheet.Cell(i+2,2).Value = items[i].Quantity;
                worksheet.Cell(i+2,3).Value = items[i].Price;
            }

            string fileName = $"items_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
            workbook.SaveAs(fileName);
            Console.WriteLine($"엑셀 파일 저장 완료: {fileName}");
        }
    }catch(Exception ex){
        Console.WriteLine("엑셀 저장 중 오류 발생:"+ ex.Message);
 
    }
}
}
}