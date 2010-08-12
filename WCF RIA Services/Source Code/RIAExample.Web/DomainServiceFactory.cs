using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.DomainServices.Server;

namespace RIAExample.Web
{
    public class DomainServiceFactory : IDomainServiceFactory
    {

        public DomainService CreateDomainService(Type domainServiceType, DomainServiceContext context)
        {
            DomainService service = null;
            if (domainServiceType == typeof(EmployeeDomainService))
                service = new EmployeeDomainService(new EmployeeRepositoryInMemory());
            else
                service = (DomainService)Activator.CreateInstance(domainServiceType, true);

            service.Initialize(context);
            return service;
        }

        public void ReleaseDomainService(DomainService domainService)
        {
            domainService.Dispose();
        }
				
    }
}