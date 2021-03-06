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

namespace OpenADK.Library.us.Assessment{

/// <summary>An AssessmentSubTest</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class AssessmentSubTest : SifDataObject
{
	/// <summary>
	/// Creates an instance of an AssessmentSubTest
	/// </summary>
	public AssessmentSubTest() : base( Adk.SifVersion, AssessmentDTD.ASSESSMENTSUBTEST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The GUID that uniquely identifies an instance of the object.</param>
	///
	public AssessmentSubTest( string refId ) : base( Adk.SifVersion, AssessmentDTD.ASSESSMENTSUBTEST )
	{
		this.RefId = refId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssessmentSubTest( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.ASSESSMENTSUBTEST_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID that uniquely identifies an instance of the object."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTSUBTEST_REFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTSUBTEST_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> The <c>Name</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Text name of the subtest."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Name
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTSUBTEST_NAME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTSUBTEST_NAME, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;ScoreRange&gt;</c> element.</summary>
	/// <param name="ScoreMetric">The metric or scale used to report the scores.</param>
	///<remarks>
	/// <para>This form of <c>setScoreRange</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ScoreRange</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetScoreRange( AssessmentReportingMethod ScoreMetric ) {
		RemoveChild( AssessmentDTD.ASSESSMENTSUBTEST_SCORERANGE);
		AddChild( AssessmentDTD.ASSESSMENTSUBTEST_SCORERANGE, new ScoreRange( ScoreMetric ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ScoreRange&gt;</c> element.
	/// </summary>
	/// <value> A ScoreRange </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The possible range of scores."</para>
	/// <para>To remove the <c>ScoreRange</c>, set <c>ScoreRange</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public ScoreRange ScoreRange
	{
		get
		{
			return (ScoreRange)GetChild( AssessmentDTD.ASSESSMENTSUBTEST_SCORERANGE);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTSUBTEST_SCORERANGE);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTSUBTEST_SCORERANGE, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PerformanceLevels&gt;</c> element.
	/// </summary>
	/// <value> A PerformanceLevels </value>
	/// <remarks>
	/// <para>To remove the <c>PerformanceLevels</c>, set <c>PerformanceLevels</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public PerformanceLevels PerformanceLevels
	{
		get
		{
			return (PerformanceLevels)GetChild( AssessmentDTD.ASSESSMENTSUBTEST_PERFORMANCELEVELS);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTSUBTEST_PERFORMANCELEVELS);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTSUBTEST_PERFORMANCELEVELS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SubjectArea&gt;</c> element.
	/// </summary>
	/// <value> The <c>SubjectArea</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Content area covered by the score."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SubjectArea
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTSUBTEST_SUBJECTAREA ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTSUBTEST_SUBJECTAREA, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GradeLevels&gt;</c> element.
	/// </summary>
	/// <value> A GradeLevels </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Grade levels for which the score is valid."</para>
	/// <para>To remove the <c>GradeLevels</c>, set <c>GradeLevels</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public GradeLevels GradeLevels
	{
		get
		{
			return (GradeLevels)GetChild( AssessmentDTD.ASSESSMENTSUBTEST_GRADELEVELS);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTSUBTEST_GRADELEVELS);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTSUBTEST_GRADELEVELS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentSubTestRefIds&gt;</c> element.
	/// </summary>
	/// <value> An AssessmentSubTestRefIds </value>
	/// <remarks>
	/// <para>To remove the <c>AssessmentSubTestRefIds</c>, set <c>AssessmentSubTestRefIds</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public AssessmentSubTestRefIds AssessmentSubTestRefIds
	{
		get
		{
			return (AssessmentSubTestRefIds)GetChild( AssessmentDTD.ASSESSMENTSUBTEST_ASSESSMENTSUBTESTREFIDS);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTSUBTEST_ASSESSMENTSUBTESTREFIDS);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTSUBTEST_ASSESSMENTSUBTESTREFIDS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SubTestTier&gt;</c> element.
	/// </summary>
	/// <value> The <c>SubTestTier</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An integer that defines the level or tier of the score in a multi-level arrangement of composite
	///                 scores. Zero indicates the highest or root level.
	///             "</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? SubTestTier
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTSUBTEST_SUBTESTTIER ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTSUBTEST_SUBTESTTIER, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LearningStandardItemRefIds&gt;</c> element.
	/// </summary>
	/// <value> A LearningStandardItemRefIds </value>
	/// <remarks>
	/// <para>To remove the <c>LearningStandardItemRefIds</c>, set <c>LearningStandardItemRefIds</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public LearningStandardItemRefIds LearningStandardItemRefIds
	{
		get
		{
			return (LearningStandardItemRefIds)GetChild( AssessmentDTD.ASSESSMENTSUBTEST_LEARNINGSTANDARDITEMREFIDS);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTSUBTEST_LEARNINGSTANDARDITEMREFIDS);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTSUBTEST_LEARNINGSTANDARDITEMREFIDS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Abbreviation&gt;</c> element.
	/// </summary>
	/// <value> The <c>Abbreviation</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This is the short version of the name of the assessment that is often used for quick reference and
	///                 used in reports.
	///             "</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Abbreviation
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTSUBTEST_ABBREVIATION ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTSUBTEST_ABBREVIATION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The description element provides an opportunity to pass additional information about the assessment
	///                 and also be used for describing elements in a test hierarchy.
	///             "</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTSUBTEST_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTSUBTEST_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;NumberOfItems&gt;</c> element.
	/// </summary>
	/// <value> The <c>NumberOfItems</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This element records the number of items included on the assessment. This number may be different than
	///                 the possible score.
	///             "</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public int? NumberOfItems
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTSUBTEST_NUMBEROFITEMS ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTSUBTEST_NUMBEROFITEMS, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ContainerOnly&gt;</c> element.
	/// </summary>
	/// <value> The <c>ContainerOnly</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicator describing the purpose of an AssessmentSubTest as being that of a container for the child
	///                 AssessmentSubTests. There will be no scores within this subtest.
	///             "</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public bool? ContainerOnly
	{
		get
		{
			return (bool?) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTSUBTEST_CONTAINERONLY ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTSUBTEST_CONTAINERONLY, new SifBoolean( value ), value );
		}
	}

}}
