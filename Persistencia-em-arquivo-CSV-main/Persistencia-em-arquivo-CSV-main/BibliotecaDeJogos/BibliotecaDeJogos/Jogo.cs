using System;

namespace BibliotecaDeJogos
{
	
	public class Jogos
	{
		public string Nome { get; set; }
        public string Plataforma { get; set; }
        public string Genero { get; set; }
        public string Status { get; set; }
        public double Nota { get; set; }

        public Jogos() { }

        public Jogos(string nome, string plataforma, string genero, string status, double nota)
        {
            Nome = nome;
            Plataforma = plataforma;
            Genero = genero;
            Status = status;
            Nota = nota;
        }
    }
}
