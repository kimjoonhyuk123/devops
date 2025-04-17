namespace ERP.Inventory{
  
public class Item
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }

    public override string ToString() {
        return $"{Name} | 수량: {Quantity} | 가격: {Price}원";
    }
}

}
