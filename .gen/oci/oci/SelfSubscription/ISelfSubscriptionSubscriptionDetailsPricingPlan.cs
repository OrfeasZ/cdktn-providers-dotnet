using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SelfSubscription
{
    [JsiiInterface(nativeType: typeof(ISelfSubscriptionSubscriptionDetailsPricingPlan), fullyQualifiedName: "oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlan")]
    public interface ISelfSubscriptionSubscriptionDetailsPricingPlan
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#billing_frequency SelfSubscription#billing_frequency}.</summary>
        [JsiiProperty(name: "billingFrequency", typeJson: "{\"primitive\":\"string\"}")]
        string BillingFrequency
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#plan_name SelfSubscription#plan_name}.</summary>
        [JsiiProperty(name: "planName", typeJson: "{\"primitive\":\"string\"}")]
        string PlanName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#plan_type SelfSubscription#plan_type}.</summary>
        [JsiiProperty(name: "planType", typeJson: "{\"primitive\":\"string\"}")]
        string PlanType
        {
            get;
        }

        /// <summary>rates block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#rates SelfSubscription#rates}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanRates" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanRates\"},\"kind\":\"array\"}}]}}")]
        object Rates
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#plan_description SelfSubscription#plan_description}.</summary>
        [JsiiProperty(name: "planDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlanDescription
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#plan_duration SelfSubscription#plan_duration}.</summary>
        [JsiiProperty(name: "planDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlanDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISelfSubscriptionSubscriptionDetailsPricingPlan), fullyQualifiedName: "oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlan")]
        internal sealed class _Proxy : DeputyBase, oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlan
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#billing_frequency SelfSubscription#billing_frequency}.</summary>
            [JsiiProperty(name: "billingFrequency", typeJson: "{\"primitive\":\"string\"}")]
            public string BillingFrequency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#plan_name SelfSubscription#plan_name}.</summary>
            [JsiiProperty(name: "planName", typeJson: "{\"primitive\":\"string\"}")]
            public string PlanName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#plan_type SelfSubscription#plan_type}.</summary>
            [JsiiProperty(name: "planType", typeJson: "{\"primitive\":\"string\"}")]
            public string PlanType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>rates block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#rates SelfSubscription#rates}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanRates" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "rates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanRates\"},\"kind\":\"array\"}}]}}")]
            public object Rates
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#plan_description SelfSubscription#plan_description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "planDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlanDescription
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#plan_duration SelfSubscription#plan_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "planDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlanDuration
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
