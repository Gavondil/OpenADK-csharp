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

namespace OpenADK.Library.us.Instr{

/// <summary>A Prerequisites</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class Prerequisites : SifKeyedList<Prerequisite>
{
	/// <summary>
	/// Creates an instance of a Prerequisites
	/// </summary>
	public Prerequisites() : base ( InstrDTD.PREREQUISITES ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="prerequisite">Skill or competency the student must have to engage in activity.</param>
	///
	public Prerequisites( Prerequisite prerequisite ) : base( InstrDTD.PREREQUISITES )
	{
		this.SafeAddChild( InstrDTD.PREREQUISITES_PREREQUISITE, prerequisite );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Prerequisites( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;Prerequisite&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Prerequisite&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setPrerequisite</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddPrerequisite</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void AddPrerequisite( string Value ) {
		AddChild( InstrDTD.PREREQUISITES_PREREQUISITE, new Prerequisite( Value ) );
	}

}}
