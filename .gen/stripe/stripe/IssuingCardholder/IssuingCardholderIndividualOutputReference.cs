using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCardholder
{
    [JsiiClass(nativeType: typeof(stripe.IssuingCardholder.IssuingCardholderIndividualOutputReference), fullyQualifiedName: "stripe.issuingCardholder.IssuingCardholderIndividualOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IssuingCardholderIndividualOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IssuingCardholderIndividualOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IssuingCardholderIndividualOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IssuingCardholderIndividualOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCardIssuing", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualCardIssuing\"}}]")]
        public virtual void PutCardIssuing(stripe.IssuingCardholder.IIssuingCardholderIndividualCardIssuing @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingCardholder.IIssuingCardholderIndividualCardIssuing)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDob", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualDob\"}}]")]
        public virtual void PutDob(stripe.IssuingCardholder.IIssuingCardholderIndividualDob @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingCardholder.IIssuingCardholderIndividualDob)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVerification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualVerification\"}}]")]
        public virtual void PutVerification(stripe.IssuingCardholder.IIssuingCardholderIndividualVerification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingCardholder.IIssuingCardholderIndividualVerification)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCardIssuing")]
        public virtual void ResetCardIssuing()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDob")]
        public virtual void ResetDob()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirstName")]
        public virtual void ResetFirstName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastName")]
        public virtual void ResetLastName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerification")]
        public virtual void ResetVerification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cardIssuing", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualCardIssuingOutputReference\"}")]
        public virtual stripe.IssuingCardholder.IssuingCardholderIndividualCardIssuingOutputReference CardIssuing
        {
            get => GetInstanceProperty<stripe.IssuingCardholder.IssuingCardholderIndividualCardIssuingOutputReference>()!;
        }

        [JsiiProperty(name: "dob", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualDobOutputReference\"}")]
        public virtual stripe.IssuingCardholder.IssuingCardholderIndividualDobOutputReference Dob
        {
            get => GetInstanceProperty<stripe.IssuingCardholder.IssuingCardholderIndividualDobOutputReference>()!;
        }

        [JsiiProperty(name: "verification", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualVerificationOutputReference\"}")]
        public virtual stripe.IssuingCardholder.IssuingCardholderIndividualVerificationOutputReference Verification
        {
            get => GetInstanceProperty<stripe.IssuingCardholder.IssuingCardholderIndividualVerificationOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCardholder.IIssuingCardholderIndividualCardIssuing" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cardIssuingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualCardIssuing\"}]}}", isOptional: true)]
        public virtual object? CardIssuingInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCardholder.IIssuingCardholderIndividualDob" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dobInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualDob\"}]}}", isOptional: true)]
        public virtual object? DobInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firstNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FirstNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCardholder.IIssuingCardholderIndividualVerification" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verificationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualVerification\"}]}}", isOptional: true)]
        public virtual object? VerificationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCardholder.IIssuingCardholderIndividual" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividual\"}]}}", isOptional: true)]
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
                        case stripe.IssuingCardholder.IIssuingCardholderIndividual cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.IssuingCardholder.IIssuingCardholderIndividual).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
