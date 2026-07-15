using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SelfSubscription
{
    [JsiiInterface(nativeType: typeof(ISelfSubscriptionSubscriptionDetailsBillingDetailsMeters), fullyQualifiedName: "oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetailsMeters")]
    public interface ISelfSubscriptionSubscriptionDetailsBillingDetailsMeters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#name SelfSubscription#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#rate_allocation SelfSubscription#rate_allocation}.</summary>
        [JsiiProperty(name: "rateAllocation", typeJson: "{\"primitive\":\"number\"}")]
        double RateAllocation
        {
            get;
        }

        /// <summary>extended_metadata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#extended_metadata SelfSubscription#extended_metadata}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetailsMetersExtendedMetadata" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "extendedMetadata", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetailsMetersExtendedMetadata\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExtendedMetadata
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISelfSubscriptionSubscriptionDetailsBillingDetailsMeters), fullyQualifiedName: "oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetailsMeters")]
        internal sealed class _Proxy : DeputyBase, oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetailsMeters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#name SelfSubscription#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#rate_allocation SelfSubscription#rate_allocation}.</summary>
            [JsiiProperty(name: "rateAllocation", typeJson: "{\"primitive\":\"number\"}")]
            public double RateAllocation
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>extended_metadata block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/self_subscription#extended_metadata SelfSubscription#extended_metadata}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetailsMetersExtendedMetadata" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extendedMetadata", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetailsMetersExtendedMetadata\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExtendedMetadata
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
