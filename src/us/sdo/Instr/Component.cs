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

/// <summary>A lesson or activity-sized portion of a resource.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class Component : SifElement
{
	/// <summary>
	/// Creates an instance of a Component
	/// </summary>
	public Component() : base ( InstrDTD.COMPONENT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="resourceComponentRefId">GUID for resource component</param>
	///<param name="name">Name of learning resource component within the resource, i.e. "Chapter 1, Section 4.</param>
	///<param name="reference">Description of where ResourceComponent is located within resource or in general, i.e. "Section 4, pages 32-38," or URL string, or whatever locator is appropriate for media.</param>
	///
	public Component( string resourceComponentRefId, string name, string reference ) : base( InstrDTD.COMPONENT )
	{
		this.ResourceComponentRefId = resourceComponentRefId;
		this.Name = name;
		this.Reference = reference;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Component( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { InstrDTD.COMPONENT_NAME, InstrDTD.COMPONENT_REFERENCE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>ResourceComponentRefId</c> attribute.
	/// </summary>
	/// <value> The <c>ResourceComponentRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "GUID for resource component"</para>
	/// <para>Version: 1.5r1</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string ResourceComponentRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.COMPONENT_RESOURCECOMPONENTREFID ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.COMPONENT_RESOURCECOMPONENTREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> The <c>Name</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Name of learning resource component within the resource, i.e. "Chapter 1, Section 4."</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;Name&gt;</description></item>
	/// </list>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Name
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.COMPONENT_NAME ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.COMPONENT_NAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Reference&gt;</c> element.
	/// </summary>
	/// <value> The <c>Reference</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Description of where ResourceComponent is located within resource or in general, i.e. "Section 4, pages 32-38," or URL string, or whatever locator is appropriate for media."</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;Reference&gt;</description></item>
	/// </list>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Reference
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.COMPONENT_REFERENCE ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.COMPONENT_REFERENCE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Description of ResourceComponent, i.e. "Discover how changing the scale of a map can either increase or decrease the level of detail you see.""</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;Description&gt;</description></item>
	/// </list>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.COMPONENT_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.COMPONENT_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>Adds a new <c>&lt;Strategies&gt;</c> child element.</summary>
	/// <param name="val">A Strategies object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Teaching/learning strategies uses in the learning resource. One per element."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void AddStrategies( Strategies val ) { 
		AddChild( InstrDTD.COMPONENT_STRATEGIES, val );
	}

	/// <summary>
	/// Gets all Strategies object instances. More than once instance can be defined for this object because it is a repeatable field element.
	/// </summary>
	/// <returns>An array of Strategies objects</returns>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public Strategies[] GetStrategieses()
	{
		return GetChildren<Strategies>().ToArray();
	}

	/// <summary>
	/// Sets all Strategies object instances. All existing 
	/// <c>Strategies</c> instances 
	/// are removed and replaced with this list. Calling this method with the 
	/// parameter value set to null removes all <c>Strategieses</c>.
	/// </summary>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetStrategieses( Strategies[] items)
	{
		SetChildren( InstrDTD.COMPONENT_STRATEGIES, items );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssociatedObjects&gt;</c> element.
	/// </summary>
	/// <value> An AssociatedObjects </value>
	/// <remarks>
	/// <para>To remove the <c>AssociatedObjects</c>, set <c>AssociatedObjects</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public AssociatedObjects AssociatedObjects
	{
		get
		{
			return (AssociatedObjects)GetChild( InstrDTD.COMPONENT_ASSOCIATEDOBJECTS);
		}
		set
		{
			RemoveChild( InstrDTD.COMPONENT_ASSOCIATEDOBJECTS);
			if( value != null)
			{
				AddChild( InstrDTD.COMPONENT_ASSOCIATEDOBJECTS, value );
			}
		}
	}

}}
