using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiInterface(nativeType: typeof(ICustomerConfig), fullyQualifiedName: "stripe.customer.CustomerConfig")]
    public interface ICustomerConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#address Customer#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.customer.CustomerAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Customer.ICustomerAddress? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>An integer amount in cents (or local equivalent) that represents the customer's current balance, which affect the customer's future invoices.</summary>
        /// <remarks>
        /// A negative amount represents a credit that decreases the amount due on an invoice; a positive amount increases the amount due on an invoice.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#balance Customer#balance}
        /// </remarks>
        [JsiiProperty(name: "balance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Balance
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#business_name Customer#business_name}.</summary>
        [JsiiProperty(name: "businessName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BusinessName
        {
            get
            {
                return null;
            }
        }

        /// <summary>cash_balance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#cash_balance Customer#cash_balance}
        /// </remarks>
        [JsiiProperty(name: "cashBalance", typeJson: "{\"fqn\":\"stripe.customer.CustomerCashBalance\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Customer.ICustomerCashBalance? CashBalance
        {
            get
            {
                return null;
            }
        }

        /// <summary>An arbitrary string that you can attach to a customer object.</summary>
        /// <remarks>
        /// It is displayed alongside the customer in the dashboard.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#description Customer#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Customer's email address.</summary>
        /// <remarks>
        /// It's displayed alongside the customer in your dashboard and can be useful for searching and tracking. This may be up to <em>512 characters</em>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#email Customer#email}
        /// </remarks>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Email
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#individual_name Customer#individual_name}.</summary>
        [JsiiProperty(name: "individualName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IndividualName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The prefix for the customer used to generate unique invoice numbers. Must be 3–12 uppercase letters or numbers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#invoice_prefix Customer#invoice_prefix}
        /// </remarks>
        [JsiiProperty(name: "invoicePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InvoicePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>invoice_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#invoice_settings Customer#invoice_settings}
        /// </remarks>
        [JsiiProperty(name: "invoiceSettings", typeJson: "{\"fqn\":\"stripe.customer.CustomerInvoiceSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Customer.ICustomerInvoiceSettings? InvoiceSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#metadata Customer#metadata}.</summary>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>The customer's full name or business name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#name Customer#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>The sequence to be used on the customer's next invoice. Defaults to 1.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#next_invoice_sequence Customer#next_invoice_sequence}
        /// </remarks>
        [JsiiProperty(name: "nextInvoiceSequence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NextInvoiceSequence
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#payment_method Customer#payment_method}.</summary>
        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PaymentMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>The customer's phone number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#phone Customer#phone}
        /// </remarks>
        [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Phone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Customer's preferred languages, ordered by preference.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#preferred_locales Customer#preferred_locales}
        /// </remarks>
        [JsiiProperty(name: "preferredLocales", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PreferredLocales
        {
            get
            {
                return null;
            }
        }

        /// <summary>shipping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#shipping Customer#shipping}
        /// </remarks>
        [JsiiProperty(name: "shipping", typeJson: "{\"fqn\":\"stripe.customer.CustomerShipping\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Customer.ICustomerShipping? Shipping
        {
            get
            {
                return null;
            }
        }

        /// <summary>tax block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#tax Customer#tax}
        /// </remarks>
        [JsiiProperty(name: "tax", typeJson: "{\"fqn\":\"stripe.customer.CustomerTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Customer.ICustomerTax? Tax
        {
            get
            {
                return null;
            }
        }

        /// <summary>The customer's tax exemption. One of `none`, `exempt`, or `reverse`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#tax_exempt Customer#tax_exempt}
        /// </remarks>
        [JsiiProperty(name: "taxExempt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaxExempt
        {
            get
            {
                return null;
            }
        }

        /// <summary>tax_id_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#tax_id_data Customer#tax_id_data}
        /// </remarks>
        [JsiiProperty(name: "taxIdData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.customer.CustomerTaxIdData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TaxIdData
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the test clock to attach to the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#test_clock Customer#test_clock}
        /// </remarks>
        [JsiiProperty(name: "testClock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TestClock
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomerConfig), fullyQualifiedName: "stripe.customer.CustomerConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.Customer.ICustomerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>address block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#address Customer#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.customer.CustomerAddress\"}", isOptional: true)]
            public stripe.Customer.ICustomerAddress? Address
            {
                get => GetInstanceProperty<stripe.Customer.ICustomerAddress?>();
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
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#business_name Customer#business_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "businessName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BusinessName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>cash_balance block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#cash_balance Customer#cash_balance}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cashBalance", typeJson: "{\"fqn\":\"stripe.customer.CustomerCashBalance\"}", isOptional: true)]
            public stripe.Customer.ICustomerCashBalance? CashBalance
            {
                get => GetInstanceProperty<stripe.Customer.ICustomerCashBalance?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#individual_name Customer#individual_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "individualName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IndividualName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The prefix for the customer used to generate unique invoice numbers. Must be 3–12 uppercase letters or numbers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#invoice_prefix Customer#invoice_prefix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "invoicePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InvoicePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>invoice_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#invoice_settings Customer#invoice_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "invoiceSettings", typeJson: "{\"fqn\":\"stripe.customer.CustomerInvoiceSettings\"}", isOptional: true)]
            public stripe.Customer.ICustomerInvoiceSettings? InvoiceSettings
            {
                get => GetInstanceProperty<stripe.Customer.ICustomerInvoiceSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#metadata Customer#metadata}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>The customer's full name or business name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#name Customer#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The sequence to be used on the customer's next invoice. Defaults to 1.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#next_invoice_sequence Customer#next_invoice_sequence}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nextInvoiceSequence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NextInvoiceSequence
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#payment_method Customer#payment_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PaymentMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The customer's phone number.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#phone Customer#phone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Phone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Customer's preferred languages, ordered by preference.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#preferred_locales Customer#preferred_locales}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferredLocales", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PreferredLocales
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>shipping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#shipping Customer#shipping}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shipping", typeJson: "{\"fqn\":\"stripe.customer.CustomerShipping\"}", isOptional: true)]
            public stripe.Customer.ICustomerShipping? Shipping
            {
                get => GetInstanceProperty<stripe.Customer.ICustomerShipping?>();
            }

            /// <summary>tax block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#tax Customer#tax}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tax", typeJson: "{\"fqn\":\"stripe.customer.CustomerTax\"}", isOptional: true)]
            public stripe.Customer.ICustomerTax? Tax
            {
                get => GetInstanceProperty<stripe.Customer.ICustomerTax?>();
            }

            /// <summary>The customer's tax exemption. One of `none`, `exempt`, or `reverse`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#tax_exempt Customer#tax_exempt}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxExempt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaxExempt
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tax_id_data block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#tax_id_data Customer#tax_id_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxIdData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.customer.CustomerTaxIdData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TaxIdData
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ID of the test clock to attach to the customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#test_clock Customer#test_clock}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "testClock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TestClock
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
