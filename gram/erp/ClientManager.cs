using System;
using System.Collections.Generic;

public static class ClientManager{
    public static List<Client> Clients = new List<Client>();

    public static void ShowClientMenu(){
        while(true){

            Console.WriteLine("\n[거래처 관리 메뉴]");
            Console.WriteLine("1. 거래처 등록");
            Console.WriteLine("2. 거래처 목록 보기");
            Console.WriteLine("3. 이전 메뉴로");
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
                    return;

                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
    }
}