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

/// <summary>A FeedbackItemsSif3StudentScoreSet</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class FeedbackItemsSif3StudentScoreSet : SifList<FeedbackItemSif3StudentScoreSet>
{
	/// <summary>
	/// Creates an instance of a FeedbackItemsSif3StudentScoreSet
	/// </summary>
	public FeedbackItemsSif3StudentScoreSet() : base ( AssessmentDTD.FEEDBACKITEMSSIF3STUDENTSCORESET ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="feedbackItemSif3StudentScoreSet">A FeedbackItemSif3StudentScoreSet</param>
	///
	public FeedbackItemsSif3StudentScoreSet( FeedbackItemSif3StudentScoreSet feedbackItemSif3StudentScoreSet ) : base( AssessmentDTD.FEEDBACKITEMSSIF3STUDENTSCORESET )
	{
		this.SafeAddChild( AssessmentDTD.FEEDBACKITEMSSIF3STUDENTSCORESET_FEEDBACKITEMSIF3STUDENTSCORESET, feedbackItemSif3StudentScoreSet );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected FeedbackItemsSif3StudentScoreSet( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.FEEDBACKITEMSSIF3STUDENTSCORESET_FEEDBACKITEMSIF3STUDENTSCORESET }; }
	}

}}