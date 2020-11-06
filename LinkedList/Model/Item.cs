﻿using System;
namespace LinkedList
{
    public class Item<T>
    {
        private T data = default(T);
        public T Data { get; set; }
        public Item<T> Next { get; set; }
        public Item(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
