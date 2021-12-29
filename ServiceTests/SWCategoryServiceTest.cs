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
using svietnamAPI.Common.Dtos.Catalog;
using System.Threading.Tasks;

namespace svietnamTEST.ServiceTests
{
    public class SWCategoryServiceTest : ServiceWrapperTest
    {
        public SWCategoryServiceTest(HostFactory hostFactory) : base(hostFactory)
        {
        }

        [Fact]
        public async Task GetAllAsync()
        {
            var categories = await _serviceWrapper.CategoryService.GetAllAsync<CategoryDto>();
        }

        [Fact]
        public async Task SoftDeleteAsync()
        {
            await _serviceWrapper.CategoryService.SoftDeleteAsync(2);
            var category = await _serviceWrapper.CategoryService.GetByIdAsync<CategoryDto>(2);
        }
    }
}