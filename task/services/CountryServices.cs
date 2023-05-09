using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using task.data;
using task.Model;

namespace task.services
{
    public class CountryServices:ICountry
    {
        taskContext context;
        public CountryServices(taskContext _context)
        {

            context= _context;
        }


        public List<CountryDTO> GetAll()
        {
            var all= context.countries.ToList();

            var contries=new List<CountryDTO>();

            foreach (var item in all)
            {
                contries.Add(new CountryDTO
                {
                    Id = item.iD,
                    Name = item.Name,
                    Code = item.Code,
                });
            }
            return contries;
        }


        public void Save(CountryDTO countryDTO)
        {
            var newCountry = new Country()
            {
                Name = countryDTO.Name,
                Code=countryDTO.Code

            };

            context.countries.Add(newCountry);
            context.SaveChanges();
        }

        public List<CountryDTO> Search( string? name)
        {
            var all = context.countries.Where(d => d.Name == name).ToList();
            var country=new List<CountryDTO>();
            foreach (var item in all)
            {

                country.Add(new CountryDTO
                {
                    Id = item.iD,
                    Name = item.Name,
                    Code = item.Code,

                });

            }
            return country;
        }

      
    }
}
