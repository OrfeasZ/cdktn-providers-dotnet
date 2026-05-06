using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnalyticsAnalyticsInstancePrivateAccessChannel
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel oci_analytics_analytics_instance_private_access_channel}.</summary>
    [JsiiClass(nativeType: typeof(oci.AnalyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannel), fullyQualifiedName: "oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannel", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelConfig\"}}]")]
    public class AnalyticsAnalyticsInstancePrivateAccessChannel : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel oci_analytics_analytics_instance_private_access_channel} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AnalyticsAnalyticsInstancePrivateAccessChannel(Constructs.Construct scope, string id, oci.AnalyticsAnalyticsInstancePrivateAccessChannel.IAnalyticsAnalyticsInstancePrivateAccessChannelConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.AnalyticsAnalyticsInstancePrivateAccessChannel.IAnalyticsAnalyticsInstancePrivateAccessChannelConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AnalyticsAnalyticsInstancePrivateAccessChannel(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AnalyticsAnalyticsInstancePrivateAccessChannel(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a AnalyticsAnalyticsInstancePrivateAccessChannel resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AnalyticsAnalyticsInstancePrivateAccessChannel to import.</param>
        /// <param name="importFromId">The id of the existing AnalyticsAnalyticsInstancePrivateAccessChannel that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AnalyticsAnalyticsInstancePrivateAccessChannel to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AnalyticsAnalyticsInstancePrivateAccessChannel to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AnalyticsAnalyticsInstancePrivateAccessChannel that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AnalyticsAnalyticsInstancePrivateAccessChannel to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.AnalyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannel), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putPrivateSourceDnsZones", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceDnsZones\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPrivateSourceDnsZones(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.AnalyticsAnalyticsInstancePrivateAccessChannel.IAnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceDnsZones[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AnalyticsAnalyticsInstancePrivateAccessChannel.IAnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceDnsZones).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AnalyticsAnalyticsInstancePrivateAccessChannel.IAnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceDnsZones).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrivateSourceScanHosts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceScanHosts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPrivateSourceScanHosts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.AnalyticsAnalyticsInstancePrivateAccessChannel.IAnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceScanHosts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AnalyticsAnalyticsInstancePrivateAccessChannel.IAnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceScanHosts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AnalyticsAnalyticsInstancePrivateAccessChannel.IAnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceScanHosts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.AnalyticsAnalyticsInstancePrivateAccessChannel.IAnalyticsAnalyticsInstancePrivateAccessChannelTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AnalyticsAnalyticsInstancePrivateAccessChannel.IAnalyticsAnalyticsInstancePrivateAccessChannelTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkSecurityGroupIds")]
        public virtual void ResetNetworkSecurityGroupIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateSourceScanHosts")]
        public virtual void ResetPrivateSourceScanHosts()
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
        = GetStaticProperty<string>(typeof(oci.AnalyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannel))!;

        [JsiiProperty(name: "egressSourceIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EgressSourceIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateSourceDnsZones", typeJson: "{\"fqn\":\"oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceDnsZonesList\"}")]
        public virtual oci.AnalyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceDnsZonesList PrivateSourceDnsZones
        {
            get => GetInstanceProperty<oci.AnalyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceDnsZonesList>()!;
        }

        [JsiiProperty(name: "privateSourceScanHosts", typeJson: "{\"fqn\":\"oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceScanHostsList\"}")]
        public virtual oci.AnalyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceScanHostsList PrivateSourceScanHosts
        {
            get => GetInstanceProperty<oci.AnalyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceScanHostsList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelTimeoutsOutputReference\"}")]
        public virtual oci.AnalyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.AnalyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "analyticsInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AnalyticsInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
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
        [JsiiProperty(name: "networkSecurityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NetworkSecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateSourceDnsZonesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceDnsZones\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PrivateSourceDnsZonesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateSourceScanHostsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceScanHosts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PrivateSourceScanHostsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcnIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VcnIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "analyticsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AnalyticsInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "networkSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NetworkSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcnId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
