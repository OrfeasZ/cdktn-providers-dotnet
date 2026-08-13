using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiClass(nativeType: typeof(stripe.TaxRegistration.TaxRegistrationCountryOptionsUsOutputReference), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsUsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TaxRegistrationCountryOptionsUsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TaxRegistrationCountryOptionsUsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TaxRegistrationCountryOptionsUsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TaxRegistrationCountryOptionsUsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLocalAmusementTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalAmusementTax\"}}]")]
        public virtual void PutLocalAmusementTax(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalAmusementTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalAmusementTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLocalLeaseTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTax\"}}]")]
        public virtual void PutLocalLeaseTax(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalLeaseTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalLeaseTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStateSalesTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTax\"}}]")]
        public virtual void PutStateSalesTax(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLocalAmusementTax")]
        public virtual void ResetLocalAmusementTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalLeaseTax")]
        public virtual void ResetLocalLeaseTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStateSalesTax")]
        public virtual void ResetStateSalesTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "localAmusementTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalAmusementTaxOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsUsLocalAmusementTaxOutputReference LocalAmusementTax
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsUsLocalAmusementTaxOutputReference>()!;
        }

        [JsiiProperty(name: "localLeaseTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTaxOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTaxOutputReference LocalLeaseTax
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTaxOutputReference>()!;
        }

        [JsiiProperty(name: "stateSalesTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTaxOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsUsStateSalesTaxOutputReference StateSalesTax
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsUsStateSalesTaxOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalAmusementTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "localAmusementTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalAmusementTax\"}]}}", isOptional: true)]
        public virtual object? LocalAmusementTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalLeaseTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "localLeaseTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTax\"}]}}", isOptional: true)]
        public virtual object? LocalLeaseTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stateSalesTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTax\"}]}}", isOptional: true)]
        public virtual object? StateSalesTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUs" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUs\"}]}}", isOptional: true)]
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
                        case stripe.TaxRegistration.ITaxRegistrationCountryOptionsUs cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUs).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
