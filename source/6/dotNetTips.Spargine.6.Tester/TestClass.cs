// ***********************************************************************
// Assembly         : dotNetTips.Spargine.6.Tester
// Author           : David McCarter
// Created          : 01-16-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-18-2023
// ***********************************************************************
// <copyright file="TestClass.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Common methods for TestClasses.</summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )
namespace DotNetTips.Spargine.Tester;

/// <summary>
/// Class TestClass.
/// </summary>
[ExcludeFromCodeCoverage]
public abstract class TestClass
{
	/// <summary>
	/// Prints the result.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The input.</param>
	/// <param name="methodName">Name of the method.</param>
	protected static void PrintResult<T>(T input, string methodName)
	{
		string message;

		if (input is string || input.GetType().IsValueType)
		{
			message = $"{methodName}: {input:C}";
		}
		else
		{
			message = $"{methodName}: {input.PropertiesToString(includeMemberName: false)}";
		}

		Debug.WriteLine(message);
	}
}
