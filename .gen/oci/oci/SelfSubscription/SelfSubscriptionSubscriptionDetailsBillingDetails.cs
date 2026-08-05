using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SelfSubscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetails")]
    public class SelfSubscriptionSubscriptionDetailsBillingDetails : oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetails
    {
        private object _meters;

        /// <summary>meters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/self_subscription#meters SelfSubscription#meters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetailsMeters" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "meters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetailsMeters\"},\"kind\":\"array\"}}]}}")]
        public object Meters
        {
            get => _meters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetailsMeters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetailsMeters).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetailsMeters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _meters = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/self_subscription#metric_type SelfSubscription#metric_type}.</summary>
        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}")]
        public string MetricType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/self_subscription#rate_allocation SelfSubscription#rate_allocation}.</summary>
        [JsiiProperty(name: "rateAllocation", typeJson: "{\"primitive\":\"number\"}")]
        public double RateAllocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/self_subscription#sku SelfSubscription#sku}.</summary>
        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        public string Sku
        {
            get;
            set;
        }

        private object? _hasGovSku;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/self_subscription#has_gov_sku SelfSubscription#has_gov_sku}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hasGovSku", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? HasGovSku
        {
            get => _hasGovSku;
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
                _hasGovSku = value;
            }
        }
    }
}
