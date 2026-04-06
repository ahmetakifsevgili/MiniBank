using System.Security.Principal;

namespace MiniBank.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string IkametIl { get; set; }
        public string Mail { get; set; }
        public string PasswordHash { get; set; }

        // Navigation Properties (İlişkiler)
        public ICollection<Account> Accounts { get; set; }
        public CryptoAccount CryptoAccount { get; set; }

    }
}
