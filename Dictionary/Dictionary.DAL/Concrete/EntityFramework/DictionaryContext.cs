using System.Data.Entity;
using Dictionary.Entity.Concrete;

namespace Dictionary.DAL.Concrete.EntityFramework
{
    public class DictionaryContext:DbContext
    {
        public DbSet<Word> Word { get; set; }
        public DbSet<LearningWord> LearningWord { get; set; }
    }
}