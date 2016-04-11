namespace Model.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("Contenido")]
    public partial class Contenido
    {
        [Key]
        public int idContenido { get; set; }

        [StringLength(50)]
        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        [StringLength(100)]
        public string Url { get; set; }

        [StringLength(100)]
        public string Imagen { get; set; }

        public int? idCategoria { get; set; }

        public DateTime? CreadoFecha { get; set; }

        public int? CreadoPor { get; set; }

        public int? ActualizadoPor { get; set; }

        public DateTime? ActualizadoFecha { get; set; }

        public int? idEmpresa { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual Usuario Usuario { get; set; }

    }
}
