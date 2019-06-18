using Ninject;

namespace Dictionary.BL.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var karnel = new StandardKernel(new BusinessModule());
            return karnel.Get<T>();
        }
    }
}