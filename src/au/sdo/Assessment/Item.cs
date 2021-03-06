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
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.Assessment{

/// <summary>An Item</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class Item : SifElement
{
	/// <summary>
	/// Creates an instance of an Item
	/// </summary>
	public Item() : base ( AssessmentDTD.ITEM ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Item( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;Response&gt;</c> element.
	/// </summary>
	/// <value> The <c>Response</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Answer selected or student work in raw format."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Response
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ITEM_RESPONSE ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ITEM_RESPONSE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ResponseLocation&gt;</c> element.
	/// </summary>
	/// <value> The <c>ResponseLocation</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An optional element that contains a URL pointing to the location of the response or additional response."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string ResponseLocation
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ITEM_RESPONSELOCATION ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ITEM_RESPONSELOCATION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ResponseStatus&gt;</c> element.
	/// </summary>
	/// <value> The <c>ResponseStatus</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Status of the response."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string ResponseStatus
	{
		get
		{ 
			return GetFieldValue( AssessmentDTD.ITEM_RESPONSESTATUS );
		}
		set
		{
			SetField( AssessmentDTD.ITEM_RESPONSESTATUS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;ResponseStatus&gt;</c> element.
	/// </summary>
	/// <param name="val">A ResponseStatus object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Status of the response."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetResponseStatus( ResponseStatus val )
	{
		SetField( AssessmentDTD.ITEM_RESPONSESTATUS, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ResponseTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>ResponseTime</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The length of time the student took to respond."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public TimeSpan? ResponseTime
	{
		get
		{
			return (TimeSpan?) GetSifSimpleFieldValue( AssessmentDTD.ITEM_RESPONSETIME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ITEM_RESPONSETIME, new SifDuration( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies the item on the assessment by number."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string ItemNumber
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ITEM_ITEMNUMBER ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ITEM_ITEMNUMBER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemName&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies the item on the assessment by name."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string ItemName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ITEM_ITEMNAME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ITEM_ITEMNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DiagnosticStatement&gt;</c> element.
	/// </summary>
	/// <value> The <c>DiagnosticStatement</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Psychometric purpose or design-related comment about the question."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string DiagnosticStatement
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ITEM_DIAGNOSTICSTATEMENT ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ITEM_DIAGNOSTICSTATEMENT, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;NumberOfAttempts&gt;</c> element.
	/// </summary>
	/// <value> The <c>NumberOfAttempts</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The number of times a student changes their answer or attempts a response."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public int? NumberOfAttempts
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( AssessmentDTD.ITEM_NUMBEROFATTEMPTS ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ITEM_NUMBEROFATTEMPTS, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>AssessmentItemRefId</c> attribute.
	/// </summary>
	/// <value> The <c>AssessmentItemRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "A GUID that identifies the item object associated with this student result."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string AssessmentItemRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ITEM_ASSESSMENTITEMREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ITEM_ASSESSMENTITEMREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemScore&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemScore</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This is the score the student received on the specific item."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string ItemScore
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ITEM_ITEMSCORE ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ITEM_ITEMSCORE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemAidSetUsed&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemAidSetUsed</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A tool or aid set used while viewing the item"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string ItemAidSetUsed
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ITEM_ITEMAIDSETUSED ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ITEM_ITEMAIDSETUSED, new SifString( value ), value );
		}
	}

}}
