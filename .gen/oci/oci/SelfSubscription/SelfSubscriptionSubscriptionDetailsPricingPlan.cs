using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SelfSubscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlan")]
    public class SelfSubscriptionSubscriptionDetailsPricingPlan : oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlan
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/self_subscription#billing_frequency SelfSubscription#billing_frequency}.</summary>
        [JsiiProperty(name: "billingFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public string BillingFrequency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/self_subscription#plan_name SelfSubscription#plan_name}.</summary>
        [JsiiProperty(name: "planName", typeJson: "{\"primitive\":\"string\"}")]
        public string PlanName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/self_subscription#plan_type SelfSubscription#plan_type}.</summary>
        [JsiiProperty(name: "planType", typeJson: "{\"primitive\":\"string\"}")]
        public string PlanType
        {
            get;
            set;
        }

        private object _rates;

        /// <summary>rates block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/self_subscription#rates SelfSubscription#rates}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanRates" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanRates\"},\"kind\":\"array\"}}]}}")]
        public object Rates
        {
            get => _rates;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanRates[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanRates).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanRates).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rates = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/self_subscription#plan_description SelfSubscription#plan_description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "planDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PlanDescription
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/self_subscription#plan_duration SelfSubscription#plan_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "planDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PlanDuration
        {
            get;
            set;
        }
    }
}
