using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SelfSubscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanDimensions")]
    public class SelfSubscriptionSubscriptionDetailsPricingPlanDimensions : oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanDimensions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#dimension_billing_frequency SelfSubscription#dimension_billing_frequency}.</summary>
        [JsiiProperty(name: "dimensionBillingFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public string DimensionBillingFrequency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#dimension_description SelfSubscription#dimension_description}.</summary>
        [JsiiProperty(name: "dimensionDescription", typeJson: "{\"primitive\":\"string\"}")]
        public string DimensionDescription
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#dimension_key SelfSubscription#dimension_key}.</summary>
        [JsiiProperty(name: "dimensionKey", typeJson: "{\"primitive\":\"string\"}")]
        public string DimensionKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#dimension_name SelfSubscription#dimension_name}.</summary>
        [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}")]
        public string DimensionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#metric_type SelfSubscription#metric_type}.</summary>
        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}")]
        public string MetricType
        {
            get;
            set;
        }

        private object _rates;

        /// <summary>rates block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#rates SelfSubscription#rates}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanDimensionsRates" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanDimensionsRates\"},\"kind\":\"array\"}}]}}")]
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
                        case oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanDimensionsRates[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanDimensionsRates).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanDimensionsRates).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rates = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#included_quantity SelfSubscription#included_quantity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includedQuantity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IncludedQuantity
        {
            get;
            set;
        }
    }
}
