using AppBlazor.Entities;
using System.ComponentModel.DataAnnotations;
using Xunit;
    
namespace AppBlazor.Test
{
    public class PedidoFormCLSTest
    {
        [Fact]
        public void Test1()
        {

        }
        private List<ValidationResult> ValidarModelo(object modelo)
        {
            var resultados = new List<ValidationResult>();
            var contexto = new ValidationContext(modelo, null, null);
            Validator.TryValidateObject(modelo, contexto, resultados, true);
            //Se validara el objeto, en base a un contexto en la que se obtendran resultados.
            return resultados;
        }//Lista que contienen los resultados de las validaciones

        //Iniciaremos la prueba unitaria 1
        [Fact]
        public void ValidacionDebeFallarCuandoCamposEstanVacios()
        {
            var pedido = new PedidoFormCLS();
            var errores = ValidarModelo(pedido);

            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El numero de empleado es requerido"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El nombre es requerido"));
        }

        //Prueba unitaria 2
        [Fact]
        public void ValidacionDebePasarConDatosCorrectos()
        {
            var pedido = new PedidoFormCLS
            {
                num_empl = 1,
                nombre = "Nombre de prueba",
                edad = 20,
                cargo = "cargo prueba",
                cuota = 20,
                venta = 20
            };
            var errores = ValidarModelo(pedido);

            Assert.Empty(errores);
        }
    }
}