using DavidTielke.OwHj123.CrossCutting.Configuration;
using DavidTielke.OwHj123.CrossCutting.Configuration.Contract;
using DavidTielke.OwHj123.Data.DataCsvStoring;
using DavidTielke.OwHj123.Data.DataCsvStoring.Contract;
using DavidTielke.OwHj123.Data.FileStoring;
using DavidTielke.OwHj123.Data.FileStoring.Contract;
using DavidTielke.OwHj123.Log.Business.Workflows;
using DavidTielke.OwHj123.Log.Business.Workflows.Contract;
using DavidTielke.OwHj123.Logic.Domain.AuditationManagement;
using DavidTielke.OwHj123.Logic.Domain.AuditationManagement.Contract;
using DavidTielke.OwHj123.Logic.Domain.PersonManagement;
using DavidTielke.OwHj123.Logic.Domain.PersonManagement.Contract;
using Ninject;

namespace DavidTielke.OwHj123.Infrastructure.Mappings;

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