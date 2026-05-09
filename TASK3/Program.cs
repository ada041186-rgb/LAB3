using System.Text;
using TASK3.Abstraction;
using TASK3.Concrete_Implementors;
using TASK3.Implementor;
using TASK3.Refined_Abstractions;

namespace TASK3
{
    internal class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            IRenderer raster = new RasterRenderer();
            IRenderer vector = new VectorRenderer();

            Console.WriteLine("--- Circle ---");
            Shape circle = new Circle(raster, 5f);
            circle.Draw();
            circle.SetRenderer(vector);
            circle.Draw();

            Console.WriteLine("\n--- Square ---");
            Shape square = new Square(raster, 4f);
            square.Draw();
            square.SetRenderer(vector);
            square.Draw();

            Console.WriteLine("\n--- Triangle ---");
            Shape triangle = new Triangle(raster, 6f, 3f);
            triangle.Draw();
            triangle.SetRenderer(vector);
            triangle.Draw();

            Console.WriteLine("\n--- Зміна рендерера на льоту ---");
            Shape shape = new Circle(vector, 10f);
            Console.Write("Vector: "); shape.Draw();
            shape.SetRenderer(raster);
            Console.Write("Raster: "); shape.Draw();
        }
    }
}