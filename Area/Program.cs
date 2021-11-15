using System;

namespace Area
{
    class AREA
    {
        double areacirculo,arearectangulo,areatriangulo;
        public void AreaCirculo(double radio) {
            areacirculo = 3.14 * radio * radio;
            Console.WriteLine("El area del circulo = "+ areacirculo);
        }
        public void AreaRectangulo(double b,double altura)
        {
            arearectangulo = b * altura;
            Console.WriteLine("El area del rectangulo = "+ arearectangulo);
        }
        public void AreaTriangulo(double b, double altura)
        {
            areatriangulo = (b * altura)/2;
            Console.WriteLine("El area del triangulo = "+ areatriangulo);
        }
        static void Main(string[] args)
        {
            
            AREA a = new AREA();

            Console.WriteLine("Introduzca el radio del circulo");
            double radio = double.Parse(Console.ReadLine());
            a.AreaCirculo(radio);

            Console.WriteLine("Introduzca la altura y la base del rectangulo");
            double alturaR = double.Parse(Console.ReadLine());
            double baseR = double.Parse(Console.ReadLine());
            a.AreaRectangulo(baseR,alturaR);

            Console.WriteLine("Introduzca la altura y la base del triangulo");
            double alturaT = double.Parse(Console.ReadLine());
            double baseT = double.Parse(Console.ReadLine());
            a.AreaTriangulo(baseR, alturaR);

        }
    }
}
