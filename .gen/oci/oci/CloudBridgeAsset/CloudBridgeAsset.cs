using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset oci_cloud_bridge_asset}.</summary>
    [JsiiClass(nativeType: typeof(oci.CloudBridgeAsset.CloudBridgeAsset), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAsset", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetConfig\"}}]")]
    public class CloudBridgeAsset : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset oci_cloud_bridge_asset} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudBridgeAsset(Constructs.Construct scope, string id, oci.CloudBridgeAsset.ICloudBridgeAssetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.CloudBridgeAsset.ICloudBridgeAssetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudBridgeAsset(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudBridgeAsset(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a CloudBridgeAsset resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CloudBridgeAsset to import.</param>
        /// <param name="importFromId">The id of the existing CloudBridgeAsset that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CloudBridgeAsset to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CloudBridgeAsset to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CloudBridgeAsset that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CloudBridgeAsset to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.CloudBridgeAsset.CloudBridgeAsset), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCompute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetCompute\"}}]")]
        public virtual void PutCompute(oci.CloudBridgeAsset.ICloudBridgeAssetCompute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudBridgeAsset.ICloudBridgeAssetCompute)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.CloudBridgeAsset.ICloudBridgeAssetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudBridgeAsset.ICloudBridgeAssetTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVm\"}}]")]
        public virtual void PutVm(oci.CloudBridgeAsset.ICloudBridgeAssetVm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudBridgeAsset.ICloudBridgeAssetVm)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVmwareVcenter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVmwareVcenter\"}}]")]
        public virtual void PutVmwareVcenter(oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVcenter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVcenter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVmwareVm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVmwareVm\"}}]")]
        public virtual void PutVmwareVm(oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVm)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAssetSourceIds")]
        public virtual void ResetAssetSourceIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompute")]
        public virtual void ResetCompute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVm")]
        public virtual void ResetVm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVmwareVcenter")]
        public virtual void ResetVmwareVcenter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVmwareVm")]
        public virtual void ResetVmwareVm()
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
        = GetStaticProperty<string>(typeof(oci.CloudBridgeAsset.CloudBridgeAsset))!;

        [JsiiProperty(name: "compute", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeOutputReference\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetComputeOutputReference Compute
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetComputeOutputReference>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetTimeoutsOutputReference\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vm", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVmOutputReference\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetVmOutputReference Vm
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetVmOutputReference>()!;
        }

        [JsiiProperty(name: "vmwareVcenter", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVmwareVcenterOutputReference\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetVmwareVcenterOutputReference VmwareVcenter
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetVmwareVcenterOutputReference>()!;
        }

        [JsiiProperty(name: "vmwareVm", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVmwareVmOutputReference\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetVmwareVmOutputReference VmwareVm
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetVmwareVmOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "assetSourceIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AssetSourceIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "assetTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssetTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeInput", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetCompute\"}", isOptional: true)]
        public virtual oci.CloudBridgeAsset.ICloudBridgeAssetCompute? ComputeInput
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetCompute?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalAssetKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExternalAssetKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inventoryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InventoryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmInput", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVm\"}", isOptional: true)]
        public virtual oci.CloudBridgeAsset.ICloudBridgeAssetVm? VmInput
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetVm?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmwareVcenterInput", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVmwareVcenter\"}", isOptional: true)]
        public virtual oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVcenter? VmwareVcenterInput
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVcenter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmwareVmInput", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVmwareVm\"}", isOptional: true)]
        public virtual oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVm? VmwareVmInput
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVm?>();
        }

        [JsiiProperty(name: "assetSourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AssetSourceIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "assetType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssetType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "externalAssetKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalAssetKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inventoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InventoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
