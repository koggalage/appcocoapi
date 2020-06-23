using CocoChicApp.Contract.DTO;
using CocoChicApp.Contract.DTO.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.Business.Interfaces
{
    public interface ICustomerService
    {
        List<CustomerDTO> GetAllCustomers();

        CustomerUpdateResponse SaveCustomer(CustomerDTO customer, int userId, int branchId);

        List<CustomerDTO> SearchCustomer(CustomerSearchRequest request);

        CustomerUpdateResponse UpdateCustomer(CustomerDTO request);
        bool GetCustomerIdExistency(string customerId);
    }
}
