using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleLibrary {
    public abstract class Figure {
        // Можно создать потомков этого класса для разных фигур, но в задании этого не требовалось.
        protected internal Figure() {
        }
        public abstract double getSquare();
        //public abstract double Perimetr();            // можно добавить еще несколько методов для расчета различных значений(параметр, медианы, высоты и т.д.),
        //public abstract double RadiusOfOutCircle();   //т.е. можно расширить возможности библиотеки просто добавив реализации нужных методов
        //public abstract double RadiusOfInCircle();    // Если заморочиться можно вообще сделать через паттерн Стратегия чтобы для разных фигур считались разные параметры(на одном тест-задании я так сделал)
        // За счет приватных конструкторов/статических методов инициализации можно  сделать реализацию через какой-нибудь порождающий паттерн(Фабричный метод, Абстр. фабрика)
    }

    public class Triangle : Figure {
        private static object varForLock = new object();
        private double hypotenuse;
        private double leg1;
        private double leg2;
        private Triangle(double one, double two, double three) {
            initSides(one, two, three, out hypotenuse, out leg1, out leg2);
        }

        public static Triangle createTriangle(double one, double two, double three) {
            lock (varForLock) {
                if (one <= 0 || two <= 0 || three <= 0) {
                    throw new TriangleException("Sides must be positive");
                } else if (one >= two + three || two >= one + three || three >= one + two) {
                    throw new TriangleException("This is not triangle");
                } else
                    return new Triangle(one, two, three);
            }
        }
        private void initSides(double one, double two, double three, out double hypotenuse, out double leg1, out double leg2) {
            if (one > two && one > three) { hypotenuse = one; leg1 = two; leg2 = three; } else if (two > one && two > three) { hypotenuse = two; leg1 = one; leg2 = three; } else { hypotenuse = three; leg1 = one; leg2 = two; }
        }
        public override double getSquare() {
            if (Math.Pow(hypotenuse, 2) != Math.Pow(leg2, 2) + Math.Pow(leg1, 2)) {
                throw new TriangleException("This is not right triangle");  // Тут вместо исключения можно написать код который считает площадь для НЕпрямоугольного треугольлника, 
                // и то как названы стороны роли играть не будет. 
            } else return 0.5 * leg1 * leg2;                                // Когда мы знаем что треугольник прямоуголный и известны катеты вычислить площадь не сложно
        }
    }
}

