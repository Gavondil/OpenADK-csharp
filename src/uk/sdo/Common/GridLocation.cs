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

namespace OpenADK.Library.uk.Common{

/// <summary>This element contains a map location. The GridLocation element is utilised within other objects and elements.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class GridLocation : SifElement
{
	/// <summary>
	/// Creates an instance of a GridLocation
	/// </summary>
	public GridLocation() : base ( CommonDTD.GRIDLOCATION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="propertyEasting">Easting coordinate for mapping an address. CBDS: 100126, 100197, S72</param>
	///<param name="propertyNorthing">Northing coordinate for mapping an address. Required when PropertyEasting is also specified. CBDS: 100127, 100198, S73</param>
	///
	public GridLocation( decimal? propertyEasting, decimal? propertyNorthing ) : base( CommonDTD.GRIDLOCATION )
	{
		this.PropertyEasting = propertyEasting;
		this.PropertyNorthing = propertyNorthing;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected GridLocation( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.GRIDLOCATION_PROPERTYEASTING, CommonDTD.GRIDLOCATION_PROPERTYNORTHING }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PropertyEasting&gt;</c> element.
	/// </summary>
	/// <value> The <c>PropertyEasting</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Easting coordinate for mapping an address. CBDS: 100126, 100197, S72"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? PropertyEasting
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( CommonDTD.GRIDLOCATION_PROPERTYEASTING ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.GRIDLOCATION_PROPERTYEASTING, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PropertyNorthing&gt;</c> element.
	/// </summary>
	/// <value> The <c>PropertyNorthing</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Northing coordinate for mapping an address. Required when PropertyEasting is also specified. CBDS: 100127, 100198, S73"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? PropertyNorthing
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( CommonDTD.GRIDLOCATION_PROPERTYNORTHING ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.GRIDLOCATION_PROPERTYNORTHING, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Latitude&gt;</c> element.
	/// </summary>
	/// <value> The <c>Latitude</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Geographical coordinate."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? Latitude
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( CommonDTD.GRIDLOCATION_LATITUDE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.GRIDLOCATION_LATITUDE, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Longitude&gt;</c> element.
	/// </summary>
	/// <value> The <c>Longitude</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Geographical coordinate. Required when Latitude is also specified."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? Longitude
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( CommonDTD.GRIDLOCATION_LONGITUDE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.GRIDLOCATION_LONGITUDE, new SifDecimal( value ), value );
		}
	}

}}