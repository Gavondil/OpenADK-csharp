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

namespace OpenADK.Library.Infra{

/// <summary>Contains one of the SIF message types.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class SIF_Register : SifMessagePayload
{
	/// <summary>
	/// Creates an instance of a SIF_Register
	/// </summary>
	public SIF_Register() : base ( InfraDTD.SIF_REGISTER ){}
	/// <summary>
	/// Creates an instance of a SIF_Register
	/// </summary>
	///  <param name="sifVersion">The version of SIF to render this message in</param>
	///
	public SIF_Register( SifVersion sifVersion ) : base( sifVersion, InfraDTD.SIF_REGISTER ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_Register( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Header&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Header </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Header information associated with this message."</para>
	/// <para>To remove the <c>SIF_Header</c>, set <c>SIF_Header</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_Header SIF_Header
	{
		get
		{
			return (SIF_Header)GetChild( InfraDTD.SIF_REGISTER_SIF_HEADER);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_REGISTER_SIF_HEADER);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_REGISTER_SIF_HEADER, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Name&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_Name</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This is the descriptive name of the agent that is registering (i.e. Ramsey Media Center)."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string SIF_Name
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_REGISTER_SIF_NAME ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_REGISTER_SIF_NAME, new SifString( value ), value );
		}
	}

	/// <summary>Adds a new <c>&lt;SIF_Version&gt;</c> child element.</summary>
	/// <param name="val">A SIF_Version object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Specifies which SIF Specification version(s) the agent supports. If the ZIS cannot communicate in this format, it should reject the request."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void AddSIF_Version( SIF_Version val ) { 
		AddChild( InfraDTD.SIF_REGISTER_SIF_VERSION, val );
	}

	/// <summary>
	/// Removes a <see cref="SIF_Version"/> object instance. More than one instance can be defined for this object because it is a repeatable field element.
	/// </summary>
	/// <param name="Value">Identifies the SIF_Version object to remove by its Value value</param>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void RemoveSIF_Version( string Value ) { 
		RemoveChild( InfraDTD.SIF_REGISTER_SIF_VERSION, new String[] { Value.ToString() } );
	}

	/// <summary>
	/// Gets a <see cref="SIF_Version"/> object instance. More than one instance can be defined for this object because it is a repeatable field element.
	/// </summary>
	/// <param name="Value">Identifies the SIF_Version object to return by its "Value" attribute value</param>
	/// <returns>A SIF_Version object</returns>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_Version GetSIF_Version( string Value ) { 
		return (SIF_Version)GetChild( InfraDTD.SIF_REGISTER_SIF_VERSION, new string[] { Value.ToString() } );
	}

	/// <summary>
	/// Gets all SIF_Version object instances. More than once instance can be defined for this object because it is a repeatable field element.
	/// </summary>
	/// <returns>An array of SIF_Version objects</returns>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_Version[] GetSIF_Versions()
	{
		return GetChildren<SIF_Version>().ToArray();
	}

	/// <summary>
	/// Sets all SIF_Version object instances. All existing 
	/// <c>SIF_Version</c> instances 
	/// are removed and replaced with this list. Calling this method with the 
	/// parameter value set to null removes all <c>SIF_Versions</c>.
	/// </summary>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetSIF_Versions( SIF_Version[] items)
	{
		SetChildren( InfraDTD.SIF_REGISTER_SIF_VERSION, items );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_MaxBufferSize&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_MaxBufferSize</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Specifies the maximum size of a packet to be returned by the ZIS. The ZIS may return packets smaller than, or equal to, the maximum value."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public int? SIF_MaxBufferSize
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( InfraDTD.SIF_REGISTER_SIF_MAXBUFFERSIZE ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_REGISTER_SIF_MAXBUFFERSIZE, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Mode&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_Mode</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Specifies the communication mode (Pull or Push) as chosen by the message sender."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string SIF_Mode
	{
		get
		{ 
			return GetFieldValue( InfraDTD.SIF_REGISTER_SIF_MODE );
		}
		set
		{
			SetField( InfraDTD.SIF_REGISTER_SIF_MODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;SIF_Mode&gt;</c> element.
	/// </summary>
	/// <param name="val">A SIFMode object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Specifies the communication mode (Pull or Push) as chosen by the message sender."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetSIF_Mode( SIFMode val )
	{
		SetField( InfraDTD.SIF_REGISTER_SIF_MODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Protocol&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Protocol </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_Protocol</c>, set <c>SIF_Protocol</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_Protocol SIF_Protocol
	{
		get
		{
			return (SIF_Protocol)GetChild( InfraDTD.SIF_REGISTER_SIF_PROTOCOL);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_REGISTER_SIF_PROTOCOL);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_REGISTER_SIF_PROTOCOL, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_NodeVendor&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_NodeVendor</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The vendor of the SIF agent."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SIF_NodeVendor
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_REGISTER_SIF_NODEVENDOR ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_REGISTER_SIF_NODEVENDOR, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_NodeVersion&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_NodeVersion</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "
	///         The agent version number.  The format of this field is undefined, but it should
	///         match the format used in the agent's conformance statement, if the agent is SIF Certified.
	///       "</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SIF_NodeVersion
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_REGISTER_SIF_NODEVERSION ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_REGISTER_SIF_NODEVERSION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Application&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Application </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_Application</c>, set <c>SIF_Application</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_Application SIF_Application
	{
		get
		{
			return (SIF_Application)GetChild( InfraDTD.SIF_REGISTER_SIF_APPLICATION);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_REGISTER_SIF_APPLICATION);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_REGISTER_SIF_APPLICATION, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Icon&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_Icon</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "
	///         HTTP URL referencing an icon for graphical representation of the application/agent.
	///         Should range from 16x16 pixels to 128x128 pixels and be of an image MIME type commonly supported by Web browsers (e.g. PNG, JPEG, GIF).
	///         Agents may optionally follow the more restrictive guidelines at [FAVICON].
	///       "</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SIF_Icon
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_REGISTER_SIF_ICON ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_REGISTER_SIF_ICON, new SifString( value ), value );
		}
	}

}}