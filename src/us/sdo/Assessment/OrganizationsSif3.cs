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

/// <summary>An OrganizationsSif3</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class OrganizationsSif3 : SifList<OrganizationSif3>
{
	/// <summary>
	/// Creates an instance of an OrganizationsSif3
	/// </summary>
	public OrganizationsSif3() : base ( AssessmentDTD.ORGANIZATIONSSIF3 ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="organizationSif3">An OrganizationSif3</param>
	///
	public OrganizationsSif3( OrganizationSif3 organizationSif3 ) : base( AssessmentDTD.ORGANIZATIONSSIF3 )
	{
		this.SafeAddChild( AssessmentDTD.ORGANIZATIONSSIF3_ORGANIZATIONSIF3, organizationSif3 );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected OrganizationsSif3( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.ORGANIZATIONSSIF3_ORGANIZATIONSIF3 }; }
	}

}}