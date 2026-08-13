using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethodConfiguration
{
    [JsiiClass(nativeType: typeof(stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPromptpayOutputReference), fullyQualifiedName: "stripe.paymentMethodConfiguration.PaymentMethodConfigurationPromptpayOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentMethodConfigurationPromptpayOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentMethodConfigurationPromptpayOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentMethodConfigurationPromptpayOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethodConfigurationPromptpayOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDisplayPreference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPromptpayDisplayPreference\"}}]")]
        public virtual void PutDisplayPreference(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPromptpayDisplayPreference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPromptpayDisplayPreference)}, new object[]{@value});
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

        [JsiiProperty(name: "displayPreference", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPromptpayDisplayPreferenceOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPromptpayDisplayPreferenceOutputReference DisplayPreference
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPromptpayDisplayPreferenceOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPromptpayDisplayPreference" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "displayPreferenceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPromptpayDisplayPreference\"}]}}", isOptional: true)]
        public virtual object? DisplayPreferenceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPromptpay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPromptpay\"}]}}", isOptional: true)]
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
                        case stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPromptpay cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPromptpay).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
