using System;
using Dictionary.Entity.Abstract;

namespace Dictionary.Entity.Concrete
{
    public class LearningWord : IEntity
    {
        public int Id { get; set; }
        public int WordId { get; set; }
        public DateTime LearningDate { get; set; }
        public DateTime TestDate { get; set; }
        public int Stage { get; set; }
    }
}
