using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiClass(nativeType: typeof(stripe.TaxRegistration.TaxRegistrationCountryOptionsHuOutputReference), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsHuOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TaxRegistrationCountryOptionsHuOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TaxRegistrationCountryOptionsHuOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TaxRegistrationCountryOptionsHuOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TaxRegistrationCountryOptionsHuOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putStandard", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsHuStandard\"}}]")]
        public virtual void PutStandard(stripe.TaxRegistration.ITaxRegistrationCountryOptionsHuStandard @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsHuStandard)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetStandard")]
        public virtual void ResetStandard()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "standard", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsHuStandardOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsHuStandardOutputReference Standard
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsHuStandardOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsHuStandard" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "standardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsHuStandard\"}]}}", isOptional: true)]
        public virtual object? StandardInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsHu" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsHu\"}]}}", isOptional: true)]
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
                        case stripe.TaxRegistration.ITaxRegistrationCountryOptionsHu cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsHu).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
