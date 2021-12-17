using System.Collections.Generic;
using WebApplication1.Data.VO;
using WebApplication1.Hypermedia.Utils;

namespace WebApplication1.Business {
    public interface IPersonBusiness {

        PersonVO Create(PersonVO person);
        PersonVO FindByID(long id);
        List<PersonVO> FindByName(string firstName, string lastName);
        List<PersonVO> FindAll();
        PagedSearchVO<PersonVO> FindWithPagedSearch(
            string name, string sortDirection, int pageSize, int page);
        PersonVO Update(PersonVO person);
        PersonVO Disable(long id);
        void Delete(long id);
    }
}
