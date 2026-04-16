using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareMagicNetworkMonitoringConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/magic_network_monitoring_configuration cloudflare_magic_network_monitoring_configuration}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareMagicNetworkMonitoringConfiguration.DataCloudflareMagicNetworkMonitoringConfiguration), fullyQualifiedName: "cloudflare.dataCloudflareMagicNetworkMonitoringConfiguration.DataCloudflareMagicNetworkMonitoringConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareMagicNetworkMonitoringConfiguration.DataCloudflareMagicNetworkMonitoringConfigurationConfig\"}}]")]
    public class DataCloudflareMagicNetworkMonitoringConfiguration : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/magic_network_monitoring_configuration cloudflare_magic_network_monitoring_configuration} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareMagicNetworkMonitoringConfiguration(Constructs.Construct scope, string id, cloudflare.DataCloudflareMagicNetworkMonitoringConfiguration.IDataCloudflareMagicNetworkMonitoringConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareMagicNetworkMonitoringConfiguration.IDataCloudflareMagicNetworkMonitoringConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareMagicNetworkMonitoringConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareMagicNetworkMonitoringConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareMagicNetworkMonitoringConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareMagicNetworkMonitoringConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareMagicNetworkMonitoringConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareMagicNetworkMonitoringConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareMagicNetworkMonitoringConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/magic_network_monitoring_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareMagicNetworkMonitoringConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareMagicNetworkMonitoringConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareMagicNetworkMonitoringConfiguration.DataCloudflareMagicNetworkMonitoringConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareMagicNetworkMonitoringConfiguration.DataCloudflareMagicNetworkMonitoringConfiguration))!;

        [JsiiProperty(name: "defaultSampling", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultSampling
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routerIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RouterIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "warpDevices", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareMagicNetworkMonitoringConfiguration.DataCloudflareMagicNetworkMonitoringConfigurationWarpDevicesList\"}")]
        public virtual cloudflare.DataCloudflareMagicNetworkMonitoringConfiguration.DataCloudflareMagicNetworkMonitoringConfigurationWarpDevicesList WarpDevices
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareMagicNetworkMonitoringConfiguration.DataCloudflareMagicNetworkMonitoringConfigurationWarpDevicesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
