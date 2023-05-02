using Microsoft.EntityFrameworkCore;
using MODELS.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTA.Login
{
    public class Login : ILogin
    {
        private readonly teoryBContext _context;
        public Login(teoryBContext context)
        {
            _context = context;
        }


        public async Task<bool> addUser(alluser user)
        {

          await  _context.alluser.AddAsync(user);
            var isOk = await _context.SaveChangesAsync() >= 0;
            if(isOk)
            {
                return true;
            }
            return false;
        }

        public async Task<List<alluser>> getAllUser()
        {
            var res = _context.alluser.ToList();
            return res;
        }

        public async Task<int> login(string email)
        {
            var mail = await _context.alluser.FirstOrDefaultAsync(x => x.mail == email);

           

            if (mail == null)
            {
                return 0;
            }
            return 1;
        }
    }
}

