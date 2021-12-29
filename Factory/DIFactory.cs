using svietnamAPI.Infras.Data.DatabaseContext;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace svietnamTEST.Factory
{


    public class DIFactory : IClassFixture<HostFactory>
    {
        protected readonly IHost _host;
        protected readonly AppDbContext _appDbContext;
        protected readonly IMapper _mapper;
        protected readonly ILoggerFactory _loggerFactory;

        public DIFactory(HostFactory hostFactory)
        {
            _host = hostFactory.TestHost;
            _appDbContext = _host.Services.GetRequiredService<AppDbContext>();
            _mapper = _host.Services.GetRequiredService<IMapper>();
            _loggerFactory = _host.Services.GetRequiredService<ILoggerFactory>();
        }
    }
}