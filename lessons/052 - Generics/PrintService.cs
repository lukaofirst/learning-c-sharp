using System;

namespace programa52 {
    class PrintService<T> {
        // Repare que nessa classe uma vez que ele é parametrizado explicitamente como [string], [int] ou [double]
        // Quando se for para o [Program.cs] ele funcionará apenas pra aquele tipo explicito

        // Agora, quando se usa o Generics, usando o tipo [T] ou qualquer outra letra, no exemplo,
        // Quando for pro [Program.cs] pode se definir na sua instanciação pode ser feita como [string], [int] ou [double]
        private T[] _values = new T[10];

        private int _count = 0;

        public void AddValue(T value) {
            if (_count == 10) {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public T First() {
            if (_count == 0) {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print() {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++) {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0) {
                Console.Write(_values[_count - 1]);
            };
            Console.WriteLine("]");
        }
    }
}
