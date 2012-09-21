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

/// <summary>An AssessmentItem</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class AssessmentItem : SifDataObject
{
	/// <summary>
	/// Creates an instance of an AssessmentItem
	/// </summary>
	public AssessmentItem() : base( Adk.SifVersion, AssessmentDTD.ASSESSMENTITEM ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">A RefId</param>
	///<param name="assessmentFormRefId">This RefId points to the assessment form of which the item is a part.</param>
	///<param name="responseType">A value that indicates the response type for the item.</param>
	///<param name="itemLabel">An item number or other identifier for the item.  It may be used to indicate the order or grouping of items.</param>
	///
	public AssessmentItem( string refId, string assessmentFormRefId, ResponseType responseType, string itemLabel ) : base( Adk.SifVersion, AssessmentDTD.ASSESSMENTITEM )
	{
		this.RefId = refId;
		this.AssessmentFormRefId = assessmentFormRefId;
		this.SetResponseType( responseType );
		this.ItemLabel = itemLabel;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssessmentItem( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.ASSESSMENTITEM_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTITEM_REFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTITEM_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentFormRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssessmentFormRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This RefId points to the assessment form of which the item is a part."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string AssessmentFormRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTITEM_ASSESSMENTFORMREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTITEM_ASSESSMENTFORMREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ResponseType&gt;</c> element.
	/// </summary>
	/// <value> The <c>ResponseType</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A value that indicates the response type for the item."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string ResponseType
	{
		get
		{ 
			return GetFieldValue( AssessmentDTD.ASSESSMENTITEM_RESPONSETYPE );
		}
		set
		{
			SetField( AssessmentDTD.ASSESSMENTITEM_RESPONSETYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;ResponseType&gt;</c> element.
	/// </summary>
	/// <param name="val">A ResponseType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A value that indicates the response type for the item."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetResponseType( ResponseType val )
	{
		SetField( AssessmentDTD.ASSESSMENTITEM_RESPONSETYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemLabel&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemLabel</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An item number or other identifier for the item.  It may be used to indicate the order or grouping of items."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string ItemLabel
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTITEM_ITEMLABEL ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTITEM_ITEMLABEL, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemName&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Name or short description of the item."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string ItemName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTITEM_ITEMNAME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTITEM_ITEMNAME, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;LearningStandardItems&gt;</c> element.</summary>
	/// <param name="LearningStandardItemRefId">A LearningStandardItemRefId</param>
	///<remarks>
	/// <para>This form of <c>setLearningStandardItems</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>LearningStandardItems</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetLearningStandardItems( LearningStandardItemRefId LearningStandardItemRefId ) {
		RemoveChild( AssessmentDTD.ASSESSMENTITEM_LEARNINGSTANDARDITEMS);
		AddChild( AssessmentDTD.ASSESSMENTITEM_LEARNINGSTANDARDITEMS, new LearningStandardItems( LearningStandardItemRefId ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LearningStandardItems&gt;</c> element.
	/// </summary>
	/// <value> A LearningStandardItems </value>
	/// <remarks>
	/// <para>To remove the <c>LearningStandardItems</c>, set <c>LearningStandardItems</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public LearningStandardItems LearningStandardItems
	{
		get
		{
			return (LearningStandardItems)GetChild( AssessmentDTD.ASSESSMENTITEM_LEARNINGSTANDARDITEMS);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTITEM_LEARNINGSTANDARDITEMS);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTITEM_LEARNINGSTANDARDITEMS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Stimulus&gt;</c> element.
	/// </summary>
	/// <value> An AbstractContentElementType </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "A piece of content to be used by the test taker in responding to the stem. Examples include a reading passage, a video, a diagram, or a picture."</para>
	/// <para>To remove the <c>AbstractContentElementType</c>, set <c>Stimulus</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public AbstractContentElementType Stimulus
	{
		get
		{
			return (AbstractContentElementType)GetChild( AssessmentDTD.ASSESSMENTITEM_STIMULUS);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTITEM_STIMULUS);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTITEM_STIMULUS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Stem&gt;</c> element.
	/// </summary>
	/// <value> An AbstractContentElementType </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The question, task, or statement that prompts a response from the test taker."</para>
	/// <para>To remove the <c>AbstractContentElementType</c>, set <c>Stem</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public AbstractContentElementType Stem
	{
		get
		{
			return (AbstractContentElementType)GetChild( AssessmentDTD.ASSESSMENTITEM_STEM);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTITEM_STEM);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTITEM_STEM, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;ResponseChoices&gt;</c> element.</summary>
	/// <param name="Choice">A Choice</param>
	///<remarks>
	/// <para>This form of <c>setResponseChoices</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ResponseChoices</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetResponseChoices( Choice Choice ) {
		RemoveChild( AssessmentDTD.ASSESSMENTITEM_RESPONSECHOICES);
		AddChild( AssessmentDTD.ASSESSMENTITEM_RESPONSECHOICES, new ResponseChoices( Choice ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ResponseChoices&gt;</c> element.
	/// </summary>
	/// <value> A ResponseChoices </value>
	/// <remarks>
	/// <para>To remove the <c>ResponseChoices</c>, set <c>ResponseChoices</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public ResponseChoices ResponseChoices
	{
		get
		{
			return (ResponseChoices)GetChild( AssessmentDTD.ASSESSMENTITEM_RESPONSECHOICES);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTITEM_RESPONSECHOICES);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTITEM_RESPONSECHOICES, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemScoreMaximum&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemScoreMaximum</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The maximum item score possible for this item."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string ItemScoreMaximum
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTITEM_ITEMSCOREMAXIMUM ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTITEM_ITEMSCOREMAXIMUM, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemScoreMinimum&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemScoreMinimum</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The minimum item score possible for this item."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string ItemScoreMinimum
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTITEM_ITEMSCOREMINIMUM ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTITEM_ITEMSCOREMINIMUM, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PerformanceLevels&gt;</c> element.
	/// </summary>
	/// <value> A PerformanceLevels </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Performance Levels are an ordered set of categories that indicate the achievement level of a person on an assessment."</para>
	/// <para>To remove the <c>PerformanceLevels</c>, set <c>PerformanceLevels</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public PerformanceLevels PerformanceLevels
	{
		get
		{
			return (PerformanceLevels)GetChild( AssessmentDTD.ASSESSMENTITEM_PERFORMANCELEVELS);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTITEM_PERFORMANCELEVELS);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTITEM_PERFORMANCELEVELS, value );
			}
		}
	}

}}