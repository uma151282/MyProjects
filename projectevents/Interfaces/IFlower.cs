using projectevents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectevents.Interfaces
{
    public interface IFlower
    {
        void SaveFlower(Flower Flower);
        IQueryable<Flower> ShowFlower(string sortColumn, string sortColumnDir, string Search);
        int DeleteFlower(int id);
        Flower GetFlowerByID(int id);
        void UpdateFlower(Flower Flower);
        bool CheckFlowerAlready(string FlowerName);
        List<FlowerModel> GetAllFlower();
        IEnumerable<Flower> ShowAllFlower();
    }
}
