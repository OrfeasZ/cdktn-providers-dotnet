using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethodConfiguration
{
    [JsiiClass(nativeType: typeof(stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPaynowOutputReference), fullyQualifiedName: "stripe.paymentMethodConfiguration.PaymentMethodConfigurationPaynowOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentMethodConfigurationPaynowOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentMethodConfigurationPaynowOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentMethodConfigurationPaynowOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethodConfigurationPaynowOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDisplayPreference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPaynowDisplayPreference\"}}]")]
        public virtual void PutDisplayPreference(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPaynowDisplayPreference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPaynowDisplayPreference)}, new object[]{@value});
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

        [JsiiProperty(name: "displayPreference", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPaynowDisplayPreferenceOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPaynowDisplayPreferenceOutputReference DisplayPreference
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPaynowDisplayPreferenceOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPaynowDisplayPreference" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "displayPreferenceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPaynowDisplayPreference\"}]}}", isOptional: true)]
        public virtual object? DisplayPreferenceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPaynow" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPaynow\"}]}}", isOptional: true)]
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
                        case stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPaynow cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPaynow).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
