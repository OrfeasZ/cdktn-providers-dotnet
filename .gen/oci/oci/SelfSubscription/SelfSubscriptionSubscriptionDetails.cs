using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SelfSubscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.selfSubscription.SelfSubscriptionSubscriptionDetails")]
    public class SelfSubscriptionSubscriptionDetails : oci.SelfSubscription.ISelfSubscriptionSubscriptionDetails
    {
        /// <summary>billing_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#billing_details SelfSubscription#billing_details}
        /// </remarks>
        [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetails\"}")]
        public oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetails BillingDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#partner_registration_url SelfSubscription#partner_registration_url}.</summary>
        [JsiiProperty(name: "partnerRegistrationUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string PartnerRegistrationUrl
        {
            get;
            set;
        }

        /// <summary>pricing_plan block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#pricing_plan SelfSubscription#pricing_plan}
        /// </remarks>
        [JsiiProperty(name: "pricingPlan", typeJson: "{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlan\"}")]
        public oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlan PricingPlan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#amount SelfSubscription#amount}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Amount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#currency SelfSubscription#currency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Currency
        {
            get;
            set;
        }

        private object? _isAutoRenew;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#is_auto_renew SelfSubscription#is_auto_renew}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isAutoRenew", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsAutoRenew
        {
            get => _isAutoRenew;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isAutoRenew = value;
            }
        }
    }
}
