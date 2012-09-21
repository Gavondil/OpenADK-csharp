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

namespace OpenADK.Library.us.Food{

/// <summary>A TransactionPayMethods</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class TransactionPayMethods : SifKeyedList<TransactionPayMethod>
{
	/// <summary>
	/// Creates an instance of a TransactionPayMethods
	/// </summary>
	public TransactionPayMethods() : base ( FoodDTD.TRANSACTIONPAYMETHODS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="transactionPayMethod">Transaction method</param>
	///
	public TransactionPayMethods( TransactionPayMethod transactionPayMethod ) : base( FoodDTD.TRANSACTIONPAYMETHODS )
	{
		this.SafeAddChild( FoodDTD.TRANSACTIONPAYMETHODS_TRANSACTIONPAYMETHOD, transactionPayMethod );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected TransactionPayMethods( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;TransactionPayMethod&gt;</c> element.</summary>
	/// <param name="Type">This refers to the way the payment was made.</param>
	/// <param name="Amounts">AmountThis amount is the form of the incoming funds for this transaction. For example; the payment can be made by a credit card.</param>
	///<remarks>
	/// <para>This form of <c>setTransactionPayMethod</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddTransactionPayMethod</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void AddTransactionPayMethod( TransactionPayMethodType Type, FSAmounts Amounts ) {
		AddChild( FoodDTD.TRANSACTIONPAYMETHODS_TRANSACTIONPAYMETHOD, new TransactionPayMethod( Type, Amounts ) );
	}

}}