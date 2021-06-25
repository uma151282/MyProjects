using projectevents.Interfaces;
using projectevents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectevents.Data
{
    public class BookFoodConcrete : IBookFood
    {
        private uma_testContext _context;

        public BookFoodConcrete(uma_testContext context)
        {
            _context = context;
        }

        public int BookFood(BookingFood Food)
        {
            _context.BookingFood.Add(Food);
            return _context.SaveChanges();
        }

        public IEnumerable<Food> FoodList(Food Food)
        {

            if (Food != null)
            {
                var FoodList = (from tempfood in _context.Food
                                where tempfood.FoodType == Food.FoodType && tempfood.MealType == Food.MealType && tempfood.DishType == Food.DishType
                                select tempfood).ToList();
                return FoodList;
            }
            else
            {
                return Enumerable.Empty<Food>();
            }

        }
    }
}
