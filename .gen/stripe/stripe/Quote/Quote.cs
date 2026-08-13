using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Quote
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote stripe_quote}.</summary>
    [JsiiClass(nativeType: typeof(stripe.Quote.Quote), fullyQualifiedName: "stripe.quote.Quote", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"stripe.quote.QuoteConfig\"}}]")]
    public class Quote : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote stripe_quote} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Quote(Constructs.Construct scope, string id, stripe.Quote.IQuoteConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.Quote.IQuoteConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Quote(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Quote(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Quote resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Quote to import.</param>
        /// <param name="importFromId">The id of the existing Quote that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Quote to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Quote to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Quote that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Quote to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.Quote.Quote), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAutomaticTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.quote.QuoteAutomaticTax\"}}]")]
        public virtual void PutAutomaticTax(stripe.Quote.IQuoteAutomaticTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Quote.IQuoteAutomaticTax)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Quote.IQuoteDiscounts" />)[]</param>
        [JsiiMethod(name: "putDiscounts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.quote.QuoteDiscounts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDiscounts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.Quote.IQuoteDiscounts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Quote.IQuoteDiscounts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Quote.IQuoteDiscounts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFromQuote", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.quote.QuoteFromQuote\"}}]")]
        public virtual void PutFromQuote(stripe.Quote.IQuoteFromQuote @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Quote.IQuoteFromQuote)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInvoiceSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.quote.QuoteInvoiceSettings\"}}]")]
        public virtual void PutInvoiceSettings(stripe.Quote.IQuoteInvoiceSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Quote.IQuoteInvoiceSettings)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Quote.IQuoteLineItems" />)[]</param>
        [JsiiMethod(name: "putLineItems", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.quote.QuoteLineItems\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLineItems(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.Quote.IQuoteLineItems[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Quote.IQuoteLineItems).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Quote.IQuoteLineItems).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSubscriptionData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.quote.QuoteSubscriptionData\"}}]")]
        public virtual void PutSubscriptionData(stripe.Quote.IQuoteSubscriptionData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Quote.IQuoteSubscriptionData)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTransferData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.quote.QuoteTransferData\"}}]")]
        public virtual void PutTransferData(stripe.Quote.IQuoteTransferData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Quote.IQuoteTransferData)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplicationFeeAmount")]
        public virtual void ResetApplicationFeeAmount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplicationFeePercent")]
        public virtual void ResetApplicationFeePercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutomaticTax")]
        public virtual void ResetAutomaticTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCollectionMethod")]
        public virtual void ResetCollectionMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomer")]
        public virtual void ResetCustomer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerAccount")]
        public virtual void ResetCustomerAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultTaxRates")]
        public virtual void ResetDefaultTaxRates()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiscounts")]
        public virtual void ResetDiscounts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpiresAt")]
        public virtual void ResetExpiresAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFooter")]
        public virtual void ResetFooter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFromQuote")]
        public virtual void ResetFromQuote()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHeader")]
        public virtual void ResetHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInvoiceSettings")]
        public virtual void ResetInvoiceSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLineItems")]
        public virtual void ResetLineItems()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnBehalfOf")]
        public virtual void ResetOnBehalfOf()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubscriptionData")]
        public virtual void ResetSubscriptionData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTestClock")]
        public virtual void ResetTestClock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransferData")]
        public virtual void ResetTransferData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(stripe.Quote.Quote))!;

        [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Application
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "automaticTax", typeJson: "{\"fqn\":\"stripe.quote.QuoteAutomaticTaxOutputReference\"}")]
        public virtual stripe.Quote.QuoteAutomaticTaxOutputReference AutomaticTax
        {
            get => GetInstanceProperty<stripe.Quote.QuoteAutomaticTaxOutputReference>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Created
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "discounts", typeJson: "{\"fqn\":\"stripe.quote.QuoteDiscountsList\"}")]
        public virtual stripe.Quote.QuoteDiscountsList Discounts
        {
            get => GetInstanceProperty<stripe.Quote.QuoteDiscountsList>()!;
        }

        [JsiiProperty(name: "fromQuote", typeJson: "{\"fqn\":\"stripe.quote.QuoteFromQuoteOutputReference\"}")]
        public virtual stripe.Quote.QuoteFromQuoteOutputReference FromQuote
        {
            get => GetInstanceProperty<stripe.Quote.QuoteFromQuoteOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invoice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Invoice
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invoiceSettings", typeJson: "{\"fqn\":\"stripe.quote.QuoteInvoiceSettingsOutputReference\"}")]
        public virtual stripe.Quote.QuoteInvoiceSettingsOutputReference InvoiceSettings
        {
            get => GetInstanceProperty<stripe.Quote.QuoteInvoiceSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "lineItems", typeJson: "{\"fqn\":\"stripe.quote.QuoteLineItemsList\"}")]
        public virtual stripe.Quote.QuoteLineItemsList LineItems
        {
            get => GetInstanceProperty<stripe.Quote.QuoteLineItemsList>()!;
        }

        [JsiiProperty(name: "livemode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Livemode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Number
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusTransitions", typeJson: "{\"fqn\":\"stripe.quote.QuoteStatusTransitionsOutputReference\"}")]
        public virtual stripe.Quote.QuoteStatusTransitionsOutputReference StatusTransitions
        {
            get => GetInstanceProperty<stripe.Quote.QuoteStatusTransitionsOutputReference>()!;
        }

        [JsiiProperty(name: "subscription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subscription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriptionData", typeJson: "{\"fqn\":\"stripe.quote.QuoteSubscriptionDataOutputReference\"}")]
        public virtual stripe.Quote.QuoteSubscriptionDataOutputReference SubscriptionData
        {
            get => GetInstanceProperty<stripe.Quote.QuoteSubscriptionDataOutputReference>()!;
        }

        [JsiiProperty(name: "subscriptionSchedule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionSchedule
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalDetails", typeJson: "{\"fqn\":\"stripe.quote.QuoteTotalDetailsOutputReference\"}")]
        public virtual stripe.Quote.QuoteTotalDetailsOutputReference TotalDetails
        {
            get => GetInstanceProperty<stripe.Quote.QuoteTotalDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.quote.QuoteTransferDataOutputReference\"}")]
        public virtual stripe.Quote.QuoteTransferDataOutputReference TransferData
        {
            get => GetInstanceProperty<stripe.Quote.QuoteTransferDataOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationFeeAmountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ApplicationFeeAmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationFeePercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ApplicationFeePercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Quote.IQuoteAutomaticTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automaticTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.quote.QuoteAutomaticTax\"}]}}", isOptional: true)]
        public virtual object? AutomaticTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "collectionMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CollectionMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerAccountInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerAccountInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultTaxRatesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DefaultTaxRatesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Quote.IQuoteDiscounts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "discountsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.quote.QuoteDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DiscountsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expiresAtInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ExpiresAtInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "footerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FooterInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Quote.IQuoteFromQuote" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fromQuoteInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.quote.QuoteFromQuote\"}]}}", isOptional: true)]
        public virtual object? FromQuoteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HeaderInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Quote.IQuoteInvoiceSettings" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "invoiceSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.quote.QuoteInvoiceSettings\"}]}}", isOptional: true)]
        public virtual object? InvoiceSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Quote.IQuoteLineItems" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lineItemsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.quote.QuoteLineItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LineItemsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onBehalfOfInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OnBehalfOfInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Quote.IQuoteSubscriptionData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subscriptionDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.quote.QuoteSubscriptionData\"}]}}", isOptional: true)]
        public virtual object? SubscriptionDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "testClockInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TestClockInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Quote.IQuoteTransferData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transferDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.quote.QuoteTransferData\"}]}}", isOptional: true)]
        public virtual object? TransferDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "applicationFeeAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApplicationFeeAmount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "applicationFeePercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApplicationFeePercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "collectionMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CollectionMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Customer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customerAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerAccount
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultTaxRates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DefaultTaxRates
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpiresAt
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "footer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Footer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "header", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Header
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onBehalfOf", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnBehalfOf
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "testClock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TestClock
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
