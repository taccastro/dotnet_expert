namespace SolidPrinciples.Dip
{
    public interface IPersonRepository
    {
        void Add(Person person);
    }

    public class PersonRepository : IPersonRepository
    {
        public PersonRepository()
        {
            // Abrir Conexão com Banco de Dados
        }
        public void Add(Person person)
        {
            throw new NotImplementedException();
        }
    }
}