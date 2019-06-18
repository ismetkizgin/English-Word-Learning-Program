using Dictionary.Entity.Abstract;
using System.Text;

namespace Dictionary.Entity.Concrete
{
    public class Word : IEntity
    {
        public int Id { get; set; }

        private string _turkish;
        public string Turkish
        {
            get
            {
                return _turkish;
            }
            set
            {
                _turkish = FirstUpper(value);
            }
        }

        private string _english;
        public string English
        {
            get
            {
                return _english;
            }
            set
            {
                _english = FirstUpper(value);
            }
        }
        private string _sentence;
        public string Sentence
        { 
            get
            {
                return _sentence;
            }
            set
            {
                _sentence = FirstUpper(value);
            }
        }

        private string FirstUpper(string value)
        {
            bool first = true;
            StringBuilder builder = new StringBuilder();
            foreach (var x in value.ToCharArray())
            {
                if (first)
                {
                    builder.Append(x.ToString().ToUpper());
                    first = false;
                }
                else
                    builder.Append(x);
            }
            return builder.ToString();
        }
    }
}
