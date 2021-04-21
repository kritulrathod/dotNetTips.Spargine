﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 04-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-02-2021
// ***********************************************************************
// <copyright file="NativeMethods.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Runtime.InteropServices;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine
{
	/// <summary>
	/// Class NativeMethods. This class cannot be inherited.
	/// </summary>
	internal sealed class NativeMethods
	{
		/// <summary>
		/// Moves the file ex.
		/// </summary>
		/// <param name="lpExistingFileName">Name of the lp existing file.</param>
		/// <param name="lpNewFileName">Name of the lp new file.</param>
		/// <param name="dwFlags">The dw flags.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern bool MoveFileEx(string lpExistingFileName, string lpNewFileName, int dwFlags);
	}
}