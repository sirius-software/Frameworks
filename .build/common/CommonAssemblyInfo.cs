using System.Reflection;
using Bridge;

[assembly: AssemblyCompany("Object.NET, Inc.")]
[assembly: AssemblyCopyright("Copyright 2008-2017 Object.NET, Inc.")]
[assembly: Convention(Member = ConventionMember.Field | ConventionMember.Method, Notation = Notation.LowerCamelCase)]
[assembly: Convention(Target = ConventionTarget.ObjectLiteral, Member = ConventionMember.Property, Notation = Notation.LowerCamelCase)]