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

/// <summary>This object provides a summary of a learner's daily attendance and membership information for a given school during the time period between the StartDate and EndDate, inclusive. As such, there may be multiple instances of this object for a learner in a school over the course of an academic school year.  Note that sessions are defined by each school and in most cases is two but can be any number in the range 1-10. Compare with US/Canada object: StudentAttendanceSummary</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class LearnerAttendanceSummary : SifDataObject
{
	/// <summary>
	/// Creates an instance of a LearnerAttendanceSummary
	/// </summary>
	public LearnerAttendanceSummary() : base( Adk.SifVersion, LearnerDTD.LEARNERATTENDANCESUMMARY ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="learnerPersonalRefId">The ID (GUID) of the learner for whom this attendance information is being reported.</param>
	///<param name="schoolInfoRefId">The ID (GUID) of the school for which this attendance information is being reported.</param>
	///<param name="schoolYear">School year for which this information is applicable, expressed as the four-digit year in which the school year ends (e.g. 2007 for the 2006/07 school year). CBDS: 100225</param>
	///<param name="startDate">Starting date of this attendance reporting period. CBDS: 100226</param>
	///<param name="endDate">Ending date of this attendance reporting period. CBDS: 100227</param>
	///<param name="reasonsList">An enumeration of sessions by reason code within the reporting period.</param>
	///<param name="sessionsAttendedTotal">The number of sessions the learner attended school when school was in session between the StartDate and EndDate, inclusive. CBDS: 100229</param>
	///<param name="sessionsPossible">The number of sessions the learner was present plus the number of sessions the learner was absent (authorised and unauthorised) when school was in session during the period between the StartDate and EndDate, inclusive. CBDS: 100228</param>
	///
	public LearnerAttendanceSummary( string learnerPersonalRefId, string schoolInfoRefId, int? schoolYear, DateTime? startDate, DateTime? endDate, Reason reasonsList, int? sessionsAttendedTotal, int? sessionsPossible ) : base( Adk.SifVersion, LearnerDTD.LEARNERATTENDANCESUMMARY )
	{
		this.LearnerPersonalRefId = learnerPersonalRefId;
		this.SchoolInfoRefId = schoolInfoRefId;
		this.SchoolYear = schoolYear;
		this.StartDate = startDate;
		this.EndDate = endDate;
		this.ReasonsList =  new ReasonsList( reasonsList );
		this.SessionsAttendedTotal = sessionsAttendedTotal;
		this.SessionsPossible = sessionsPossible;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected LearnerAttendanceSummary( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { LearnerDTD.LEARNERATTENDANCESUMMARY_LEARNERPERSONALREFID, LearnerDTD.LEARNERATTENDANCESUMMARY_SCHOOLINFOREFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>LearnerPersonalRefId</c> attribute.
	/// </summary>
	/// <value> The <c>LearnerPersonalRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) of the learner for whom this attendance information is being reported."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string LearnerPersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_LEARNERPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_LEARNERPERSONALREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SchoolInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) of the school for which this attendance information is being reported."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolYear&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolYear</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "School year for which this information is applicable, expressed as the four-digit year in which the school year ends (e.g. 2007 for the 2006/07 school year). CBDS: 100225"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? SchoolYear
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_SCHOOLYEAR ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_SCHOOLYEAR, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StartDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>StartDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Starting date of this attendance reporting period. CBDS: 100226"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? StartDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_STARTDATE ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_STARTDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EndDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>EndDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Ending date of this attendance reporting period. CBDS: 100227"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? EndDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_ENDDATE ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_ENDDATE, new SifDate( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;ReasonsList&gt;</c> element.</summary>
	/// <param name="Reason">Learner attendance marks by code and number.</param>
	///<remarks>
	/// <para>This form of <c>setReasonsList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ReasonsList</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetReasonsList( Reason Reason ) {
		RemoveChild( LearnerDTD.LEARNERATTENDANCESUMMARY_REASONSLIST);
		AddChild( LearnerDTD.LEARNERATTENDANCESUMMARY_REASONSLIST, new ReasonsList( Reason ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReasonsList&gt;</c> element.
	/// </summary>
	/// <value> A ReasonsList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "An enumeration of sessions by reason code within the reporting period."</para>
	/// <para>To remove the <c>ReasonsList</c>, set <c>ReasonsList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public ReasonsList ReasonsList
	{
		get
		{
			return (ReasonsList)GetChild( LearnerDTD.LEARNERATTENDANCESUMMARY_REASONSLIST);
		}
		set
		{
			RemoveChild( LearnerDTD.LEARNERATTENDANCESUMMARY_REASONSLIST);
			if( value != null)
			{
				AddChild( LearnerDTD.LEARNERATTENDANCESUMMARY_REASONSLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SessionsAttendedTotal&gt;</c> element.
	/// </summary>
	/// <value> The <c>SessionsAttendedTotal</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The number of sessions the learner attended school when school was in session between the StartDate and EndDate, inclusive. CBDS: 100229"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? SessionsAttendedTotal
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_SESSIONSATTENDEDTOTAL ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_SESSIONSATTENDEDTOTAL, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SessionsPossible&gt;</c> element.
	/// </summary>
	/// <value> The <c>SessionsPossible</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The number of sessions the learner was present plus the number of sessions the learner was absent (authorised and unauthorised) when school was in session during the period between the StartDate and EndDate, inclusive. CBDS: 100228"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? SessionsPossible
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_SESSIONSPOSSIBLE ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_SESSIONSPOSSIBLE, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AuthorisedAbsences&gt;</c> element.
	/// </summary>
	/// <value> The <c>AuthorisedAbsences</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The number of sessions the learner was absent from school with a valid excuse when school was in session between the StartDate and EndDate, inclusive. Note that ts column can be derived from Reason Status. CBDS: 100230"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? AuthorisedAbsences
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_AUTHORISEDABSENCES ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_AUTHORISEDABSENCES, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;UnauthorisedAbsences&gt;</c> element.
	/// </summary>
	/// <value> The <c>UnauthorisedAbsences</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The number of sessions the learner was absent from school without a valid excuse when school was in session between the StartDate and EndDate, inclusive.  Note that this column can be derived from Reason Status. CBDS: 100231"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? UnauthorisedAbsences
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_UNAUTHORISEDABSENCES ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_UNAUTHORISEDABSENCES, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AlternativeTuitionHours&gt;</c> element.
	/// </summary>
	/// <value> The <c>AlternativeTuitionHours</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Number of Alternative Tuition (whole) hours attended between the StartDate and EndDate, inclusive. CBDS: 100238"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string AlternativeTuitionHours
	{
		get
		{ 
			return GetFieldValue( LearnerDTD.LEARNERATTENDANCESUMMARY_ALTERNATIVETUITIONHOURS );
		}
		set
		{
			SetField( LearnerDTD.LEARNERATTENDANCESUMMARY_ALTERNATIVETUITIONHOURS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AlternativeTuitionHours&gt;</c> element.
	/// </summary>
	/// <param name="val">A TuitionHours object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Number of Alternative Tuition (whole) hours attended between the StartDate and EndDate, inclusive. CBDS: 100238"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetAlternativeTuitionHours( TuitionHours val )
	{
		SetField( LearnerDTD.LEARNERATTENDANCESUMMARY_ALTERNATIVETUITIONHOURS, val );
	}

}}