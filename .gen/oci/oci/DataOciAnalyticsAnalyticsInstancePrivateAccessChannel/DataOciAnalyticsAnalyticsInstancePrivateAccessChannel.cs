using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAnalyticsAnalyticsInstancePrivateAccessChannel
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/analytics_analytics_instance_private_access_channel oci_analytics_analytics_instance_private_access_channel}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciAnalyticsAnalyticsInstancePrivateAccessChannel.DataOciAnalyticsAnalyticsInstancePrivateAccessChannel), fullyQualifiedName: "oci.dataOciAnalyticsAnalyticsInstancePrivateAccessChannel.DataOciAnalyticsAnalyticsInstancePrivateAccessChannel", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciAnalyticsAnalyticsInstancePrivateAccessChannel.DataOciAnalyticsAnalyticsInstancePrivateAccessChannelConfig\"}}]")]
    public class DataOciAnalyticsAnalyticsInstancePrivateAccessChannel : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/analytics_analytics_instance_private_access_channel oci_analytics_analytics_instance_private_access_channel} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciAnalyticsAnalyticsInstancePrivateAccessChannel(Constructs.Construct scope, string id, oci.DataOciAnalyticsAnalyticsInstancePrivateAccessChannel.IDataOciAnalyticsAnalyticsInstancePrivateAccessChannelConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciAnalyticsAnalyticsInstancePrivateAccessChannel.IDataOciAnalyticsAnalyticsInstancePrivateAccessChannelConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAnalyticsAnalyticsInstancePrivateAccessChannel(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAnalyticsAnalyticsInstancePrivateAccessChannel(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciAnalyticsAnalyticsInstancePrivateAccessChannel resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciAnalyticsAnalyticsInstancePrivateAccessChannel to import.</param>
        /// <param name="importFromId">The id of the existing DataOciAnalyticsAnalyticsInstancePrivateAccessChannel that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciAnalyticsAnalyticsInstancePrivateAccessChannel to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciAnalyticsAnalyticsInstancePrivateAccessChannel to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/analytics_analytics_instance_private_access_channel#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciAnalyticsAnalyticsInstancePrivateAccessChannel that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciAnalyticsAnalyticsInstancePrivateAccessChannel to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciAnalyticsAnalyticsInstancePrivateAccessChannel.DataOciAnalyticsAnalyticsInstancePrivateAccessChannel), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciAnalyticsAnalyticsInstancePrivateAccessChannel.DataOciAnalyticsAnalyticsInstancePrivateAccessChannel))!;

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "egressSourceIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EgressSourceIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "networkSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NetworkSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "privateSourceDnsZones", typeJson: "{\"fqn\":\"oci.dataOciAnalyticsAnalyticsInstancePrivateAccessChannel.DataOciAnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceDnsZonesList\"}")]
        public virtual oci.DataOciAnalyticsAnalyticsInstancePrivateAccessChannel.DataOciAnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceDnsZonesList PrivateSourceDnsZones
        {
            get => GetInstanceProperty<oci.DataOciAnalyticsAnalyticsInstancePrivateAccessChannel.DataOciAnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceDnsZonesList>()!;
        }

        [JsiiProperty(name: "privateSourceScanHosts", typeJson: "{\"fqn\":\"oci.dataOciAnalyticsAnalyticsInstancePrivateAccessChannel.DataOciAnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceScanHostsList\"}")]
        public virtual oci.DataOciAnalyticsAnalyticsInstancePrivateAccessChannel.DataOciAnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceScanHostsList PrivateSourceScanHosts
        {
            get => GetInstanceProperty<oci.DataOciAnalyticsAnalyticsInstancePrivateAccessChannel.DataOciAnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceScanHostsList>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcnId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "analyticsInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AnalyticsInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateAccessChannelKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateAccessChannelKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "analyticsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AnalyticsInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateAccessChannelKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateAccessChannelKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
