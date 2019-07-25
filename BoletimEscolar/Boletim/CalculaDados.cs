using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar.Boletim
{
    class CalculaDados
    {
        public int Media(int  Nota1, int Nota2, int Nota3)
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public float Frequencia(float nAulas, float nFaltas)
        {
            return ((nAulas - nFaltas) / nAulas) *100;

        }

        public string SituacaoAluno(int media, float frequencia)
        {
            if (media >= 7 && frequencia > 75)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }

        
    }
}
