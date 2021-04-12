﻿using System;
using System.Collections.Generic;
using System.Text;
using CodeGen.JsonTypes;

namespace CodeGen.Generators.NanoFrameworkGen
{
    class ProjectGenerator: GeneratorBase
    {
        private readonly Quantity _quantity;
        private readonly string _nanoFrameworkPath;

        public ProjectGenerator(Quantity quantity, string nanoFrameworkPath)
        {
            _quantity = quantity ?? throw new ArgumentNullException(nameof(quantity));
            _nanoFrameworkPath = nanoFrameworkPath;
        }

        public override string Generate()
        {
            Writer.W($@"<?xml version=""1.0"" encoding=""utf-8""?>
<Project ToolsVersion=""15.0"" DefaultTargets=""Build"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">
  <PropertyGroup Label=""Globals"">
    <NanoFrameworkProjectSystemPath>{_nanoFrameworkPath}</NanoFrameworkProjectSystemPath>
  </PropertyGroup>
  <Import Project=""$(NanoFrameworkProjectSystemPath)NFProjectSystem.Default.props"" Condition=""Exists('$(NanoFrameworkProjectSystemPath)NFProjectSystem.Default.props')"" />
  <PropertyGroup>
    <Configuration Condition="" '$(Configuration)' == '' "">Debug</Configuration>
    <Platform Condition="" '$(Platform)' == '' "">AnyCPU</Platform>
    <ProjectTypeGuids>{{11A8DD76-328B-46DF-9F39-F559912D0360}};{{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}}</ProjectTypeGuids>
    <ProjectGuid>{Guid.NewGuid()}</ProjectGuid>
    <OutputType>Library</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <FileAlignment>512</FileAlignment>
    <RootNamespace>UnitsNet</RootNamespace>
    <AssemblyName>UnitsNet.{_quantity.Name}</AssemblyName>
    <TargetFrameworkVersion>v1.0</TargetFrameworkVersion>
  </PropertyGroup>
  <Import Project=""$(NanoFrameworkProjectSystemPath)NFProjectSystem.props"" Condition=""Exists('$(NanoFrameworkProjectSystemPath)NFProjectSystem.props')"" />
  <ItemGroup>
    <Compile Include=""..\Quantities\{_quantity.Name}.g.cs"" />
    <Compile Include=""..\Units\{_quantity.Name}Unit.g.cs"" />
    <Compile Include=""..\Properties\AssemblyInfo.cs"" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include=""mscorlib, Version=1.10.3.0, Culture=neutral, PublicKeyToken=c07d481e9758c731"">
      <HintPath>..\packages\nanoFramework.CoreLibrary.1.10.3-preview.7\lib\mscorlib.dll</HintPath>
      <Private>True</Private>
      <SpecificVersion>True</SpecificVersion>
    </Reference>  
  </ItemGroup>
  <ItemGroup>
    <None Include=""packages.config"" />
  </ItemGroup>
  <Import Project=""$(NanoFrameworkProjectSystemPath)NFProjectSystem.CSharp.targets"" Condition=""Exists('$(NanoFrameworkProjectSystemPath)NFProjectSystem.CSharp.targets')"" />
  <ProjectExtensions>
    <ProjectCapabilities>
      <ProjectConfigurationsDeclaredAsItems />
    </ProjectCapabilities>
  </ProjectExtensions>
</Project>");

            return Writer.ToString();
        }
    }
}
