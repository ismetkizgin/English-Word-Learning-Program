using System.Collections.Generic;
using Dictionary.Entity.Concrete;

namespace Dictionary.BL.Abstract
{
    public interface IWordService
    {
        List<Word> GetAll();
        Word WordGet(int Id);
        void Add(Word word);
        void Update(Word word);
        void Delete(Word word);
    }
}
