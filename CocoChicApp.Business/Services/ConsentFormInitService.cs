using CocoChicApp.Business.Interfaces;
using CocoChicApp.Contract.DTO;
using CocoChicApp.EF.Repositories.Interfaces;
using CocoChicApp.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.Business.Services
{
    public class ConsentFormInitService : IConsentFormInitService
    {

        private readonly IConsentFormInitiRepository _consentFormInitiRepository;
        private readonly ICustomerRepository _customerRepository;

        public ConsentFormInitService(IConsentFormInitiRepository consentFormInitiRepository,
                                      ICustomerRepository customeRepository)
        {
            _consentFormInitiRepository = consentFormInitiRepository;
            _customerRepository = customeRepository;
        }

        public bool SaveConsentInitForm(ConsentFormInitiDTO consent, int userId)
        {
            try
            {
                consent.ConsentBy = userId;
                consent.ConsentDatetime = DateTime.Now;
                
                _consentFormInitiRepository.Add(DomainDTOMapper.ToConsentFormInitiDomain(consent));
                _consentFormInitiRepository.SaveChanges();

                UpdateCustomerStatus(consent.CustomerId);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void UpdateCustomerStatus(string customerId)
        {
            try
            {
                var customer = _customerRepository.FirstOrDefault(x => x.CustomerId == customerId);

                customer.IsFilledInitConcern = true;

                _customerRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
