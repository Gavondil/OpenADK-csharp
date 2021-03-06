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

/// <summary>A ResponseChoices</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.2</para>
/// </remarks>
[Serializable]
public class ResponseChoices : SifKeyedList<Choice>
{
	/// <summary>
	/// Creates an instance of a ResponseChoices
	/// </summary>
	public ResponseChoices() : base ( AssessmentDTD.RESPONSECHOICES ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="choice">A Choice</param>
	///
	public ResponseChoices( Choice choice ) : base( AssessmentDTD.RESPONSECHOICES )
	{
		this.SafeAddChild( AssessmentDTD.RESPONSECHOICES_CHOICE, choice );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ResponseChoices( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.RESPONSECHOICES_CHOICE }; }
	}

	///<summary>Adds the value of the <c>&lt;Choice&gt;</c> element.</summary>
	/// <param name="ChoiceContent">The text of the choice, such as true, 27, or Important economic and social factors.</param>
	///<remarks>
	/// <para>This form of <c>setChoice</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddChoice</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public void AddChoice( ContentElement ChoiceContent ) {
		AddChild( AssessmentDTD.RESPONSECHOICES_CHOICE, new Choice( ChoiceContent ) );
	}

}}
