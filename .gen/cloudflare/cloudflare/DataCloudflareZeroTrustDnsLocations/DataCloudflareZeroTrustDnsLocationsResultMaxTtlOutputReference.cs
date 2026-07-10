using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDnsLocations
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultMaxTtlOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultMaxTtlOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustDnsLocationsResultMaxTtlOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustDnsLocationsResultMaxTtlOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDnsLocationsResultMaxTtlOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDnsLocationsResultMaxTtlOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ttlSecs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TtlSecs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultMaxTtl\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustDnsLocations.IDataCloudflareZeroTrustDnsLocationsResultMaxTtl? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDnsLocations.IDataCloudflareZeroTrustDnsLocationsResultMaxTtl?>();
            set => SetInstanceProperty(value);
        }
    }
}
