using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudBridgeAsset
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/cloud_bridge_asset oci_cloud_bridge_asset}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAsset), fullyQualifiedName: "oci.dataOciCloudBridgeAsset.DataOciCloudBridgeAsset", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciCloudBridgeAsset.DataOciCloudBridgeAssetConfig\"}}]")]
    public class DataOciCloudBridgeAsset : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/cloud_bridge_asset oci_cloud_bridge_asset} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCloudBridgeAsset(Constructs.Construct scope, string id, oci.DataOciCloudBridgeAsset.IDataOciCloudBridgeAssetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCloudBridgeAsset.IDataOciCloudBridgeAssetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudBridgeAsset(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudBridgeAsset(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCloudBridgeAsset resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCloudBridgeAsset to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCloudBridgeAsset that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCloudBridgeAsset to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCloudBridgeAsset to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/cloud_bridge_asset#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCloudBridgeAsset that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCloudBridgeAsset to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAsset), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAsset))!;

        [JsiiProperty(name: "assetSourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AssetSourceIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "assetType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssetType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compute", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAsset.DataOciCloudBridgeAssetComputeList\"}")]
        public virtual oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAssetComputeList Compute
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAssetComputeList>()!;
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

        [JsiiProperty(name: "externalAssetKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalAssetKey
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

        [JsiiProperty(name: "inventoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InventoryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceKey
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "vm", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAsset.DataOciCloudBridgeAssetVmList\"}")]
        public virtual oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAssetVmList Vm
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAssetVmList>()!;
        }

        [JsiiProperty(name: "vmwareVcenter", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAsset.DataOciCloudBridgeAssetVmwareVcenterList\"}")]
        public virtual oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAssetVmwareVcenterList VmwareVcenter
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAssetVmwareVcenterList>()!;
        }

        [JsiiProperty(name: "vmwareVm", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAsset.DataOciCloudBridgeAssetVmwareVmList\"}")]
        public virtual oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAssetVmwareVmList VmwareVm
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAssetVmwareVmList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "assetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "assetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
