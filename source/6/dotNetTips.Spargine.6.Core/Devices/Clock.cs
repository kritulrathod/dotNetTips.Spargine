// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-01-2023
// ***********************************************************************
// <copyright file="Clock.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Time Utility Class for common tasks related to clocks and
// time. It includes functionalities to retrieve the current time and
// tick count, as well as a method to determine the number of days in
// the current month (DaysInCurrentMonth).
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Devices;

/// <summary>
/// Clock Information.
/// </summary>
/// <remarks>Some of this code is from the Microsoft.VisualBasic.dll</remarks>
[ExcludeFromCodeCoverage(Justification = "Not needed due to just using the DateTime type.")]
[Information(nameof(Clock), "David McCarter", "11/11/2020", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.NotRequired)]
public static class Clock
{
	/// <summary>
	/// Gets the days in the current month (local time).
	/// </summary>
	/// <value>The days in month.</value>
	[Information(nameof(DaysInCurrentMonth), "David McCarter", "11/11/2020", Status = Status.Available)]
	public static int DaysInCurrentMonth => DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

	/// <summary>
	/// Gets the days in current UTC month.
	/// </summary>
	/// <value>The days in current UTC month.</value>
	[Information(nameof(DaysInCurrentUtcMonth), "David McCarter", "11/11/2020", Status = Status.Available)]
	public static int DaysInCurrentUtcMonth => DateTime.DaysInMonth(DateTime.UtcNow.Year, DateTime.UtcNow.Month);

	/// <summary>
	/// Gets the local time.
	/// </summary>
	/// <value>The local time.</value>
	[Information(nameof(LocalTime), "David McCarter", "11/11/2020", Status = Status.Available)]
	public static DateTime LocalTime => DateTime.Now.ToLocalTime();

	/// <summary>
	/// Gets the tick count.
	/// </summary>
	/// <value>The tick count.</value>
	[Information(nameof(TickCount), "David McCarter", "11/11/2020", Status = Status.Available)]
	public static int TickCount => Environment.TickCount;

	/// <summary>
	/// Gets the UTC time.
	/// </summary>
	/// <value>The UTC time.</value>
	[Information(nameof(UtcTime), "David McCarter", "11/11/2020", Status = Status.Available)]
	public static DateTime UtcTime => DateTime.UtcNow;
}
