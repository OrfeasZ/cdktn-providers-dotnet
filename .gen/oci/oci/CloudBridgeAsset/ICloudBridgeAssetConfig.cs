using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiInterface(nativeType: typeof(ICloudBridgeAssetConfig), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetConfig")]
    public interface ICloudBridgeAssetConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#asset_type CloudBridgeAsset#asset_type}.</summary>
        [JsiiProperty(name: "assetType", typeJson: "{\"primitive\":\"string\"}")]
        string AssetType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#compartment_id CloudBridgeAsset#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#external_asset_key CloudBridgeAsset#external_asset_key}.</summary>
        [JsiiProperty(name: "externalAssetKey", typeJson: "{\"primitive\":\"string\"}")]
        string ExternalAssetKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#inventory_id CloudBridgeAsset#inventory_id}.</summary>
        [JsiiProperty(name: "inventoryId", typeJson: "{\"primitive\":\"string\"}")]
        string InventoryId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#source_key CloudBridgeAsset#source_key}.</summary>
        [JsiiProperty(name: "sourceKey", typeJson: "{\"primitive\":\"string\"}")]
        string SourceKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#asset_source_ids CloudBridgeAsset#asset_source_ids}.</summary>
        [JsiiProperty(name: "assetSourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AssetSourceIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>compute block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#compute CloudBridgeAsset#compute}
        /// </remarks>
        [JsiiProperty(name: "compute", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetCompute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudBridgeAsset.ICloudBridgeAssetCompute? Compute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#defined_tags CloudBridgeAsset#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#display_name CloudBridgeAsset#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#freeform_tags CloudBridgeAsset#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#id CloudBridgeAsset#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#timeouts CloudBridgeAsset#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudBridgeAsset.ICloudBridgeAssetTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>vm block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#vm CloudBridgeAsset#vm}
        /// </remarks>
        [JsiiProperty(name: "vm", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudBridgeAsset.ICloudBridgeAssetVm? Vm
        {
            get
            {
                return null;
            }
        }

        /// <summary>vmware_vcenter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#vmware_vcenter CloudBridgeAsset#vmware_vcenter}
        /// </remarks>
        [JsiiProperty(name: "vmwareVcenter", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVmwareVcenter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVcenter? VmwareVcenter
        {
            get
            {
                return null;
            }
        }

        /// <summary>vmware_vm block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#vmware_vm CloudBridgeAsset#vmware_vm}
        /// </remarks>
        [JsiiProperty(name: "vmwareVm", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVmwareVm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVm? VmwareVm
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudBridgeAssetConfig), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CloudBridgeAsset.ICloudBridgeAssetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#asset_type CloudBridgeAsset#asset_type}.</summary>
            [JsiiProperty(name: "assetType", typeJson: "{\"primitive\":\"string\"}")]
            public string AssetType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#compartment_id CloudBridgeAsset#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#external_asset_key CloudBridgeAsset#external_asset_key}.</summary>
            [JsiiProperty(name: "externalAssetKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ExternalAssetKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#inventory_id CloudBridgeAsset#inventory_id}.</summary>
            [JsiiProperty(name: "inventoryId", typeJson: "{\"primitive\":\"string\"}")]
            public string InventoryId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#source_key CloudBridgeAsset#source_key}.</summary>
            [JsiiProperty(name: "sourceKey", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#asset_source_ids CloudBridgeAsset#asset_source_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "assetSourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AssetSourceIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>compute block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#compute CloudBridgeAsset#compute}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compute", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetCompute\"}", isOptional: true)]
            public oci.CloudBridgeAsset.ICloudBridgeAssetCompute? Compute
            {
                get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetCompute?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#defined_tags CloudBridgeAsset#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#display_name CloudBridgeAsset#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#freeform_tags CloudBridgeAsset#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#id CloudBridgeAsset#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#timeouts CloudBridgeAsset#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetTimeouts\"}", isOptional: true)]
            public oci.CloudBridgeAsset.ICloudBridgeAssetTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetTimeouts?>();
            }

            /// <summary>vm block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#vm CloudBridgeAsset#vm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vm", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVm\"}", isOptional: true)]
            public oci.CloudBridgeAsset.ICloudBridgeAssetVm? Vm
            {
                get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetVm?>();
            }

            /// <summary>vmware_vcenter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#vmware_vcenter CloudBridgeAsset#vmware_vcenter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vmwareVcenter", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVmwareVcenter\"}", isOptional: true)]
            public oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVcenter? VmwareVcenter
            {
                get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVcenter?>();
            }

            /// <summary>vmware_vm block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#vmware_vm CloudBridgeAsset#vmware_vm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vmwareVm", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVmwareVm\"}", isOptional: true)]
            public oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVm? VmwareVm
            {
                get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVm?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
