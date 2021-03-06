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

namespace OpenADK.Library.us.Datamodel{

/// <summary>A MultipleIntelligence</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.2</para>
/// </remarks>
[Serializable]
public class MultipleIntelligence : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a MultipleIntelligence
	/// </summary>
	public MultipleIntelligence() : base ( DatamodelDTD.MULTIPLEINTELLIGENCE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="value">Gets or sets the content value of the &amp;lt;MultipleIntelligence&amp;gt; element</param>
	///
	public MultipleIntelligence( MultipleIntelligenceType value ) : base( DatamodelDTD.MULTIPLEINTELLIGENCE )
	{
		this.SetValue( value );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected MultipleIntelligence( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { DatamodelDTD.MULTIPLEINTELLIGENCE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MultipleIntelligence&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;MultipleIntelligence&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public string Value
	{
		get
		{ 
			return GetFieldValue( DatamodelDTD.MULTIPLEINTELLIGENCE );
		}
		set
		{
			SetField( DatamodelDTD.MULTIPLEINTELLIGENCE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Value&gt;</c> element.
	/// </summary>
	/// <param name="val">A MultipleIntelligenceType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;MultipleIntelligence&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public void SetValue( MultipleIntelligenceType val )
	{
		SetField( DatamodelDTD.MULTIPLEINTELLIGENCE, val );
	}

}}
