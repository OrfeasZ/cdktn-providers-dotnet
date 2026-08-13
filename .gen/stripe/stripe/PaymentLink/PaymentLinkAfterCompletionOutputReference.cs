using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiClass(nativeType: typeof(stripe.PaymentLink.PaymentLinkAfterCompletionOutputReference), fullyQualifiedName: "stripe.paymentLink.PaymentLinkAfterCompletionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentLinkAfterCompletionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentLinkAfterCompletionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentLinkAfterCompletionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentLinkAfterCompletionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHostedConfirmation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletionHostedConfirmation\"}}]")]
        public virtual void PutHostedConfirmation(stripe.PaymentLink.IPaymentLinkAfterCompletionHostedConfirmation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkAfterCompletionHostedConfirmation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedirect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletionRedirect\"}}]")]
        public virtual void PutRedirect(stripe.PaymentLink.IPaymentLinkAfterCompletionRedirect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkAfterCompletionRedirect)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHostedConfirmation")]
        public virtual void ResetHostedConfirmation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedirect")]
        public virtual void ResetRedirect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "hostedConfirmation", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletionHostedConfirmationOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkAfterCompletionHostedConfirmationOutputReference HostedConfirmation
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkAfterCompletionHostedConfirmationOutputReference>()!;
        }

        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletionRedirectOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkAfterCompletionRedirectOutputReference Redirect
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkAfterCompletionRedirectOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkAfterCompletionHostedConfirmation" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostedConfirmationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletionHostedConfirmation\"}]}}", isOptional: true)]
        public virtual object? HostedConfirmationInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkAfterCompletionRedirect" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redirectInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletionRedirect\"}]}}", isOptional: true)]
        public virtual object? RedirectInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkAfterCompletion" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletion\"}]}}", isOptional: true)]
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
                        case stripe.PaymentLink.IPaymentLinkAfterCompletion cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkAfterCompletion).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
