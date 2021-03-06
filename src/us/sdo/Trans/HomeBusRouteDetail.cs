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
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Trans{

/// <summary>GUID referring to a BusRouteDetail object that identifies the origin bus stop for an inbound route or the destination bus stop for an outbound route. If the HomeBusRouteDetail element does not exist, then the student does not ride a bus to/from school.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class HomeBusRouteDetail : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of an HomeBusRouteDetail
	/// </summary>
	public HomeBusRouteDetail() : base ( TransDTD.HOMEBUSROUTEDETAIL ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sifRefObject">Must be set to BusRouteDetail</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;HomeBusRouteDetail&amp;gt; element</param>
	///
	public HomeBusRouteDetail( string sifRefObject, string value ) : base( TransDTD.HOMEBUSROUTEDETAIL )
	{
		this.SIF_RefObject = sifRefObject;
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected HomeBusRouteDetail( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { TransDTD.HOMEBUSROUTEDETAIL_SIF_REFOBJECT }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;HomeBusRouteDetail&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;HomeBusRouteDetail&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( TransDTD.HOMEBUSROUTEDETAIL ) ;
		}
		set
		{
			SetFieldValue( TransDTD.HOMEBUSROUTEDETAIL, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SIF_RefObject</c> attribute.
	/// </summary>
	/// <value> The <c>SIF_RefObject</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Must be set to BusRouteDetail"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string SIF_RefObject
	{
		get
		{
			return (string) GetSifSimpleFieldValue( TransDTD.HOMEBUSROUTEDETAIL_SIF_REFOBJECT ) ;
		}
		set
		{
			SetFieldValue( TransDTD.HOMEBUSROUTEDETAIL_SIF_REFOBJECT, new SifString( value ), value );
		}
	}

}}
