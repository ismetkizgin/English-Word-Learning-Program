using Dictionary.BL.Abstract;
using Dictionary.BL.Concrete;
using Dictionary.DAL.Abstract;
using Dictionary.DAL.Concrete.EntityFramework;
using Ninject.Modules;

namespace Dictionary.BL.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IWordService>().To<WordManager>().InSingletonScope();
            Bind<IWordDal>().To<EfWordDal>().InSingletonScope();

            Bind<ILearningWordSevice>().To<LearningWordManager>().InSingletonScope();
            Bind<ILearningWordDal>().To<EfLearningWord>().InSingletonScope();
        }
    }
}