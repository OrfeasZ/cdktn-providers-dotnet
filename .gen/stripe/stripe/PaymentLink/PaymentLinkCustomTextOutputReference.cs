using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiClass(nativeType: typeof(stripe.PaymentLink.PaymentLinkCustomTextOutputReference), fullyQualifiedName: "stripe.paymentLink.PaymentLinkCustomTextOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentLinkCustomTextOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentLinkCustomTextOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentLinkCustomTextOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentLinkCustomTextOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAfterSubmit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextAfterSubmit\"}}]")]
        public virtual void PutAfterSubmit(stripe.PaymentLink.IPaymentLinkCustomTextAfterSubmit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkCustomTextAfterSubmit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShippingAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextShippingAddress\"}}]")]
        public virtual void PutShippingAddress(stripe.PaymentLink.IPaymentLinkCustomTextShippingAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkCustomTextShippingAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSubmit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextSubmit\"}}]")]
        public virtual void PutSubmit(stripe.PaymentLink.IPaymentLinkCustomTextSubmit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkCustomTextSubmit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTermsOfServiceAcceptance", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextTermsOfServiceAcceptance\"}}]")]
        public virtual void PutTermsOfServiceAcceptance(stripe.PaymentLink.IPaymentLinkCustomTextTermsOfServiceAcceptance @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkCustomTextTermsOfServiceAcceptance)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAfterSubmit")]
        public virtual void ResetAfterSubmit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShippingAddress")]
        public virtual void ResetShippingAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubmit")]
        public virtual void ResetSubmit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTermsOfServiceAcceptance")]
        public virtual void ResetTermsOfServiceAcceptance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "afterSubmit", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextAfterSubmitOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkCustomTextAfterSubmitOutputReference AfterSubmit
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkCustomTextAfterSubmitOutputReference>()!;
        }

        [JsiiProperty(name: "shippingAddress", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextShippingAddressOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkCustomTextShippingAddressOutputReference ShippingAddress
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkCustomTextShippingAddressOutputReference>()!;
        }

        [JsiiProperty(name: "submit", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextSubmitOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkCustomTextSubmitOutputReference Submit
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkCustomTextSubmitOutputReference>()!;
        }

        [JsiiProperty(name: "termsOfServiceAcceptance", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextTermsOfServiceAcceptanceOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkCustomTextTermsOfServiceAcceptanceOutputReference TermsOfServiceAcceptance
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkCustomTextTermsOfServiceAcceptanceOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkCustomTextAfterSubmit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "afterSubmitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextAfterSubmit\"}]}}", isOptional: true)]
        public virtual object? AfterSubmitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkCustomTextShippingAddress" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shippingAddressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextShippingAddress\"}]}}", isOptional: true)]
        public virtual object? ShippingAddressInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkCustomTextSubmit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "submitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextSubmit\"}]}}", isOptional: true)]
        public virtual object? SubmitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkCustomTextTermsOfServiceAcceptance" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "termsOfServiceAcceptanceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextTermsOfServiceAcceptance\"}]}}", isOptional: true)]
        public virtual object? TermsOfServiceAcceptanceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkCustomText" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomText\"}]}}", isOptional: true)]
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
                        case stripe.PaymentLink.IPaymentLinkCustomText cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkCustomText).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
