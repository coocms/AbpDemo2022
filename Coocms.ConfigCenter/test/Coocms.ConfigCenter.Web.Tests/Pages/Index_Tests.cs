using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Coocms.ConfigCenter.Pages;

public class Index_Tests : ConfigCenterWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
