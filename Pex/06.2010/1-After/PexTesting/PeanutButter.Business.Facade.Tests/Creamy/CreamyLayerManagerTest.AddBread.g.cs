// <copyright file="CreamyLayerManagerTest.AddBread.g.cs" company="Microsoft">Copyright © Microsoft 2010</copyright>
// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using PeanutButter.Business.Entities.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Engine.Exceptions;

namespace PeanutButter.Business.Facade.Creamy
{
    public partial class CreamyLayerManagerTest
    {
[TestMethod]
[PexGeneratedBy(typeof(CreamyLayerManagerTest))]
[PexRaisedException(typeof(AssertInconclusiveException), PexExceptionState.Inconclusive)]
public void AddBreadThrowsAssertInconclusiveException809()
{
    CreamyLayerManager creamyLayerManager;
    creamyLayerManager = new CreamyLayerManager();
    this.AddBread(creamyLayerManager, Bread.Wheat);
}
    }
}
