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
	/// Defines the set of values that can be specified whenever a ContentType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a ContentType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class ContentType : SifEnum
	{
	/// <summary>A specific type of XML, known to both parties ("NamedXML")</summary>
	public static readonly ContentType NAMEDXML = new ContentType("NamedXML");

	/// <summary>Any generic XML ("GenericXML")</summary>
	public static readonly ContentType GENERICXML = new ContentType("GenericXML");

	///<summary>Wrap an arbitrary string value in a ContentType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static ContentType Wrap( String wrappedValue ) {
		return new ContentType( wrappedValue );
	}

	private ContentType( string enumDefValue ) : base( enumDefValue ) {}
	}
}