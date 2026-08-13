using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiClass(nativeType: typeof(stripe.TaxRegistration.TaxRegistrationCountryOptionsRoOutputReference), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsRoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TaxRegistrationCountryOptionsRoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TaxRegistrationCountryOptionsRoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TaxRegistrationCountryOptionsRoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TaxRegistrationCountryOptionsRoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putStandard", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsRoStandard\"}}]")]
        public virtual void PutStandard(stripe.TaxRegistration.ITaxRegistrationCountryOptionsRoStandard @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsRoStandard)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetStandard")]
        public virtual void ResetStandard()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "standard", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsRoStandardOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsRoStandardOutputReference Standard
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsRoStandardOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsRoStandard" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "standardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsRoStandard\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsRo" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsRo\"}]}}", isOptional: true)]
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
                        case stripe.TaxRegistration.ITaxRegistrationCountryOptionsRo cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsRo).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
