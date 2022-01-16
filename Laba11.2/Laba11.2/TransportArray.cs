using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;

namespace Laba11._2
{
    [Serializable]
    public class TransportArray : IList<Transport>, IComparable
    {
        Transport[] array;
        public List<LiteCar> liteCars;

        public TransportArray(Transport[] arr)
        {
            array = arr;
        }

        public TransportArray(List<LiteCar> liteCars)
        {
            this.liteCars = liteCars;
        }

        private readonly IList<Transport> _list = new List<Transport>();

        public Transport this[int index]
        {
            get { return _list[index]; }
            set { _list[index] = value; }
        }

        public int Count
        {
            get { return _list.Count; }
        }

        public bool IsReadOnly
        {
            get { return _list.IsReadOnly; }
        }

        public void Add(Transport item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(Transport item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(Transport[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Transport> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public int IndexOf(Transport item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, Transport item)
        {
            _list.Insert(index, item);
        }

        public bool Remove(Transport item)
        {
            return _list.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public void SortObject()
        {
            int[] arr = new int[array.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = array[i].Speed;
            }
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (array[i].Speed > array[j].Speed)
                    {
                        temp = array[i].Speed;
                        array[i].Speed = array[j].Speed;
                        array[j].Speed = temp;
                    }
                }

            }
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(array[i].Speed);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public int CompareTo(object p)
        {
            TransportArray c = p as TransportArray;
            return this.Count.CompareTo(c.Count);
        }
    }
}
