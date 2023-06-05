﻿using ServicesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
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

        public async Task<List<Car>> GetAllAsync()
        {
            return await http.GetFromJsonAsync<List<Car>>("cars");
        }
    }
}