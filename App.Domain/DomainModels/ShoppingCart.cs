using App.Domain.Identity;
using App.Domain.Relations;
using App.Domain;
using System;
using System.Collections.Generic;


namespace App.Domain.DomainModels
{
    public class ShoppingCart : BaseEntity
    {
        public string OwnerId { get; set; }
        public virtual AppApplicationUser Owner { get; set; }

        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }

    }
}