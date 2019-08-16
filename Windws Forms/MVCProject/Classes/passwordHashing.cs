using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Classes
{
    public class passwordHashing
    {
        // Cria array de bytes
        public byte[] salt;

        /// <summary>
        /// Método para criptografar a senha
        /// </summary>
        /// <param name="senha">Senha as ser criptografada</param>
        /// <returns>Retorna a senha criptografada</returns>
        public string PasswordHash(string senha)
        {
            //Gera no array valores aleatorios em bytes
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);


            //Criptograva a senha utilizando os valores aleatórios em bytes gerados acima
            var pbkdf2 = new Rfc2898DeriveBytes(senha, salt, 10000);


            //Decodifica o conjunto de caracteres da variável acima em uma sequência de bytes
            byte[] hash = pbkdf2.GetBytes(20);


            //Gera um novo array de bytes para armazenar o salt(tamanho 16) + senha(tamanho 20) = 36
            byte[] hashBytes = new byte[36];


            //Coloca os valores das variáveis "salt" e "hash" em seus respectivos lugares
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);


            //Converte a senha decodificada para uma string e salva em uma variável
            string senhaProtegida = Convert.ToBase64String(hashBytes);


            //Retorna a senha criptografada
            return senhaProtegida;
        }
    }
}
