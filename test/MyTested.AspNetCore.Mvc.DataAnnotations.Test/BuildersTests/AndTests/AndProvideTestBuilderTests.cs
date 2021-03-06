﻿namespace MyTested.AspNetCore.Mvc.Test.BuildersTests.AndTests
{
    using System;
    using Setups;
    using Setups.Controllers;
    using Xunit;

    public class AndProvideTestBuilderTests
    {
        [Fact]
        public void AndProvideShouldThrowExceptionIfActionIsVoid()
        {
            Test.AssertException<InvalidOperationException>(
                () =>
                {
                    MyController<MvcController>
                        .Instance()
                        .Calling(c => c.EmptyActionWithException())
                        .ShouldHave()
                        .ValidModelState()
                        .ShouldPassFor()
                        .TheActionResult(actionResult => actionResult != null);
                },
                "Void methods cannot provide action result because they do not have return value.");
        }
    }
}
