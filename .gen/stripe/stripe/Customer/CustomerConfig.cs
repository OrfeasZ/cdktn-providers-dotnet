using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiByValue(fqn: "stripe.customer.CustomerConfig")]
    public class CustomerConfig : stripe.Customer.ICustomerConfig
    {
        /// <summary>address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#address Customer#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.customer.CustomerAddress\"}", isOptional: true)]
        public stripe.Customer.ICustomerAddress? Address
        {
            get;
            set;
        }

        /// <summary>An integer amount in cents (or local equivalent) that represents the customer's current balance, which affect the customer's future invoices.</summary>
        /// <remarks>
        /// A negative amount represents a credit that decreases the amount due on an invoice; a positive amount increases the amount due on an invoice.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#balance Customer#balance}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "balance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Balance
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#business_name Customer#business_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "businessName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BusinessName
        {
            get;
            set;
        }

        /// <summary>cash_balance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#cash_balance Customer#cash_balance}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cashBalance", typeJson: "{\"fqn\":\"stripe.customer.CustomerCashBalance\"}", isOptional: true)]
        public stripe.Customer.ICustomerCashBalance? CashBalance
        {
            get;
            set;
        }

        /// <summary>An arbitrary string that you can attach to a customer object.</summary>
        /// <remarks>
        /// It is displayed alongside the customer in the dashboard.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#description Customer#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Customer's email address.</summary>
        /// <remarks>
        /// It's displayed alongside the customer in your dashboard and can be useful for searching and tracking. This may be up to <em>512 characters</em>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#email Customer#email}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Email
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#individual_name Customer#individual_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "individualName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IndividualName
        {
            get;
            set;
        }

        /// <summary>The prefix for the customer used to generate unique invoice numbers. Must be 3–12 uppercase letters or numbers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#invoice_prefix Customer#invoice_prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "invoicePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InvoicePrefix
        {
            get;
            set;
        }

        /// <summary>invoice_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#invoice_settings Customer#invoice_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "invoiceSettings", typeJson: "{\"fqn\":\"stripe.customer.CustomerInvoiceSettings\"}", isOptional: true)]
        public stripe.Customer.ICustomerInvoiceSettings? InvoiceSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#metadata Customer#metadata}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
        }

        /// <summary>The customer's full name or business name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#name Customer#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>The sequence to be used on the customer's next invoice. Defaults to 1.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#next_invoice_sequence Customer#next_invoice_sequence}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nextInvoiceSequence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NextInvoiceSequence
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#payment_method Customer#payment_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PaymentMethod
        {
            get;
            set;
        }

        /// <summary>The customer's phone number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#phone Customer#phone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Phone
        {
            get;
            set;
        }

        /// <summary>Customer's preferred languages, ordered by preference.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#preferred_locales Customer#preferred_locales}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preferredLocales", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PreferredLocales
        {
            get;
            set;
        }

        /// <summary>shipping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#shipping Customer#shipping}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shipping", typeJson: "{\"fqn\":\"stripe.customer.CustomerShipping\"}", isOptional: true)]
        public stripe.Customer.ICustomerShipping? Shipping
        {
            get;
            set;
        }

        /// <summary>tax block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#tax Customer#tax}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tax", typeJson: "{\"fqn\":\"stripe.customer.CustomerTax\"}", isOptional: true)]
        public stripe.Customer.ICustomerTax? Tax
        {
            get;
            set;
        }

        /// <summary>The customer's tax exemption. One of `none`, `exempt`, or `reverse`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#tax_exempt Customer#tax_exempt}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "taxExempt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TaxExempt
        {
            get;
            set;
        }

        private object? _taxIdData;

        /// <summary>tax_id_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#tax_id_data Customer#tax_id_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "taxIdData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.customer.CustomerTaxIdData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TaxIdData
        {
            get => _taxIdData;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.Customer.ICustomerTaxIdData[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Customer.ICustomerTaxIdData).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _taxIdData = value;
            }
        }

        /// <summary>ID of the test clock to attach to the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#test_clock Customer#test_clock}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "testClock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TestClock
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
