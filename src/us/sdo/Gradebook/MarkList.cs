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

/// <summary>A MarkList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class MarkList : SifKeyedList<Mark>
{
	/// <summary>
	/// Creates an instance of a MarkList
	/// </summary>
	public MarkList() : base ( GradebookDTD.MARKLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="mark">A Mark</param>
	///
	public MarkList( Mark mark ) : base( GradebookDTD.MARKLIST )
	{
		this.SafeAddChild( GradebookDTD.MARKLIST_MARK, mark );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected MarkList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;Mark&gt;</c> element.</summary>
	/// <param name="MarkInfoRefId">The ID (GUID) that identifies a mark that was given for this student.</param>
	///<remarks>
	/// <para>This form of <c>setMark</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddMark</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddMark( string MarkInfoRefId ) {
		AddChild( GradebookDTD.MARKLIST_MARK, new Mark( MarkInfoRefId ) );
	}

}}
