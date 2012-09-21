// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever a NCES0108CreditTypeEarned
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a NCES0108CreditTypeEarned object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	[Serializable]
	public class NCES0108CreditTypeEarned : SifEnum
	{
	/// <summary>Carnegie unit ("585")</summary>
	public static readonly NCES0108CreditTypeEarned CARNEGIE_UNIT = new NCES0108CreditTypeEarned("585");

	/// <summary>Long session hour credit ("595")</summary>
	public static readonly NCES0108CreditTypeEarned LONG_SESSION_HOUR_CREDIT = new NCES0108CreditTypeEarned("595");

	/// <summary>Twelve month hour credit ("596")</summary>
	public static readonly NCES0108CreditTypeEarned TWELVE_MONTH_HOUR_CREDIT = new NCES0108CreditTypeEarned("596");

	/// <summary>Other ("9999")</summary>
	public static readonly NCES0108CreditTypeEarned OTHER = new NCES0108CreditTypeEarned("9999");

	/// <summary>Semester hour credit ("586")</summary>
	public static readonly NCES0108CreditTypeEarned SEMESTER_HOUR_CREDIT = new NCES0108CreditTypeEarned("586");

	/// <summary>Adult education credit ("598")</summary>
	public static readonly NCES0108CreditTypeEarned ADULT_EDUCATION_CREDIT = new NCES0108CreditTypeEarned("598");

	/// <summary>Summer term hour credit ("591")</summary>
	public static readonly NCES0108CreditTypeEarned SUMMER_TERM_HOUR_CREDIT = new NCES0108CreditTypeEarned("591");

	/// <summary>Quinmester hour credit ("589")</summary>
	public static readonly NCES0108CreditTypeEarned QUINMESTER_HOUR_CREDIT = new NCES0108CreditTypeEarned("589");

	/// <summary>Correspondence credit ("600")</summary>
	public static readonly NCES0108CreditTypeEarned CORRESPONDENCE_CREDIT = new NCES0108CreditTypeEarned("600");

	/// <summary>Mini-term hour credit ("590")</summary>
	public static readonly NCES0108CreditTypeEarned MINI_TERM_HOUR_CREDIT = new NCES0108CreditTypeEarned("590");

	/// <summary>Credit by examination ("599")</summary>
	public static readonly NCES0108CreditTypeEarned CREDIT_BY_EXAMINATION = new NCES0108CreditTypeEarned("599");

	/// <summary>None ("9998")</summary>
	public static readonly NCES0108CreditTypeEarned NONE = new NCES0108CreditTypeEarned("9998");

	/// <summary>Converted occupational experience credit ("601")</summary>
	public static readonly NCES0108CreditTypeEarned CONVERTED_OCCUPATIONAL_EXPERIENCE_CREDIT = new NCES0108CreditTypeEarned("601");

	/// <summary>Vocational credit ("597")</summary>
	public static readonly NCES0108CreditTypeEarned VOCATIONAL_CREDIT = new NCES0108CreditTypeEarned("597");

	/// <summary>Trimester hour credit ("587")</summary>
	public static readonly NCES0108CreditTypeEarned TRIMESTER_HOUR_CREDIT = new NCES0108CreditTypeEarned("587");

	/// <summary>Quarter hour credit ("588")</summary>
	public static readonly NCES0108CreditTypeEarned QUARTER_HOUR_CREDIT = new NCES0108CreditTypeEarned("588");

	/// <summary>Intersession hour credit ("592")</summary>
	public static readonly NCES0108CreditTypeEarned INTERSESSION_HOUR_CREDIT = new NCES0108CreditTypeEarned("592");

	///<summary>Wrap an arbitrary string value in a NCES0108CreditTypeEarned object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static NCES0108CreditTypeEarned Wrap( String wrappedValue ) {
		return new NCES0108CreditTypeEarned( wrappedValue );
	}

	private NCES0108CreditTypeEarned( string enumDefValue ) : base( enumDefValue ) {}
	}
}