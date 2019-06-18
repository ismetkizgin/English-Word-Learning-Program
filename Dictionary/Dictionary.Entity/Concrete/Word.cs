using Dictionary.Entity.Abstract;

namespace Dictionary.Entity.Concrete
{
    public class Word : IEntity
    {
        public int Id { get; set; }
        public string Turkish { get; set; }
        public string English { get; set; }
        public string Sentence { get; set; }
    }
}
