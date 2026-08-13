using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethodConfiguration
{
    [JsiiClass(nativeType: typeof(stripe.PaymentMethodConfiguration.PaymentMethodConfigurationKlarnaOutputReference), fullyQualifiedName: "stripe.paymentMethodConfiguration.PaymentMethodConfigurationKlarnaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentMethodConfigurationKlarnaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentMethodConfigurationKlarnaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentMethodConfigurationKlarnaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethodConfigurationKlarnaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDisplayPreference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationKlarnaDisplayPreference\"}}]")]
        public virtual void PutDisplayPreference(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKlarnaDisplayPreference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKlarnaDisplayPreference)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDisplayPreference")]
        public virtual void ResetDisplayPreference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "available", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Available
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "displayPreference", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationKlarnaDisplayPreferenceOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationKlarnaDisplayPreferenceOutputReference DisplayPreference
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationKlarnaDisplayPreferenceOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKlarnaDisplayPreference" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "displayPreferenceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationKlarnaDisplayPreference\"}]}}", isOptional: true)]
        public virtual object? DisplayPreferenceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKlarna" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationKlarna\"}]}}", isOptional: true)]
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
                        case stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKlarna cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKlarna).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
