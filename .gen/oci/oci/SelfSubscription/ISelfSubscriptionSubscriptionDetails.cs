using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SelfSubscription
{
    [JsiiInterface(nativeType: typeof(ISelfSubscriptionSubscriptionDetails), fullyQualifiedName: "oci.selfSubscription.SelfSubscriptionSubscriptionDetails")]
    public interface ISelfSubscriptionSubscriptionDetails
    {
        /// <summary>billing_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/self_subscription#billing_details SelfSubscription#billing_details}
        /// </remarks>
        [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetails\"}")]
        oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetails BillingDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/self_subscription#partner_registration_url SelfSubscription#partner_registration_url}.</summary>
        [JsiiProperty(name: "partnerRegistrationUrl", typeJson: "{\"primitive\":\"string\"}")]
        string PartnerRegistrationUrl
        {
            get;
        }

        /// <summary>pricing_plan block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/self_subscription#pricing_plan SelfSubscription#pricing_plan}
        /// </remarks>
        [JsiiProperty(name: "pricingPlan", typeJson: "{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlan\"}")]
        oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlan PricingPlan
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/self_subscription#amount SelfSubscription#amount}.</summary>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Amount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/self_subscription#currency SelfSubscription#currency}.</summary>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Currency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/self_subscription#is_auto_renew SelfSubscription#is_auto_renew}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isAutoRenew", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAutoRenew
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISelfSubscriptionSubscriptionDetails), fullyQualifiedName: "oci.selfSubscription.SelfSubscriptionSubscriptionDetails")]
        internal sealed class _Proxy : DeputyBase, oci.SelfSubscription.ISelfSubscriptionSubscriptionDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>billing_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/self_subscription#billing_details SelfSubscription#billing_details}
            /// </remarks>
            [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetails\"}")]
            public oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetails BillingDetails
            {
                get => GetInstanceProperty<oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/self_subscription#partner_registration_url SelfSubscription#partner_registration_url}.</summary>
            [JsiiProperty(name: "partnerRegistrationUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string PartnerRegistrationUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>pricing_plan block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/self_subscription#pricing_plan SelfSubscription#pricing_plan}
            /// </remarks>
            [JsiiProperty(name: "pricingPlan", typeJson: "{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlan\"}")]
            public oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlan PricingPlan
            {
                get => GetInstanceProperty<oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlan>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/self_subscription#amount SelfSubscription#amount}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Amount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/self_subscription#currency SelfSubscription#currency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Currency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/self_subscription#is_auto_renew SelfSubscription#is_auto_renew}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isAutoRenew", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAutoRenew
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
