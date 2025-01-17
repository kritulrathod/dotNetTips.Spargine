// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-02-2023
// ***********************************************************************
// <copyright file="WebHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Helper methods for website calls, featuring the following methods:
// DownloadStringAsync(): Allows asynchronous downloading of a string
// from a website. HttpHeaderNames(): Provides a collection of common
// HTTP header names for reference and use in web requests. IsLocalUri():
// Determines if a given URI is a local resource or points to an external
// website. These methods aid in simplifying website interactions and
// handling HTTP-related tasks efficiently.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Microsoft.AspNetCore.Http;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Web;

/// <summary>
/// Class WebHelper.
/// </summary>
[Information("From dotNetTips.Utility", Status = Status.Available)]
public static class WebHelper
{

	/// <summary>
	/// The HTTP client
	/// </summary>
	private static readonly HttpClient _httpClient = new();

	/// <summary>
	/// Downloads the string.
	/// </summary>
	/// <param name="address">The address.</param>
	/// <param name="clientId">The client identifier.</param>
	/// <returns>System.String.</returns>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(DownloadStringAsync), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
	public static async Task<string> DownloadStringAsync(Uri address, string clientId = "NONE")
	{
		address = address.ArgumentNotNull();

		if (clientId.HasValue())
		{
			_httpClient.DefaultRequestHeaders.Add("CLIENTID", clientId);
		}

		// Download the data
		using (var response = await _httpClient.GetAsync(address, CancellationToken.None).ConfigureAwait(false))
		{
			return await response.Content.ReadAsStringAsync(CancellationToken.None).ConfigureAwait(false);
		}
	}

	/// <summary>
	/// Gets the HTTP header names.
	/// </summary>
	/// <returns>System.String[].</returns>
	/// <value>The HTTP header names.</value>
	[Information(nameof(HttpHeaderNames), "David McCarter", "9/2/2020", "9/2/2020", Status = Status.Available, UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired)]
	public static string[] HttpHeaderNames()
	{
		return Enum.GetNames(typeof(HttpRequestHeader));
	}

	/// <summary>
	/// Determines whether the Uri is from the local server.
	/// </summary>
	/// <param name="path">The Uri.</param>
	/// <param name="request">The context.</param>
	/// <returns><c>true</c> if [is local Uri] [the specified Uri]; otherwise, <c>false</c>.</returns>
	/// <remarks>If you are using .NET 4 or above or .NET Core, this check is not needed unless you have turned
	/// off validation in the config file or in classes.</remarks>
	[Information(nameof(IsLocalUri), author: "David McCarter", createdOn: "9/12/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static bool IsLocalUri([NotNull] string path, [NotNull] HttpRequest request)
	{
		path = path.ArgumentNotNullOrEmpty(true);
		request = request.ArgumentNotNull();

		if (Uri.TryCreate(path, UriKind.Absolute, out var absoluteUri))
		{
			var validHostName = string.Equals(request.Host.ToUriComponent(), absoluteUri.Host, StringComparison.OrdinalIgnoreCase);

			return validHostName;
		}
		else
		{
			var isLocal = !path.StartsWith("http:", StringComparison.OrdinalIgnoreCase) &&
				!path.StartsWith("https:", StringComparison.OrdinalIgnoreCase) &&
				Uri.IsWellFormedUriString(path, UriKind.Relative);

			return isLocal;
		}
	}

}
