using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.CreditNote
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note stripe_credit_note}.</summary>
    [JsiiClass(nativeType: typeof(stripe.CreditNote.CreditNote), fullyQualifiedName: "stripe.creditNote.CreditNote", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.creditNote.CreditNoteConfig\"}}]")]
    public class CreditNote : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note stripe_credit_note} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CreditNote(Constructs.Construct scope, string id, stripe.CreditNote.ICreditNoteConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.CreditNote.ICreditNoteConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CreditNote(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CreditNote(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a CreditNote resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CreditNote to import.</param>
        /// <param name="importFromId">The id of the existing CreditNote that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CreditNote to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CreditNote to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CreditNote that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CreditNote to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.CreditNote.CreditNote), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.CreditNote.ICreditNoteRefunds" />)[]</param>
        [JsiiMethod(name: "putRefunds", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.creditNote.CreditNoteRefunds\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRefunds(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.CreditNote.ICreditNoteRefunds[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.CreditNote.ICreditNoteRefunds).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.CreditNote.ICreditNoteRefunds).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShippingCost", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.creditNote.CreditNoteShippingCost\"}}]")]
        public virtual void PutShippingCost(stripe.CreditNote.ICreditNoteShippingCost @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.CreditNote.ICreditNoteShippingCost)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAmount")]
        public virtual void ResetAmount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreditAmount")]
        public virtual void ResetCreditAmount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEffectiveAt")]
        public virtual void ResetEffectiveAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailType")]
        public virtual void ResetEmailType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemo")]
        public virtual void ResetMemo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutOfBandAmount")]
        public virtual void ResetOutOfBandAmount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReason")]
        public virtual void ResetReason()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRefundAmount")]
        public virtual void ResetRefundAmount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRefunds")]
        public virtual void ResetRefunds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShippingCost")]
        public virtual void ResetShippingCost()
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
        = GetStaticProperty<string>(typeof(stripe.CreditNote.CreditNote))!;

        [JsiiProperty(name: "amountShipping", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountShipping
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Customer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerBalanceTransaction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerBalanceTransaction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "discountAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DiscountAmount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "discountAmounts", typeJson: "{\"fqn\":\"stripe.creditNote.CreditNoteDiscountAmountsList\"}")]
        public virtual stripe.CreditNote.CreditNoteDiscountAmountsList DiscountAmounts
        {
            get => GetInstanceProperty<stripe.CreditNote.CreditNoteDiscountAmountsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "postPaymentAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PostPaymentAmount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "prePaymentAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PrePaymentAmount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "pretaxCreditAmounts", typeJson: "{\"fqn\":\"stripe.creditNote.CreditNotePretaxCreditAmountsList\"}")]
        public virtual stripe.CreditNote.CreditNotePretaxCreditAmountsList PretaxCreditAmounts
        {
            get => GetInstanceProperty<stripe.CreditNote.CreditNotePretaxCreditAmountsList>()!;
        }

        [JsiiProperty(name: "refunds", typeJson: "{\"fqn\":\"stripe.creditNote.CreditNoteRefundsList\"}")]
        public virtual stripe.CreditNote.CreditNoteRefundsList Refunds
        {
            get => GetInstanceProperty<stripe.CreditNote.CreditNoteRefundsList>()!;
        }

        [JsiiProperty(name: "shippingCost", typeJson: "{\"fqn\":\"stripe.creditNote.CreditNoteShippingCostOutputReference\"}")]
        public virtual stripe.CreditNote.CreditNoteShippingCostOutputReference ShippingCost
        {
            get => GetInstanceProperty<stripe.CreditNote.CreditNoteShippingCostOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subtotal", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Subtotal
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "subtotalExcludingTax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SubtotalExcludingTax
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "total", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Total
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalExcludingTax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalExcludingTax
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalTaxes", typeJson: "{\"fqn\":\"stripe.creditNote.CreditNoteTotalTaxesList\"}")]
        public virtual stripe.CreditNote.CreditNoteTotalTaxesList TotalTaxes
        {
            get => GetInstanceProperty<stripe.CreditNote.CreditNoteTotalTaxesList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "voidedAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VoidedAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "creditAmountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CreditAmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "effectiveAtInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EffectiveAtInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "invoiceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InvoiceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MemoInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outOfBandAmountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OutOfBandAmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reasonInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReasonInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "refundAmountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RefundAmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.CreditNote.ICreditNoteRefunds" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "refundsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.creditNote.CreditNoteRefunds\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RefundsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.CreditNote.ICreditNoteShippingCost" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shippingCostInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.creditNote.CreditNoteShippingCost\"}]}}", isOptional: true)]
        public virtual object? ShippingCostInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Amount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "creditAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CreditAmount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "effectiveAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EffectiveAt
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "invoice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Invoice
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Memo
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

        [JsiiProperty(name: "outOfBandAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OutOfBandAmount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Reason
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "refundAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RefundAmount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
