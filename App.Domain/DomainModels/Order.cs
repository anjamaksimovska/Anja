using App.Domain.Identity;
using App.Domain;
using App.Domain.Relations;
using System;
using System.Collections.Generic;

namespace App.Domain.DomainModels
{
    public class Order : BaseEntity
    {
        public string UserId { get; set; }
        public AppApplicationUser User { get; set; }

        public virtual ICollection<TicketInOrder> TicketInOrders { get; set; }
    }
}