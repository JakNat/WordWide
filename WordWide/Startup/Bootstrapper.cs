using Autofac;
using WordWide.UI.Data;
using WordWide.UI.ViewModel;
using WordWIde.DataAccess;

namespace WordWide.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<WordWideDbContext>().AsSelf();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<WordViewModel>().AsSelf();
            builder.RegisterType<WordDataService>().As<IWordDataService>();

            return builder.Build();
        }
    }
}
