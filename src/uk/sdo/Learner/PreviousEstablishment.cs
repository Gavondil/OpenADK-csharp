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
using OpenADK.Library.uk.Common;

namespace OpenADK.Library.uk.Learner{

/// <summary>A previous school or establishment.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class PreviousEstablishment : SifElement
{
	/// <summary>
	/// Creates an instance of a PreviousEstablishment
	/// </summary>
	public PreviousEstablishment() : base ( LearnerDTD.PREVIOUSESTABLISHMENT ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected PreviousEstablishment( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;EstablishmentId&gt;</c> element.
	/// </summary>
	/// <value> The <c>EstablishmentId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "DfES Establishment Number for this school."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string EstablishmentId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearnerDTD.PREVIOUSESTABLISHMENT_ESTABLISHMENTID ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.PREVIOUSESTABLISHMENT_ESTABLISHMENTID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EstablishmentName&gt;</c> element.
	/// </summary>
	/// <value> The <c>EstablishmentName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "School's name as indicated on the Annual Schools Census."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string EstablishmentName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearnerDTD.PREVIOUSESTABLISHMENT_ESTABLISHMENTNAME ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.PREVIOUSESTABLISHMENT_ESTABLISHMENTNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LAId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LAId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The 3-digit LA number assigned by DfES."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string LAId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearnerDTD.PREVIOUSESTABLISHMENT_LAID ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.PREVIOUSESTABLISHMENT_LAID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EntryDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>EntryDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date the learner entered this school or establishment."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? EntryDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( LearnerDTD.PREVIOUSESTABLISHMENT_ENTRYDATE ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.PREVIOUSESTABLISHMENT_ENTRYDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ExitDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>ExitDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date the learner exited this school or establishment."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? ExitDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( LearnerDTD.PREVIOUSESTABLISHMENT_EXITDATE ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.PREVIOUSESTABLISHMENT_EXITDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ExitType&gt;</c> element.
	/// </summary>
	/// <value> The <c>ExitType</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Code indicating the type of exit from this school or establishment."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string ExitType
	{
		get
		{ 
			return GetFieldValue( LearnerDTD.PREVIOUSESTABLISHMENT_EXITTYPE );
		}
		set
		{
			SetField( LearnerDTD.PREVIOUSESTABLISHMENT_EXITTYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;ExitType&gt;</c> element.
	/// </summary>
	/// <param name="val">A LeavingReason object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Code indicating the type of exit from this school or establishment."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetExitType( LeavingReason val )
	{
		SetField( LearnerDTD.PREVIOUSESTABLISHMENT_EXITTYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LastSchool&gt;</c> element.
	/// </summary>
	/// <value> The <c>LastSchool</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An indication of whether the described school or establishment was the last establishment the learner attended. Note that it is possible that more than one establishment can be marked as LastSchool when a learner is enroled in more than one school simultaneously."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string LastSchool
	{
		get
		{ 
			return GetFieldValue( LearnerDTD.PREVIOUSESTABLISHMENT_LASTSCHOOL );
		}
		set
		{
			SetField( LearnerDTD.PREVIOUSESTABLISHMENT_LASTSCHOOL, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;LastSchool&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNo object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An indication of whether the described school or establishment was the last establishment the learner attended. Note that it is possible that more than one establishment can be marked as LastSchool when a learner is enroled in more than one school simultaneously."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetLastSchool( YesNo val )
	{
		SetField( LearnerDTD.PREVIOUSESTABLISHMENT_LASTSCHOOL, val );
	}

}}