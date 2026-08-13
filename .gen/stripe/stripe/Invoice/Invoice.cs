using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice stripe_invoice}.</summary>
    [JsiiClass(nativeType: typeof(stripe.Invoice.Invoice), fullyQualifiedName: "stripe.invoice.Invoice", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"stripe.invoice.InvoiceConfig\"}}]")]
    public class Invoice : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice stripe_invoice} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Invoice(Constructs.Construct scope, string id, stripe.Invoice.IInvoiceConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.Invoice.IInvoiceConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Invoice(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Invoice(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Invoice resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Invoice to import.</param>
        /// <param name="importFromId">The id of the existing Invoice that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Invoice to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Invoice to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Invoice that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Invoice to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.Invoice.Invoice), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAutomaticTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoiceAutomaticTax\"}}]")]
        public virtual void PutAutomaticTax(stripe.Invoice.IInvoiceAutomaticTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoiceAutomaticTax)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Invoice.IInvoiceCustomFields" />)[]</param>
        [JsiiMethod(name: "putCustomFields", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.invoice.InvoiceCustomFields\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomFields(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.Invoice.IInvoiceCustomFields[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Invoice.IInvoiceCustomFields).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Invoice.IInvoiceCustomFields).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Invoice.IInvoiceDiscounts" />)[]</param>
        [JsiiMethod(name: "putDiscounts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.invoice.InvoiceDiscounts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDiscounts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.Invoice.IInvoiceDiscounts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Invoice.IInvoiceDiscounts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Invoice.IInvoiceDiscounts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFromInvoice", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoiceFromInvoice\"}}]")]
        public virtual void PutFromInvoice(stripe.Invoice.IInvoiceFromInvoice @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoiceFromInvoice)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIssuer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoiceIssuer\"}}]")]
        public virtual void PutIssuer(stripe.Invoice.IInvoiceIssuer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoiceIssuer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPaymentSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoicePaymentSettings\"}}]")]
        public virtual void PutPaymentSettings(stripe.Invoice.IInvoicePaymentSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoicePaymentSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRendering", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoiceRendering\"}}]")]
        public virtual void PutRendering(stripe.Invoice.IInvoiceRendering @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoiceRendering)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShippingCost", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoiceShippingCost\"}}]")]
        public virtual void PutShippingCost(stripe.Invoice.IInvoiceShippingCost @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoiceShippingCost)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShippingDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoiceShippingDetails\"}}]")]
        public virtual void PutShippingDetails(stripe.Invoice.IInvoiceShippingDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoiceShippingDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTransferData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoiceTransferData\"}}]")]
        public virtual void PutTransferData(stripe.Invoice.IInvoiceTransferData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoiceTransferData)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountTaxIds")]
        public virtual void ResetAccountTaxIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplicationFeeAmount")]
        public virtual void ResetApplicationFeeAmount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoAdvance")]
        public virtual void ResetAutoAdvance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutomaticallyFinalizesAt")]
        public virtual void ResetAutomaticallyFinalizesAt()
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

        [JsiiMethod(name: "resetCurrency")]
        public virtual void ResetCurrency()
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

        [JsiiMethod(name: "resetCustomFields")]
        public virtual void ResetCustomFields()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDaysUntilDue")]
        public virtual void ResetDaysUntilDue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultPaymentMethod")]
        public virtual void ResetDefaultPaymentMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultSource")]
        public virtual void ResetDefaultSource()
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

        [JsiiMethod(name: "resetDueDate")]
        public virtual void ResetDueDate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEffectiveAt")]
        public virtual void ResetEffectiveAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFooter")]
        public virtual void ResetFooter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFromInvoice")]
        public virtual void ResetFromInvoice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIssuer")]
        public virtual void ResetIssuer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumber")]
        public virtual void ResetNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnBehalfOf")]
        public virtual void ResetOnBehalfOf()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaymentSettings")]
        public virtual void ResetPaymentSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPendingInvoiceItemsBehavior")]
        public virtual void ResetPendingInvoiceItemsBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRendering")]
        public virtual void ResetRendering()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShippingCost")]
        public virtual void ResetShippingCost()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShippingDetails")]
        public virtual void ResetShippingDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatementDescriptor")]
        public virtual void ResetStatementDescriptor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubscription")]
        public virtual void ResetSubscription()
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
        = GetStaticProperty<string>(typeof(stripe.Invoice.Invoice))!;

        [JsiiProperty(name: "accountCountry", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountCountry
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "amountDue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountDue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "amountOverpaid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountOverpaid
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "amountPaid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountPaid
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "amountPaidOffStripe", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountPaidOffStripe
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "amountRemaining", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountRemaining
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "amountShipping", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountShipping
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Application
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attemptCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AttemptCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "attempted", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Attempted
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "automaticTax", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceAutomaticTaxOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceAutomaticTaxOutputReference AutomaticTax
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceAutomaticTaxOutputReference>()!;
        }

        [JsiiProperty(name: "billingReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "confirmationSecret", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceConfirmationSecretOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceConfirmationSecretOutputReference ConfirmationSecret
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceConfirmationSecretOutputReference>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Created
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "customerAddress", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceCustomerAddressOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceCustomerAddressOutputReference CustomerAddress
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceCustomerAddressOutputReference>()!;
        }

        [JsiiProperty(name: "customerEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerPhone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerPhone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerShipping", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceCustomerShippingOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceCustomerShippingOutputReference CustomerShipping
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceCustomerShippingOutputReference>()!;
        }

        [JsiiProperty(name: "customerTaxIds", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceCustomerTaxIdsList\"}")]
        public virtual stripe.Invoice.InvoiceCustomerTaxIdsList CustomerTaxIds
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceCustomerTaxIdsList>()!;
        }

        [JsiiProperty(name: "customFields", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceCustomFieldsList\"}")]
        public virtual stripe.Invoice.InvoiceCustomFieldsList CustomFields
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceCustomFieldsList>()!;
        }

        [JsiiProperty(name: "discounts", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceDiscountsList\"}")]
        public virtual stripe.Invoice.InvoiceDiscountsList Discounts
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceDiscountsList>()!;
        }

        [JsiiProperty(name: "endingBalance", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EndingBalance
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "fromInvoice", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceFromInvoiceOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceFromInvoiceOutputReference FromInvoice
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceFromInvoiceOutputReference>()!;
        }

        [JsiiProperty(name: "hostedInvoiceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostedInvoiceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invoicePdf", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvoicePdf
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceIssuerOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceIssuerOutputReference Issuer
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceIssuerOutputReference>()!;
        }

        [JsiiProperty(name: "lastFinalizationError", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceLastFinalizationErrorOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceLastFinalizationErrorOutputReference LastFinalizationError
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceLastFinalizationErrorOutputReference>()!;
        }

        [JsiiProperty(name: "latestRevision", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LatestRevision
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "livemode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Livemode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "nextPaymentAttempt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NextPaymentAttempt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parent", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceParentOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceParentOutputReference Parent
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceParentOutputReference>()!;
        }

        [JsiiProperty(name: "paymentSettings", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsOutputReference\"}")]
        public virtual stripe.Invoice.InvoicePaymentSettingsOutputReference PaymentSettings
        {
            get => GetInstanceProperty<stripe.Invoice.InvoicePaymentSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "periodEnd", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PeriodEnd
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "periodStart", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PeriodStart
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "postPaymentCreditNotesAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PostPaymentCreditNotesAmount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "prePaymentCreditNotesAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PrePaymentCreditNotesAmount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "receiptNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReceiptNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rendering", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceRenderingOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceRenderingOutputReference Rendering
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceRenderingOutputReference>()!;
        }

        [JsiiProperty(name: "shippingCost", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingCostOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceShippingCostOutputReference ShippingCost
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceShippingCostOutputReference>()!;
        }

        [JsiiProperty(name: "shippingDetails", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingDetailsOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceShippingDetailsOutputReference ShippingDetails
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceShippingDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "startingBalance", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartingBalance
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusTransitions", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceStatusTransitionsOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceStatusTransitionsOutputReference StatusTransitions
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceStatusTransitionsOutputReference>()!;
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

        [JsiiProperty(name: "testClock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TestClock
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "thresholdReason", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceThresholdReasonOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceThresholdReasonOutputReference ThresholdReason
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceThresholdReasonOutputReference>()!;
        }

        [JsiiProperty(name: "total", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Total
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalDiscountAmounts", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceTotalDiscountAmountsList\"}")]
        public virtual stripe.Invoice.InvoiceTotalDiscountAmountsList TotalDiscountAmounts
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceTotalDiscountAmountsList>()!;
        }

        [JsiiProperty(name: "totalExcludingTax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalExcludingTax
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalPretaxCreditAmounts", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceTotalPretaxCreditAmountsList\"}")]
        public virtual stripe.Invoice.InvoiceTotalPretaxCreditAmountsList TotalPretaxCreditAmounts
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceTotalPretaxCreditAmountsList>()!;
        }

        [JsiiProperty(name: "totalTaxes", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceTotalTaxesList\"}")]
        public virtual stripe.Invoice.InvoiceTotalTaxesList TotalTaxes
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceTotalTaxesList>()!;
        }

        [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceTransferDataOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceTransferDataOutputReference TransferData
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceTransferDataOutputReference>()!;
        }

        [JsiiProperty(name: "webhooksDeliveredAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WebhooksDeliveredAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountTaxIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AccountTaxIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationFeeAmountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ApplicationFeeAmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoAdvanceInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutoAdvanceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticallyFinalizesAtInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AutomaticallyFinalizesAtInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoiceAutomaticTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automaticTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoiceAutomaticTax\"}]}}", isOptional: true)]
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
        [JsiiProperty(name: "currencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CurrencyInput
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Invoice.IInvoiceCustomFields" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customFieldsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.invoice.InvoiceCustomFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomFieldsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "daysUntilDueInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DaysUntilDueInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultPaymentMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultPaymentMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultSourceInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Invoice.IInvoiceDiscounts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "discountsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.invoice.InvoiceDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DiscountsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dueDateInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DueDateInput
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
        [JsiiProperty(name: "footerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FooterInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoiceFromInvoice" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fromInvoiceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoiceFromInvoice\"}]}}", isOptional: true)]
        public virtual object? FromInvoiceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoiceIssuer" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "issuerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoiceIssuer\"}]}}", isOptional: true)]
        public virtual object? IssuerInput
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
        [JsiiProperty(name: "numberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onBehalfOfInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OnBehalfOfInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoicePaymentSettings" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoicePaymentSettings\"}]}}", isOptional: true)]
        public virtual object? PaymentSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pendingInvoiceItemsBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PendingInvoiceItemsBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoiceRendering" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "renderingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoiceRendering\"}]}}", isOptional: true)]
        public virtual object? RenderingInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoiceShippingCost" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shippingCostInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoiceShippingCost\"}]}}", isOptional: true)]
        public virtual object? ShippingCostInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoiceShippingDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shippingDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoiceShippingDetails\"}]}}", isOptional: true)]
        public virtual object? ShippingDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statementDescriptorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatementDescriptorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubscriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoiceTransferData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transferDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoiceTransferData\"}]}}", isOptional: true)]
        public virtual object? TransferDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accountTaxIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AccountTaxIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "applicationFeeAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApplicationFeeAmount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "autoAdvance", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AutoAdvance
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "automaticallyFinalizesAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutomaticallyFinalizesAt
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

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
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

        [JsiiProperty(name: "daysUntilDue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DaysUntilDue
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultPaymentMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultPaymentMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultSource
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

        [JsiiProperty(name: "dueDate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DueDate
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

        [JsiiProperty(name: "footer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Footer
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

        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Number
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onBehalfOf", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnBehalfOf
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pendingInvoiceItemsBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PendingInvoiceItemsBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "statementDescriptor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatementDescriptor
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subscription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subscription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
