﻿using API.Models;

namespace API.Services
{
    public interface ICarCollection
    {
        Task CreateCar(Car car);
        Task UpdateCar(Car car);
        Task DeleteCar(string id);
        Task<List<Car>> GetAllCars();
        Task<Car> GetCarById(string id);
        Task<List<Car>> GetCarParameters(string Category, string Brand);
        Task<bool> Exists(string id);


    }
}
