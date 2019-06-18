using Dictionary.DAL.Abstract;
using Dictionary.Entity.Concrete;

namespace Dictionary.DAL.Concrete.EntityFramework
{
    public class EfLearningWord : EfEntityRepositoryBase<LearningWord, DictionaryContext>, ILearningWordDal
    {

    }
}
