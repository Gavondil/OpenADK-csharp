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

namespace OpenADK.Library.us.Food{

/// <summary>A FoodserviceMilkSales</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class FoodserviceMilkSales : SifDataObject
{
	/// <summary>
	/// Creates an instance of a FoodserviceMilkSales
	/// </summary>
	public FoodserviceMilkSales() : base( Adk.SifVersion, FoodDTD.FOODSERVICEMILKSALES ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">GUID that identifies the daily milk sales object</param>
	///<param name="schoolInfoRefId">School for which the sales object applies</param>
	///<param name="date">Date on which the sales occurred.</param>
	///<param name="program">A Program</param>
	///<param name="saleQuantities">A SaleQuantities</param>
	///
	public FoodserviceMilkSales( string refId, string schoolInfoRefId, DateTime? date, Program program, SaleQuantities saleQuantities ) : base( Adk.SifVersion, FoodDTD.FOODSERVICEMILKSALES )
	{
		this.RefId = refId;
		this.SchoolInfoRefId = schoolInfoRefId;
		this.Date = date;
		this.Program = program;
		this.SaleQuantities = saleQuantities;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected FoodserviceMilkSales( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { FoodDTD.FOODSERVICEMILKSALES_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "GUID that identifies the daily milk sales object"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( FoodDTD.FOODSERVICEMILKSALES_REFID ) ;
		}
		set
		{
			SetFieldValue( FoodDTD.FOODSERVICEMILKSALES_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "School for which the sales object applies"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( FoodDTD.FOODSERVICEMILKSALES_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( FoodDTD.FOODSERVICEMILKSALES_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Date&gt;</c> element.
	/// </summary>
	/// <value> The <c>Date</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date on which the sales occurred."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? Date
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( FoodDTD.FOODSERVICEMILKSALES_DATE ) ;
		}
		set
		{
			SetFieldValue( FoodDTD.FOODSERVICEMILKSALES_DATE, new SifDate( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Program&gt;</c> element.</summary>
	/// <param name="Type">The type of the program. Type identifies the list of values.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Program&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setProgram</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Program</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetProgram( FinancialProgram Type, string Value ) {
		RemoveChild( FoodDTD.FOODSERVICEMILKSALES_PROGRAM);
		AddChild( FoodDTD.FOODSERVICEMILKSALES_PROGRAM, new Program( Type, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Program&gt;</c> element.
	/// </summary>
	/// <value> A Program </value>
	/// <remarks>
	/// <para>To remove the <c>Program</c>, set <c>Program</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public Program Program
	{
		get
		{
			return (Program)GetChild( FoodDTD.FOODSERVICEMILKSALES_PROGRAM);
		}
		set
		{
			RemoveChild( FoodDTD.FOODSERVICEMILKSALES_PROGRAM);
			if( value != null)
			{
				AddChild( FoodDTD.FOODSERVICEMILKSALES_PROGRAM, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SaleQuantities&gt;</c> element.
	/// </summary>
	/// <value> A SaleQuantities </value>
	/// <remarks>
	/// <para>To remove the <c>SaleQuantities</c>, set <c>SaleQuantities</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SaleQuantities SaleQuantities
	{
		get
		{
			return (SaleQuantities)GetChild( FoodDTD.FOODSERVICEMILKSALES_SALEQUANTITIES);
		}
		set
		{
			RemoveChild( FoodDTD.FOODSERVICEMILKSALES_SALEQUANTITIES);
			if( value != null)
			{
				AddChild( FoodDTD.FOODSERVICEMILKSALES_SALEQUANTITIES, value );
			}
		}
	}

}}
