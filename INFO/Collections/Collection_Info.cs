using System.Collections.Generic;
using Training;

namespace ConsoleApp1.Collections
{
    public class Collection_Info
    {
        List<Stalker> _list = new List<Stalker>();

        /// Cаморасширяется
        /// new List<Stalker>(int размер) // пустой размера int
        /// new List<Stalker>(Stalker[]) // из массива
        ///.Add() добавляет в лист
        ///.Remove() удаляет 
        ///.Contains() - содержит ли лист этот элементж
        ///.Clear() - очищает лист
        ///.AddRange() - добавляет к концу массив

        
        void TestSyntax()
        {
            foreach (Stalker stalker in _list) 
            {
                stalker.Yell("SUKA");
            }
        }

        Dictionary<string, Stalker> _dictionary = new Dictionary<string, Stalker>(); //<ключ, значение>
        /// <summary>
        /// позволяет получать элемент по ключу
        /// _dictionary[ключ]
        /// </summary>
        void TestSyntax2()
        {
            foreach (Stalker stalker in _list)
            {
                _dictionary.Add(stalker.Name, stalker);
            }
            _dictionary["дуля"]
        }


    }
}
