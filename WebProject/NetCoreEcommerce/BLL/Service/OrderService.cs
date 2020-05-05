using BLL.Abstract;
using DAL.Context;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Service
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext context;

        public OrderService(AppDbContext context)
        {
            this.context = context;
        }
        public void Add(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public List<Order> GettAll()
        {
            return context.Orders.ToList();
        }

        public void Update(Order order)
        {
            context.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
