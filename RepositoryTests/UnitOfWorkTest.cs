using svietnamAPI.Infras.Data.DatabaseContext;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using svietnamTEST.Factory;
using svietnamAPI.Models.IUnitOfWorks;
using svietnamAPI.Models.UnitOfWorks;

namespace svietnamTEST.RepositoryTests
{
    public class UnitOfWorkTest : DIFactory
    {
        protected readonly IUnitOfWork _unitOfWork;

        public UnitOfWorkTest(HostFactory hostFactory) : base(hostFactory)
        {
            _unitOfWork = new UnitOfWork(_appDbContext, _mapper, _loggerFactory);
        }

        [Fact]
        public void LogPrepare()
        {

        }
    }
}