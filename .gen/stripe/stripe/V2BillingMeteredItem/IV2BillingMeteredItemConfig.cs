using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingMeteredItem
{
    [JsiiInterface(nativeType: typeof(IV2BillingMeteredItemConfig), fullyQualifiedName: "stripe.v2BillingMeteredItem.V2BillingMeteredItemConfig")]
    public interface IV2BillingMeteredItemConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Description that customers will see in the invoice line item. Maximum length of 250 characters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#display_name V2BillingMeteredItem#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>ID of the Meter that measures usage for this Metered Item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#meter V2BillingMeteredItem#meter}
        /// </remarks>
        [JsiiProperty(name: "meter", typeJson: "{\"primitive\":\"string\"}")]
        string Meter
        {
            get;
        }

        /// <summary>Optional array of Meter dimensions to group event dimension keys for invoice line items.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#invoice_presentation_dimensions V2BillingMeteredItem#invoice_presentation_dimensions}
        /// </remarks>
        [JsiiProperty(name: "invoicePresentationDimensions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? InvoicePresentationDimensions
        {
            get
            {
                return null;
            }
        }

        /// <summary>An internal key you can use to search for a particular billable item.</summary>
        /// <remarks>
        /// Must be unique among billable items. Maximum length of 200 characters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#lookup_key V2BillingMeteredItem#lookup_key}
        /// </remarks>
        [JsiiProperty(name: "lookupKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LookupKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](/docs/api/metadata) that you can attach to an object.</summary>
        /// <remarks>
        /// This can be useful for storing additional information about the object in a structured format.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#metadata V2BillingMeteredItem#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>meter_segment_conditions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#meter_segment_conditions V2BillingMeteredItem#meter_segment_conditions}
        /// </remarks>
        [JsiiProperty(name: "meterSegmentConditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.v2BillingMeteredItem.V2BillingMeteredItemMeterSegmentConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MeterSegmentConditions
        {
            get
            {
                return null;
            }
        }

        /// <summary>The unit to use when displaying prices for this billable item in places like Checkout.</summary>
        /// <remarks>
        /// For example, set this field to "CPU-hour" for Checkout to display "(price) per CPU-hour", or "1 million events" to display "(price) per 1 million events". Maximum length of 100 characters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#unit_label V2BillingMeteredItem#unit_label}
        /// </remarks>
        [JsiiProperty(name: "unitLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UnitLabel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2BillingMeteredItemConfig), fullyQualifiedName: "stripe.v2BillingMeteredItem.V2BillingMeteredItemConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.V2BillingMeteredItem.IV2BillingMeteredItemConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Description that customers will see in the invoice line item. Maximum length of 250 characters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#display_name V2BillingMeteredItem#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ID of the Meter that measures usage for this Metered Item.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#meter V2BillingMeteredItem#meter}
            /// </remarks>
            [JsiiProperty(name: "meter", typeJson: "{\"primitive\":\"string\"}")]
            public string Meter
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Optional array of Meter dimensions to group event dimension keys for invoice line items.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#invoice_presentation_dimensions V2BillingMeteredItem#invoice_presentation_dimensions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "invoicePresentationDimensions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? InvoicePresentationDimensions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>An internal key you can use to search for a particular billable item.</summary>
            /// <remarks>
            /// Must be unique among billable items. Maximum length of 200 characters.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#lookup_key V2BillingMeteredItem#lookup_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lookupKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LookupKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set of [key-value pairs](/docs/api/metadata) that you can attach to an object.</summary>
            /// <remarks>
            /// This can be useful for storing additional information about the object in a structured format.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#metadata V2BillingMeteredItem#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>meter_segment_conditions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#meter_segment_conditions V2BillingMeteredItem#meter_segment_conditions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "meterSegmentConditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.v2BillingMeteredItem.V2BillingMeteredItemMeterSegmentConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MeterSegmentConditions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The unit to use when displaying prices for this billable item in places like Checkout.</summary>
            /// <remarks>
            /// For example, set this field to "CPU-hour" for Checkout to display "(price) per CPU-hour", or "1 million events" to display "(price) per 1 million events". Maximum length of 100 characters.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#unit_label V2BillingMeteredItem#unit_label}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unitLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UnitLabel
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
