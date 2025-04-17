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
            Menu.ShowMenu();

        }else
            Console.WriteLine("로그인실패 !");
    }
    
} 