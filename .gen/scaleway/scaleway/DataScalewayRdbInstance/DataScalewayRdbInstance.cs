using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayRdbInstance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/rdb_instance scaleway_rdb_instance}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayRdbInstance.DataScalewayRdbInstance), fullyQualifiedName: "scaleway.dataScalewayRdbInstance.DataScalewayRdbInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"scaleway.dataScalewayRdbInstance.DataScalewayRdbInstanceConfig\"}}]")]
    public class DataScalewayRdbInstance : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/rdb_instance scaleway_rdb_instance} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataScalewayRdbInstance(Constructs.Construct scope, string id, scaleway.DataScalewayRdbInstance.IDataScalewayRdbInstanceConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.DataScalewayRdbInstance.IDataScalewayRdbInstanceConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayRdbInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayRdbInstance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataScalewayRdbInstance resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataScalewayRdbInstance to import.</param>
        /// <param name="importFromId">The id of the existing DataScalewayRdbInstance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataScalewayRdbInstance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataScalewayRdbInstance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/rdb_instance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataScalewayRdbInstance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataScalewayRdbInstance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.DataScalewayRdbInstance.DataScalewayRdbInstance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceId")]
        public virtual void ResetInstanceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProjectId")]
        public virtual void ResetProjectId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
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
        = GetStaticProperty<string>(typeof(scaleway.DataScalewayRdbInstance.DataScalewayRdbInstance))!;

        [JsiiProperty(name: "backupSameRegion", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable BackupSameRegion
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "backupScheduleFrequency", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupScheduleFrequency
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "backupScheduleRetention", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupScheduleRetention
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Certificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disableBackup", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DisableBackup
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "encryptionAtRest", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EncryptionAtRest
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "endpointIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EndpointPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Engine
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "initSettings", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap InitSettings
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "isHaCluster", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHaCluster
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "loadBalancer", typeJson: "{\"fqn\":\"scaleway.dataScalewayRdbInstance.DataScalewayRdbInstanceLoadBalancerList\"}")]
        public virtual scaleway.DataScalewayRdbInstance.DataScalewayRdbInstanceLoadBalancerList LoadBalancer
        {
            get => GetInstanceProperty<scaleway.DataScalewayRdbInstance.DataScalewayRdbInstanceLoadBalancerList>()!;
        }

        [JsiiProperty(name: "logsPolicy", typeJson: "{\"fqn\":\"scaleway.dataScalewayRdbInstance.DataScalewayRdbInstanceLogsPolicyList\"}")]
        public virtual scaleway.DataScalewayRdbInstance.DataScalewayRdbInstanceLogsPolicyList LogsPolicy
        {
            get => GetInstanceProperty<scaleway.DataScalewayRdbInstance.DataScalewayRdbInstanceLogsPolicyList>()!;
        }

        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordWo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordWo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordWoVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PasswordWoVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "privateIp", typeJson: "{\"fqn\":\"scaleway.dataScalewayRdbInstance.DataScalewayRdbInstancePrivateIpList\"}")]
        public virtual scaleway.DataScalewayRdbInstance.DataScalewayRdbInstancePrivateIpList PrivateIp
        {
            get => GetInstanceProperty<scaleway.DataScalewayRdbInstance.DataScalewayRdbInstancePrivateIpList>()!;
        }

        [JsiiProperty(name: "privateNetwork", typeJson: "{\"fqn\":\"scaleway.dataScalewayRdbInstance.DataScalewayRdbInstancePrivateNetworkList\"}")]
        public virtual scaleway.DataScalewayRdbInstance.DataScalewayRdbInstancePrivateNetworkList PrivateNetwork
        {
            get => GetInstanceProperty<scaleway.DataScalewayRdbInstance.DataScalewayRdbInstancePrivateNetworkList>()!;
        }

        [JsiiProperty(name: "readReplicas", typeJson: "{\"fqn\":\"scaleway.dataScalewayRdbInstance.DataScalewayRdbInstanceReadReplicasList\"}")]
        public virtual scaleway.DataScalewayRdbInstance.DataScalewayRdbInstanceReadReplicasList ReadReplicas
        {
            get => GetInstanceProperty<scaleway.DataScalewayRdbInstance.DataScalewayRdbInstanceReadReplicasList>()!;
        }

        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Settings
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnapshotId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "upgradableVersions", typeJson: "{\"fqn\":\"scaleway.dataScalewayRdbInstance.DataScalewayRdbInstanceUpgradableVersionsList\"}")]
        public virtual scaleway.DataScalewayRdbInstance.DataScalewayRdbInstanceUpgradableVersionsList UpgradableVersions
        {
            get => GetInstanceProperty<scaleway.DataScalewayRdbInstance.DataScalewayRdbInstanceUpgradableVersionsList>()!;
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VolumeSizeInGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceIdInput
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
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceId
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

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
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
    }
}
