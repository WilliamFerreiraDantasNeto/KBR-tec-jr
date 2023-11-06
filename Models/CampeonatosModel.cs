using System.ComponentModel.DataAnnotations;

namespace KRB_tec_jr.Models
{
    public class CampeonatosModel
    {
        [Key]
        public int Codigo { get; set; }
        public string Campeonato { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string DataRealizacao { get; set; }
        public string Sobre { get; set; }
        public string Ginasio { get; set; }
        public string InformacoesGerais { get; set; }
        public string? EntradaAoPublico { get; set; }
        public string Tipo { get; set; }
        public string Fase { get; set; }
        public string Status { get; set; }
        public int Destaque { get; set; }
    }
}
