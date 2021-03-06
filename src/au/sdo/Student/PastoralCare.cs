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

namespace OpenADK.Library.au.Student{

/// <summary>A PastoralCare</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class PastoralCare : SifElement
{
	/// <summary>
	/// Creates an instance of a PastoralCare
	/// </summary>
	public PastoralCare() : base ( StudentDTD.PASTORALCARE ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected PastoralCare( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;DisciplinaryAbsences&gt;</c> element.
	/// </summary>
	/// <value> The <c>DisciplinaryAbsences</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Have there been any school disciplinary absences (in or out of school) in the last 12 months"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string DisciplinaryAbsences
	{
		get
		{ 
			return GetFieldValue( StudentDTD.PASTORALCARE_DISCIPLINARYABSENCES );
		}
		set
		{
			SetField( StudentDTD.PASTORALCARE_DISCIPLINARYABSENCES, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;DisciplinaryAbsences&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Have there been any school disciplinary absences (in or out of school) in the last 12 months"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetDisciplinaryAbsences( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.PASTORALCARE_DISCIPLINARYABSENCES, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;IndividualBehaviourPlan&gt;</c> element.
	/// </summary>
	/// <value> The <c>IndividualBehaviourPlan</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is there an individual behaviour management plan"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string IndividualBehaviourPlan
	{
		get
		{ 
			return GetFieldValue( StudentDTD.PASTORALCARE_INDIVIDUALBEHAVIOURPLAN );
		}
		set
		{
			SetField( StudentDTD.PASTORALCARE_INDIVIDUALBEHAVIOURPLAN, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;IndividualBehaviourPlan&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is there an individual behaviour management plan"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetIndividualBehaviourPlan( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.PASTORALCARE_INDIVIDUALBEHAVIOURPLAN, val );
	}

}}
