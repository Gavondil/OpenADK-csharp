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

/// <summary>This object represents the score conversion tables to be used by the scoring system to derive alternate values. As an example, it is often typical for a scoring system to convert a raw score to a scale score. It is also common for a scoring system to derive a student performance level on an assessment from a total scaled score.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class Sif3AssessmentScoreTable : SifDataObject
{
	/// <summary>
	/// Creates an instance of a Sif3AssessmentScoreTable
	/// </summary>
	public Sif3AssessmentScoreTable() : base( Adk.SifVersion, AssessmentDTD.SIF3ASSESSMENTSCORETABLE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The GUID that uniquely identifies an instance of the object.</param>
	///<param name="scoreTableName">The user defined name of the score table.</param>
	///
	public Sif3AssessmentScoreTable( string refId, string scoreTableName ) : base( Adk.SifVersion, AssessmentDTD.SIF3ASSESSMENTSCORETABLE )
	{
		this.RefId = refId;
		this.ScoreTableName = scoreTableName;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Sif3AssessmentScoreTable( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.SIF3ASSESSMENTSCORETABLE_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID that uniquely identifies an instance of the object."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_REFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ScoreTableVersion&gt;</c> element.
	/// </summary>
	/// <value> The <c>ScoreTableVersion</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The version of the score table that this object represents. Note that new versions of score tables must generate new RefIds and therefore a new score table object. The format of the numbering system is determined by the assessment provider."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ScoreTableVersion
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_SCORETABLEVERSION ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_SCORETABLEVERSION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TablePublishDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>TablePublishDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date that this version of the score table was published (published means made available for use). If a ScoreTableVersion is provided, then this element should also be provided."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public DateTime? TablePublishDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_TABLEPUBLISHDATE ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_TABLEPUBLISHDATE, new SifDateTime( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;ScoreTableIdentifiers&gt;</c> element.</summary>
	/// <param name="ScoreTableIdentifier">An internal or natural identifier for the ScoreTable used by the assessment system</param>
	///<remarks>
	/// <para>This form of <c>setScoreTableIdentifiers</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ScoreTableIdentifiers</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetScoreTableIdentifiers( ScoreTableIdentifier ScoreTableIdentifier ) {
		RemoveChild( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_SCORETABLEIDENTIFIERS);
		AddChild( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_SCORETABLEIDENTIFIERS, new ScoreTableIdentifiers( ScoreTableIdentifier ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ScoreTableIdentifiers&gt;</c> element.
	/// </summary>
	/// <value> A ScoreTableIdentifiers </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "If the authoring system provides for a unique coding system for subtests then this element is used to store that information."</para>
	/// <para>To remove the <c>ScoreTableIdentifiers</c>, set <c>ScoreTableIdentifiers</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public ScoreTableIdentifiers ScoreTableIdentifiers
	{
		get
		{
			return (ScoreTableIdentifiers)GetChild( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_SCORETABLEIDENTIFIERS);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_SCORETABLEIDENTIFIERS);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_SCORETABLEIDENTIFIERS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ScoreTableName&gt;</c> element.
	/// </summary>
	/// <value> The <c>ScoreTableName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The user defined name of the score table."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ScoreTableName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_SCORETABLENAME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_SCORETABLENAME, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;ScoreValues&gt;</c> element.</summary>
	/// <param name="ScoreValue">A ScoreValue</param>
	///<remarks>
	/// <para>This form of <c>setScoreValues</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ScoreValues</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetScoreValues( ScoreValue ScoreValue ) {
		RemoveChild( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_SCOREVALUES);
		AddChild( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_SCOREVALUES, new ScoreValues( ScoreValue ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ScoreValues&gt;</c> element.
	/// </summary>
	/// <value> A ScoreValues </value>
	/// <remarks>
	/// <para>To remove the <c>ScoreValues</c>, set <c>ScoreValues</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public ScoreValues ScoreValues
	{
		get
		{
			return (ScoreValues)GetChild( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_SCOREVALUES);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_SCOREVALUES);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTSCORETABLE_SCOREVALUES, value );
			}
		}
	}

}}
