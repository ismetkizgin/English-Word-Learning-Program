using Dictionary.DAL.Abstract;
using Dictionary.Entity.Concrete;

namespace Dictionary.DAL.Concrete.EntityFramework
{
    public class EfWordDal : EfEntityRepositoryBase<Word,DictionaryContext>, IWordDal
    {
       
    }
}
