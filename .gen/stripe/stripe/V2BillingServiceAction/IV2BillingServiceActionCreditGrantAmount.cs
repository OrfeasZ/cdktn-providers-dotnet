using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingServiceAction
{
    [JsiiInterface(nativeType: typeof(IV2BillingServiceActionCreditGrantAmount), fullyQualifiedName: "stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmount")]
    public interface IV2BillingServiceActionCreditGrantAmount
    {
        /// <summary>The type of the credit grant amount. We currently support `monetary` and `custom_pricing_unit` billing credits.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#type V2BillingServiceAction#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>custom_pricing_unit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#custom_pricing_unit V2BillingServiceAction#custom_pricing_unit}
        /// </remarks>
        [JsiiProperty(name: "customPricingUnit", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmountCustomPricingUnit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmountCustomPricingUnit? CustomPricingUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>monetary block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#monetary V2BillingServiceAction#monetary}
        /// </remarks>
        [JsiiProperty(name: "monetary", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmountMonetary\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmountMonetary? Monetary
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2BillingServiceActionCreditGrantAmount), fullyQualifiedName: "stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmount")]
        internal sealed class _Proxy : DeputyBase, stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The type of the credit grant amount. We currently support `monetary` and `custom_pricing_unit` billing credits.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#type V2BillingServiceAction#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>custom_pricing_unit block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#custom_pricing_unit V2BillingServiceAction#custom_pricing_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customPricingUnit", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmountCustomPricingUnit\"}", isOptional: true)]
            public stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmountCustomPricingUnit? CustomPricingUnit
            {
                get => GetInstanceProperty<stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmountCustomPricingUnit?>();
            }

            /// <summary>monetary block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#monetary V2BillingServiceAction#monetary}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monetary", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmountMonetary\"}", isOptional: true)]
            public stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmountMonetary? Monetary
            {
                get => GetInstanceProperty<stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmountMonetary?>();
            }
        }
    }
}
