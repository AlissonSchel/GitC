using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WebApiInsano.Enums;

namespace WebApiInsano.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        ContextDB dB = new ContextDB();

        private ValidFields typeField;

        private EstadoCivil estadoCivil;

        public CustomValidFields(ValidFields type)
        {
            typeField = type;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                switch (typeField)
                {
                    case ValidFields.NomeCompleto: { return NomeCompletoCheck(value); }

                    case ValidFields.EstadoCivil: { return EstadoCivil(value); }

                    case ValidFields.Rg: { return RgCheck(value); }

                    case ValidFields.CpfCnpj: { return CpjCnpjCheck(value); }

                    case ValidFields.NomeFantasia:
                        break;

                    case ValidFields.Cep:
                        break;

                    case ValidFields.Endereco:
                        break;

                    case ValidFields.Cidade:
                        break;

                    case ValidFields.Estado:
                        break;

                    case ValidFields.Telefone:
                        break;

                    case ValidFields.Celular:
                        break;

                    case ValidFields.Email:
                        break;

                }
            }
            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório.");
        }

        private ValidationResult NomeCompletoCheck(object value)
        {
            bool result = Regex.IsMatch(value.ToString(), @"[A-Z][a-z]* [A-Z][a-z]*");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult("O nome informado não é válido");
        }

        private ValidationResult RgCheck(object value)
        {
            bool result = Regex.IsMatch(value.ToString(), @"[0-9]\.[0-9]{3}\.[0-9]{3}-[0-9]");
            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"Rg inválido.");
        }

        private ValidationResult EstadoCivil(object value)
        {
            var valueString = value.ToString();
            if (valueString == Enums.EstadoCivil.Casado.ToString() || valueString == Enums.EstadoCivil.Divorciado.ToString() || valueString == Enums.EstadoCivil.Solteiro.ToString() || valueString == Enums.EstadoCivil.Viúvo.ToString())
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Estado civil inválido.");
        }

        private ValidationResult CpjCnpjCheck(object value)
        {
            var teste = dB.clientes.FirstOrDefault(x => x.CpfCnpj == value.ToString());

            if (teste == null)
                return ValidationResult.Success;

            return new ValidationResult($"Cpf/Cnpj já cadastrado.");
        }

    }
}