// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Hrfin
{
	///<summary>
	/// Defines the set of values that can be specified whenever an ExpenditureAreaValue
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an ExpenditureAreaValue object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class ExpenditureAreaValue : SifEnum
	{
	/// <summary>Other ("Other")</summary>
	public static readonly ExpenditureAreaValue OTHER = new ExpenditureAreaValue("Other");

	/// <summary>Federal ("Federal")</summary>
	public static readonly ExpenditureAreaValue FEDERAL = new ExpenditureAreaValue("Federal");

	/// <summary>Elementary ("Elementary")</summary>
	public static readonly ExpenditureAreaValue ELEMENTARY = new ExpenditureAreaValue("Elementary");

	/// <summary>Secondary ("Secondary")</summary>
	public static readonly ExpenditureAreaValue SECONDARY = new ExpenditureAreaValue("Secondary");

	///<summary>Wrap an arbitrary string value in an ExpenditureAreaValue object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static ExpenditureAreaValue Wrap( String wrappedValue ) {
		return new ExpenditureAreaValue( wrappedValue );
	}

	private ExpenditureAreaValue( string enumDefValue ) : base( enumDefValue ) {}
	}
}