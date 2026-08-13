using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiClass(nativeType: typeof(stripe.PaymentLink.PaymentLinkConsentCollectionOutputReference), fullyQualifiedName: "stripe.paymentLink.PaymentLinkConsentCollectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentLinkConsentCollectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentLinkConsentCollectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentLinkConsentCollectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentLinkConsentCollectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPaymentMethodReuseAgreement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkConsentCollectionPaymentMethodReuseAgreement\"}}]")]
        public virtual void PutPaymentMethodReuseAgreement(stripe.PaymentLink.IPaymentLinkConsentCollectionPaymentMethodReuseAgreement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkConsentCollectionPaymentMethodReuseAgreement)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPaymentMethodReuseAgreement")]
        public virtual void ResetPaymentMethodReuseAgreement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPromotions")]
        public virtual void ResetPromotions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTermsOfService")]
        public virtual void ResetTermsOfService()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "paymentMethodReuseAgreement", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkConsentCollectionPaymentMethodReuseAgreementOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkConsentCollectionPaymentMethodReuseAgreementOutputReference PaymentMethodReuseAgreement
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkConsentCollectionPaymentMethodReuseAgreementOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkConsentCollectionPaymentMethodReuseAgreement" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodReuseAgreementInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkConsentCollectionPaymentMethodReuseAgreement\"}]}}", isOptional: true)]
        public virtual object? PaymentMethodReuseAgreementInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "promotionsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PromotionsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "termsOfServiceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TermsOfServiceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "promotions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Promotions
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "termsOfService", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TermsOfService
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkConsentCollection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkConsentCollection\"}]}}", isOptional: true)]
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
                        case stripe.PaymentLink.IPaymentLinkConsentCollection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkConsentCollection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
