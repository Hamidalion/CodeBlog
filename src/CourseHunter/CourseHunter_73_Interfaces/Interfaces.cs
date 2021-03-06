﻿using System;

namespace CourseHunter_73_Interfaces
{
    public interface IBaseCollection
    {
        void Add(object obj);

        void Remove(object obj);
    }

    public class BaseList : IBaseCollection
    {
        private object[] items;
        private int count = 0;


        public BaseList(int initialCapasity)
        {
            items = new object[initialCapasity];
        }

        public void Add(object obj)
        {
            items[count] = obj;
            count++;
        }

        public void Remove(object obj)
        {
            items[count] = null;
            count--;
        }
    }
}
