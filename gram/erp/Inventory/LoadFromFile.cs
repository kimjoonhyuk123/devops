using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; 

namespace ERP.Inventory{
  
public static class LoadFromFile{
    public static List<Item> Load(){

        try{
            if(!File.Exists("items.json")){
                Console.WriteLine("저장된 파일이 없습니다.");
                return new List<Item>();
            }
            string json = File.ReadAllText("items.json");
            var items = JsonSerializer.Deserialize<List<Item>>(json);
            //var items = JsonSerializer.Deserialize<List<Item>>(json);
            Console.WriteLine("item.json 파일에서 불러오기 완료");
            return items ?? new List<Item>();
            

        }catch(Exception ex){
            Console.WriteLine("불러오기 중 오류 발생: ", ex.Message);
            return new List<Item>();
        }
    } 

    
}
}