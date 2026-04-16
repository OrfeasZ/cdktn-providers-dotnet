using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingMeter
{
    [JsiiInterface(nativeType: typeof(IBillingMeterConfig), fullyQualifiedName: "stripe.billingMeter.BillingMeterConfig")]
    public interface IBillingMeterConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>default_aggregation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#default_aggregation BillingMeter#default_aggregation}
        /// </remarks>
        [JsiiProperty(name: "defaultAggregation", typeJson: "{\"fqn\":\"stripe.billingMeter.BillingMeterDefaultAggregation\"}")]
        stripe.BillingMeter.IBillingMeterDefaultAggregation DefaultAggregation
        {
            get;
        }

        /// <summary>The meter’s name. Not visible to the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#display_name BillingMeter#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>The name of the meter event to record usage for. Corresponds with the `event_name` field on meter events.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#event_name BillingMeter#event_name}
        /// </remarks>
        [JsiiProperty(name: "eventName", typeJson: "{\"primitive\":\"string\"}")]
        string EventName
        {
            get;
        }

        /// <summary>customer_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#customer_mapping BillingMeter#customer_mapping}
        /// </remarks>
        [JsiiProperty(name: "customerMapping", typeJson: "{\"fqn\":\"stripe.billingMeter.BillingMeterCustomerMapping\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.BillingMeter.IBillingMeterCustomerMapping? CustomerMapping
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of keys that will be used to group meter events by.</summary>
        /// <remarks>
        /// Each key must be present in the event payload.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#dimension_payload_keys BillingMeter#dimension_payload_keys}
        /// </remarks>
        [JsiiProperty(name: "dimensionPayloadKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DimensionPayloadKeys
        {
            get
            {
                return null;
            }
        }

        /// <summary>The time window which meter events have been pre-aggregated for, if any.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#event_time_window BillingMeter#event_time_window}
        /// </remarks>
        [JsiiProperty(name: "eventTimeWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventTimeWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>value_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#value_settings BillingMeter#value_settings}
        /// </remarks>
        [JsiiProperty(name: "valueSettings", typeJson: "{\"fqn\":\"stripe.billingMeter.BillingMeterValueSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.BillingMeter.IBillingMeterValueSettings? ValueSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingMeterConfig), fullyQualifiedName: "stripe.billingMeter.BillingMeterConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.BillingMeter.IBillingMeterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_aggregation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#default_aggregation BillingMeter#default_aggregation}
            /// </remarks>
            [JsiiProperty(name: "defaultAggregation", typeJson: "{\"fqn\":\"stripe.billingMeter.BillingMeterDefaultAggregation\"}")]
            public stripe.BillingMeter.IBillingMeterDefaultAggregation DefaultAggregation
            {
                get => GetInstanceProperty<stripe.BillingMeter.IBillingMeterDefaultAggregation>()!;
            }

            /// <summary>The meter’s name. Not visible to the customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#display_name BillingMeter#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the meter event to record usage for. Corresponds with the `event_name` field on meter events.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#event_name BillingMeter#event_name}
            /// </remarks>
            [JsiiProperty(name: "eventName", typeJson: "{\"primitive\":\"string\"}")]
            public string EventName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>customer_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#customer_mapping BillingMeter#customer_mapping}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customerMapping", typeJson: "{\"fqn\":\"stripe.billingMeter.BillingMeterCustomerMapping\"}", isOptional: true)]
            public stripe.BillingMeter.IBillingMeterCustomerMapping? CustomerMapping
            {
                get => GetInstanceProperty<stripe.BillingMeter.IBillingMeterCustomerMapping?>();
            }

            /// <summary>Set of keys that will be used to group meter events by.</summary>
            /// <remarks>
            /// Each key must be present in the event payload.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#dimension_payload_keys BillingMeter#dimension_payload_keys}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimensionPayloadKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DimensionPayloadKeys
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The time window which meter events have been pre-aggregated for, if any.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#event_time_window BillingMeter#event_time_window}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eventTimeWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventTimeWindow
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>value_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#value_settings BillingMeter#value_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "valueSettings", typeJson: "{\"fqn\":\"stripe.billingMeter.BillingMeterValueSettings\"}", isOptional: true)]
            public stripe.BillingMeter.IBillingMeterValueSettings? ValueSettings
            {
                get => GetInstanceProperty<stripe.BillingMeter.IBillingMeterValueSettings?>();
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
