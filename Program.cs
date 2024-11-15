namespace CriarSenhaIntellihub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione enter para gerar novas senhas\n" +
                "<cancel> para cancelar e <cls> para limpar:");

            while (true)
            {
                string str = $"{Console.ReadLine()}";

                if (str.ToLower().Equals("clear") || str.ToLower().Equals("cls"))
                {
                    Console.Clear();
                    Console.WriteLine("Pressione <enter> para gerar uma nova senha\n" +
                "<cancel> para cancelar e <cls> para limpar:");
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine(CriarNovaSenha());
                    }
                }
            }
        }

        public static string CriarNovaSenha(int TAMANHO = 18)
        {
            try
            {
                const string MAIUSCULAS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                const string MINUSCULAS = "abcdefghijklmnopqrstuvwxyz";
                const string NUMEROS = "0123456789";
                // const string ESPECIAIS = @"(!@#$%&*()-+.,;?{[}]^><:)";
                const string ESPECIAIS = "@!#$%&*+,;:/|";
                string PERMITIDO = $"{MAIUSCULAS}{MINUSCULAS}{NUMEROS}{ESPECIAIS}";

                string SENHA = "", SENHA_PROVISORIA = "";
                Random rand = new Random();

                for (int i = 0; i < 3; i++)
                {
                    int n = rand.Next(0, MAIUSCULAS.Length);
                    SENHA_PROVISORIA += MAIUSCULAS[n];
                }

                for (int i = 0; i < 3; i++)
                {
                    int n = rand.Next(0, MINUSCULAS.Length);
                    SENHA_PROVISORIA += MINUSCULAS[n];
                }

                for (int i = 0; i < 6; i++)
                {
                    int n = rand.Next(0, NUMEROS.Length);
                    SENHA_PROVISORIA += NUMEROS[n];
                }

                for (int i = 0; i < 6; i++)
                {
                    int n = rand.Next(0, ESPECIAIS.Length);
                    SENHA_PROVISORIA += ESPECIAIS[n];
                }

                while (SENHA.Length < TAMANHO)
                {
                    int n = rand.Next(0, SENHA_PROVISORIA.Length);
                    SENHA += SENHA_PROVISORIA[n];
                    SENHA_PROVISORIA = SENHA_PROVISORIA.Remove(n, 1);
                }

                return SENHA;
            }
            catch
            {
                return null;
            }
        }

        public static string CriarNovoCodigo(int TAMANHO = 8)
        {
            try
            {
                const string LETRAS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                const string NUMEROS = "0123456789";
                string PERMITIDO = $"{LETRAS}{NUMEROS}";

                string SENHA = "", SENHA_PROVISORIA = "";
                Random rand = new Random();

                for (int i = 0; i < 3; i++)
                {
                    int n = rand.Next(0, LETRAS.Length);
                    SENHA_PROVISORIA += LETRAS[n];
                }

                for (int i = 0; i < 6; i++)
                {
                    int n = rand.Next(0, NUMEROS.Length);
                    SENHA_PROVISORIA += NUMEROS[n];
                }

                while (SENHA.Length < TAMANHO)
                {
                    int n = rand.Next(0, SENHA_PROVISORIA.Length);
                    SENHA += SENHA_PROVISORIA[n];
                    SENHA_PROVISORIA = SENHA_PROVISORIA.Remove(n, 1);
                }

                return SENHA;
            }
            catch
            {
                return null;
            }
        }
    }
}
