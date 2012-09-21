// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Infrastructure
{
	///<summary>
	/// Defines the set of values that can be specified whenever an AuthSifRefIdType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an AuthSifRefIdType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class AuthSifRefIdType : SifEnum
	{
	/// <summary>StudentContact ("StudentContact")</summary>
	public static readonly AuthSifRefIdType STUDENTCONTACT = new AuthSifRefIdType("StudentContact");

	/// <summary>StaffPersonal ("StaffPersonal")</summary>
	public static readonly AuthSifRefIdType STAFFPERSONAL = new AuthSifRefIdType("StaffPersonal");

	/// <summary>EmployeePersonal ("EmployeePersonal")</summary>
	public static readonly AuthSifRefIdType EMPLOYEEPERSONAL = new AuthSifRefIdType("EmployeePersonal");

	/// <summary>StudentPersonal ("StudentPersonal")</summary>
	public static readonly AuthSifRefIdType STUDENTPERSONAL = new AuthSifRefIdType("StudentPersonal");

	///<summary>Wrap an arbitrary string value in an AuthSifRefIdType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static AuthSifRefIdType Wrap( String wrappedValue ) {
		return new AuthSifRefIdType( wrappedValue );
	}

	private AuthSifRefIdType( string enumDefValue ) : base( enumDefValue ) {}
	}
}