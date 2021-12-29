using System.Threading.Tasks;
using svietnamTEST.Factory;
using Xunit;

namespace svietnamTEST.RepositoryTests
{
    public class UoWCategoryRepositoryTest : UnitOfWorkTest
    {
        public UoWCategoryRepositoryTest(HostFactory hostFactory) : base(hostFactory)
        {
        }

        [Fact]
        public async Task GetAllTest()
        {
            var categories = await _unitOfWork.CategoryDbRepo.GetAllAsync();
        }

        [Fact]
        public async Task GetById()
        {
            var category = await _unitOfWork.CategoryDbRepo.GetByIdAsync(4);
        }
    }
}