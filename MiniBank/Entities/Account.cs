namespace MiniBank.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string IBAN { get; set; }
        public string ParaBirimi { get; set; } // TL, EUR, USD
        public decimal Bakiye { get; set; }
        public bool Aktif { get; set; }

        // Foreign Key (Kullanıcı Bağlantısı)
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
