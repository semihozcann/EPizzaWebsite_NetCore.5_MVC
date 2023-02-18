using ePizza.Entities.Concrete;
using ePizza.Repositories.Interfaces;
using ePizza.Services.Interfaces;
using ePizza.Services.Models;
using Microsoft.Extensions.Options;
using Razorpay.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Services.Implementations
{
    public class PaymentManager : IPaymentService
    {
        
        private readonly IOptions<RazorPayConfig> _razorPayConfing;
        private readonly RazorpayClient _client;
        private readonly IRepository<PaymentDetails> _repository;
        private readonly ICartRepository _cartRepository;

        public PaymentManager(IOptions<RazorPayConfig> razorPayConfing, RazorpayClient client, IRepository<PaymentDetails> repository, ICartRepository cartRepository)
        {
            _razorPayConfing = razorPayConfing;
            _client = client;
            _repository = repository;
            _cartRepository = cartRepository;
        }

        public string CapturePayment(string paymentId, string orderId)
        {
            throw new NotImplementedException();
        }

        public string CreateOrder(decimal amount, string currency, string receipt)
        {
            try
            {
                Dictionary<string, object> options = new Dictionary<string, object>()
            {
                {"amount", amount },
                {"currency", currency },
                {"receipt", receipt },
            };
                Razorpay.Api.Order orderResponse = _client.Order.Create(options);
                return orderResponse["id"].ToString();
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Payment GetPaymentDetails(string paymentId)
        {
            if (!string.IsNullOrWhiteSpace(paymentId))
            {
                return _client.Payment.Fetch(paymentId);
            }
            return null;
        }

        public Task<int> SavePaymentDetails(PaymentDetails model)
        {
            throw new NotImplementedException();
        }

        public bool VerifySignature(string signature, string orderId, string paymentId)
        {
            throw new NotImplementedException();
        }
    }
}
