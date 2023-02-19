using System;
using System.Collections.Generic;
using System.Text;

namespace Fish
{
    class Fish // класс Рыбка
    {
        public string Name; //имя

        private string _view; //вид

        private string _color; //окрас

        private string _size; // размер


        public Fish() { }

        public Fish(string name, string view, string color, string size)
        {
            Name = name;
            _view = view;
            _color = color;
            _size = size;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Вид: {_view}");
            Console.WriteLine($"Окрас: {_color}");
            Console.WriteLine($"Размер: {_size}"); 

        }
    }
}





        