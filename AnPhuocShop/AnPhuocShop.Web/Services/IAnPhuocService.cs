using AnPhuocShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnPhuocShop.Web.Services
{
    public interface IAnPhuocService
    {
        Task<IEnumerable<AnPhuoc>> GetAnPhuocs();
        Task<AnPhuoc> GetAnPhuoc(int id);
        Task<AnPhuoc> UpdateAnPhuoc(AnPhuoc updateAnphuoc);
        Task<AnPhuoc> CreateAnPhuoc(AnPhuoc newAnphuoc);
        Task DeleteAnPhuoc(int id);
    }
}
