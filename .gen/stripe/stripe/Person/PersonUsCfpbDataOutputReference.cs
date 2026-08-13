using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiClass(nativeType: typeof(stripe.Person.PersonUsCfpbDataOutputReference), fullyQualifiedName: "stripe.person.PersonUsCfpbDataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PersonUsCfpbDataOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PersonUsCfpbDataOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PersonUsCfpbDataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PersonUsCfpbDataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEthnicityDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonUsCfpbDataEthnicityDetails\"}}]")]
        public virtual void PutEthnicityDetails(stripe.Person.IPersonUsCfpbDataEthnicityDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonUsCfpbDataEthnicityDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRaceDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonUsCfpbDataRaceDetails\"}}]")]
        public virtual void PutRaceDetails(stripe.Person.IPersonUsCfpbDataRaceDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonUsCfpbDataRaceDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEthnicityDetails")]
        public virtual void ResetEthnicityDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRaceDetails")]
        public virtual void ResetRaceDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSelfIdentifiedGender")]
        public virtual void ResetSelfIdentifiedGender()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "ethnicityDetails", typeJson: "{\"fqn\":\"stripe.person.PersonUsCfpbDataEthnicityDetailsOutputReference\"}")]
        public virtual stripe.Person.PersonUsCfpbDataEthnicityDetailsOutputReference EthnicityDetails
        {
            get => GetInstanceProperty<stripe.Person.PersonUsCfpbDataEthnicityDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "raceDetails", typeJson: "{\"fqn\":\"stripe.person.PersonUsCfpbDataRaceDetailsOutputReference\"}")]
        public virtual stripe.Person.PersonUsCfpbDataRaceDetailsOutputReference RaceDetails
        {
            get => GetInstanceProperty<stripe.Person.PersonUsCfpbDataRaceDetailsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonUsCfpbDataEthnicityDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ethnicityDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonUsCfpbDataEthnicityDetails\"}]}}", isOptional: true)]
        public virtual object? EthnicityDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonUsCfpbDataRaceDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "raceDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonUsCfpbDataRaceDetails\"}]}}", isOptional: true)]
        public virtual object? RaceDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "selfIdentifiedGenderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SelfIdentifiedGenderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "selfIdentifiedGender", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SelfIdentifiedGender
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonUsCfpbData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonUsCfpbData\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.Person.IPersonUsCfpbData cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Person.IPersonUsCfpbData).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
