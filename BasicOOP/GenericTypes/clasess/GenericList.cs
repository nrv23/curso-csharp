using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes.clasess
{
    public class GenericList<T> // se marca la clase como generica
    {
        private T[] _items = new T[4]; // arreglo para almacenar los elementos

        private int _size = 0; // tamaño actual de la lista

        public void Add(T item)
        {
            if (_size >= _items.Length)
            {
                var newitems = new T[_items.Length * 2]; // duplica el tamaño de la matriz nueva

                for (int i = 0; i < _items.Length; i++)
                {
                    newitems[i] = _items[i]; // copia los elementos antiguos a la nueva matriz
                }
                _items = newitems; // asigna la nueva matriz a la variable de instancia
            }
            // agregir el nuevo elemento
            _items[_size] = item; // agrega el elemento y aumenta el tamaño
            _size++; // incrementa el tamaño del contador

        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _size) // i el índice está fuera de rango de tamaño del array
            {
                throw new IndexOutOfRangeException($"{index} is outside the bounds of the list");
            }
            _size--; // decrementa el tamaño del contador
            for (int i = index; i < _size; i++)
            {
                _items[i] = _items[i + 1]; // el valor del indice actual es igual al valor del siguiente índice, por eso se corre un espacio a la izquierda
            }

            //_items[_size] = default(T); // esto se usa para limpiar el indice que se quiso eliminar, asignandole el valor por defecto del tipo de dato (0 en este caso
            _items[_size] = default;
        }

        public int Count => _size; // propiedad de solo lectura que devuelve el tamaño actual de la lista

        public T GetAtIndex(int index) // método para obtener el elemento en un índice específico
        {
            if (index < 0 || index >= _size) // si el índice está fuera de rango de tamaño del array
            {
                throw new IndexOutOfRangeException($"{index} is outside the bounds of the list");
            }
            return _items[index]; // devuelve el elemento en el índice especificado
        }


    }
}
