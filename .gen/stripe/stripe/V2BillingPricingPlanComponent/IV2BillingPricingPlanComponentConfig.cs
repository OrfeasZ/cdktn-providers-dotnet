using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingPricingPlanComponent
{
    [JsiiInterface(nativeType: typeof(IV2BillingPricingPlanComponentConfig), fullyQualifiedName: "stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentConfig")]
    public interface IV2BillingPricingPlanComponentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Path parameter: pricing_plan_id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component#pricing_plan_id V2BillingPricingPlanComponent#pricing_plan_id}
        /// </remarks>
        [JsiiProperty(name: "pricingPlanId", typeJson: "{\"primitive\":\"string\"}")]
        string PricingPlanId
        {
            get;
        }

        /// <summary>The type of the PricingPlanComponent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component#type V2BillingPricingPlanComponent#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>license_fee block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component#license_fee V2BillingPricingPlanComponent#license_fee}
        /// </remarks>
        [JsiiProperty(name: "licenseFee", typeJson: "{\"fqn\":\"stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentLicenseFee\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentLicenseFee? LicenseFee
        {
            get
            {
                return null;
            }
        }

        /// <summary>An identifier that can be used to find this component.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component#lookup_key V2BillingPricingPlanComponent#lookup_key}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component#metadata V2BillingPricingPlanComponent#metadata}
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

        /// <summary>rate_card block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component#rate_card V2BillingPricingPlanComponent#rate_card}
        /// </remarks>
        [JsiiProperty(name: "rateCard", typeJson: "{\"fqn\":\"stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentRateCard\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentRateCard? RateCard
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component#service_action V2BillingPricingPlanComponent#service_action}
        /// </remarks>
        [JsiiProperty(name: "serviceAction", typeJson: "{\"fqn\":\"stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentServiceAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentServiceAction? ServiceAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2BillingPricingPlanComponentConfig), fullyQualifiedName: "stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Path parameter: pricing_plan_id.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component#pricing_plan_id V2BillingPricingPlanComponent#pricing_plan_id}
            /// </remarks>
            [JsiiProperty(name: "pricingPlanId", typeJson: "{\"primitive\":\"string\"}")]
            public string PricingPlanId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The type of the PricingPlanComponent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component#type V2BillingPricingPlanComponent#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>license_fee block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component#license_fee V2BillingPricingPlanComponent#license_fee}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "licenseFee", typeJson: "{\"fqn\":\"stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentLicenseFee\"}", isOptional: true)]
            public stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentLicenseFee? LicenseFee
            {
                get => GetInstanceProperty<stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentLicenseFee?>();
            }

            /// <summary>An identifier that can be used to find this component.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component#lookup_key V2BillingPricingPlanComponent#lookup_key}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component#metadata V2BillingPricingPlanComponent#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>rate_card block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component#rate_card V2BillingPricingPlanComponent#rate_card}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rateCard", typeJson: "{\"fqn\":\"stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentRateCard\"}", isOptional: true)]
            public stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentRateCard? RateCard
            {
                get => GetInstanceProperty<stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentRateCard?>();
            }

            /// <summary>service_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component#service_action V2BillingPricingPlanComponent#service_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceAction", typeJson: "{\"fqn\":\"stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentServiceAction\"}", isOptional: true)]
            public stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentServiceAction? ServiceAction
            {
                get => GetInstanceProperty<stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentServiceAction?>();
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
