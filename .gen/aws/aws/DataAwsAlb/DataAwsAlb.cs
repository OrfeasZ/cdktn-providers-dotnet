using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAlb
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/alb aws_alb}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsAlb.DataAwsAlb), fullyQualifiedName: "aws.dataAwsAlb.DataAwsAlb", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.dataAwsAlb.DataAwsAlbConfig\"}}]")]
    public class DataAwsAlb : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/alb aws_alb} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsAlb(Constructs.Construct scope, string id, aws.DataAwsAlb.IDataAwsAlbConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsAlb.IDataAwsAlbConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAlb(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAlb(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsAlb resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsAlb to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsAlb that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsAlb to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsAlb to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/alb#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsAlb that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsAlb to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsAlb.DataAwsAlb), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsAlb.DataAwsAlbTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.DataAwsAlb.IDataAwsAlbTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsAlb.IDataAwsAlbTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArn")]
        public virtual void ResetArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(aws.DataAwsAlb.DataAwsAlb))!;

        [JsiiProperty(name: "accessLogs", typeJson: "{\"fqn\":\"aws.dataAwsAlb.DataAwsAlbAccessLogsList\"}")]
        public virtual aws.DataAwsAlb.DataAwsAlbAccessLogsList AccessLogs
        {
            get => GetInstanceProperty<aws.DataAwsAlb.DataAwsAlbAccessLogsList>()!;
        }

        [JsiiProperty(name: "arnSuffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArnSuffix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientKeepAlive", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ClientKeepAlive
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "connectionLogs", typeJson: "{\"fqn\":\"aws.dataAwsAlb.DataAwsAlbConnectionLogsList\"}")]
        public virtual aws.DataAwsAlb.DataAwsAlbConnectionLogsList ConnectionLogs
        {
            get => GetInstanceProperty<aws.DataAwsAlb.DataAwsAlbConnectionLogsList>()!;
        }

        [JsiiProperty(name: "customerOwnedIpv4Pool", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerOwnedIpv4Pool
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "desyncMitigationMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DesyncMitigationMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsRecordClientRoutingPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsRecordClientRoutingPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dropInvalidHeaderFields", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DropInvalidHeaderFields
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enableCrossZoneLoadBalancing", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableCrossZoneLoadBalancing
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enableDeletionProtection", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableDeletionProtection
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enableHttp2", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableHttp2
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enableTlsVersionAndCipherSuiteHeaders", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableTlsVersionAndCipherSuiteHeaders
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enableWafFailOpen", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableWafFailOpen
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enableXffClientPort", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableXffClientPort
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enableZonalShift", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableZonalShift
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enforceSecurityGroupInboundRulesOnPrivateLinkTraffic", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "healthCheckLogs", typeJson: "{\"fqn\":\"aws.dataAwsAlb.DataAwsAlbHealthCheckLogsList\"}")]
        public virtual aws.DataAwsAlb.DataAwsAlbHealthCheckLogsList HealthCheckLogs
        {
            get => GetInstanceProperty<aws.DataAwsAlb.DataAwsAlbHealthCheckLogsList>()!;
        }

        [JsiiProperty(name: "idleTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IdleTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "internal", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Internal
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddressType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipamPools", typeJson: "{\"fqn\":\"aws.dataAwsAlb.DataAwsAlbIpamPoolsList\"}")]
        public virtual aws.DataAwsAlb.DataAwsAlbIpamPoolsList IpamPools
        {
            get => GetInstanceProperty<aws.DataAwsAlb.DataAwsAlbIpamPoolsList>()!;
        }

        [JsiiProperty(name: "loadBalancerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preserveHostHeader", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PreserveHostHeader
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "secondaryIpsAutoAssignedPerSubnet", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SecondaryIpsAutoAssignedPerSubnet
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "subnetMapping", typeJson: "{\"fqn\":\"aws.dataAwsAlb.DataAwsAlbSubnetMappingList\"}")]
        public virtual aws.DataAwsAlb.DataAwsAlbSubnetMappingList SubnetMapping
        {
            get => GetInstanceProperty<aws.DataAwsAlb.DataAwsAlbSubnetMappingList>()!;
        }

        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Subnets
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.dataAwsAlb.DataAwsAlbTimeoutsOutputReference\"}")]
        public virtual aws.DataAwsAlb.DataAwsAlbTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.DataAwsAlb.DataAwsAlbTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "xffHeaderProcessingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string XffHeaderProcessingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "arnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.dataAwsAlb.DataAwsAlbTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
