using Dictionary.Entity.Concrete;
using FluentValidation;

namespace Dictionary.BL.ValidationRules.FluentValidation
{
    public class WordValidation : AbstractValidator<Word>
    {
        public WordValidation()
        {
            RuleFor(x => x.English).NotEmpty().WithMessage("İngilizce Kelime Girilmesi Gerekmekte...");
            RuleFor(x => x.Turkish).NotEmpty().WithMessage("Türkçe Kelime Girilmesi Gerekmekte...");
            RuleFor(x => x.Sentence).NotEmpty().WithMessage("İngilizce Kelimeye Uygun Cümle Girilmesi Gerekmekte...");
        }
    }
}
