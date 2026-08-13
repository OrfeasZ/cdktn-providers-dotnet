using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiClass(nativeType: typeof(stripe.PaymentMethod.PaymentMethodUpiOutputReference), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodUpiOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentMethodUpiOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentMethodUpiOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentMethodUpiOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethodUpiOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMandateOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodUpiMandateOptions\"}}]")]
        public virtual void PutMandateOptions(stripe.PaymentMethod.IPaymentMethodUpiMandateOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodUpiMandateOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMandateOptions")]
        public virtual void ResetMandateOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodUpiMandateOptionsOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodUpiMandateOptionsOutputReference MandateOptions
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodUpiMandateOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "vpa", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Vpa
        {
            get => GetInstanceProperty<string>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodUpiMandateOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mandateOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodUpiMandateOptions\"}]}}", isOptional: true)]
        public virtual object? MandateOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodUpi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodUpi\"}]}}", isOptional: true)]
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
                        case stripe.PaymentMethod.IPaymentMethodUpi cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentMethod.IPaymentMethodUpi).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
