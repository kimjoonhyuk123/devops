using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; 


namespace ERP.Client{
  

public static class SaveClientToFile{
    
    public static void Save(List<Client> clients){
        
        try{
            string json = JsonSerializer.Serialize(clients, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText("client.json", json);
            Console.WriteLine("거래처가 client.json 파일로 저장되었습니다.");
            
        }catch(Exception ex){
            Console.WriteLine("거래처 저장 중 오류 발생: "+ ex.Message);
        }
    }
    

}
}
