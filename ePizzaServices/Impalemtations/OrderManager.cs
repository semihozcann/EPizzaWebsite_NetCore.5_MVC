﻿using ePizza.Entities.Concrete;
using ePizza.Repositories.Interfaces;
using ePizza.Repositories.Models;
using ePizza.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Services.Impalemtations
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public OrderModel GetOrderDetails(string orderId)
        {
            throw new NotImplementedException();
        }

        public PagingListModel<OrderModel> GetOrderList(int page = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetUserOrders(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<int> PlaceOrder(int userId, string orderId, string paymentId, CartModel cart, Address address)
        {
            Order order = new Order
            {
                PaymentId = paymentId,
                UserId = userId,
                CreatedDate = DateTime.Now,
                Id = orderId,
                Street =address.Street,
                Locality = address.Locality,
                City = address.City,
                ZipCode = address.ZipCode,
                PhoneNumber = address.PhoneNumber,
            };
            foreach (var item in cart.Products)
            {
                OrderItem orderItem = new OrderItem(item.ProductId, item.UnitPrice, item.Quantity, item.Total);
            }
            await _orderRepository.AddAsync(order);
            return await _orderRepository.SaveAsync();
        }
    }
}
