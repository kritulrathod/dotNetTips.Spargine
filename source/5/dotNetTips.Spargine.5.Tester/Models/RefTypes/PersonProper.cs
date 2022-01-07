﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 07-17-2019
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="PersonProper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester.Properties;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Tester.Models.RefTypes
{
	/// <summary>
	/// Person class that implements interfaces and validates data. Implements the <see cref="IPerson" /> Implements the
	/// <see cref="IComparable" />
	/// </summary>
	/// <seealso cref="IPerson" />
	/// <seealso cref="IComparable" />
	[DebuggerDisplay("{Email}")]
	[Serializable]
	[XmlRoot(ElementName = "PersonProper", Namespace = "http://dotNetTips.Spargine.Tester.Models")]
	[DataContract(Name = "personProper", Namespace = "http://dotNetTips.Spargine.Tester.Models")]
	public sealed class PersonProper : IDataModel<PersonProper, string>, IPerson
	{
		/// <summary>
		/// Address 1.
		/// </summary>
		[NonSerialized]
		private string _address1;

		/// <summary>
		/// Address 2.
		/// </summary>
		[NonSerialized]
		private string _address2;

		/// <summary>
		/// The born on date and time.
		/// </summary>
		[NonSerialized]
		private DateTimeOffset _bornOn;

		/// <summary>
		/// The cell phone number.
		/// </summary>
		[NonSerialized]
		private string _cellPhone;

		/// <summary>
		/// The city name.
		/// </summary>
		[NonSerialized]
		private string _city;

		/// <summary>
		/// The country name.
		/// </summary>
		[NonSerialized]
		private string _country = RegionInfo.CurrentRegion.ThreeLetterISORegionName;

		/// <summary>
		/// The email address.
		/// </summary>
		[NonSerialized]
		private string _email;

		/// <summary>
		/// The first name.
		/// </summary>
		[NonSerialized]
		private string _firstName;

		/// <summary>
		/// The home phone number.
		/// </summary>
		[NonSerialized]
		private string _homePhone;

		/// <summary>
		/// The unique identifier.
		/// </summary>
		[NonSerialized]
		private string _id;

		/// <summary>
		/// The last name.
		/// </summary>
		[NonSerialized]
		private string _lastName;

		/// <summary>
		/// The postal code.
		/// </summary>
		[NonSerialized]
		private string _postalCode;

		/// <summary>
		/// The state
		/// </summary>
		[NonSerialized]
		private string _state;

		/// <summary>
		/// Initializes a new instance of <see cref="PersonProper" />.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public PersonProper()
		{
		}
		/// <summary>
		/// Initializes a new instance of <see cref="PersonProper" />.
		/// </summary>
		/// <param name="id">The unique identifier.</param>
		/// <param name="email">The email address.</param>
		public PersonProper([NotNull] string id, [NotNull] string email)
		{
			this.Id = id;
			this.Email = email;
		}

		/// <summary>
		/// Implements the != operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator !=(PersonProper left, PersonProper right) => !( left == right );

		/// <summary>
		/// Implements the &lt; operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator <(PersonProper left, PersonProper right) => left is null
			? right is not null
			: left.CompareTo(right) < 0;

		/// <summary>
		/// Implements the &lt;= operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator <=(PersonProper left, PersonProper right) => left is null ||
			left.CompareTo(right) <= 0;

		/// <summary>
		/// Implements the == operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator ==(PersonProper left, PersonProper right)
		{
			return left is null ? right is null : left.Equals(right);
		}

		/// <summary>
		/// Implements the &gt; operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator >(PersonProper left, PersonProper right) => left is not null &&
			left.CompareTo(right) > 0;

		/// <summary>
		/// Implements the &gt;= operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator >=(PersonProper left, PersonProper right) => left is null
			? right is null
			: left.CompareTo(right) >= 0;

		/// <summary>
		/// Calculates the person's current age.
		/// </summary>
		/// <returns>TimeSpan.</returns>
		private TimeSpan CalculateAge() => DateTimeOffset.UtcNow.Subtract(this.BornOn);

		/// <summary>
		/// Compares to.
		/// </summary>
		/// <param name="other">The other.</param>
		/// <returns>System.Int32.</returns>
		public int CompareTo([NotNull] PersonProper other)
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

			result = string.Compare(this._id, other._id, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._lastName, other._lastName, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			return -1;
		}

		/// <summary>
		/// Determines whether the specified <see cref="object" /> is equal to this instance.
		/// </summary>
		/// <param name="obj">The object to compare with the current object.</param>
		/// <returns><c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
		/// <exception cref="NotImplementedException"></exception>
		public override bool Equals([NotNull] object obj) { return ReferenceEquals(this, obj); }

		/// <summary>
		/// Equals the specified other.
		/// </summary>
		/// <param name="other">The other.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="NotImplementedException"></exception>
		public bool Equals([NotNull] PersonProper other) { return ReferenceEquals(this, other); }

		///// <summary>
		///// Returns the hash code for this instance based on id.
		///// </summary>
		///// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
		//public override int GetHashCode() => HashCode.Combine(this.Email, this.Id);
		/// <summary>
		/// Returns a <see cref="string" /> of the users id.
		/// </summary>
		/// <returns>A <see cref="string" /> of the users id.</returns>
		public override string ToString() => this.Id.ToString(CultureInfo.CurrentCulture);

		/// <summary>
		/// Returns a hash code for this instance.
		/// </summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
		public override int GetHashCode()
		{
			var hash = new HashCode();
			hash.Add(this.Address1);
			hash.Add(this.Address2);
			hash.Add(this.Age);
			hash.Add(this.BornOn);
			hash.Add(this.CellPhone);
			hash.Add(this.City);
			hash.Add(this.Country);
			hash.Add(this.Email);
			hash.Add(this.FirstName);
			hash.Add(this.HomePhone);
			hash.Add(this.Id);
			hash.Add(this.LastName);
			hash.Add(this.PostalCode);
			hash.Add(this.State);
			return hash.ToHashCode();
		}

		/// <summary>
		/// Gets or sets first address.
		/// </summary>
		/// <value>The address1.</value>
		/// <exception cref="System.ArgumentOutOfRangeException">Address1</exception>
		[DataMember(Name = "address1")]
		[XmlElement]
		public string Address1
		{
			get => this._address1;

			set
			{
				if (string.Equals(this._address1, value, StringComparison.Ordinal))
				{
					return;
				}

				this._address1 = value.HasValue(0, 100) == false
					? throw new ArgumentOutOfRangeException(
						nameof(this.Address1),
						Resources.AddressLengthIsLimitedTo100Characters)
					: value;
			}
		}

		/// <summary>
		/// Gets or sets second address.
		/// </summary>
		/// <value>The address2.</value>
		/// <exception cref="System.ArgumentOutOfRangeException">Address2</exception>
		[DataMember(Name = "address2")]
		[XmlElement]
		public string Address2
		{
			get => this._address2;

			set
			{
				if (string.Equals(this._address2, value, StringComparison.Ordinal))
				{
					return;
				}

				this._address2 = value.HasValue(0, 100) == false
					? throw new ArgumentOutOfRangeException(
						nameof(this.Address2),
						Resources.AddressLengthIsLimitedTo100Characters)
					: value;
			}
		}

		/// <summary>
		/// Gets the person's current age.
		/// </summary>
		/// <value>The age.</value>
		[IgnoreDataMember]
		public TimeSpan Age => this.CalculateAge();

		/// <summary>
		/// Gets or sets the born on date and time.
		/// </summary>
		/// <value>The born on.</value>
		/// <exception cref="System.ArgumentOutOfRangeException">BornOn</exception>
		[DataMember(Name = "bornOn")]
		[XmlElement]
		public DateTimeOffset BornOn
		{
			get => this._bornOn;

			set
			{
				if (this._bornOn == value)
				{
					return;
				}

				this._bornOn = value.ToUniversalTime() > DateTimeOffset.UtcNow
					? throw new ArgumentOutOfRangeException(
						nameof(this.BornOn),
						Resources.PersonBornOnCannotBeInTheFuture)
					: value;
			}
		}

		/// <summary>
		/// Gets or sets the cell phone number.
		/// </summary>
		/// <value>The cell phone.</value>
		/// <exception cref="System.ArgumentOutOfRangeException">CellPhone</exception>
		[DataMember(Name = "cellPhone")]
		[XmlElement]
		public string CellPhone
		{
			get => this._cellPhone;

			set
			{
				if (string.Equals(this._cellPhone, value, StringComparison.Ordinal))
				{
					return;
				}

				this._cellPhone = value.HasValue(0, 50) == false
					? throw new ArgumentOutOfRangeException(
						nameof(this.CellPhone),
						Resources.PhoneNumberIsLimitedTo50Characters)
					: value;
			}
		}

		/// <summary>
		/// Gets or sets the city name.
		/// </summary>
		/// <value>The city.</value>
		/// <exception cref="System.ArgumentOutOfRangeException">City</exception>
		[DataMember(Name = "city")]
		[XmlElement]
		public string City
		{
			get => this._city;

			set
			{
				if (string.Equals(this._city, value, StringComparison.Ordinal))
				{
					return;
				}

				this._city = value.HasValue(0, 100) == false
					? throw new ArgumentOutOfRangeException(
						nameof(this.City),
						Resources.CityLengthIsLimitedTo100Characters)
					: value;
			}
		}

		/// <summary>
		/// Gets or sets the country.
		/// </summary>
		/// <value>The country.</value>
		/// <exception cref="System.ArgumentOutOfRangeException">Country</exception>
		[DataMember(Name = "country")]
		[XmlElement]
		public string Country
		{
			get => this._country;

			set
			{
				if (string.Equals(this._country, value, StringComparison.Ordinal))
				{
					return;
				}

				this._country = value.HasValue(0, 50) == false
					? throw new ArgumentOutOfRangeException(
						nameof(this.Country),
						Resources.CountryLengthIsLimitedTo50Characters)
					: value;
			}
		}

		/// <summary>
		/// Gets the email.
		/// </summary>
		/// <value>The email.</value>
		/// <exception cref="System.ArgumentOutOfRangeException">Email</exception>
		[DataMember(Name = "email", IsRequired = true)]
		[XmlElement(IsNullable = false)]
		[DisallowNull]
		public string Email
		{
			get => this._email;

			set
			{
				if (string.Equals(this._email, value, StringComparison.Ordinal))
				{
					return;
				}

				this._email = value.HasValue(0, 75) == false
					? throw new ArgumentOutOfRangeException(
						nameof(this.Email),
						Resources.EmailLengthIsLimitedTo75Characters)
					: value;
			}
		}

		/// <summary>
		/// Gets or sets the first name.
		/// </summary>
		/// <value>The first name.</value>
		/// <exception cref="System.ArgumentOutOfRangeException">FirstName</exception>
		[DataMember(Name = "firstName")]
		[XmlElement]
		public string FirstName
		{
			get => this._firstName;
			set
			{
				if (string.Equals(this._firstName, value, StringComparison.Ordinal))
				{
					return;
				}

				this._firstName = value.HasValue(0, 50) == false
					? throw new ArgumentOutOfRangeException(
						nameof(this.FirstName),
						Resources.FirstNameLengthIsLimitedTo50Characters)
					: value;
			}
		}

		/// <summary>
		/// Gets or sets the home phone.
		/// </summary>
		/// <value>The home phone.</value>
		/// <exception cref="System.ArgumentOutOfRangeException">HomePhone</exception>
		[DataMember(Name = "homePhone")]
		[XmlElement]
		public string HomePhone
		{
			get => this._homePhone;
			set
			{
				if (string.Equals(this._homePhone, value, StringComparison.Ordinal))
				{
					return;
				}

				this._homePhone = value.HasValue(0, 50) == false
					? throw new ArgumentOutOfRangeException(
						nameof(this.HomePhone),
						Resources.PhoneNumberIsLimitedTo50Characters)
					: value;
			}
		}

		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		/// <exception cref="System.ArgumentOutOfRangeException">Id</exception>
		[DataMember(Name = "id", IsRequired = true)]
		[XmlElement(IsNullable = false)]
		[DisallowNull]
		public string Id
		{
			get => this._id;
			set
			{
				if (string.Equals(this._id, value, StringComparison.Ordinal))
				{
					return;
				}

				this._id = value.HasValue(1, 50) == false
					? throw new ArgumentOutOfRangeException(nameof(this.Id), Resources.IdLengthIsLimitedTo50Characters)
					: value;
			}
		}

		/// <summary>
		/// Gets or sets the last name.
		/// </summary>
		/// <value>The last name.</value>
		/// <exception cref="System.ArgumentOutOfRangeException">LastName</exception>
		[DataMember(Name = "lastName")]
		[XmlElement]
		public string LastName
		{
			get => this._lastName;
			set
			{
				if (string.Equals(this._lastName, value, StringComparison.Ordinal))
				{
					return;
				}

				this._lastName = value.HasValue(0, 50) == false
					? throw new ArgumentOutOfRangeException(
						nameof(this.LastName),
						Resources.LastNameLengthIsLimitedTo50Characters)
					: value;
			}
		}

		/// <summary>
		/// Gets or sets the postal code.
		/// </summary>
		/// <value>The postal code.</value>
		/// <exception cref="System.ArgumentOutOfRangeException">PostalCode</exception>
		[DataMember(Name = "postalCode")]
		[XmlElement]
		public string PostalCode
		{
			get => this._postalCode;
			set
			{
				if (string.Equals(this._postalCode, value, StringComparison.Ordinal))
				{
					return;
				}

				this._postalCode = value.HasValue(0, 15) == false
					? throw new ArgumentOutOfRangeException(
						nameof(this.PostalCode),
						Resources.PostalCodeLengthIsLimitedTo15Characters)
					: value;
			}
		}

		/// <summary>
		/// Gets or sets the State.
		/// </summary>
		/// <value>The State.</value>
		/// <exception cref="System.ArgumentOutOfRangeException">State</exception>
		[DataMember(Name = "state")]
		[XmlElement]
		public string State
		{
			get => this._state;
			set
			{
				if (string.Equals(this._state, value, StringComparison.Ordinal))
				{
					return;
				}

				this._state = value.HasValue(0, 25) == false
					? throw new ArgumentOutOfRangeException(
						nameof(this.State),
						Resources.StateLengthIsLimitedTo25Characters)
					: value;
			}
		}

	}
}