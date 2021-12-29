using svietnamAPI.Infras.Data.DatabaseContext;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using svietnamTEST.Factory;
using svietnamAPI.Models.IUnitOfWorks;
using svietnamAPI.Models.UnitOfWorks;
using svietnamAPI.Models.IServices;
using svietnamAPI.Models.Services;

namespace svietnamTEST.ServiceTests
{
    public class ServiceWrapperTest : DIFactory
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IServiceWrapper _serviceWrapper;

        public ServiceWrapperTest(HostFactory hostFactory) : base(hostFactory)
        {
            _unitOfWork = new UnitOfWork(_appDbContext, _mapper, _loggerFactory);
            _serviceWrapper = new ServiceWrapper(_unitOfWork, _mapper, _loggerFactory);
        }

        [Fact]
        public void LogPrepare()
        {

        }
    }
}