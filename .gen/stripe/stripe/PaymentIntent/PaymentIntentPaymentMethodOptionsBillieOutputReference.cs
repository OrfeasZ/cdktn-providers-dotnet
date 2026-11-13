using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiClass(nativeType: typeof(stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsBillieOutputReference), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBillieOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentIntentPaymentMethodOptionsBillieOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentIntentPaymentMethodOptionsBillieOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentIntentPaymentMethodOptionsBillieOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentIntentPaymentMethodOptionsBillieOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCompanyDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBillieCompanyDetails\"}}]")]
        public virtual void PutCompanyDetails(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillieCompanyDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillieCompanyDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCaptureMethod")]
        public virtual void ResetCaptureMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompanyDetails")]
        public virtual void ResetCompanyDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReference")]
        public virtual void ResetReference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "companyDetails", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBillieCompanyDetailsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsBillieCompanyDetailsOutputReference CompanyDetails
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsBillieCompanyDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "captureMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CaptureMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillieCompanyDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "companyDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBillieCompanyDetails\"}]}}", isOptional: true)]
        public virtual object? CompanyDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "referenceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReferenceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "captureMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaptureMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Reference
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillie" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBillie\"}]}}", isOptional: true)]
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
                        case stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillie cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillie).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
