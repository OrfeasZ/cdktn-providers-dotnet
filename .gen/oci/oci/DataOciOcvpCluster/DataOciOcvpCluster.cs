using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOcvpCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/ocvp_cluster oci_ocvp_cluster}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOcvpCluster.DataOciOcvpCluster), fullyQualifiedName: "oci.dataOciOcvpCluster.DataOciOcvpCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOcvpCluster.DataOciOcvpClusterConfig\"}}]")]
    public class DataOciOcvpCluster : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/ocvp_cluster oci_ocvp_cluster} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOcvpCluster(Constructs.Construct scope, string id, oci.DataOciOcvpCluster.IDataOciOcvpClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOcvpCluster.IDataOciOcvpClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOcvpCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOcvpCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOcvpCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOcvpCluster to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOcvpCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOcvpCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOcvpCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/ocvp_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOcvpCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOcvpCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOcvpCluster.DataOciOcvpCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciOcvpCluster.DataOciOcvpCluster))!;

        [JsiiProperty(name: "actualEsxiHostsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ActualEsxiHostsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "attachDatastoreClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttachDatastoreClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeAvailabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeAvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "datastoreClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DatastoreClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "datastores", typeJson: "{\"fqn\":\"oci.dataOciOcvpCluster.DataOciOcvpClusterDatastoresList\"}")]
        public virtual oci.DataOciOcvpCluster.DataOciOcvpClusterDatastoresList Datastores
        {
            get => GetInstanceProperty<oci.DataOciOcvpCluster.DataOciOcvpClusterDatastoresList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "detachDatastoreClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DetachDatastoreClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "esxiHostsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EsxiHostsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "esxiSoftwareVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EsxiSoftwareVersion
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "initialCommitment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InitialCommitment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "initialHostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InitialHostOcpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "initialHostShapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InitialHostShapeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceDisplayNamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceDisplayNamePrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isShieldedInstanceEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsShieldedInstanceEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"oci.dataOciOcvpCluster.DataOciOcvpClusterNetworkConfigurationList\"}")]
        public virtual oci.DataOciOcvpCluster.DataOciOcvpClusterNetworkConfigurationList NetworkConfiguration
        {
            get => GetInstanceProperty<oci.DataOciOcvpCluster.DataOciOcvpClusterNetworkConfigurationList>()!;
        }

        [JsiiProperty(name: "sddcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SddcId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "upgradeLicenses", typeJson: "{\"fqn\":\"oci.dataOciOcvpCluster.DataOciOcvpClusterUpgradeLicensesList\"}")]
        public virtual oci.DataOciOcvpCluster.DataOciOcvpClusterUpgradeLicensesList UpgradeLicenses
        {
            get => GetInstanceProperty<oci.DataOciOcvpCluster.DataOciOcvpClusterUpgradeLicensesList>()!;
        }

        [JsiiProperty(name: "vmwareSoftwareVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmwareSoftwareVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vsphereType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VsphereType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vsphereUpgradeObjects", typeJson: "{\"fqn\":\"oci.dataOciOcvpCluster.DataOciOcvpClusterVsphereUpgradeObjectsList\"}")]
        public virtual oci.DataOciOcvpCluster.DataOciOcvpClusterVsphereUpgradeObjectsList VsphereUpgradeObjects
        {
            get => GetInstanceProperty<oci.DataOciOcvpCluster.DataOciOcvpClusterVsphereUpgradeObjectsList>()!;
        }

        [JsiiProperty(name: "workloadNetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkloadNetworkCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
