using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SelfSubscription
{
    [JsiiInterface(nativeType: typeof(ISelfSubscriptionSubscriptionDetailsPricingPlanDimensions), fullyQualifiedName: "oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanDimensions")]
    public interface ISelfSubscriptionSubscriptionDetailsPricingPlanDimensions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#dimension_billing_frequency SelfSubscription#dimension_billing_frequency}.</summary>
        [JsiiProperty(name: "dimensionBillingFrequency", typeJson: "{\"primitive\":\"string\"}")]
        string DimensionBillingFrequency
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#dimension_description SelfSubscription#dimension_description}.</summary>
        [JsiiProperty(name: "dimensionDescription", typeJson: "{\"primitive\":\"string\"}")]
        string DimensionDescription
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#dimension_key SelfSubscription#dimension_key}.</summary>
        [JsiiProperty(name: "dimensionKey", typeJson: "{\"primitive\":\"string\"}")]
        string DimensionKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#dimension_name SelfSubscription#dimension_name}.</summary>
        [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}")]
        string DimensionName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#metric_type SelfSubscription#metric_type}.</summary>
        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}")]
        string MetricType
        {
            get;
        }

        /// <summary>rates block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#rates SelfSubscription#rates}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanDimensionsRates" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanDimensionsRates\"},\"kind\":\"array\"}}]}}")]
        object Rates
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#included_quantity SelfSubscription#included_quantity}.</summary>
        [JsiiProperty(name: "includedQuantity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IncludedQuantity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISelfSubscriptionSubscriptionDetailsPricingPlanDimensions), fullyQualifiedName: "oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanDimensions")]
        internal sealed class _Proxy : DeputyBase, oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanDimensions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#dimension_billing_frequency SelfSubscription#dimension_billing_frequency}.</summary>
            [JsiiProperty(name: "dimensionBillingFrequency", typeJson: "{\"primitive\":\"string\"}")]
            public string DimensionBillingFrequency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#dimension_description SelfSubscription#dimension_description}.</summary>
            [JsiiProperty(name: "dimensionDescription", typeJson: "{\"primitive\":\"string\"}")]
            public string DimensionDescription
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#dimension_key SelfSubscription#dimension_key}.</summary>
            [JsiiProperty(name: "dimensionKey", typeJson: "{\"primitive\":\"string\"}")]
            public string DimensionKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#dimension_name SelfSubscription#dimension_name}.</summary>
            [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}")]
            public string DimensionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#metric_type SelfSubscription#metric_type}.</summary>
            [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>rates block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#rates SelfSubscription#rates}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanDimensionsRates" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "rates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanDimensionsRates\"},\"kind\":\"array\"}}]}}")]
            public object Rates
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#included_quantity SelfSubscription#included_quantity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includedQuantity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IncludedQuantity
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
