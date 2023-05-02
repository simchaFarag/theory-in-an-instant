using MODELS.MODELS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTA.Login
{
    public interface ILogin
    {
        Task<List<alluser>> getAllUser();
        Task<bool> addUser(alluser user);
        Task<int> login(string email);

    }
}
