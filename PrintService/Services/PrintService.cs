using System;

namespace PrintService.Services {
    public class PrinterService<T> {
        // Attributes
        private T[] _values = new T[10];
        private int _count = 0;

        // Methods
        public void AddValue(T value) {
            if (_count == 10) throw new InvalidOperationException("Limite de números excedido!");
            _values[_count] = value;
            _count++;
        }

        public T First() {
            if (_count == 0) throw new InvalidOperationException("Lista vazia!");
            return _values[0];
        }

        public void Print() {
            string listNumbers = "[";
            int n = _count;
            for (int i = 0; i < n; i++) {
                listNumbers += _values[i].ToString() + ",";
            }
            listNumbers = listNumbers.Substring(0, listNumbers.Length - 1);
            listNumbers += "]";
            Console.WriteLine(listNumbers);
        }
    }
}
