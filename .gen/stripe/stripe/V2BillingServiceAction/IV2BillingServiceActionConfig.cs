using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingServiceAction
{
    [JsiiInterface(nativeType: typeof(IV2BillingServiceActionConfig), fullyQualifiedName: "stripe.v2BillingServiceAction.V2BillingServiceActionConfig")]
    public interface IV2BillingServiceActionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The interval for assessing service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#service_interval V2BillingServiceAction#service_interval}
        /// </remarks>
        [JsiiProperty(name: "serviceInterval", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceInterval
        {
            get;
        }

        /// <summary>The length of the interval for assessing service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#service_interval_count V2BillingServiceAction#service_interval_count}
        /// </remarks>
        [JsiiProperty(name: "serviceIntervalCount", typeJson: "{\"primitive\":\"number\"}")]
        double ServiceIntervalCount
        {
            get;
        }

        /// <summary>The type of the service action.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#type V2BillingServiceAction#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>credit_grant block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#credit_grant V2BillingServiceAction#credit_grant}
        /// </remarks>
        [JsiiProperty(name: "creditGrant", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrant\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrant? CreditGrant
        {
            get
            {
                return null;
            }
        }

        /// <summary>An internal key you can use to search for this service action. Maximum length of 200 characters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#lookup_key V2BillingServiceAction#lookup_key}
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

        [JsiiTypeProxy(nativeType: typeof(IV2BillingServiceActionConfig), fullyQualifiedName: "stripe.v2BillingServiceAction.V2BillingServiceActionConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.V2BillingServiceAction.IV2BillingServiceActionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The interval for assessing service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#service_interval V2BillingServiceAction#service_interval}
            /// </remarks>
            [JsiiProperty(name: "serviceInterval", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceInterval
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The length of the interval for assessing service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#service_interval_count V2BillingServiceAction#service_interval_count}
            /// </remarks>
            [JsiiProperty(name: "serviceIntervalCount", typeJson: "{\"primitive\":\"number\"}")]
            public double ServiceIntervalCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The type of the service action.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#type V2BillingServiceAction#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>credit_grant block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#credit_grant V2BillingServiceAction#credit_grant}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "creditGrant", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrant\"}", isOptional: true)]
            public stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrant? CreditGrant
            {
                get => GetInstanceProperty<stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrant?>();
            }

            /// <summary>An internal key you can use to search for this service action. Maximum length of 200 characters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#lookup_key V2BillingServiceAction#lookup_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lookupKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LookupKey
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
