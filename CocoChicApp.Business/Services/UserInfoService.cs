using CocoChicApp.Business.Interfaces;
using CocoChicApp.Contract.DTO.UI;
using CocoChicApp.EF.Repositories.Interfaces;
using CocoChicApp.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocoChicApp.Business.Services
{
    public class UserInfoService : IUserInfoService
    {
        private readonly IUserInfoRepository _userInfoRepository;

        public UserInfoService(IUserInfoRepository userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }

        public LoginReponse Login(LoginRequest request)
        {
            var test = _userInfoRepository.GetAll();
            var loginInfo = _userInfoRepository.FirstOrDefault(x => x.UserName == request.UserName && x.Password == request.Password);

            if (loginInfo != null)
            {
                var xx = DomainDTOMapper.ToLoginReponseDTOs(loginInfo);
                return xx;
                //return DomainDTOMapper.ToLoginReponseDTOs(loginInfo);
            }

            return new LoginReponse();

        }

        public List<EmployeeListResponse> GetUserList(string designation, int branchId)
        {
            return _userInfoRepository.All.Where(x => x.Designation == designation
                                                         && x.BranchId == branchId
                                                         && x.IsDeleted == false
                                                         && x.DeletedDate == null)
                .Select(x => new EmployeeListResponse { EmpNo = x.UserId, EmpName = x.UserName, SignatureURL = x.SignatureURL })
                .ToList();
        }

    }
}
