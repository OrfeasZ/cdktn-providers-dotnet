using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingCreditGrant
{
    [JsiiInterface(nativeType: typeof(IBillingCreditGrantAmount), fullyQualifiedName: "stripe.billingCreditGrant.BillingCreditGrantAmount")]
    public interface IBillingCreditGrantAmount
    {
        /// <summary>The type of this amount. We currently only support `monetary` billing credits.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_credit_grant#type BillingCreditGrant#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>The monetary amount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_credit_grant#monetary BillingCreditGrant#monetary}
        /// </remarks>
        [JsiiProperty(name: "monetary", typeJson: "{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantAmountMonetary\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.BillingCreditGrant.IBillingCreditGrantAmountMonetary? Monetary
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingCreditGrantAmount), fullyQualifiedName: "stripe.billingCreditGrant.BillingCreditGrantAmount")]
        internal sealed class _Proxy : DeputyBase, stripe.BillingCreditGrant.IBillingCreditGrantAmount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The type of this amount. We currently only support `monetary` billing credits.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_credit_grant#type BillingCreditGrant#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The monetary amount.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_credit_grant#monetary BillingCreditGrant#monetary}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monetary", typeJson: "{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantAmountMonetary\"}", isOptional: true)]
            public stripe.BillingCreditGrant.IBillingCreditGrantAmountMonetary? Monetary
            {
                get => GetInstanceProperty<stripe.BillingCreditGrant.IBillingCreditGrantAmountMonetary?>();
            }
        }
    }
}
