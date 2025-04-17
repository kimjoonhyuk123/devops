// See https://aka.ms/new-console-template for more information



using System;
using System.Collections.Generic;

class Program{

    static void Main(string[] args){

        const string USERNAME = "admin";
        const string PASSWORD = "1234";

        Console.WriteLine("===== ERP 로그인 =====  ");
        Console.Write("아이디: ");
        string inputId = Console.ReadLine();

        Console.Write("비밀번호: ");
        string inputPw = Console.ReadLine();

        if(inputId == USERNAME && inputPw == PASSWORD){
            Console.WriteLine("로그인성공 !");
            ShowMenu();

        }else
            Console.WriteLine("로그인실패 !");
    }
    static void ShowMenu(){
        while(true){
            Console.WriteLine("\n===== ERP메뉴 =====");
            Console.WriteLine("1. 재고관리");
            Console.WriteLine("2. 거래처관리");
            Console.WriteLine("3. 종료");
            Console.Write("메뉴 번호를 선택하세요: ");

            string choice = Console.ReadLine();

            switch(choice){

                case "1":
                    //Console.WriteLine("[재고 관리] 기능입니다");
                    ShowInventoryMenu();
                    break;
                case "2":
                    Console.WriteLine("[거래처 관리] 기능입니다");
                    break;
                case "3":
                    Console.WriteLine("프로그램을 종료합니다.");
                    return;
                default:
                    Console.WriteLine("잘못된 입력입니다. 다시 선택해주세요");
                    break;
            }
        }
    }
    static List<Item> items = new List<Item>();
    //재고 관리 메뉴
    static void ShowInventoryMenu(){
        
        while(true){
            Console.WriteLine("\n[재고 관리 메뉴]");
            Console.WriteLine("1. 상품 등록");
            Console.WriteLine("2. 상품 목록 보기");
            Console.WriteLine("3. 이전 메뉴로");
            Console.Write("선택: ");
            string input = Console.ReadLine();

            switch(input){
                case "1":
                    Console.Write("상품명: ");
                    string name = Console.ReadLine();

                    Console.Write("수량: ");
                    int qty = int.Parse(Console.ReadLine());

                    Console.Write("가격: ");
                    int price = int.Parse(Console.ReadLine());

                    items.Add(new Item{Name =name, Quantity =qty, Price = price});
                    Console.WriteLine("상품이 등록되었습니다.");
                    break;
                case "2":
                    Console.WriteLine("\n상품 목록: ");
                    if(items.Count == 0){
                        Console.WriteLine("등록된 상품이 없습니다.");

                    }else{
                        foreach (var item in items){
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "3":
                    return; //상위 메뉴로 복귀
                deafult:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
    }
}
class Item{
    public string Name {get; set;}
    public int Quantity {get; set;}
    public int Price {get; set;}

    public override string ToString(){
        return $"{Name} | 수량: {Quantity} | 가격: {Price}원";
    }
}


//Console.WriteLine("Hello, World!");
