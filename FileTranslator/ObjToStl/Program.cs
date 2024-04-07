using ComputationalGeometry;
using IOOperation;
using System.Xml;
using Conversion;

namespace ObjToStl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string baseDirectory = "D:\\sonali_workspace\\C#\\FileTranslator\\ObjToStl\\Resources\\";
                string baseDirectory1 = "D:\\sonali_workspace\\C#\\FileTranslator\\ObjToStl\\OutputFiles\\";

                Console.WriteLine("Enter the relative path to the input OBJ file:");
                string inputRelativePath = Console.ReadLine();
                string inputFilePath = System.IO.Path.Combine(baseDirectory, inputRelativePath);

                Console.WriteLine("Enter the relative path to the output STL file:");
                string outputRelativePath = Console.ReadLine();
                string outputFilePath = System.IO.Path.Combine(baseDirectory1, outputRelativePath);

                Triangulation triangulation = new Triangulation();
                ObjReader objReader = new ObjReader();
                objReader.ReadOBJ(inputFilePath, triangulation);

                ObjConvertor objToStl = new ObjConvertor();
                objToStl.ObjToStlConversion(outputFilePath, triangulation);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
