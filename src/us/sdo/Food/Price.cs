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

namespace OpenADK.Library.us.Food{

/// <summary>Price of the meal</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class Price : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Price
	/// </summary>
	public Price() : base ( FoodDTD.PRICE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="value">The price value</param>
	///<param name="mealStatus">This gives information about a student's meal status.</param>
	///<param name="mealType">This gives information about a meal type</param>
	///<param name="gradeLevels">Refer to section 5.1.12 GradeLevels.</param>
	///
	public Price( decimal? value, MealStatus mealStatus, MealTypes mealType, GradeLevels gradeLevels ) : base( FoodDTD.PRICE )
	{
		this.Value = value;
		this.MealStatus = mealStatus;
		this.SetMealType( mealType );
		this.GradeLevels = gradeLevels;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Price( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { FoodDTD.PRICE_VALUE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Value</c> attribute.
	/// </summary>
	/// <value> The <c>Value</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The price value"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public decimal? Value
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( FoodDTD.PRICE_VALUE ) ;
		}
		set
		{
			SetFieldValue( FoodDTD.PRICE_VALUE, new SifDecimal( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;MealStatus&gt;</c> element.</summary>
	/// <param name="Type">Meal status type.</param>
	///<remarks>
	/// <para>This form of <c>setMealStatus</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>MealStatus</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetMealStatus( FreeReducedStatus Type ) {
		RemoveChild( FoodDTD.PRICE_MEALSTATUS);
		AddChild( FoodDTD.PRICE_MEALSTATUS, new MealStatus( Type ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MealStatus&gt;</c> element.
	/// </summary>
	/// <value> A MealStatus </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "This gives information about a student's meal status."</para>
	/// <para>To remove the <c>MealStatus</c>, set <c>MealStatus</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public MealStatus MealStatus
	{
		get
		{
			return (MealStatus)GetChild( FoodDTD.PRICE_MEALSTATUS);
		}
		set
		{
			RemoveChild( FoodDTD.PRICE_MEALSTATUS);
			if( value != null)
			{
				AddChild( FoodDTD.PRICE_MEALSTATUS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MealType&gt;</c> element.
	/// </summary>
	/// <value> The <c>MealType</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This gives information about a meal type"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string MealType
	{
		get
		{ 
			return GetFieldValue( FoodDTD.PRICE_MEALTYPE );
		}
		set
		{
			SetField( FoodDTD.PRICE_MEALTYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;MealType&gt;</c> element.
	/// </summary>
	/// <param name="val">A MealTypes object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This gives information about a meal type"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetMealType( MealTypes val )
	{
		SetField( FoodDTD.PRICE_MEALTYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GradeLevels&gt;</c> element.
	/// </summary>
	/// <value> A GradeLevels </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Refer to section 5.1.12 GradeLevels."</para>
	/// <para>To remove the <c>GradeLevels</c>, set <c>GradeLevels</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public GradeLevels GradeLevels
	{
		get
		{
			return (GradeLevels)GetChild( FoodDTD.PRICE_GRADELEVELS);
		}
		set
		{
			RemoveChild( FoodDTD.PRICE_GRADELEVELS);
			if( value != null)
			{
				AddChild( FoodDTD.PRICE_GRADELEVELS, value );
			}
		}
	}

}}
