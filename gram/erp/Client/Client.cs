using System; 

namespace ERP.Client{
    public class Client{
    public string Name {get; set;}
    public string Contact {get; set;}
    public string Address {get; set;}

    public override string ToString(){
        return $"거래처명: {Name}, 연락처: {Contact}, 주소: {Address}";
    }
    }
}
