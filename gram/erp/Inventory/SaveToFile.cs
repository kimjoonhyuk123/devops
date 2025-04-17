using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; 


namespace ERP.Inventory{
  

public static class SaveToFile{
    public static void Save(List<Item> items){

        try{
            string json = JsonSerializer.Serialize(items, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText("items.json", json);
            Console.WriteLine("items.json 파일로 저장 완료!");

        }catch(Exception ex){
            Console.WriteLine("저장 중 오류 발생: ", ex.Message);
        }
    } 


}}