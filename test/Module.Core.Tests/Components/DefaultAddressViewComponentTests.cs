using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Moq;
using Infrastructure.Data;
using Module.Core.Components;
using Module.Core.Extensions;
using Module.Core.Models;
using Module.Core.ViewModels.Manage;
using Xunit;

namespace Module.Core.Tests.Components
{
    public class DefaultAddressViewComponentTests
    {
        [Fact]
        public async Task DefaultAddressViewComponent_Should_Returns_DefaultAddress()
        {
            var address = MakeAddress();
            var component = MakeMockedDefaultAddressViewComponent(address, MakeUserWithShippingAdress());

            var result = await component.InvokeAsync() as ViewViewComponentResult;
            var returnedModel = (result?.ViewData.Model as DefaultAddressViewComponentVm);

            Assert.Equal(address.AddressLine1, returnedModel?.Address.AddressLine1);
        }

        [Fact]
        public async Task DefaultAddressViewComponetn_ShouldReturns_CorrectModelType()
        {
            var component = MakeMockedDefaultAddressViewComponent(MakeAddress(), MakeUserWithShippingAdress());

            var view = await component.InvokeAsync() as ViewViewComponentResult;

            Assert.IsType<DefaultAddressViewComponentVm>(view?.ViewData.Model);
        }

        [Fact]
        public async Task DefaultAddressViewComponetn_ShouldReturns_CorrectViewType()
        {
            var component = MakeMockedDefaultAddressViewComponent(MakeAddress(), MakeUserWithShippingAdress());

            var view = await component.InvokeAsync() as ViewViewComponentResult;

            Assert.IsType<ViewViewComponentResult>(view);
        }

        [Fact]
        public async Task DefaultAddressViewComponetn_ShouldReturns_NotNullView()
        {
            var component = MakeMockedDefaultAddressViewComponent(MakeAddress(), MakeUserWithShippingAdress());

            var view = await component.InvokeAsync() as ViewViewComponentResult;

            Assert.NotNull(view);
        }

        [Fact]
        public async Task DefaultAddressViewComponetn_ShouldReturns_CorrectViewName()
        {
            var component = MakeMockedDefaultAddressViewComponent(MakeAddress(), MakeUserWithShippingAdress());

            var view = await component.InvokeAsync() as ViewViewComponentResult;

            Assert.Equal("/Modules/Module.Core/Views/Components/DefaultAddress.cshtml", view?.ViewName);
        }

        private DefaultAddressViewComponent MakeMockedDefaultAddressViewComponent(Address address, User user)
        {
            var mockRepository = new Mock<IRepository<Address>>();
            var mockWorkContext = new Mock<IWorkContext>();

            mockRepository.Setup(x => x.Query()).Returns(new List<Address> { address }.AsQueryable());
            mockWorkContext.Setup(x => x.GetCurrentUser()).Returns(Task.FromResult(user));
            var component = new DefaultAddressViewComponent(mockRepository.Object, mockWorkContext.Object);

            return component;
        }

        private User MakeUserWithShippingAdress()
        {
            return new User { Id = 1, FullName = "Maher", DefaultShippingAddressId = 0 };
        }

        private Address MakeAddress()
        {
            var country = new Country { Name = "France" };
            var stateOrProvince = new StateOrProvince { Name = "IDF", Country = country, Type = "State" };
            var district = new District { Location = "Center", StateOrProvince = stateOrProvince, Name = "Paris" };

            var address = new Address
            {
                CountryId = 1,
                AddressLine1 = "115 Rue Marcel",
                Country = country,
                StateOrProvince = stateOrProvince,
                District = district
            };

            return address;
        }
    }
}
