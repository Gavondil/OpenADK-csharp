// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Programs
{
	///<summary>
	/// Defines the set of values that can be specified whenever a ProgramFundingSourceCodeType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a ProgramFundingSourceCodeType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class ProgramFundingSourceCodeType : SifEnum
	{
	/// <summary>Other ("9")</summary>
	public static readonly ProgramFundingSourceCodeType C9_OTHER = new ProgramFundingSourceCodeType("9");

	/// <summary>School Source ("3")</summary>
	public static readonly ProgramFundingSourceCodeType C3_SCHOOL_SOURCE = new ProgramFundingSourceCodeType("3");

	/// <summary>Director's Discretion ("4")</summary>
	public static readonly ProgramFundingSourceCodeType C4_DIRECTORS_DISCRETION = new ProgramFundingSourceCodeType("4");

	/// <summary>State/Jurisdiction ("1")</summary>
	public static readonly ProgramFundingSourceCodeType C1_STATE_JURISDICTION = new ProgramFundingSourceCodeType("1");

	/// <summary>Commonwealth Initiative ("2")</summary>
	public static readonly ProgramFundingSourceCodeType C2_COMMONWEALTH_INITIATIVE = new ProgramFundingSourceCodeType("2");

	/// <summary>Community Sponsored ("5")</summary>
	public static readonly ProgramFundingSourceCodeType C5_COMMUNITY_SPONSORED = new ProgramFundingSourceCodeType("5");

	///<summary>Wrap an arbitrary string value in a ProgramFundingSourceCodeType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static ProgramFundingSourceCodeType Wrap( String wrappedValue ) {
		return new ProgramFundingSourceCodeType( wrappedValue );
	}

	private ProgramFundingSourceCodeType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
