using Ninject.Modules;
using Restaurant.Models.Services;
using Restaurant.Models.Services.Interface;
using Restaurant.ViewModels;

namespace Restaurant
{
    class IocConfiguration : NinjectModule
    {
        public override void Load()
        {
            Bind<IItemDataService>().To<ItemDataService>().InSingletonScope();

            Bind<ItemViewModel>().ToSelf().InTransientScope();
        }
    }
}
