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

namespace OpenADK.Library.us.Gradebook{

/// <summary>A Numeric</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class Numeric : SifElement
{
	/// <summary>
	/// Creates an instance of a Numeric
	/// </summary>
	public Numeric() : base ( GradebookDTD.NUMERIC ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Numeric( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>IsAccepted</c> attribute.
	/// </summary>
	/// <value> The <c>IsAccepted</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Indicates whether a numeric score is accepted and is used in Change events to unambiguously signal whether support for the Mark has changed, especially ended."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public bool? IsAccepted
	{
		get
		{
			return (bool?) GetSifSimpleFieldValue( GradebookDTD.NUMERIC_ISACCEPTED ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.NUMERIC_ISACCEPTED, new SifBoolean( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Precision&gt;</c> element.
	/// </summary>
	/// <value> The <c>Precision</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Number of significant digits."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? Precision
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( GradebookDTD.NUMERIC_PRECISION ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.NUMERIC_PRECISION, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Scale&gt;</c> element.
	/// </summary>
	/// <value> The <c>Scale</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Number of decimal places."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? Scale
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( GradebookDTD.NUMERIC_SCALE ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.NUMERIC_SCALE, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Low&gt;</c> element.
	/// </summary>
	/// <value> The <c>Low</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Lowest Mark in the range (e.g., 98, 3.95)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? Low
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( GradebookDTD.NUMERIC_LOW ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.NUMERIC_LOW, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;High&gt;</c> element.
	/// </summary>
	/// <value> The <c>High</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Highest Mark in the range (e.g., 100, 4.0)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? High
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( GradebookDTD.NUMERIC_HIGH ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.NUMERIC_HIGH, new SifDecimal( value ), value );
		}
	}

}}
