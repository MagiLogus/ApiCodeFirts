namespace WebCodeFirst.Utils
{
    public static class Criptografia //classe estatica 
    {
        /// <summary>
        /// gera uma hash apartir de uma senha 
        /// </summary>
        /// <param name="senha">senha que recebera a hash</param>
        /// <returns>senha criptografada com hash</returns>
        public static string GerarHash(string senha) 
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

        /// <summary>
        /// verifica se a hash da senha informada e igual a hash salva no banco
        /// </summary>
        /// <param name="senhaForm">senha informada pelo usuario</param>
        /// <param name="senhaBanco">senha cadastrada no banco</param>
        /// <returns>true or false (senha verdadeira?)</returns>
        public static bool CompararHash(string senhaForm, string senhaBanco)
        {
            return BCrypt.Net.BCrypt.Verify(senhaForm, senhaBanco);
        }
    }
}
