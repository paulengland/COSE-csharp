// <copyright file="PexAssemblyInfo.cs" company="August Cellars">Copyright © August Cellars 2016</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "NUnit")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("COSE")]
[assembly: PexInstrumentAssembly("System.Core")]
[assembly: PexInstrumentAssembly("BouncyCastle.Crypto")]
[assembly: PexInstrumentAssembly("CBOR")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "BouncyCastle.Crypto")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "CBOR")]

