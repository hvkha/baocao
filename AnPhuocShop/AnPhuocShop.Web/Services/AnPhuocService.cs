using AnPhuocShop.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AnPhuocShop.Web.Services
{
    public class AnPhuocService: IAnPhuocService
    {
        private readonly HttpClient httpClient;
        public AnPhuocService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async  Task<AnPhuoc> CreateAnPhuoc(AnPhuoc newAnphuoc)
        {
            return await httpClient.PostJsonAsync<AnPhuoc>("api/anphuocs", newAnphuoc);
        }

        public async Task DeleteAnPhuoc(int id)
        {
            await httpClient.DeleteAsync($"api/anphuocs/{id}");
        }

        public async Task<AnPhuoc> GetAnPhuoc(int id)
        {
            return await httpClient.GetJsonAsync<AnPhuoc>($"api/anphuocs/{id}");
        }

        public async Task<IEnumerable<AnPhuoc>> GetAnPhuocs()
        {
            return await httpClient.GetJsonAsync<AnPhuoc[]>("api/anphuocs");
        }

        public async Task<AnPhuoc> UpdateAnPhuoc(AnPhuoc updateAnphuoc)
        {
            return await httpClient.PutJsonAsync<AnPhuoc>("api/anphuocs",updateAnphuoc);
        }
    }
}
