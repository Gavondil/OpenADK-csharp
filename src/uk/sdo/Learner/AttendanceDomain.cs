// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Learner
{
	///<summary>
	/// Defines the set of values that can be specified whenever an AttendanceDomain
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an AttendanceDomain object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	[Serializable]
	public class AttendanceDomain : SifEnum
	{
	/// <summary>Lesson ("Lesson")</summary>
	public static readonly AttendanceDomain LESSON = new AttendanceDomain("Lesson");

	/// <summary>Session ("Session")</summary>
	public static readonly AttendanceDomain SESSION = new AttendanceDomain("Session");

	/// <summary>Both ("Both")</summary>
	public static readonly AttendanceDomain BOTH = new AttendanceDomain("Both");

	///<summary>Wrap an arbitrary string value in an AttendanceDomain object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static AttendanceDomain Wrap( String wrappedValue ) {
		return new AttendanceDomain( wrappedValue );
	}

	private AttendanceDomain( string enumDefValue ) : base( enumDefValue ) {}
	}
}
