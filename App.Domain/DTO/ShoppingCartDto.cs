using App.Domain.Relations;
using System.Collections.Generic;

namespace App.Domain.DTO
{
    public class ShoppingCartDto
    {
        public List<TicketInShoppingCart> Tickets { get; set; }

        public double TotalPrice { get; set; }
    }
}