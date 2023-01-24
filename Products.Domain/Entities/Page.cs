using System;

namespace Products.Domain.Entities
{
    public class Page
    {
        public int PageNumber { get; set; } = 10;

        public int PageSize { get; set; } = 20;

        public int TotalElements { get; set; }

        public decimal TotalPages => Math.Ceiling((decimal)this.TotalElements / this.PageSize);

        public int Offset
        {
            get
            {
                return (PageNumber - 1) * PageSize;
            }
        }
    }
}
