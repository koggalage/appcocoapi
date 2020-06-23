using CocoChicApp.Business.Interfaces;
using CocoChicApp.Business.Util;
using CocoChicApp.Contract.DTO;
using CocoChicApp.Contract.DTO.UI;
using CocoChicApp.EF.Repositories.Interfaces;
using CocoChicApp.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocoChicApp.Business.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<CustomerDTO> GetAllCustomers()
        {
            return DomainDTOMapper.ToCustomerDTOs(_customerRepository.GetAll().ToList());
        }

        public CustomerUpdateResponse SaveCustomer(CustomerDTO customer, int userId, int branchId)
        {
            customer.CustomerId = String.Format("C{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);
            customer.BranchId = branchId;
            customer.EnteredBy = userId;
            customer.EnteredDate = DateTime.Now;
            customer.IsDeleted = false;
            customer.Gender = customer.Gender == "Male" ? "M" : "F";

            try
            {
                //customer.DoB = customer.DoB.Value.Date;
                var imageName = string.Format(@"{0}", Guid.NewGuid());

                ImageConverter.SaveImage(customer.SignatureURL, imageName);

                customer.SignatureURL = imageName;

                _customerRepository.Add(DomainDTOMapper.ToCustomerDomain(customer));
                _customerRepository.SaveChanges();

                CustomerUpdateResponse response = new CustomerUpdateResponse();
                response.ImageName = imageName;
                response.CustomerId = customer.CustomerId;
                
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<CustomerDTO> SearchCustomer(CustomerSearchRequest request)
        {
            var customers = new List<CustomerDTO>();

            if (!string.IsNullOrWhiteSpace(request.CustomerName))
            {
                customers.AddRange(DomainDTOMapper.ToCustomerDTOs(_customerRepository
                    .Where(c => c.FullName.Contains(request.CustomerName)).ToList()));
            }

            if (!string.IsNullOrWhiteSpace(request.CustomerId))
            {
                customers.AddRange(DomainDTOMapper.ToCustomerDTOs(_customerRepository
                    .Where(c => c.CustomerId.Contains(request.CustomerId)).ToList()));
            }

            if (!string.IsNullOrWhiteSpace(request.MobileNo))
            {
                customers.AddRange(DomainDTOMapper.ToCustomerDTOs(_customerRepository
                    .Where(c => c.MobileNo.Contains(request.MobileNo)).ToList()));
            }

            return customers;
        }

        public CustomerUpdateResponse UpdateCustomer(CustomerDTO request)
        {
            try
            {
                var customer = _customerRepository.FirstOrDefault(x => x.CustomerId == request.CustomerId);

                customer.MobileNo = request.MobileNo;
                customer.FullName = request.FullName;
                customer.Email = request.Email;

                var imageName = string.Format(@"{0}", Guid.NewGuid());

                if (String.IsNullOrEmpty(customer.SignatureURL))
                {
                    ImageConverter.SaveImage(request.SignatureURL, imageName);
                    customer.SignatureURL = imageName;
                }
                else
                {
                    imageName = "";
                }

                _customerRepository.SaveChanges();

                CustomerUpdateResponse response = new CustomerUpdateResponse();
                response.ImageName = imageName;
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public bool GetCustomerIdExistency(string customerId)
        {
            return _customerRepository.Where(x => x.CustomerId == customerId).Any();
        }


    }
}
