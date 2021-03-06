﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Builders;

namespace Microsoft.Framework.CodeGeneration.EntityFramework.Test.TestModels
{
    public static class TestModel
    {
        public static IModel Model
        {
            get
            {
                var model = new Model();
                var builder = new ModelBuilderFactory().CreateConventionBuilder(model);

                builder.Entity<Product>()
                    .Reference(p => p.ProductCategory)
                    .InverseCollection(c => c.CategoryProducts)
                    .ForeignKey(e => e.ProductCategoryId);

                return model;
            }
        }
    }
}