using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SelfSubscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetailsMeters")]
    public class SelfSubscriptionSubscriptionDetailsBillingDetailsMeters : oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetailsMeters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/self_subscription#name SelfSubscription#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/self_subscription#rate_allocation SelfSubscription#rate_allocation}.</summary>
        [JsiiProperty(name: "rateAllocation", typeJson: "{\"primitive\":\"number\"}")]
        public double RateAllocation
        {
            get;
            set;
        }

        private object? _extendedMetadata;

        /// <summary>extended_metadata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/self_subscription#extended_metadata SelfSubscription#extended_metadata}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetailsMetersExtendedMetadata" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extendedMetadata", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetailsMetersExtendedMetadata\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExtendedMetadata
        {
            get => _extendedMetadata;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetailsMetersExtendedMetadata[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetailsMetersExtendedMetadata).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _extendedMetadata = value;
            }
        }
    }
}
