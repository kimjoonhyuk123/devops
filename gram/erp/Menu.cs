using System;

public static class Menu{
    public static void ShowMenu(){
        while(true){
            Console.WriteLine("\n===== ERP메뉴 =====");
            Console.WriteLine("1. 재고관리");
            Console.WriteLine("2. 거래처관리");
            Console.WriteLine("3. 상품삭제");
            Console.WriteLine("4. 종료");
            Console.Write("메뉴 번호를 선택하세요: ");

            string choice = Console.ReadLine();

            switch(choice){

                case "1":
                    //Console.WriteLine("[재고 관리] 기능입니다");
                    InventoryManager.ShowInventoryMenu();
                    break;
                case "2":
                    //Console.WriteLine("[거래처 관리] 기능입니다");
                    ClientManager.ShowClientMenu();
                    break;
                case "3":
                    Console.WriteLine("삭제할 상품명을 입력: ");
                    string delName = Console.ReadLine();
                    var found = InventoryManager.Items.Find(i => i.Name == delName);
                    if(found != null){
                        InventoryManager.Items.Remove(found);
                        Console.WriteLine("삭제 완료");
                    }else{
                        Console.WriteLine("상품을 찾을 수 없습니다.");
                    }
                    break;
                case "4":
                    Console.WriteLine("프로그램을 종료합니다.");
                    return;
                default:
                    Console.WriteLine("잘못된 입력입니다. 다시 선택해주세요");
                    break;
            }
        }
    }  
}
