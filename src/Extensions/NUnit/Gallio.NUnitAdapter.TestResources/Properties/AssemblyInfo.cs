// Copyright 2005-2010 Gallio Project - http://www.gallio.org/
// Portions Copyright 2000-2004 Jonathan de Halleux
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
#if NUNIT248
[assembly: AssemblyDescription("A sample test assembly for NUnit v2.4.8.")]
[assembly: AssemblyTitle("Gallio.NUnitAdapter248.TestResources")]
#elif NUNIT253
[assembly: AssemblyDescription("A sample test assembly for NUnit v2.5.3.")]
[assembly: AssemblyTitle("Gallio.NUnitAdapter253.TestResources")]
#elif NUNIT254TO10
[assembly: AssemblyDescription("A sample test assembly for NUnit v2.5.4-10.")]
[assembly: AssemblyTitle("Gallio.NUnitAdapter254-10.TestResources")]
#elif NUNITLATEST
[assembly: AssemblyDescription("A sample test assembly for NUnit v2.6+.")]
[assembly: AssemblyTitle("Gallio.NUnitAdapterLatest.TestResources")]
#else
#error "Unrecognized NUnit framework version."
#endif
[assembly: AssemblyConfiguration("Test")]
[assembly: AssemblyCompany("MbUnit Project")]
[assembly: AssemblyProduct("Gallio")]
[assembly: AssemblyCopyright("Copyright © 2005-2010 Gallio Project - http://www.gallio.org/")]
[assembly: AssemblyTrademark("Gallio")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyInformationalVersion("1.2.3.4")]

#if ! HAVE_ASSEMBLY_VERSION
[assembly: AssemblyFileVersion("1.2.3.4")]
[assembly: AssemblyVersion("1.2.3.4")]
#endif

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("794d0902-a28d-4471-a12a-f052d12973bb")]
