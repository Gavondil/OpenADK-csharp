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

namespace OpenADK.Library.au.System{

/// <summary>A Role</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class Role : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Role
	/// </summary>
	public Role() : base ( SystemDTD.ROLE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="roleId">A RoleId</param>
	///
	public Role( string roleId ) : base( SystemDTD.ROLE )
	{
		this.RoleId = roleId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Role( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { SystemDTD.ROLE_ROLEID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RoleId</c> attribute.
	/// </summary>
	/// <value> The <c>RoleId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string RoleId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SystemDTD.ROLE_ROLEID ) ;
		}
		set
		{
			SetFieldValue( SystemDTD.ROLE_ROLEID, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;RoleScopeList&gt;</c> element.</summary>
	/// <param name="RoleScope">A RoleScope</param>
	///<remarks>
	/// <para>This form of <c>setRoleScopeList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>RoleScopeList</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetRoleScopeList( RoleScope RoleScope ) {
		RemoveChild( SystemDTD.ROLE_ROLESCOPELIST);
		AddChild( SystemDTD.ROLE_ROLESCOPELIST, new RoleScopeList( RoleScope ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RoleScopeList&gt;</c> element.
	/// </summary>
	/// <value> A RoleScopeList </value>
	/// <remarks>
	/// <para>To remove the <c>RoleScopeList</c>, set <c>RoleScopeList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public RoleScopeList RoleScopeList
	{
		get
		{
			return (RoleScopeList)GetChild( SystemDTD.ROLE_ROLESCOPELIST);
		}
		set
		{
			RemoveChild( SystemDTD.ROLE_ROLESCOPELIST);
			if( value != null)
			{
				AddChild( SystemDTD.ROLE_ROLESCOPELIST, value );
			}
		}
	}

}}
