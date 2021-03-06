// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Instr
{
	///<summary>
	/// Defines the set of values that can be specified whenever an EvaluationType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an EvaluationType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class EvaluationType : SifEnum
	{
	/// <summary>RefId ("RefId")</summary>
	public static readonly EvaluationType REFID = new EvaluationType("RefId");

	/// <summary>Inline ("Inline")</summary>
	public static readonly EvaluationType INLINE = new EvaluationType("Inline");

	///<summary>Wrap an arbitrary string value in an EvaluationType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static EvaluationType Wrap( String wrappedValue ) {
		return new EvaluationType( wrappedValue );
	}

	private EvaluationType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
