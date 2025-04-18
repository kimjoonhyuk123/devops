using System;
using System.Data.SqlClient; // MSSQL DB 연결을 위한 라이브러리

namespace ERP.Database{ 
    public static class DatabaseManager{
        private static readonly string connStr = "Server=localhost;Database=ERPDB;Trusted_Connection=True;"; //DB연결 정보
        public static void ShowItems(){
            using (SqlConnection conn = new SqlConnection(connStr)){ // DB와 연결하는 객체(연결하면 .Open 해줘야함)
                conn.Open();
               // Console.WriteLine("DB 연결 성공 ! ");

                string query = "SELECT * FROM Items";
                using (SqlCommand cmd = new SqlCommand(query, conn))    // 쿼리를 실행할 때 사용하는 객체.
                using (SqlDataReader reader = cmd.ExecuteReader()){
                    if(!reader.HasRows){
                        Console.WriteLine("등록된 상품이 없습니다.");
                        return;
                    }

                    while(reader.Read()){
                        Console.WriteLine($"{reader["Id"]} | {reader["name"]} | 수량: {reader["Quantity"]} | 가격: {reader["Price"]}원");
                    }
                }
            }
        }
        public static void InsertItem(string name, int quantity, int price){
            using (SqlConnection conn = new SqlConnection(connStr)){
                conn.Open();
                string query = "INSERT INTO Items (Name, Quantity, Price) VALUES (@name, @qty, @price)";

                using (SqlCommand cmd = new SqlCommand(query, conn)){

                    cmd.Parameters.AddWithValue("@name", name); //쿼리에 안전하게 값을 넣는 방법(sql 인젝션 방지)
                    cmd.Parameters.AddWithValue("@qty", quantity);
                    cmd.Parameters.AddWithValue("@price", price); 

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected}개의 상품을 추가되었습니다.");

                }
            }
        }
        public static void DeleteItemByName(string id){
            using (SqlConnection conn = new SqlConnection(connStr)){
                conn.Open();
                string query = "DELETE FROM Items WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn)){
                    cmd.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)  {
                        Console.WriteLine($"'상품번호 {id}' 상품 삭제 완료!");
                    }
                    else{
                        Console.WriteLine($"'상품번호{id}' 상품을 찾을 수 없습니다.");
                    }
                }
            }
        }
        public static void UpdateItemById(int id, string newName, int newQty, int newPrice){
            using (SqlConnection conn = new SqlConnection(connStr))   {
                conn.Open();
                string query = "UPDATE Items SET Name = @name, Quantity = @qty, Price = @price WHERE Id = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))   {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", newName);
                    cmd.Parameters.AddWithValue("@qty", newQty);
                    cmd.Parameters.AddWithValue("@price", newPrice);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)  {
                        Console.WriteLine($"상품 번호 {id} 수정 완료!");
                    }else{
                        Console.WriteLine($"상품 번호 {id}를 찾을 수 없습니다.");
                    }
                }
            }
        }
    } 
}