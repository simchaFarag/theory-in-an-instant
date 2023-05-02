using Microsoft.EntityFrameworkCore;
using MODELS.MODELS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTA.Tamrurs
{
    public class Tmrurim : ITamrurim
    {
        private readonly teoryBContext _context;
        public Tmrurim(teoryBContext context)
        {
            _context = context;
        }

        public async Task<List<sabjekTamrurim>> getAllSabjectTamrur()
        {
            var res = await _context.sabjekTamrurim.ToListAsync();
            return res;
        }

        public async Task<List<Tamrurim>> getAllTamrurs()
        {
            var res = await _context.Tamrurim.ToListAsync();
            return res;
        }

        public async Task<List<questionArr>> playT()
        {

            var res = await _context.Tamrurim.ToListAsync();
            List<questionArr> arrLern = new List<questionArr>();

            arrLern = hh(res);

            return arrLern;

        }



        public List<questionArr> hh(List<Tamrurim> list)
        {

            List<questionArr> arrLern = new List<questionArr>();
            int k = 0;

            int num2,num3;
            for (int i = 0; i < list.Count; i++)
            {
                questionArr x = new questionArr();
                x.id = k++;
                x.question = list[i].description;

                Random rnd = new Random();
                int num = rnd.Next(0, list.Count);
                while (num == i)
                {
                  
                    if (num == i)
                    {
                        num = rnd.Next(0, list.Count);
                    }
                   
                }
                x.e1 = list[num].Smol_T_img;
                 num2 = num;
                num = rnd.Next(0, list.Count);
                 while (num == i || num == num2)
                {
                    if (num == i || num == num2)
                    {
                        num = rnd.Next(0, list.Count);
                    }
                }
                x.e2 = list[num].Smol_T_img;
                num3 = num;
                num = rnd.Next(0, list.Count);
                while (num == i || num == num2||num==num3)
                {
                    if (num == i || num == num2||num==num3)
                    {
                        num = rnd.Next(0, list.Count);
                    }
                }
               
                x.e3 = list[num].Smol_T_img;

                x.e4 = list[i].Smol_T_img;
                x.r = 4;
                arrLern.Add(x);
            }
          
            return arrLern;
        }





    }
}
