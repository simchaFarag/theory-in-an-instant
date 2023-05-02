using DAL.DTO;
using Microsoft.EntityFrameworkCore;
using MODELS.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTA.Test
{
    public class TestData : ITestData
    {
        private readonly teoryBContext _context;
        public TestData(teoryBContext context)
        {
            _context = context;
        }
        public async Task<List<questionArr>> getAllQuestion()
        {
            var res = await _context.questionArr.ToListAsync();
            return res;
        }

        public async Task<List<questionArr>> lern()
        {
            var res = await _context.questionArr.ToListAsync();
            List<questionArr> arrLern = new List<questionArr>() ;

           arrLern= hh(res);

            return arrLern;

        }
        public  List<questionArr> hh(List<questionArr> list)
        {
          
            List<questionArr> arrLern = new List<questionArr>();
            int k = 0;
            Random rnd = new Random();
            int num = rnd.Next(0, list.Count);
            for (int i = num; i < list.Count; i++)
            {
                questionArr x = new questionArr();
                x.id = k++;
                x.question = list[i].question;
                x.e1 = list[i].e1;
                x.e2 = list[i].e2;
                x.e3 = list[i].e3;
                x.e4 = list[i].e4;
                x.r = list[i].r; x.img = list[i].img;
                arrLern.Add(x);
            }
            for (int i = 0; i < num; i++)
            {
                questionArr x = new questionArr();
                x.id = k++;
                x.question = list[i].question;
                x.e1 = list[i].e1;
                x.e2 = list[i].e2;
                x.e3 = list[i].e3;
                x.e4 = list[i].e4;
                x.r = list[i].r; x.img = list[i].img;
                arrLern.Add(x);
            }
            return arrLern;
        }

        public async Task<bool> endTest(List<endTestDto> test)
        {

            //בדיקה האם המשתמש קיים במערכת
            //אם כן- לשמור את המבחן בDB
           // אם לא קיים לא לשמור
            for (int i = 0; i < test.Count(); i++)
            {
               
            }
            throw new NotImplementedException();
        }
    }
}
