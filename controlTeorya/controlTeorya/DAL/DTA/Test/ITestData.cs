using DAL.DTO;
using MODELS.MODELS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTA.Test
{
   public interface ITestData
    {
        Task<List<questionArr>> getAllQuestion();
        Task<List<questionArr>> lern();
        Task<bool> endTest(List<endTestDto> test);
    }
} 