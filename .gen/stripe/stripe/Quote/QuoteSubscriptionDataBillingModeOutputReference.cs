using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Quote
{
    [JsiiClass(nativeType: typeof(stripe.Quote.QuoteSubscriptionDataBillingModeOutputReference), fullyQualifiedName: "stripe.quote.QuoteSubscriptionDataBillingModeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuoteSubscriptionDataBillingModeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuoteSubscriptionDataBillingModeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuoteSubscriptionDataBillingModeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuoteSubscriptionDataBillingModeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFlexible", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.quote.QuoteSubscriptionDataBillingModeFlexible\"}}]")]
        public virtual void PutFlexible(stripe.Quote.IQuoteSubscriptionDataBillingModeFlexible @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Quote.IQuoteSubscriptionDataBillingModeFlexible)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFlexible")]
        public virtual void ResetFlexible()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "flexible", typeJson: "{\"fqn\":\"stripe.quote.QuoteSubscriptionDataBillingModeFlexibleOutputReference\"}")]
        public virtual stripe.Quote.QuoteSubscriptionDataBillingModeFlexibleOutputReference Flexible
        {
            get => GetInstanceProperty<stripe.Quote.QuoteSubscriptionDataBillingModeFlexibleOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Quote.IQuoteSubscriptionDataBillingModeFlexible" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flexibleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.quote.QuoteSubscriptionDataBillingModeFlexible\"}]}}", isOptional: true)]
        public virtual object? FlexibleInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Quote.IQuoteSubscriptionDataBillingMode" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.quote.QuoteSubscriptionDataBillingMode\"}]}}", isOptional: true)]
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
                        case stripe.Quote.IQuoteSubscriptionDataBillingMode cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Quote.IQuoteSubscriptionDataBillingMode).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
