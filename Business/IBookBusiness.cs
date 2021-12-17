using System.Collections.Generic;
using WebApplication1.Data.VO;

namespace WebApplication1.Business {
    public interface IBookBusiness {
        BookVO Create(BookVO book);
        BookVO FindByID(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}
