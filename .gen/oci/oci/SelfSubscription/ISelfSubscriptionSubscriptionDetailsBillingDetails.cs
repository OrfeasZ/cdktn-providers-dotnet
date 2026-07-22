using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SelfSubscription
{
    [JsiiInterface(nativeType: typeof(ISelfSubscriptionSubscriptionDetailsBillingDetails), fullyQualifiedName: "oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetails")]
    public interface ISelfSubscriptionSubscriptionDetailsBillingDetails
    {
        /// <summary>meters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/self_subscription#meters SelfSubscription#meters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetailsMeters" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "meters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetailsMeters\"},\"kind\":\"array\"}}]}}")]
        object Meters
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/self_subscription#metric_type SelfSubscription#metric_type}.</summary>
        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}")]
        string MetricType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/self_subscription#rate_allocation SelfSubscription#rate_allocation}.</summary>
        [JsiiProperty(name: "rateAllocation", typeJson: "{\"primitive\":\"number\"}")]
        double RateAllocation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/self_subscription#sku SelfSubscription#sku}.</summary>
        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        string Sku
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/self_subscription#has_gov_sku SelfSubscription#has_gov_sku}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "hasGovSku", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HasGovSku
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISelfSubscriptionSubscriptionDetailsBillingDetails), fullyQualifiedName: "oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetails")]
        internal sealed class _Proxy : DeputyBase, oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>meters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/self_subscription#meters SelfSubscription#meters}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetailsMeters" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "meters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetailsMeters\"},\"kind\":\"array\"}}]}}")]
            public object Meters
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/self_subscription#metric_type SelfSubscription#metric_type}.</summary>
            [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/self_subscription#rate_allocation SelfSubscription#rate_allocation}.</summary>
            [JsiiProperty(name: "rateAllocation", typeJson: "{\"primitive\":\"number\"}")]
            public double RateAllocation
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/self_subscription#sku SelfSubscription#sku}.</summary>
            [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
            public string Sku
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/self_subscription#has_gov_sku SelfSubscription#has_gov_sku}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hasGovSku", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HasGovSku
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
