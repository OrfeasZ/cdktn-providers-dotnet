using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Quote
{
    [JsiiClass(nativeType: typeof(stripe.Quote.QuoteInvoiceSettingsOutputReference), fullyQualifiedName: "stripe.quote.QuoteInvoiceSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuoteInvoiceSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuoteInvoiceSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuoteInvoiceSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuoteInvoiceSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIssuer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.quote.QuoteInvoiceSettingsIssuer\"}}]")]
        public virtual void PutIssuer(stripe.Quote.IQuoteInvoiceSettingsIssuer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Quote.IQuoteInvoiceSettingsIssuer)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDaysUntilDue")]
        public virtual void ResetDaysUntilDue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIssuer")]
        public virtual void ResetIssuer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"fqn\":\"stripe.quote.QuoteInvoiceSettingsIssuerOutputReference\"}")]
        public virtual stripe.Quote.QuoteInvoiceSettingsIssuerOutputReference Issuer
        {
            get => GetInstanceProperty<stripe.Quote.QuoteInvoiceSettingsIssuerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "daysUntilDueInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DaysUntilDueInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Quote.IQuoteInvoiceSettingsIssuer" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "issuerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.quote.QuoteInvoiceSettingsIssuer\"}]}}", isOptional: true)]
        public virtual object? IssuerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "daysUntilDue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DaysUntilDue
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Quote.IQuoteInvoiceSettings" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.quote.QuoteInvoiceSettings\"}]}}", isOptional: true)]
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
                        case stripe.Quote.IQuoteInvoiceSettings cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Quote.IQuoteInvoiceSettings).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
