using System;
using System.Collections.Generic;
using System.Linq;
using Dictionary.BL.Abstract;
using Dictionary.DAL.Abstract;
using Dictionary.Entity.Concrete;

namespace Dictionary.BL.Concrete
{
    public class LearningWordManager : ILearningWordSevice
    {
        private readonly ILearningWordDal _learningWordDal;
        public LearningWordManager(ILearningWordDal learningWordDal)
        {
            _learningWordDal = learningWordDal;
        }

        public void Add(LearningWord learningWord)
        {
            _learningWordDal.Add(learningWord);
        }

        public void Delete(LearningWord learningWord)
        {
            _learningWordDal.Delete(learningWord);
        }

        public List<LearningWord> GetAll()
        {
            return _learningWordDal.GetAll();
        }

        public LearningWord LearningWordGet(int id)
        {
            return _learningWordDal.Get(x => x.Id == id);
        }

        public LearningWord LearningWordGetNewid()
        {
            return _learningWordDal.GetAll(x =>x.Stage != 0).Where(x => x.TestDate.Date <= DateTime.Now.Date)
                .OrderBy(u => Guid.NewGuid()).FirstOrDefault();
        }

        public LearningWord LearningWordAddNewid()
        {
            return _learningWordDal.GetAll(x => x.Stage == 0).OrderBy(u => Guid.NewGuid()).Take(1).FirstOrDefault();
        }

        public void Update(LearningWord learningWord)
        {
            _learningWordDal.Update(learningWord);
        }

        public void DeleteWordId(int id)
        {
            LearningWord learningWord = _learningWordDal.Get(x => x.WordId == id);
            _learningWordDal.Delete(learningWord);
        }
    }
}