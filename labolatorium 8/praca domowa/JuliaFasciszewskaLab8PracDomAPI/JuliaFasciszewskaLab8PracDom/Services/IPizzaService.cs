using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JuliaFasciszewskaLab8PracDom.Models;

namespace JuliaFasciszewskaLab8PracDom.Services
{
    public interface IPizzaService
    {
        /// <summary>
        /// Metoda zwraca wszystkie pizze
        /// </summary>
        /// <returns></returns>
        List<Pizza> Get();

        /// <summary>
        /// Metoda dodaje nową pizze i zwraca jej id
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns></returns>
        int Post(Pizza pizza);

        /// <summary>
        /// Metdoa edytuje wskazaną pizze
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pizza"></param>
        /// <returns></returns>
        bool Put(int id, Pizza pizza);

        /// <summary>
        /// Metoda usuwa wskazaną pizze
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);

    }
}
