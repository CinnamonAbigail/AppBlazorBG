using System.ComponentModel.DataAnnotations;

namespace AppBlazor.Entities
{
    public class PedidoFormCLS
    {
        [Required(ErrorMessage = "El numero de empleado es requerido")]
        [Range(1, int.MinValue)]

        public int num_empl { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string nombre { get; set; }


        [Range(18, int.MinValue, ErrorMessage = "La edad debe ser un valor numerico mayor o igual a 18")]
        public int edad { get; set; }


        [Required(ErrorMessage = "El cargo es requerido")]
        public string cargo { get; set; } = null!;


        [Required(ErrorMessage = "La fecha de contrato es requerida")]
        public DateTime fecha_contrato { get; set; }


        [Required(ErrorMessage = "La cuota es requerida")]
        public int cuota { get; set; }


        [Required(ErrorMessage = "Las ventas son requeridas")]
        public int venta { get; set; }
    }
}
