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

/// <summary>A SIF_Provider</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class SIF_Provider : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a SIF_Provider
	/// </summary>
	public SIF_Provider() : base ( InfraDTD.SIF_PROVIDER ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sourceId">The identifier of the SIF node that is providing objects. This is the agent or ZIS identifier that would appear in the SIF_SourceId field of any SIF_Header created by the SIF node.</param>
	///<param name="sifObjectList">The name of the object that is being provided by this SIF_SIFNode</param>
	///
	public SIF_Provider( string sourceId, SIF_ObjectList sifObjectList ) : base( InfraDTD.SIF_PROVIDER )
	{
		this.SourceId = sourceId;
		this.SIF_ObjectList = sifObjectList;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_Provider( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { InfraDTD.SIF_PROVIDER_SOURCEID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>SourceId</c> attribute.
	/// </summary>
	/// <value> The <c>SourceId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The identifier of the SIF node that is providing objects. This is the agent or ZIS identifier that would appear in the SIF_SourceId field of any SIF_Header created by the SIF node."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string SourceId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_PROVIDER_SOURCEID ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_PROVIDER_SOURCEID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_ObjectList&gt;</c> element.
	/// </summary>
	/// <value> A SIF_ObjectList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The name of the object that is being provided by this SIF_SIFNode"</para>
	/// <para>To remove the <c>SIF_ObjectList</c>, set <c>SIF_ObjectList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_ObjectList SIF_ObjectList
	{
		get
		{
			return (SIF_ObjectList)GetChild( InfraDTD.SIF_PROVIDER_SIF_OBJECTLIST);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_PROVIDER_SIF_OBJECTLIST);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_PROVIDER_SIF_OBJECTLIST, value );
			}
		}
	}

}}