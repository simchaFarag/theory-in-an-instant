using MODELS.MODELS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTA.Tamrurs
{
    public interface ITamrurim
    {
        Task<List<Tamrurim>> getAllTamrurs();
        Task<List<sabjekTamrurim>> getAllSabjectTamrur();
        Task<List<questionArr>> playT();
    }
}
