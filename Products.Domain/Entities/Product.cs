using System;

namespace Products.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Description { get; set; }

        public bool Situation { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ExpirationDate { get; set; }

        public int ProviderId { get; set; }

        public string ProviderDescripton { get; set; }

        public string ProviderCNPJ { get; set; }
    }
}
