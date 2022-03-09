using Series.Enum;

namespace Series.Classes
{
    public class Serie : EntidadeBase
    {
        //atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido { get; set; }

        //construtor
        //construtor ira receber os seguintes valores no Program.cs

        public Serie(int id, Genero genero, string titulo, string descricao, int ano )
        {
            //apos receber os valores ira armazenar nas propriedades com letra maiuscula
            this.Id = id;       //nao esta na classe Series mas ta na classe EntidadeBase
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            //momento da criação nao pode excluir
            this.Excluido = false;
        }
        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            //Environment.NewLine - serve como um \n(quebra de linha)
            //cria variavel retorno
            string retorno = "";
            //escreve 
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        //retorna titulo e ID serao usados no Program.cs na hora da listagem, por isso foram feitos(e o metodo retornaTitulo é necessario ja que a propriedade Titulo é private e nao pode ser instanciada fora da classe)
        public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}

        //cria metodo para executar exclusao
        //apenas vai marcar como excluido, nao ira deletar de fato
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}