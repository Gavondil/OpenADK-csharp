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

/// <summary>This Staff Evaluation Object is to meet the new APPR Regulations from the Federal government and are being enforced by the states.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class StaffEvaluation : SifDataObject
{
	/// <summary>
	/// Creates an instance of a StaffEvaluation
	/// </summary>
	public StaffEvaluation() : base( Adk.SifVersion, StudentDTD.STAFFEVALUATION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="staffPersonalRefId">The Id (GUID) of the staff being evaluated.</param>
	///<param name="schoolInfoRefId">The Id (GUID) of the School the staff member resides and where they are being evaluated.</param>
	///<param name="evaluationDate">Date of when the evaluation actually was observed.</param>
	///<param name="evaluationSystem">This is the name of the tool being used.</param>
	///<param name="evaluationHolisticScore">The overall Score for the evaluation.</param>
	///<param name="evaluationHolisticScale">This is the overall Scale that is being used for the evaluation.</param>
	///
	public StaffEvaluation( string staffPersonalRefId, string schoolInfoRefId, DateTime? evaluationDate, string evaluationSystem, string evaluationHolisticScore, string evaluationHolisticScale ) : base( Adk.SifVersion, StudentDTD.STAFFEVALUATION )
	{
		this.StaffPersonalRefId = staffPersonalRefId;
		this.SchoolInfoRefId = schoolInfoRefId;
		this.EvaluationDate = evaluationDate;
		this.EvaluationSystem = evaluationSystem;
		this.EvaluationHolisticScore = evaluationHolisticScore;
		this.EvaluationHolisticScale = evaluationHolisticScale;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StaffEvaluation( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.STAFFEVALUATION_STAFFPERSONALREFID, StudentDTD.STAFFEVALUATION_SCHOOLINFOREFID, StudentDTD.STAFFEVALUATION_EVALUATIONDATE, StudentDTD.STAFFEVALUATION_EVALUATIONSYSTEM, StudentDTD.STAFFEVALUATION_EVALUATIONHOLISTICSCORE, StudentDTD.STAFFEVALUATION_EVALUATIONHOLISTICSCALE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StaffPersonalRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StaffPersonalRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The Id (GUID) of the staff being evaluated."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string StaffPersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STAFFEVALUATION_STAFFPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFEVALUATION_STAFFPERSONALREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The Id (GUID) of the School the staff member resides and where they are being evaluated."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STAFFEVALUATION_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFEVALUATION_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;NCESId&gt;</c> element.
	/// </summary>
	/// <value> The <c>NCESId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The NCES-assigned identifier of the school or district where the evaluator resides."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string NCESId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STAFFEVALUATION_NCESID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFEVALUATION_NCESID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EvaluatorStateProvinceId&gt;</c> element.
	/// </summary>
	/// <value> The <c>EvaluatorStateProvinceId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The identifier that has been assigned by the state to the administrator that is administering the evaluation"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string EvaluatorStateProvinceId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STAFFEVALUATION_EVALUATORSTATEPROVINCEID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFEVALUATION_EVALUATORSTATEPROVINCEID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;BargainingUnit&gt;</c> element.
	/// </summary>
	/// <value> The <c>BargainingUnit</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This is the unit that the person being observed is part of."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string BargainingUnit
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STAFFEVALUATION_BARGAININGUNIT ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFEVALUATION_BARGAININGUNIT, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EvaluationCycleName&gt;</c> element.
	/// </summary>
	/// <value> The <c>EvaluationCycleName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The type of evaluation that will take place for that individual."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string EvaluationCycleName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STAFFEVALUATION_EVALUATIONCYCLENAME ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFEVALUATION_EVALUATIONCYCLENAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EvaluationPreconferenceDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>EvaluationPreconferenceDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "When the Evaluation was first discussed and the goals for the evaluation were discussed."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public DateTime? EvaluationPreconferenceDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( StudentDTD.STAFFEVALUATION_EVALUATIONPRECONFERENCEDATE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFEVALUATION_EVALUATIONPRECONFERENCEDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ProjectedEvaluationDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>ProjectedEvaluationDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "When the evaluation is anticipated to happen."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public DateTime? ProjectedEvaluationDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( StudentDTD.STAFFEVALUATION_PROJECTEDEVALUATIONDATE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFEVALUATION_PROJECTEDEVALUATIONDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EvaluationDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>EvaluationDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date of when the evaluation actually was observed."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public DateTime? EvaluationDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( StudentDTD.STAFFEVALUATION_EVALUATIONDATE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFEVALUATION_EVALUATIONDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EvaluationPostconferenceDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>EvaluationPostconferenceDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date of Postconference where the evaluation will be discussed."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public DateTime? EvaluationPostconferenceDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( StudentDTD.STAFFEVALUATION_EVALUATIONPOSTCONFERENCEDATE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFEVALUATION_EVALUATIONPOSTCONFERENCEDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EvaluationSystem&gt;</c> element.
	/// </summary>
	/// <value> The <c>EvaluationSystem</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This is the name of the tool being used."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string EvaluationSystem
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STAFFEVALUATION_EVALUATIONSYSTEM ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFEVALUATION_EVALUATIONSYSTEM, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;EvaluationParts&gt;</c> element.</summary>
	/// <param name="EvaluationPart">Container for parts of the evaluation</param>
	///<remarks>
	/// <para>This form of <c>setEvaluationParts</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>EvaluationParts</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetEvaluationParts( EvaluationPart EvaluationPart ) {
		RemoveChild( StudentDTD.STAFFEVALUATION_EVALUATIONPARTS);
		AddChild( StudentDTD.STAFFEVALUATION_EVALUATIONPARTS, new EvaluationParts( EvaluationPart ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EvaluationParts&gt;</c> element.
	/// </summary>
	/// <value> An EvaluationParts </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The set of Evaluation Parts"</para>
	/// <para>To remove the <c>EvaluationParts</c>, set <c>EvaluationParts</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public EvaluationParts EvaluationParts
	{
		get
		{
			return (EvaluationParts)GetChild( StudentDTD.STAFFEVALUATION_EVALUATIONPARTS);
		}
		set
		{
			RemoveChild( StudentDTD.STAFFEVALUATION_EVALUATIONPARTS);
			if( value != null)
			{
				AddChild( StudentDTD.STAFFEVALUATION_EVALUATIONPARTS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EvaluationHolisticScore&gt;</c> element.
	/// </summary>
	/// <value> The <c>EvaluationHolisticScore</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The overall Score for the evaluation."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string EvaluationHolisticScore
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STAFFEVALUATION_EVALUATIONHOLISTICSCORE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFEVALUATION_EVALUATIONHOLISTICSCORE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EvaluationHolisticScale&gt;</c> element.
	/// </summary>
	/// <value> The <c>EvaluationHolisticScale</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This is the overall Scale that is being used for the evaluation."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string EvaluationHolisticScale
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STAFFEVALUATION_EVALUATIONHOLISTICSCALE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFEVALUATION_EVALUATIONHOLISTICSCALE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EvaluationRecommendation&gt;</c> element.
	/// </summary>
	/// <value> An EvaluationRecommendation </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "What was done because of a summative evaluation."</para>
	/// <para>To remove the <c>EvaluationRecommendation</c>, set <c>EvaluationRecommendation</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public EvaluationRecommendation EvaluationRecommendation
	{
		get
		{
			return (EvaluationRecommendation)GetChild( StudentDTD.STAFFEVALUATION_EVALUATIONRECOMMENDATION);
		}
		set
		{
			RemoveChild( StudentDTD.STAFFEVALUATION_EVALUATIONRECOMMENDATION);
			if( value != null)
			{
				AddChild( StudentDTD.STAFFEVALUATION_EVALUATIONRECOMMENDATION, value );
			}
		}
	}

}}
