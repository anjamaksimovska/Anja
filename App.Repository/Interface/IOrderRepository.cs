using App.Domain;
using App.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Repository.Interface
{
    public interface IOrderRepository
    {
        public List<Order> getAllOrders();
        public Order getOrderDetails(BaseEntity model);

    }
}