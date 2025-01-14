// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions **
// Author           : David McCarter
// Created          : 07-30-2018
//
// Last Modified By : David McCarter
// Last Modified On : 01-18-2023
// ***********************************************************************
// <copyright file="GuidExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Class GuidExtensions.
/// </summary>
public static class GuidExtensions
{
	/// <summary>
	/// Fast way to compare <see cref="Guid" />'s.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <remarks>Orginal code: https://www.meziantou.net/faster-guid-comparisons-using-vectors-simd-in-dotnet.htm</remarks>
	[Obsolete("This method will be removed at the end of 2023. In .NET 6 & 7, it is less performant than using Equals().")]
	[Information(nameof(FastEquals), UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool FastEquals(this in Guid left, in Guid right)
	{
		if (left.IsNull() || right.IsNull())
		{
			return false;
		}

		if (Sse2.IsSupported)
		{
			var leftVector = Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.As<Guid, byte>(ref Unsafe.AsRef(in left)));
			var rightVector = Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.As<Guid, byte>(ref Unsafe.AsRef(in right)));

			var equals = Sse2.CompareEqual(leftVector, rightVector);
			var result = Sse2.MoveMask(equals);

			return (result & 0xFFFF) == 0xFFFF;
		}

		return left == right;
	}
	/// <summary>
	/// Returns the <see cref="Guid" /> without dashes.
	/// Validates that <paramref name="input" /> is not empty.
	/// </summary>
	/// <param name="input">The Guid value.</param>
	/// <returns>System.String.</returns>
	[Information(nameof(ToDigits), UnitTestCoverage = 100, Status = Status.Available)]
	public static string ToDigits([NotNull] this Guid input)
	{
		if (input.CheckIsNotEmpty())
		{
			return input.ToString("N", CultureInfo.InvariantCulture);
		}
		else
		{
			return string.Empty;
		}
	}
}
