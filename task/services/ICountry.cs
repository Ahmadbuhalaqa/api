using task.Model;

namespace task.services
{
    public interface ICountry
    {

        List<CountryDTO> GetAll();


        void Save(CountryDTO countryDTO);

        List<CountryDTO> Search(string? name);
    }
}
