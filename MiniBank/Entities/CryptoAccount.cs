namespace MiniBank.Entities
{
    public class CryptoAccount
    {
        public int Id { get; set; }
        public decimal USDTBakiye { get; set; }

        // Foreign Key
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
