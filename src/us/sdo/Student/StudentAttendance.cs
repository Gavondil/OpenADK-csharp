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

/// <summary>A StudentAttendance</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class StudentAttendance : SifElement
{
	/// <summary>
	/// Creates an instance of a StudentAttendance
	/// </summary>
	public StudentAttendance() : base ( StudentDTD.STUDENTATTENDANCE ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StudentAttendance( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;CountsTowardAttendance&gt;</c> element.
	/// </summary>
	/// <value> The <c>CountsTowardAttendance</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Designates whether this date should be counted toward student attendance."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string CountsTowardAttendance
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTATTENDANCE_COUNTSTOWARDATTENDANCE );
		}
		set
		{
			SetField( StudentDTD.STUDENTATTENDANCE_COUNTSTOWARDATTENDANCE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;CountsTowardAttendance&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNo object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Designates whether this date should be counted toward student attendance."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetCountsTowardAttendance( YesNo val )
	{
		SetField( StudentDTD.STUDENTATTENDANCE_COUNTSTOWARDATTENDANCE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AttendanceValue&gt;</c> element.
	/// </summary>
	/// <value> The <c>AttendanceValue</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Amount of the school day in which the student should be in attendance (Format is x.x; a student who should be in attendance a full day would be represented as 1.0).  If StudentAttendance is present, StudentAttendanceValue must also be present.  If StudentAttendance equals "Yes" then StudentAttendanceValue must be greater than zero."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? AttendanceValue
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( StudentDTD.STUDENTATTENDANCE_ATTENDANCEVALUE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTATTENDANCE_ATTENDANCEVALUE, new SifDecimal( value ), value );
		}
	}

}}