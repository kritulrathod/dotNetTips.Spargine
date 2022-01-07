﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 01-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-02-2021
// ***********************************************************************
// <copyright file="PersonRecord.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester.Properties;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Tester.Models.RefTypes
{
	/// <summary>
	/// Class Person with proper encapsulation and validation.
	/// Implements the <see cref="IDataRecord" />
	/// </summary>
	public record PersonRecord : IDataRecord, IComparable<PersonRecord>
	{
		/// <summary>
		/// The born on
		/// </summary>
		private DateTimeOffset _bornOn;

		/// <summary>
		/// The cell phone number
		/// </summary>
		private string _cellPhone;

		/// <summary>
		/// The email
		/// </summary>
		private string _email;

		/// <summary>
		/// The first name
		/// </summary>
		private string _firstName;

		/// <summary>
		/// The home phone number
		/// </summary>
		private string _homePhone;

		/// <summary>
		/// The last name
		/// </summary>
		private string _lastName;

		/// <summary>
		/// Initializes a new instance of the <see cref="Person" /> class.
		/// </summary>
		/// <param name="email">The email.</param>
		/// <param name="id">The identifier.</param>
		public PersonRecord(string email, string id)
		{
			this.Email = email;
			this.Id = id;
		}

		/// <summary>
		/// Prevents a default instance of the <see cref="PersonRecord" /> class from being created.
		/// </summary>
		private PersonRecord()
		{ }

		/// <summary>
		/// Gets or sets the addresses.
		/// </summary>
		/// <value>The addresses.</value>
		public Collection<AddressRecord> Addresses { get; init; }

		/// <summary>
		/// Gets or sets the born on date.
		/// </summary>
		/// <value>The born on date.</value>
		/// <exception cref="ArgumentOutOfRangeException">BornOn - Person cannot be born in the future.</exception>
		public DateTimeOffset BornOn
		{
			get => this._bornOn;
			init => this._bornOn = value.ToUniversalTime() > DateTimeOffset.UtcNow ? throw new ArgumentOutOfRangeException(nameof(this.BornOn), "Person cannot be born in the future.") : value;
		}

		/// <summary>
		/// Gets or sets the cell phone number.
		/// </summary>
		/// <value>The cell phone number.</value>
		/// <exception cref="ArgumentOutOfRangeException">CellPhone - Phone number is limited to 50 characters.</exception>
		/// <exception cref="ArgumentNullException">CellPhone - Phone number is limited to 50 characters.</exception>
		[DisallowNull]
		public string CellPhone
		{
			get => this._cellPhone;
			init => this._cellPhone = value?.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.CellPhone), "Phone number is limited to 50 characters.") : value;
		}

		/// <summary>
		/// Gets or sets the email address.
		/// </summary>
		/// <value>The email address.</value>
		/// <exception cref="ArgumentNullException">Email - Value for Email cannot be null or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Email</exception>
		public string Email
		{
			get => this._email;
			init
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException(nameof(this.Email), "Value for Email cannot be null or empty.");
				}

				this._email = value.Length > 75 ? throw new ArgumentOutOfRangeException(nameof(this.Email), Resources.EmailLengthIsLimitedTo75Characters) : value;
			}
		}

		/// <summary>
		/// Gets or sets the first name.
		/// </summary>
		/// <value>The first name.</value>
		/// <exception cref="ArgumentNullException">FirstName - Value for name cannot be null or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException">FirstName - First name length is limited to 50 characters.</exception>
		public string FirstName
		{
			get => this._firstName;
			init
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException(nameof(this.FirstName), "Value for name cannot be null or empty.");
				}

				this._firstName = value.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.FirstName), "First name length is limited to 50 characters.") : value;
			}
		}

		/// <summary>
		/// Gets or sets the home phone number.
		/// </summary>
		/// <value>The home phone.</value>
		/// <exception cref="ArgumentOutOfRangeException">HomePhone - Home phone length is limited to 50 characters.</exception>
		/// <exception cref="ArgumentNullException">HomePhone - Home phone length is limited to 50 characters.</exception>
		[DisallowNull]
		public string HomePhone
		{
			get => this._homePhone;
			init => this._homePhone = value.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.HomePhone), "Home phone length is limited to 50 characters.") : value;
		}

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		[DisallowNull]
		public string Id { get; init; }

		/// <summary>
		/// Gets or sets the last name.
		/// </summary>
		/// <value>The last name.</value>
		/// <exception cref="ArgumentNullException">LastName - Value for name cannot be null or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException">LastName - Last name length is limited to 50 characters.</exception>
		public string LastName
		{
			get => this._lastName;
			init
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException(nameof(this.LastName), "Value for name cannot be null or empty.");
				}

				this._lastName = value.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.LastName), "Last name length is limited to 50 characters.") : value;
			}
		}

		/// <summary>
		/// Compares to.
		/// </summary>
		/// <param name="other">The other.</param>
		/// <returns>System.Int32.</returns>
		public int CompareTo(PersonRecord other)
		{
			if (other is null)
			{
				return 1;
			}

			var result = this._bornOn.CompareTo(other._bornOn);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._cellPhone, other._cellPhone, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._email, other._email, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._firstName, other._firstName, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._homePhone, other._homePhone, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.Id, other.Id, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._lastName, other._lastName, StringComparison.OrdinalIgnoreCase);

			if (result != 0)
			{
				return result;
			}

			return result;
		}
	}
}