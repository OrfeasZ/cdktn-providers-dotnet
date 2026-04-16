using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingServiceAction
{
    [JsiiInterface(nativeType: typeof(IV2BillingServiceActionCreditGrant), fullyQualifiedName: "stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrant")]
    public interface IV2BillingServiceActionCreditGrant
    {
        /// <summary>amount block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#amount V2BillingServiceAction#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmount\"}")]
        stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmount Amount
        {
            get;
        }

        /// <summary>applicability_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#applicability_config V2BillingServiceAction#applicability_config}
        /// </remarks>
        [JsiiProperty(name: "applicabilityConfig", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfig\"}")]
        stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfig ApplicabilityConfig
        {
            get;
        }

        /// <summary>expiry_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#expiry_config V2BillingServiceAction#expiry_config}
        /// </remarks>
        [JsiiProperty(name: "expiryConfig", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantExpiryConfig\"}")]
        stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantExpiryConfig ExpiryConfig
        {
            get;
        }

        /// <summary>A descriptive name shown in dashboard.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#name V2BillingServiceAction#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The category of the credit grant.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#category V2BillingServiceAction#category}
        /// </remarks>
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Category
        {
            get
            {
                return null;
            }
        }

        /// <summary>The desired priority for applying this credit grant.</summary>
        /// <remarks>
        /// If not specified, it will be set to the default value of 50. The highest priority is 0 and the lowest is 100.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#priority V2BillingServiceAction#priority}
        /// </remarks>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2BillingServiceActionCreditGrant), fullyQualifiedName: "stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrant")]
        internal sealed class _Proxy : DeputyBase, stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrant
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>amount block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#amount V2BillingServiceAction#amount}
            /// </remarks>
            [JsiiProperty(name: "amount", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmount\"}")]
            public stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmount Amount
            {
                get => GetInstanceProperty<stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmount>()!;
            }

            /// <summary>applicability_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#applicability_config V2BillingServiceAction#applicability_config}
            /// </remarks>
            [JsiiProperty(name: "applicabilityConfig", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfig\"}")]
            public stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfig ApplicabilityConfig
            {
                get => GetInstanceProperty<stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfig>()!;
            }

            /// <summary>expiry_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#expiry_config V2BillingServiceAction#expiry_config}
            /// </remarks>
            [JsiiProperty(name: "expiryConfig", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantExpiryConfig\"}")]
            public stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantExpiryConfig ExpiryConfig
            {
                get => GetInstanceProperty<stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantExpiryConfig>()!;
            }

            /// <summary>A descriptive name shown in dashboard.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#name V2BillingServiceAction#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The category of the credit grant.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#category V2BillingServiceAction#category}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Category
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The desired priority for applying this credit grant.</summary>
            /// <remarks>
            /// If not specified, it will be set to the default value of 50. The highest priority is 0 and the lowest is 100.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#priority V2BillingServiceAction#priority}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
