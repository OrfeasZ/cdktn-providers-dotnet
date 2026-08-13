using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethodConfiguration
{
    [JsiiClass(nativeType: typeof(stripe.PaymentMethodConfiguration.PaymentMethodConfigurationCardOutputReference), fullyQualifiedName: "stripe.paymentMethodConfiguration.PaymentMethodConfigurationCardOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentMethodConfigurationCardOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentMethodConfigurationCardOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentMethodConfigurationCardOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethodConfigurationCardOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDisplayPreference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCardDisplayPreference\"}}]")]
        public virtual void PutDisplayPreference(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCardDisplayPreference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCardDisplayPreference)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDisplayPreference")]
        public virtual void ResetDisplayPreference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "displayPreference", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCardDisplayPreferenceOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationCardDisplayPreferenceOutputReference DisplayPreference
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationCardDisplayPreferenceOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCardDisplayPreference" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "displayPreferenceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCardDisplayPreference\"}]}}", isOptional: true)]
        public virtual object? DisplayPreferenceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCard" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCard\"}]}}", isOptional: true)]
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
                        case stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCard cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCard).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
