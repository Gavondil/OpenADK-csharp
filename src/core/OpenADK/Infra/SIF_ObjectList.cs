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

/// <summary>A SIF_ObjectList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class SIF_ObjectList : SifKeyedList<SIF_Object>
{
	/// <summary>
	/// Creates an instance of a SIF_ObjectList
	/// </summary>
	public SIF_ObjectList() : base ( InfraDTD.SIF_OBJECTLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sifObject">The name of the object that is being provided by this SIF_SIFNode</param>
	///
	public SIF_ObjectList( SIF_Object sifObject ) : base( InfraDTD.SIF_OBJECTLIST )
	{
		this.SafeAddChild( InfraDTD.SIF_OBJECTLIST_SIF_OBJECT, sifObject );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_ObjectList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;SIF_Object&gt;</c> element.</summary>
	/// <param name="ObjectName">The name of a SIF data object</param>
	///<remarks>
	/// <para>This form of <c>setSIF_Object</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddSIF_Object</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void AddSIF_Object( string ObjectName ) {
		AddChild( InfraDTD.SIF_OBJECTLIST_SIF_OBJECT, new SIF_Object( ObjectName ) );
	}

}}
