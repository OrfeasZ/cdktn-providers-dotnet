using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingServiceAction
{
    [JsiiInterface(nativeType: typeof(IV2BillingServiceActionCreditGrantExpiryConfig), fullyQualifiedName: "stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantExpiryConfig")]
    public interface IV2BillingServiceActionCreditGrantExpiryConfig
    {
        /// <summary>The type of the expiry configuration. We currently support `end_of_service_period`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#type V2BillingServiceAction#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IV2BillingServiceActionCreditGrantExpiryConfig), fullyQualifiedName: "stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantExpiryConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantExpiryConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The type of the expiry configuration. We currently support `end_of_service_period`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#type V2BillingServiceAction#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
