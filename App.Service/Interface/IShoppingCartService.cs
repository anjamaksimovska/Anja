using App.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Service.Interface
{
    public interface IShoppingCartService
    {
        ShoppingCartDto getShoppingCartInfo(string userId);
        bool deleteTicketFromSoppingCart(string userId, Guid ticketId);
        bool order(string userId);
    }
}