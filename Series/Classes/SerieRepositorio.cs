using Series.Interfaces;

namespace Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        //cria listaSerie (list)
        private List<Serie> listaSerie = new List<Serie>();
        //quando implementa pelo vscode ja da toda a estrutura
        public void Atualiza(int id, Serie entidade)
        {   //da a listaSerie os dados de cada metodo
            listaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {   //nao pode usar REMOVEAT se nao vai alterar os indices dos objetos quando for excluido
            //cria um bool para saber se o registro ta excluido ou nao em SERIE(classe)
        
        
            listaSerie[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            
            listaSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            //apenas retorna a lista
            return listaSerie;
        }

        public int ProximoId()
        {
            //Count sempre esta um valor acima do index, se tem Count=1 tem 1 valor com o index = 0
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }

}