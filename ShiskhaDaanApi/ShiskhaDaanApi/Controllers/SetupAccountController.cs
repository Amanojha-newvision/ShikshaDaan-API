using AutoMapper;
using Database;
using DTO;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace ShiskhaDaanApi.Controllers
{
    public class SetupAccountController : ControllerBase
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public SetupAccountController(ApplicationContext context, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _context = context;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpPost("createpassword")] // POST: api/SetupAccount/createpassword
        public async Task<ActionResult<SetupAccount>> Register([FromBody]SetupAccountDto setupAccountDto)
        {
            using var hmac = new HMACSHA512();

            var superAdmin = new SetupAccount
            {
                SuperAdminEmail = setupAccountDto.SuperAdminEmail,
                CreatePassword = setupAccountDto.CreatePassword,
                ConfirmPassword = setupAccountDto.ConfirmPassword,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(setupAccountDto.CreatePassword)),
                PasswordSalt = hmac.Key
            };
           

            _context.SuperAdmins.Add(superAdmin);
            await _context.SaveChangesAsync();
            // _unitOfWork.SuperAdmins.Add();
            _unitOfWork.Complete();

            return superAdmin;


            // return _context.SuperAdmins.Select(x => _mapper.Map<SetupAccountDto>(x)).ElementAt(0);
            

        }
    }
}
