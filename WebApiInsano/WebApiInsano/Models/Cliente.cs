using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiInsano.Models
{
    public class Cliente : UserControls
    {
        [Key]
        public int Id { get; set; }

        [CustomValidFields(Enums.ValidFields.NomeCompleto)]
        public string NomeCompleto { get; set; }

        [CustomValidFields(Enums.ValidFields.EstadoCivil)]
        public string EstadoCivil { get; set; }

        [CustomValidFields(Enums.ValidFields.Rg)]
        public string Rg { get; set; }

        [CustomValidFields(Enums.ValidFields.CpfCnpj)]
        public string CpfCnpj { get; set; }
        public string NomeFantasia { get; set; }
        public int Cep { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Telefone { get; set; }
        public int Celular { get; set; }
        public string Email { get; set; }
    }
}