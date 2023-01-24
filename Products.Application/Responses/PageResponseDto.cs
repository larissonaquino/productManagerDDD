using System;

namespace Products.Application.Responses
{
    public class PageResponseDto
    {
        public int PageNumber { get; set; } = 10;

        public int PageSize { get; set; } = 20;

        public int TotalElements { get; set; }

        public decimal TotalPages => Math.Ceiling((decimal)this.TotalElements / this.PageSize);
    }
}
