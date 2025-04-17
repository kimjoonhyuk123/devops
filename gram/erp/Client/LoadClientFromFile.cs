using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; 

namespace ERP.Client{
  
public static class LoadClientFromFile{

    public static List<Client> Load(){
        try{
            if(!File.Exists("client.json")){
                Console.WriteLine("저장된 거래처 파일이 없습니다.");
                return new List<Client>();
            }

            string json = File.ReadAllText("client.json");
            var clients = JsonSerializer.Deserialize<List<Client>>(json);

            Console.WriteLine("거래처 파일 불러오기 완료 !");
            return clients ?? new List<Client>();
        }catch(Exception ex){
            Console.WriteLine("거래처 불러오기 중 오류 발생"+ex.Message);
            return new List<Client>();
        }
    }

}
}