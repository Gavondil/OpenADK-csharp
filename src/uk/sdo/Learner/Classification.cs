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
	/// Defines the set of values that can be specified whenever a Classification
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a Classification object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class Classification : SifEnum
	{
	/// <summary>Activity ("Activity")</summary>
	public static readonly Classification ACTIVITY = new Classification("Activity");

	/// <summary>Communication ("Communication")</summary>
	public static readonly Classification COMMUNICATION = new Classification("Communication");

	/// <summary>Exclusion ("Exclusion")</summary>
	public static readonly Classification EXCLUSION = new Classification("Exclusion");

	/// <summary>Punishment ("Punishment")</summary>
	public static readonly Classification PUNISHMENT = new Classification("Punishment");

	///<summary>Wrap an arbitrary string value in a Classification object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static Classification Wrap( String wrappedValue ) {
		return new Classification( wrappedValue );
	}

	private Classification( string enumDefValue ) : base( enumDefValue ) {}
	}
}
