﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Study.Core.Pages;

public class Index_Tests : CoreWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
