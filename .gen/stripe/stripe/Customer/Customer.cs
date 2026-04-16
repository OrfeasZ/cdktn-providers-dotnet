using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer stripe_customer}.</summary>
    [JsiiClass(nativeType: typeof(stripe.Customer.Customer), fullyQualifiedName: "stripe.customer.Customer", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"stripe.customer.CustomerConfig\"}}]")]
    public class Customer : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer stripe_customer} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Customer(Constructs.Construct scope, string id, stripe.Customer.ICustomerConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.Customer.ICustomerConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Customer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Customer(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Customer resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Customer to import.</param>
        /// <param name="importFromId">The id of the existing Customer that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Customer to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Customer to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Customer that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Customer to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.Customer.Customer), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.customer.CustomerAddress\"}}]")]
        public virtual void PutAddress(stripe.Customer.ICustomerAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Customer.ICustomerAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCashBalance", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.customer.CustomerCashBalance\"}}]")]
        public virtual void PutCashBalance(stripe.Customer.ICustomerCashBalance @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Customer.ICustomerCashBalance)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInvoiceSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.customer.CustomerInvoiceSettings\"}}]")]
        public virtual void PutInvoiceSettings(stripe.Customer.ICustomerInvoiceSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Customer.ICustomerInvoiceSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShipping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.customer.CustomerShipping\"}}]")]
        public virtual void PutShipping(stripe.Customer.ICustomerShipping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Customer.ICustomerShipping)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.customer.CustomerTax\"}}]")]
        public virtual void PutTax(stripe.Customer.ICustomerTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Customer.ICustomerTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTaxIdData", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.customer.CustomerTaxIdData\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTaxIdData(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.Customer.ICustomerTaxIdData[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Customer.ICustomerTaxIdData).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Customer.ICustomerTaxIdData).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAddress")]
        public virtual void ResetAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBalance")]
        public virtual void ResetBalance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBusinessName")]
        public virtual void ResetBusinessName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCashBalance")]
        public virtual void ResetCashBalance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmail")]
        public virtual void ResetEmail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndividualName")]
        public virtual void ResetIndividualName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInvoicePrefix")]
        public virtual void ResetInvoicePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInvoiceSettings")]
        public virtual void ResetInvoiceSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNextInvoiceSequence")]
        public virtual void ResetNextInvoiceSequence()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaymentMethod")]
        public virtual void ResetPaymentMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhone")]
        public virtual void ResetPhone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreferredLocales")]
        public virtual void ResetPreferredLocales()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShipping")]
        public virtual void ResetShipping()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTax")]
        public virtual void ResetTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaxExempt")]
        public virtual void ResetTaxExempt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaxIdData")]
        public virtual void ResetTaxIdData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTestClock")]
        public virtual void ResetTestClock()
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
        = GetStaticProperty<string>(typeof(stripe.Customer.Customer))!;

        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.customer.CustomerAddressOutputReference\"}")]
        public virtual stripe.Customer.CustomerAddressOutputReference Address
        {
            get => GetInstanceProperty<stripe.Customer.CustomerAddressOutputReference>()!;
        }

        [JsiiProperty(name: "cashBalance", typeJson: "{\"fqn\":\"stripe.customer.CustomerCashBalanceOutputReference\"}")]
        public virtual stripe.Customer.CustomerCashBalanceOutputReference CashBalance
        {
            get => GetInstanceProperty<stripe.Customer.CustomerCashBalanceOutputReference>()!;
        }

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerAccount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "delinquent", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Delinquent
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invoiceSettings", typeJson: "{\"fqn\":\"stripe.customer.CustomerInvoiceSettingsOutputReference\"}")]
        public virtual stripe.Customer.CustomerInvoiceSettingsOutputReference InvoiceSettings
        {
            get => GetInstanceProperty<stripe.Customer.CustomerInvoiceSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "shipping", typeJson: "{\"fqn\":\"stripe.customer.CustomerShippingOutputReference\"}")]
        public virtual stripe.Customer.CustomerShippingOutputReference Shipping
        {
            get => GetInstanceProperty<stripe.Customer.CustomerShippingOutputReference>()!;
        }

        [JsiiProperty(name: "tax", typeJson: "{\"fqn\":\"stripe.customer.CustomerTaxOutputReference\"}")]
        public virtual stripe.Customer.CustomerTaxOutputReference Tax
        {
            get => GetInstanceProperty<stripe.Customer.CustomerTaxOutputReference>()!;
        }

        [JsiiProperty(name: "taxIdData", typeJson: "{\"fqn\":\"stripe.customer.CustomerTaxIdDataList\"}")]
        public virtual stripe.Customer.CustomerTaxIdDataList TaxIdData
        {
            get => GetInstanceProperty<stripe.Customer.CustomerTaxIdDataList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "addressInput", typeJson: "{\"fqn\":\"stripe.customer.CustomerAddress\"}", isOptional: true)]
        public virtual stripe.Customer.ICustomerAddress? AddressInput
        {
            get => GetInstanceProperty<stripe.Customer.ICustomerAddress?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "balanceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BalanceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "businessNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BusinessNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cashBalanceInput", typeJson: "{\"fqn\":\"stripe.customer.CustomerCashBalance\"}", isOptional: true)]
        public virtual stripe.Customer.ICustomerCashBalance? CashBalanceInput
        {
            get => GetInstanceProperty<stripe.Customer.ICustomerCashBalance?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "individualNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IndividualNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "invoicePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InvoicePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "invoiceSettingsInput", typeJson: "{\"fqn\":\"stripe.customer.CustomerInvoiceSettings\"}", isOptional: true)]
        public virtual stripe.Customer.ICustomerInvoiceSettings? InvoiceSettingsInput
        {
            get => GetInstanceProperty<stripe.Customer.ICustomerInvoiceSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nextInvoiceSequenceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NextInvoiceSequenceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PaymentMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "phoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PhoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferredLocalesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PreferredLocalesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shippingInput", typeJson: "{\"fqn\":\"stripe.customer.CustomerShipping\"}", isOptional: true)]
        public virtual stripe.Customer.ICustomerShipping? ShippingInput
        {
            get => GetInstanceProperty<stripe.Customer.ICustomerShipping?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taxExemptInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaxExemptInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taxIdDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.customer.CustomerTaxIdData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TaxIdDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taxInput", typeJson: "{\"fqn\":\"stripe.customer.CustomerTax\"}", isOptional: true)]
        public virtual stripe.Customer.ICustomerTax? TaxInput
        {
            get => GetInstanceProperty<stripe.Customer.ICustomerTax?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "testClockInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TestClockInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "balance", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Balance
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "businessName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BusinessName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Email
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "individualName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IndividualName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "invoicePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvoicePrefix
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nextInvoiceSequence", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NextInvoiceSequence
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Phone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preferredLocales", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PreferredLocales
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taxExempt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaxExempt
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
