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

namespace OpenADK.Library.au.Dw{

/// <summary>Rule for which statistic may not be reported</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class ExclusionRule : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of an ExclusionRule
	/// </summary>
	public ExclusionRule() : base ( DwDTD.EXCLUSIONRULE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="type">Values: SampleSize, Description</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;ExclusionRule&amp;gt; element</param>
	///
	public ExclusionRule( ExclusionRuleType type, string value ) : base( DwDTD.EXCLUSIONRULE )
	{
		this.SetType( type );
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ExclusionRule( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { DwDTD.EXCLUSIONRULE_TYPE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ExclusionRule&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;ExclusionRule&amp;gt; element"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( DwDTD.EXCLUSIONRULE ) ;
		}
		set
		{
			SetFieldValue( DwDTD.EXCLUSIONRULE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <value> The <c>Type</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Values: SampleSize, Description"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Type
	{
		get
		{ 
			return GetFieldValue( DwDTD.EXCLUSIONRULE_TYPE );
		}
		set
		{
			SetField( DwDTD.EXCLUSIONRULE_TYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <param name="val">A ExclusionRuleType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Values: SampleSize, Description"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetType( ExclusionRuleType val )
	{
		SetField( DwDTD.EXCLUSIONRULE_TYPE, val );
	}

}}