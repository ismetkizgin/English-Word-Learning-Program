using System.Collections.Generic;
using Dictionary.BL.Abstract;
using Dictionary.BL.Utilities;
using Dictionary.BL.ValidationRules.FluentValidation;
using Dictionary.DAL.Abstract;
using Dictionary.Entity.Concrete;

namespace Dictionary.BL.Concrete
{
    public class WordManager : IWordService
    {
        private readonly IWordDal _wordDal;

        public WordManager(IWordDal wordDal)
        {
            _wordDal = wordDal;
        }

        public void Add(Word word)
        {
            ValidationTool.Validate(new WordValidation(), word);
            _wordDal.Add(word);
        }

        public void Delete(Word word)
        {
            ValidationTool.Validate(new WordValidation(), word);
            _wordDal.Delete(word);
        }

        public List<Word> GetAll()
        {
            return _wordDal.GetAll();
        }

        public void Update(Word word)
        {
            ValidationTool.Validate(new WordValidation(), word);
            _wordDal.Update(word);
        }

        public Word WordGet(int id)
        {
            return _wordDal.Get(x => x.Id == id);
        }
    }
}
