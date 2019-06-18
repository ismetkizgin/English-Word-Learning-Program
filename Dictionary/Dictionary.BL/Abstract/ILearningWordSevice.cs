using System.Collections.Generic;
using Dictionary.Entity.Concrete;

namespace Dictionary.BL.Abstract
{
    public interface ILearningWordSevice
    {
        List<LearningWord> GetAll();
        LearningWord LearningWordGet(int Id);
        LearningWord LearningWordGetNewid();
        LearningWord LearningWordAddNewid();
        void Add(LearningWord learningWord);
        void Delete(LearningWord learningWord);
        void Update(LearningWord learningWord);
        void DeleteWordId(int id);
    }
}