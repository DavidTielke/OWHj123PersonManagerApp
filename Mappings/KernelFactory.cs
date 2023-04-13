using Configuration;
using DavidTielke.OwHj123.Data.DataCsvStoring;
using DavidTielke.OwHj123.Logic.Domain.AuditationManagement;
using DavidTielke.OwHj123.Logic.Domain.PersonManagement;
using FileStoring;
using Ninject;
using Workflows;

namespace Mappings;

public class KernelFactory
{
    public IKernel Create()
    {
        var kernel = new StandardKernel();

        kernel.Bind<IPersonManagementWorkflows>().To<PersonManagementWorkflows>();
        kernel.Bind<IAuditEntryManager>().To<AuditEntryManager>();
        kernel.Bind<IAuditEntryRepository>().To<AuditEntryRepository>();
        kernel.Bind<IPersonManager>().To<PersonManager>();
        kernel.Bind<IPersonRepository>().To<PersonRepository>();
        kernel.Bind<IPersonParser>().To<PersonParser>();
        kernel.Bind<IFileStorer>().To<FileStorer>();
        kernel.Bind<IConfigurator>().To<Configurator>().InSingletonScope();
        return kernel;
    }
}