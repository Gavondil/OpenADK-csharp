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

namespace OpenADK.Library.us.Student{

/// <summary>An Action</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class Action : SifElement
{
	/// <summary>
	/// Creates an instance of an Action
	/// </summary>
	public Action() : base ( StudentDTD.ACTION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="code">A Code</param>
	///<param name="startDate">The date on which the disciplinary action begins.</param>
	///<param name="endDate">The date through which the disciplinary action is in effect, inclusive.</param>
	///<param name="duration">Identifies the length, in school days, of the disciplinary action.  Note: decimal places may be used for fractions of school days.</param>
	///<param name="zeroTolerance">Identifies whether or not this action taken against a student was imposed as a consequence of state or local zero tolerance policies.</param>
	///<param name="fullYearExpulsion">Identifies whether or not the action involved an expulsion with or without services for a period of one full year (i.e., 365 days).</param>
	///<param name="shortenedExpulsion">Identifies whether or not the action involved an expulsion with or without services that is shortened to a term of less than one year by the superintendent or chief administrator of a school district.</param>
	///<param name="policeNotification">Identifies whether or not the offender's action included notification of local law enforcement, regardless of whether official action was taken.</param>
	///<param name="arrest">Identifies whether or not the offender was arrested.</param>
	///<param name="alternativeEducation">Identifies whether or not the offender was assigned to an Alternative Education facility.</param>
	///
	public Action( string code, DateTime? startDate, DateTime? endDate, decimal? duration, YesNo zeroTolerance, YesNo fullYearExpulsion, YesNo shortenedExpulsion, YesNo policeNotification, ArrestStatus arrest, YesNo alternativeEducation ) : base( StudentDTD.ACTION )
	{
		this.Code = code;
		this.StartDate = startDate;
		this.EndDate = endDate;
		this.Duration = duration;
		this.SetZeroTolerance( zeroTolerance );
		this.SetFullYearExpulsion( fullYearExpulsion );
		this.SetShortenedExpulsion( shortenedExpulsion );
		this.SetPoliceNotification( policeNotification );
		this.SetArrest( arrest );
		this.SetAlternativeEducation( alternativeEducation );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Action( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>Code</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Code
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.ACTION_CODE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.ACTION_CODE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherCodeList&gt;</c> element.
	/// </summary>
	/// <value> An OtherCodeList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "List of other codes or strings that crosswalk to or serve as translations of the Code element.  If Code changes and OtherCode elements are supported, both Code and all associated OtherCode elements must be present."</para>
	/// <para>To remove the <c>OtherCodeList</c>, set <c>OtherCodeList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public OtherCodeList OtherCodeList
	{
		get
		{
			return (OtherCodeList)GetChild( StudentDTD.ACTION_OTHERCODELIST);
		}
		set
		{
			RemoveChild( StudentDTD.ACTION_OTHERCODELIST);
			if( value != null)
			{
				AddChild( StudentDTD.ACTION_OTHERCODELIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StartDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>StartDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date on which the disciplinary action begins."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? StartDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( StudentDTD.ACTION_STARTDATE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.ACTION_STARTDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EndDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>EndDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date through which the disciplinary action is in effect, inclusive."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? EndDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( StudentDTD.ACTION_ENDDATE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.ACTION_ENDDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Duration&gt;</c> element.
	/// </summary>
	/// <value> The <c>Duration</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies the length, in school days, of the disciplinary action.  Note: decimal places may be used for fractions of school days."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? Duration
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( StudentDTD.ACTION_DURATION ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.ACTION_DURATION, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ZeroTolerance&gt;</c> element.
	/// </summary>
	/// <value> The <c>ZeroTolerance</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies whether or not this action taken against a student was imposed as a consequence of state or local zero tolerance policies."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string ZeroTolerance
	{
		get
		{ 
			return GetFieldValue( StudentDTD.ACTION_ZEROTOLERANCE );
		}
		set
		{
			SetField( StudentDTD.ACTION_ZEROTOLERANCE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;ZeroTolerance&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNo object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies whether or not this action taken against a student was imposed as a consequence of state or local zero tolerance policies."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetZeroTolerance( YesNo val )
	{
		SetField( StudentDTD.ACTION_ZEROTOLERANCE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FullYearExpulsion&gt;</c> element.
	/// </summary>
	/// <value> The <c>FullYearExpulsion</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies whether or not the action involved an expulsion with or without services for a period of one full year (i.e., 365 days)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string FullYearExpulsion
	{
		get
		{ 
			return GetFieldValue( StudentDTD.ACTION_FULLYEAREXPULSION );
		}
		set
		{
			SetField( StudentDTD.ACTION_FULLYEAREXPULSION, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;FullYearExpulsion&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNo object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies whether or not the action involved an expulsion with or without services for a period of one full year (i.e., 365 days)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetFullYearExpulsion( YesNo val )
	{
		SetField( StudentDTD.ACTION_FULLYEAREXPULSION, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ShortenedExpulsion&gt;</c> element.
	/// </summary>
	/// <value> The <c>ShortenedExpulsion</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies whether or not the action involved an expulsion with or without services that is shortened to a term of less than one year by the superintendent or chief administrator of a school district."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string ShortenedExpulsion
	{
		get
		{ 
			return GetFieldValue( StudentDTD.ACTION_SHORTENEDEXPULSION );
		}
		set
		{
			SetField( StudentDTD.ACTION_SHORTENEDEXPULSION, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;ShortenedExpulsion&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNo object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies whether or not the action involved an expulsion with or without services that is shortened to a term of less than one year by the superintendent or chief administrator of a school district."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetShortenedExpulsion( YesNo val )
	{
		SetField( StudentDTD.ACTION_SHORTENEDEXPULSION, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PoliceNotification&gt;</c> element.
	/// </summary>
	/// <value> The <c>PoliceNotification</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies whether or not the offender's action included notification of local law enforcement, regardless of whether official action was taken."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string PoliceNotification
	{
		get
		{ 
			return GetFieldValue( StudentDTD.ACTION_POLICENOTIFICATION );
		}
		set
		{
			SetField( StudentDTD.ACTION_POLICENOTIFICATION, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;PoliceNotification&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNo object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies whether or not the offender's action included notification of local law enforcement, regardless of whether official action was taken."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetPoliceNotification( YesNo val )
	{
		SetField( StudentDTD.ACTION_POLICENOTIFICATION, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Arrest&gt;</c> element.
	/// </summary>
	/// <value> The <c>Arrest</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies whether or not the offender was arrested."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Arrest
	{
		get
		{ 
			return GetFieldValue( StudentDTD.ACTION_ARREST );
		}
		set
		{
			SetField( StudentDTD.ACTION_ARREST, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Arrest&gt;</c> element.
	/// </summary>
	/// <param name="val">A ArrestStatus object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies whether or not the offender was arrested."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetArrest( ArrestStatus val )
	{
		SetField( StudentDTD.ACTION_ARREST, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AlternativeEducation&gt;</c> element.
	/// </summary>
	/// <value> The <c>AlternativeEducation</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies whether or not the offender was assigned to an Alternative Education facility."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string AlternativeEducation
	{
		get
		{ 
			return GetFieldValue( StudentDTD.ACTION_ALTERNATIVEEDUCATION );
		}
		set
		{
			SetField( StudentDTD.ACTION_ALTERNATIVEEDUCATION, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AlternativeEducation&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNo object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies whether or not the offender was assigned to an Alternative Education facility."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetAlternativeEducation( YesNo val )
	{
		SetField( StudentDTD.ACTION_ALTERNATIVEEDUCATION, val );
	}

}}
