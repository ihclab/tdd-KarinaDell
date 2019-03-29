using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ordenamiento.Pruebas
{
    [TestClass]
    public class UnitTest1
    {
        private int[] salidaEsperada = new int[] {1, 2, 3, 4, 5};
        private Ordenamiento.Burbuja ordenar = new Ordenamiento.Burbuja();
       
        [TestMethod]
        public void Ordenado() {
            int[] entrada = new int[] {1, 2, 3, 4, 5};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
            
        }

        [TestMethod]
        public void Desordenado() {
            int[] entrada = new int[] {1, 3, 2, 4, 5};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
            
        }

        [TestMethod]
        public void Principio() {
            int[] entrada = new int[] {5, 1, 2, 3, 4};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
            
        }

        [TestMethod]
        public void Final() {
            int[] entrada = new int[] {2, 3, 4, 5, 1};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
            
        }

        [TestMethod]
        public void Invertido() {
            int[] entrada = new int[] {5, 4, 3, 2, 1};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
            
        }
    }
}
