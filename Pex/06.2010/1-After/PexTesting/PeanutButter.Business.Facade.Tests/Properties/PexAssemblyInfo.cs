// <copyright file="PexAssemblyInfo.cs" company="Microsoft">Copyright © Microsoft 2010</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Moles;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("PeanutButter.Business.Facade")]
[assembly: PexInstrumentAssembly("PeanutButter.Business.Entities")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "PeanutButter.Business.Entities")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "PeanutButter.Business.Facade")]

// Microsoft.Pex.Framework.Moles
[assembly: PexAssumeContractEnsuresFailureAtStubSurface]
[assembly: PexChooseAsBehavedCurrentBehavior]
[assembly: PexUseStubsFromTestAssembly]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]

