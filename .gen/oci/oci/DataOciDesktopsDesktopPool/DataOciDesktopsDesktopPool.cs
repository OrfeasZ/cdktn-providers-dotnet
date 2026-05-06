using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDesktopsDesktopPool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/desktops_desktop_pool oci_desktops_desktop_pool}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDesktopsDesktopPool.DataOciDesktopsDesktopPool), fullyQualifiedName: "oci.dataOciDesktopsDesktopPool.DataOciDesktopsDesktopPool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolConfig\"}}]")]
    public class DataOciDesktopsDesktopPool : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/desktops_desktop_pool oci_desktops_desktop_pool} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDesktopsDesktopPool(Constructs.Construct scope, string id, oci.DataOciDesktopsDesktopPool.IDataOciDesktopsDesktopPoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDesktopsDesktopPool.IDataOciDesktopsDesktopPoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDesktopsDesktopPool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDesktopsDesktopPool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDesktopsDesktopPool resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDesktopsDesktopPool to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDesktopsDesktopPool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDesktopsDesktopPool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDesktopsDesktopPool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/desktops_desktop_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDesktopsDesktopPool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDesktopsDesktopPool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDesktopsDesktopPool.DataOciDesktopsDesktopPool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDesktopsDesktopPool.DataOciDesktopsDesktopPool))!;

        [JsiiProperty(name: "activeDesktops", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ActiveDesktops
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "arePrivilegedUsers", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ArePrivilegedUsers
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "areVolumesPreserved", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AreVolumesPreserved
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityPolicy", typeJson: "{\"fqn\":\"oci.dataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolAvailabilityPolicyList\"}")]
        public virtual oci.DataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolAvailabilityPolicyList AvailabilityPolicy
        {
            get => GetInstanceProperty<oci.DataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolAvailabilityPolicyList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "contactDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContactDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "devicePolicy", typeJson: "{\"fqn\":\"oci.dataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolDevicePolicyList\"}")]
        public virtual oci.DataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolDevicePolicyList DevicePolicy
        {
            get => GetInstanceProperty<oci.DataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolDevicePolicyList>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "image", typeJson: "{\"fqn\":\"oci.dataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolImageList\"}")]
        public virtual oci.DataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolImageList Image
        {
            get => GetInstanceProperty<oci.DataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolImageList>()!;
        }

        [JsiiProperty(name: "isStorageEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsStorageEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "maximumSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolNetworkConfigurationList\"}")]
        public virtual oci.DataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolNetworkConfigurationList NetworkConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolNetworkConfigurationList>()!;
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "privateAccessDetails", typeJson: "{\"fqn\":\"oci.dataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolPrivateAccessDetailsList\"}")]
        public virtual oci.DataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolPrivateAccessDetailsList PrivateAccessDetails
        {
            get => GetInstanceProperty<oci.DataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolPrivateAccessDetailsList>()!;
        }

        [JsiiProperty(name: "sessionLifecycleActions", typeJson: "{\"fqn\":\"oci.dataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolSessionLifecycleActionsList\"}")]
        public virtual oci.DataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolSessionLifecycleActionsList SessionLifecycleActions
        {
            get => GetInstanceProperty<oci.DataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolSessionLifecycleActionsList>()!;
        }

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.dataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolShapeConfigList\"}")]
        public virtual oci.DataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolShapeConfigList ShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciDesktopsDesktopPool.DataOciDesktopsDesktopPoolShapeConfigList>()!;
        }

        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShapeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "standbySize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StandbySize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageBackupPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageBackupPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStartScheduled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStartScheduled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStopScheduled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStopScheduled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "useDedicatedVmHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UseDedicatedVmHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "desktopPoolIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DesktopPoolIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "desktopPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DesktopPoolId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
