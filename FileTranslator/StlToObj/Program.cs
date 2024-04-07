using Geometry;
using ComputationalGeometry;
using IOOperation;
using Conversion;

namespace STLTOOBJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string baseDirectory = "D:\\sonali_workspace\\C#\\FileTranslator\\STLTOOBJ\\Resources\\";
                string baseDirectory1 = "D:\\sonali_workspace\\C#\\FileTranslator\\STLTOOBJ\\OutputFiles\\";

                Console.WriteLine("Enter the relative path to the input OBJ file:");
                string inputRelativePath = Console.ReadLine();
                string inputFilePath = System.IO.Path.Combine(baseDirectory, inputRelativePath);

                Console.WriteLine("Enter the relative path to the output STL file:");
                string outputRelativePath = Console.ReadLine();
                string outputFilePath = System.IO.Path.Combine(baseDirectory1, outputRelativePath);

                Triangulation triangulation = new Triangulation();
                STLReader stlReader = new STLReader();
                stlReader.ReadSTL(inputFilePath, triangulation);

                StlToObj stlToObj = new StlToObj();
                stlToObj.StlToObjConversion(outputFilePath, triangulation);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
