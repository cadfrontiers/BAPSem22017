﻿using Xunit;
using SqlQueryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlQueryLibrary.Tests
{
    public class SuppliersQueryTests
    {
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("1239r4")]
        public void  GetSuppliersTest(string supplierCode)
        {

            var exception = Record.Exception(() => SuppliersQuery.GetSuppliers(supplierCode));

            Assert.NotNull(exception);
        }
    }
}