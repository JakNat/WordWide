using Autofac;
using WordWide.UI.Data;
using WordWide.UI.ViewModel;

namespace WordWide.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<WordViewModel>().AsSelf();
            builder.RegisterType<WordDataService>().As<IWordDataService>();

            return builder.Build();
        }
    }
}
