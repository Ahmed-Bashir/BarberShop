using System;
using System.Collections.Generic;
using System.Net;

using Barber_shop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BarberShop.Controllers.Dto;
using AutoMapper;


namespace BarberShop.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        private readonly BarberShopDbContext _context;
        private readonly IMapper _mapper;
        public CustomersController(IMapper mapper, BarberShopDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        [Route("GetCustomers")]
        public IEnumerable<Customer> GetCustomers()
        {


            return _context.Customers.ToList();
       }

        [HttpGet]
        public CustomerDto GetCustomer(int id)
        {
            var customerInDB = _context.Customers.SingleOrDefault(c => c.Id == id);

            if(customerInDB == null)
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.BadRequest);
            }


            return _mapper.Map<Customer, CustomerDto>(customerInDB);
        }


        [HttpPost]
        public CustomerDto CreateCustomer(CustomerDto customerDto)
        {
           
            if (!ModelState.IsValid)
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.BadRequest);
            }

            var customer = _mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            return customerDto;
        }



        [HttpPut]
        public CustomerDto UpdateCustomer(int Id, CustomerDto customerDto)
        {

          

            if (!ModelState.IsValid)
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.BadRequest);
            }

            var customerInDB = _context.Customers.SingleOrDefault(c => c.Id == Id);

            if (customerInDB == null)
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
            }

            var customer = _mapper.Map<CustomerDto, Customer>(customerDto, customerInDB);
            _context.Customers.Update(customer);
            _context.SaveChanges();

            return customerDto;
        }

        [HttpDelete]
        public void DeleteCustomer(int Id)
        {

            var customer = _context.Customers.SingleOrDefault(c => c.Id == Id);

            if (customer == null)
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Customers.Remove(customer);
            _context.SaveChanges();
           
        }


    }
}