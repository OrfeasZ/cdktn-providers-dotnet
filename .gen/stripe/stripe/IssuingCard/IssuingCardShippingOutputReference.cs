using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCard
{
    [JsiiClass(nativeType: typeof(stripe.IssuingCard.IssuingCardShippingOutputReference), fullyQualifiedName: "stripe.issuingCard.IssuingCardShippingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IssuingCardShippingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IssuingCardShippingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IssuingCardShippingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IssuingCardShippingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingCard.IssuingCardShippingAddress\"}}]")]
        public virtual void PutAddress(stripe.IssuingCard.IIssuingCardShippingAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingCard.IIssuingCardShippingAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAddressValidation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingCard.IssuingCardShippingAddressValidation\"}}]")]
        public virtual void PutAddressValidation(stripe.IssuingCard.IIssuingCardShippingAddressValidation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingCard.IIssuingCardShippingAddressValidation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustoms", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingCard.IssuingCardShippingCustoms\"}}]")]
        public virtual void PutCustoms(stripe.IssuingCard.IIssuingCardShippingCustoms @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingCard.IIssuingCardShippingCustoms)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAddressValidation")]
        public virtual void ResetAddressValidation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustoms")]
        public virtual void ResetCustoms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhoneNumber")]
        public virtual void ResetPhoneNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequireSignature")]
        public virtual void ResetRequireSignature()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetService")]
        public virtual void ResetService()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardShippingAddressOutputReference\"}")]
        public virtual stripe.IssuingCard.IssuingCardShippingAddressOutputReference Address
        {
            get => GetInstanceProperty<stripe.IssuingCard.IssuingCardShippingAddressOutputReference>()!;
        }

        [JsiiProperty(name: "addressValidation", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardShippingAddressValidationOutputReference\"}")]
        public virtual stripe.IssuingCard.IssuingCardShippingAddressValidationOutputReference AddressValidation
        {
            get => GetInstanceProperty<stripe.IssuingCard.IssuingCardShippingAddressValidationOutputReference>()!;
        }

        [JsiiProperty(name: "carrier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Carrier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customs", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardShippingCustomsOutputReference\"}")]
        public virtual stripe.IssuingCard.IssuingCardShippingCustomsOutputReference Customs
        {
            get => GetInstanceProperty<stripe.IssuingCard.IssuingCardShippingCustomsOutputReference>()!;
        }

        [JsiiProperty(name: "eta", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Eta
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trackingNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrackingNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trackingUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrackingUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "addressInput", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardShippingAddress\"}", isOptional: true)]
        public virtual stripe.IssuingCard.IIssuingCardShippingAddress? AddressInput
        {
            get => GetInstanceProperty<stripe.IssuingCard.IIssuingCardShippingAddress?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCard.IIssuingCardShippingAddressValidation" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addressValidationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCard.IssuingCardShippingAddressValidation\"}]}}", isOptional: true)]
        public virtual object? AddressValidationInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCard.IIssuingCardShippingCustoms" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCard.IssuingCardShippingCustoms\"}]}}", isOptional: true)]
        public virtual object? CustomsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "phoneNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PhoneNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requireSignatureInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RequireSignatureInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhoneNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "requireSignature", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object RequireSignature
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Service
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCard.IIssuingCardShipping" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCard.IssuingCardShipping\"}]}}", isOptional: true)]
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
                        case stripe.IssuingCard.IIssuingCardShipping cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.IssuingCard.IIssuingCardShipping).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
