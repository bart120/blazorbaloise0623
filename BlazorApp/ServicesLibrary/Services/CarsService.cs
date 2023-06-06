using ServicesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLibrary.Services
{
    public class CarsService
    {
        private readonly HttpClient http;

        public CarsService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<List<Car>?> GetAllAsync()
        {
            return await http.GetFromJsonAsync<List<Car>>("carsbob");
        }

        public async Task<Car?> GetById(int id)
        {
            return await http.GetFromJsonAsync<Car>($"cars/{id}");
        }

        public async Task<Car?> AddAsync(Car car)
        {
            var resp = await http.PostAsJsonAsync<Car>("cars", car);
            if (resp.IsSuccessStatusCode)
            {
                return await resp.Content.ReadFromJsonAsync<Car>();
            }
            else
            {
                return null;
            }
        }

        public async Task<Car> DeleteById(int id)
        {
            return await http.DeleteFromJsonAsync<Car>($"cars/{id}");
        }
    }
}
