using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingCreditGrant
{
    [JsiiInterface(nativeType: typeof(IBillingCreditGrantApplicabilityConfig), fullyQualifiedName: "stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfig")]
    public interface IBillingCreditGrantApplicabilityConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_credit_grant#scope BillingCreditGrant#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfigScope\"}")]
        stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScope Scope
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingCreditGrantApplicabilityConfig), fullyQualifiedName: "stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_credit_grant#scope BillingCreditGrant#scope}.</summary>
            [JsiiProperty(name: "scope", typeJson: "{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfigScope\"}")]
            public stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScope Scope
            {
                get => GetInstanceProperty<stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScope>()!;
            }
        }
    }
}
