using System;
using System.Collections.Generic;

public static class InventoryManager{

    public static List<Item> Items = new List<Item>();
    public static void ShowInventoryMenu(){
        while(true){
            Console.WriteLine("\n[재고 관리 메뉴]");
            Console.WriteLine("1. 상품 등록");
            Console.WriteLine("2. 상품 목록 보기");
            Console.WriteLine("3. 상품 삭제");
            Console.WriteLine("4. 이전 메뉴로");
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

                    Items.Add(new Item{Name =name, Quantity =qty, Price = price});
                    Console.WriteLine("상품이 등록되었습니다.");
                    break;
                case "2":
                    Console.WriteLine("\n상품 목록: ");
                    if(Items.Count == 0){
                        Console.WriteLine("등록된 상품이 없습니다.");

                    }else{
                        foreach (var item in Items){
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("삭제할 상품명을 입력: ");
                    string delName = Console.ReadLine();
                    var found = Items.Find(i => i.Name == delName);
                    if (found != null){
                        Items.Remove(found);
                        Console.WriteLine("🗑️ 삭제 완료!");
                    } else{
                        Console.WriteLine("❌ 해당 상품을 찾을 수 없습니다.");
                    }
                    break;
                case "4":
                    return; //상위 메뉴로 복귀
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
    }
}