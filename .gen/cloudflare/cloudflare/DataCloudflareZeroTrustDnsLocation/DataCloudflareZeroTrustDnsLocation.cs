using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDnsLocation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_dns_location cloudflare_zero_trust_dns_location}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocation), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationConfig\"}}]")]
    public class DataCloudflareZeroTrustDnsLocation : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_dns_location cloudflare_zero_trust_dns_location} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareZeroTrustDnsLocation(Constructs.Construct scope, string id, cloudflare.DataCloudflareZeroTrustDnsLocation.IDataCloudflareZeroTrustDnsLocationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareZeroTrustDnsLocation.IDataCloudflareZeroTrustDnsLocationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDnsLocation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDnsLocation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareZeroTrustDnsLocation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareZeroTrustDnsLocation to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareZeroTrustDnsLocation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareZeroTrustDnsLocation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareZeroTrustDnsLocation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_dns_location#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareZeroTrustDnsLocation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareZeroTrustDnsLocation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocation))!;

        [JsiiProperty(name: "clientDefault", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ClientDefault
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsDestinationIpsId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsDestinationIpsId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsDestinationIpv6BlockId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsDestinationIpv6BlockId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dohSubdomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DohSubdomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ecsSupport", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EcsSupport
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "endpoints", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsOutputReference Endpoints
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ip
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv4Destination", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv4Destination
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv4DestinationBackup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv4DestinationBackup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networks", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationNetworksList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationNetworksList Networks
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationNetworksList>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "locationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
