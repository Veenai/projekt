using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JuliaFasciszewskaLab8PracDom.Models;

namespace JuliaFasciszewskaLab8PracDom.Services
{
    public interface IPracownikService
    {
        /// <summary>
        /// Metoda zwraca wszystkich pracowników
        /// </summary>
        /// <returns></returns>
        List<Pracownik> Get();

        /// <summary>
        /// Metoda dodaje pracownika i zwraca jego id
        /// </summary>
        /// <param name="pracownik"></param>
        /// <returns></returns>
        int Post(Pracownik pracownik);

        /// <summary>
        /// Metdoa edytuje wskazanego pracownika
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pracownik"></param>
        /// <returns></returns>
        bool Put(int id, Pracownik pracownik);

        /// <summary>
        /// Metoda usuwa wskazanego pracownika
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);

    }
}
