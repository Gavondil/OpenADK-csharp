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

namespace OpenADK.Library.us.Hrfin{

/// <summary>Period of the income statement.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class FISPeriod : SifElement
{
	/// <summary>
	/// Creates an instance of a FISPeriod
	/// </summary>
	public FISPeriod() : base ( HrfinDTD.FISPERIOD ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="startDate">Start date.</param>
	///<param name="endDate">End date.</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;FISPeriod&amp;gt; element</param>
	///
	public FISPeriod( DateTime? startDate, DateTime? endDate, string value ) : base( HrfinDTD.FISPERIOD )
	{
		this.StartDate = startDate;
		this.EndDate = endDate;
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected FISPeriod( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { HrfinDTD.FISPERIOD_STARTDATE, HrfinDTD.FISPERIOD_ENDDATE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FISPeriod&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;FISPeriod&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.FISPERIOD ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FISPERIOD, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>StartDate</c> attribute.
	/// </summary>
	/// <value> The <c>StartDate</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Start date."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public DateTime? StartDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( HrfinDTD.FISPERIOD_STARTDATE ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FISPERIOD_STARTDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>EndDate</c> attribute.
	/// </summary>
	/// <value> The <c>EndDate</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "End date."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public DateTime? EndDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( HrfinDTD.FISPERIOD_ENDDATE ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FISPERIOD_ENDDATE, new SifDate( value ), value );
		}
	}

}}
