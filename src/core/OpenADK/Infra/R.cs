// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;

namespace OpenADK.Library.Infra{

/// <summary>A R</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class R : SifKeyedList<C>
{
	/// <summary>
	/// Creates an instance of a R
	/// </summary>
	public R() : base ( InfraDTD.R ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="c">A C</param>
	///
	public R( C c ) : base( InfraDTD.R )
	{
		this.SafeAddChild( InfraDTD.R_C, c );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected R( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;C&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;C&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setC</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddC</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddC( string Value ) {
		AddChild( InfraDTD.R_C, new C( Value ) );
	}

}}
