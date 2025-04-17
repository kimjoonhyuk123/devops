using System;
using System.Collections.Generic; 



namespace ERP.Client{
  



public static class ClientManager{
    public static List<Client> Clients = new List<Client>();

    public static void ShowClientMenu(){
        while(true){

            Console.WriteLine("\n[거래처 관리 메뉴]");
            Console.WriteLine("1. 거래처 등록");
            Console.WriteLine("2. 거래처 목록 보기");
            Console.WriteLine("3. 거래처 삭제");
            Console.WriteLine("4. 파일로 저장");
            Console.WriteLine("5. 파일에서 불러오기");
            Console.WriteLine("6. 이전 메뉴로");
            Console.Write("선택: ");
            string input = Console.ReadLine();

            switch(input){
                case "1":
                    Console.Write("거래처명: ");
                    string name = Console.ReadLine();
                    Console.Write("연락처: ");
                    string contact = Console.ReadLine();                    
                    Console.Write("주소: ");
                    string address = Console.ReadLine();

                    Clients.Add(new Client {Name = name, Contact = contact, Address = address});
                    SaveClientToFile.Save(Clients);
                    Console.WriteLine("거래처가 등록되었습니다.");
                    break;
                case "2":
                    Console.WriteLine("\n 거래처 목록: ");
                    if(Clients.Count == 0){
                        Console.WriteLine("등록된 거래처가 없습니다.");
                    }else{
                        foreach(var client in Clients){
                            Console.WriteLine(client);
                        } 
                    }
                    break;

                case "3":
                    Console.Write("삭제할 거래처명 입력: ");
                    string delName = Console.ReadLine();
                    var found = Clients.Find(c => c.Name == delName);
                    if (found != null)
                    {
                        Clients.Remove(found);
                        Console.WriteLine("삭제 완료!");
                    }
                    else
                    {
                        Console.WriteLine("거래처를 찾을 수 없습니다.");
                    }
                    break;

                case "4":
                    SaveClientToFile.Save(Clients);
                    break;
                case "5":
                    Clients = LoadClientFromFile.Load();
                    break;
                case "6":
                    return;

                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
    }
}
}