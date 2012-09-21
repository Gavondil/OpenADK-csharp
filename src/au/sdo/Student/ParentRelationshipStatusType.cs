// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Student
{
	///<summary>
	/// Defines the set of values that can be specified whenever a ParentRelationshipStatusType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a ParentRelationshipStatusType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	[Serializable]
	public class ParentRelationshipStatusType : SifEnum
	{
	/// <summary>Parent 2 ("Parent2")</summary>
	public static readonly ParentRelationshipStatusType PARENT_2 = new ParentRelationshipStatusType("Parent2");

	/// <summary>Parent 1 ("Parent1")</summary>
	public static readonly ParentRelationshipStatusType PARENT_1 = new ParentRelationshipStatusType("Parent1");

	/// <summary>Not For Reporting ("NotForReporting")</summary>
	public static readonly ParentRelationshipStatusType NOT_FOR_REPORTING = new ParentRelationshipStatusType("NotForReporting");

	///<summary>Wrap an arbitrary string value in a ParentRelationshipStatusType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static ParentRelationshipStatusType Wrap( String wrappedValue ) {
		return new ParentRelationshipStatusType( wrappedValue );
	}

	private ParentRelationshipStatusType( string enumDefValue ) : base( enumDefValue ) {}
	}
}