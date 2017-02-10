﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Xunit;

namespace Microsoft.AspNetCore.Mvc.ModelBinding.Metadata
{
    public class SpecialBindingSourceMetadataProviderTests
    {
        [Fact]
        public void ChecksParameterType_AssignsSpecialBindingSource()
        {
            // Arrange
            var provider = new SpecialBindingSourceMetadataProvider(typeof(Test));

            var key = ModelMetadataIdentity.ForType(
                typeof(Test));

            var context = new BindingMetadataProviderContext(key, new ModelAttributes(new object[0], new object[0]));

            // Act
            provider.CreateBindingMetadata(context);

            // Assert
            Assert.Equal(BindingSource.Special, context.BindingMetadata.BindingSource);
        }

        private class Test
        {
        }
    }
}