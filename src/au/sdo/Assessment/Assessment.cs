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

/// <summary>An Assessment</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class Assessment : SifDataObject
{
	/// <summary>
	/// Creates an instance of an Assessment
	/// </summary>
	public Assessment() : base( Adk.SifVersion, AssessmentDTD.ASSESSMENT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The GUID that uniquely identifies this object.</param>
	///<param name="name">Name of the test.</param>
	///
	public Assessment( string refId, string name ) : base( Adk.SifVersion, AssessmentDTD.ASSESSMENT )
	{
		this.RefId = refId;
		this.Name = name;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Assessment( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.ASSESSMENT_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID that uniquely identifies this object."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENT_REFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENT_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> The <c>Name</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Name of the test."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Name
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENT_NAME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENT_NAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentId&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssessmentId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The state, local or publisher unique ID for the assessment."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string AssessmentId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENT_ASSESSMENTID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENT_ASSESSMENTID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentPackageRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssessmentPackageRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string AssessmentPackageRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENT_ASSESSMENTPACKAGEREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENT_ASSESSMENTPACKAGEREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentDescriptors&gt;</c> element.
	/// </summary>
	/// <value> An AssessmentDescriptors </value>
	/// <remarks>
	/// <para>To remove the <c>AssessmentDescriptors</c>, set <c>AssessmentDescriptors</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public AssessmentDescriptors AssessmentDescriptors
	{
		get
		{
			return (AssessmentDescriptors)GetChild( AssessmentDTD.ASSESSMENT_ASSESSMENTDESCRIPTORS);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENT_ASSESSMENTDESCRIPTORS);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENT_ASSESSMENTDESCRIPTORS, value );
			}
		}
	}

}}