using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JuliaFasciszewskaLab8PracDom.Models;

namespace JuliaFasciszewskaLab8PracDom.Services
{
    public interface IPizzeriaService
    {
        /// <summary>
        /// Metoda zwraca wszystkie pizzeerie
        /// </summary>
        /// <returns></returns>
        List<Pizzeria> Get();

        /// <summary>
        /// Metoda dodaje nową pizzerie i zwraca jej id
        /// </summary>
        /// <param name="pizzeria"></param>
        /// <returns></returns>
        int Post(Pizzeria pizzeria);

        /// <summary>
        /// Metdoa edytuje wskazaną pizzerie
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pizzeria"></param>
        /// <returns></returns>
        bool Put(int id, Pizzeria pizzeria);

        /// <summary>
        /// Metoda usuwa wskazaną pizzerie
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);

    }
}
