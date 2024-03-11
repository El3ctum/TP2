namespace TP2.models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        private string _cpf;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O nome não pode ser nulo ou vazio.");
                }

                _nome = value;
            }
        }

        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("A idade deve ser maior que zero.");
                }

                _idade = value;
            }
        }

        public string CPF
        {
            get { return _cpf; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O CPF não pode ser nulo ou vazio.");
                }

                _cpf = value;
            }
        }

        public Pessoa()
        {

        }

        public Pessoa(string nome, int idade, string cpf)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, CPF: {CPF}";
        }
    }
}
