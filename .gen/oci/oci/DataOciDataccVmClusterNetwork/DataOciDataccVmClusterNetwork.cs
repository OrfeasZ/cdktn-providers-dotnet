using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataccVmClusterNetwork
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/datacc_vm_cluster_network oci_datacc_vm_cluster_network}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataccVmClusterNetwork.DataOciDataccVmClusterNetwork), fullyQualifiedName: "oci.dataOciDataccVmClusterNetwork.DataOciDataccVmClusterNetwork", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataccVmClusterNetwork.DataOciDataccVmClusterNetworkConfig\"}}]")]
    public class DataOciDataccVmClusterNetwork : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/datacc_vm_cluster_network oci_datacc_vm_cluster_network} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataccVmClusterNetwork(Constructs.Construct scope, string id, oci.DataOciDataccVmClusterNetwork.IDataOciDataccVmClusterNetworkConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataccVmClusterNetwork.IDataOciDataccVmClusterNetworkConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataccVmClusterNetwork(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataccVmClusterNetwork(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataccVmClusterNetwork resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataccVmClusterNetwork to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataccVmClusterNetwork that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataccVmClusterNetwork to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataccVmClusterNetwork to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/datacc_vm_cluster_network#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataccVmClusterNetwork that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataccVmClusterNetwork to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataccVmClusterNetwork.DataOciDataccVmClusterNetwork), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataccVmClusterNetwork.DataOciDataccVmClusterNetwork))!;

        [JsiiProperty(name: "associatedResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociatedResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "baseVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseVmClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "consumerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumerType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsServers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "infrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InfrastructureId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isScanEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsScanEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ListenerPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "listenerPortSsl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ListenerPortSsl
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ntpServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NtpServers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "scans", typeJson: "{\"fqn\":\"oci.dataOciDataccVmClusterNetwork.DataOciDataccVmClusterNetworkScansList\"}")]
        public virtual oci.DataOciDataccVmClusterNetwork.DataOciDataccVmClusterNetworkScansList Scans
        {
            get => GetInstanceProperty<oci.DataOciDataccVmClusterNetwork.DataOciDataccVmClusterNetworkScansList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmNetworks", typeJson: "{\"fqn\":\"oci.dataOciDataccVmClusterNetwork.DataOciDataccVmClusterNetworkVmNetworksList\"}")]
        public virtual oci.DataOciDataccVmClusterNetwork.DataOciDataccVmClusterNetworkVmNetworksList VmNetworks
        {
            get => GetInstanceProperty<oci.DataOciDataccVmClusterNetwork.DataOciDataccVmClusterNetworkVmNetworksList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmClusterNetworkIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VmClusterNetworkIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "vmClusterNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmClusterNetworkId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
