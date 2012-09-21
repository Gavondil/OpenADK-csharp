// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Learner
{
	///<summary>
	/// Defines the set of values that can be specified whenever a SENTypeCode
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SENTypeCode object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class SENTypeCode : SifEnum
	{
	/// <summary>Visual Impairment ("VI")</summary>
	public static readonly SENTypeCode VISUAL_IMPAIRMENT = new SENTypeCode("VI");

	/// <summary>Does not apply (Wales) ("DNA")</summary>
	public static readonly SENTypeCode DOES_NOT_APPLY_WALES = new SENTypeCode("DNA");

	/// <summary>Specific Learning Difficulty ("SPLD")</summary>
	public static readonly SENTypeCode SPECIFIC_LEARNING_DIFFICULTY = new SENTypeCode("SPLD");

	/// <summary>Physical and Medical Difficulties (Wales) ("PMED")</summary>
	public static readonly SENTypeCode PHYSICAL_AND_MEDICAL = new SENTypeCode("PMED");

	/// <summary>Speech, Language and Communication Needs (England) ("SLCN")</summary>
	public static readonly SENTypeCode SPEECH_LANG_COMM_NEEDS = new SENTypeCode("SLCN");

	/// <summary>Severe Learning Difficulty ("SLD")</summary>
	public static readonly SENTypeCode SEVERE_LEARNING_DIFFICULTY = new SENTypeCode("SLD");

	/// <summary>Profound &amp; Multiple Learning Difficulty ("PMLD")</summary>
	public static readonly SENTypeCode PROFOUND_MULTIPLE_LEARNING = new SENTypeCode("PMLD");

	/// <summary>Other Difficulty/Disability (England) ("OTH")</summary>
	public static readonly SENTypeCode OTHER_DIFFICULTY_DISABILITY = new SENTypeCode("OTH");

	/// <summary>Moderate Learning Difficulty ("MLD")</summary>
	public static readonly SENTypeCode MODERATE_LEARNING_DIFFICULTY = new SENTypeCode("MLD");

	/// <summary>Physical Disability (England) ("PD")</summary>
	public static readonly SENTypeCode PHYSICAL_DISABILITY_ENGLAND = new SENTypeCode("PD");

	/// <summary>Hearing Impairment ("HI")</summary>
	public static readonly SENTypeCode HEARING_IMPAIRMENT = new SENTypeCode("HI");

	/// <summary>Autistic Spectrum Disorder ("ASD")</summary>
	public static readonly SENTypeCode AUTISTIC_SPECTRUM_DISORDER = new SENTypeCode("ASD");

	/// <summary>Speech, Language and Communication Difficulties (Wales) ("SLCD")</summary>
	public static readonly SENTypeCode SPEECH_LANG_COMM_DIFF = new SENTypeCode("SLCD");

	/// <summary>Multi-Sensory Impairment ("MSI")</summary>
	public static readonly SENTypeCode MULTI_SENSORY_IMPAIRMENT = new SENTypeCode("MSI");

	/// <summary>Behaviour, Emotional &amp; Social Difficulties ("BESD")</summary>
	public static readonly SENTypeCode BEHAVIOUR_EMOTIONAL_SOCIAL = new SENTypeCode("BESD");

	///<summary>Wrap an arbitrary string value in a SENTypeCode object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SENTypeCode Wrap( String wrappedValue ) {
		return new SENTypeCode( wrappedValue );
	}

	private SENTypeCode( string enumDefValue ) : base( enumDefValue ) {}
	}
}