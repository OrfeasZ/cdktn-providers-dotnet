using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetConfig")]
    public class CloudBridgeAssetConfig : oci.CloudBridgeAsset.ICloudBridgeAssetConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#asset_type CloudBridgeAsset#asset_type}.</summary>
        [JsiiProperty(name: "assetType", typeJson: "{\"primitive\":\"string\"}")]
        public string AssetType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#compartment_id CloudBridgeAsset#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public string CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#external_asset_key CloudBridgeAsset#external_asset_key}.</summary>
        [JsiiProperty(name: "externalAssetKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ExternalAssetKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#inventory_id CloudBridgeAsset#inventory_id}.</summary>
        [JsiiProperty(name: "inventoryId", typeJson: "{\"primitive\":\"string\"}")]
        public string InventoryId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#source_key CloudBridgeAsset#source_key}.</summary>
        [JsiiProperty(name: "sourceKey", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#asset_class_name CloudBridgeAsset#asset_class_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "assetClassName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AssetClassName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#asset_class_version CloudBridgeAsset#asset_class_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "assetClassVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AssetClassVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#asset_details CloudBridgeAsset#asset_details}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "assetDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AssetDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#asset_source_ids CloudBridgeAsset#asset_source_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "assetSourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AssetSourceIds
        {
            get;
            set;
        }

        /// <summary>attached_ebs_volumes_cost block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#attached_ebs_volumes_cost CloudBridgeAsset#attached_ebs_volumes_cost}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attachedEbsVolumesCost", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAttachedEbsVolumesCost\"}", isOptional: true)]
        public oci.CloudBridgeAsset.ICloudBridgeAssetAttachedEbsVolumesCost? AttachedEbsVolumesCost
        {
            get;
            set;
        }

        /// <summary>aws_ebs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#aws_ebs CloudBridgeAsset#aws_ebs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsEbs", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEbs\"}", isOptional: true)]
        public oci.CloudBridgeAsset.ICloudBridgeAssetAwsEbs? AwsEbs
        {
            get;
            set;
        }

        /// <summary>aws_ec2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#aws_ec2 CloudBridgeAsset#aws_ec2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsEc2", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2\"}", isOptional: true)]
        public oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2? AwsEc2
        {
            get;
            set;
        }

        /// <summary>aws_ec2cost block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#aws_ec2cost CloudBridgeAsset#aws_ec2cost}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsEc2Cost", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2Cost\"}", isOptional: true)]
        public oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Cost? AwsEc2Cost
        {
            get;
            set;
        }

        /// <summary>compute block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#compute CloudBridgeAsset#compute}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "compute", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetCompute\"}", isOptional: true)]
        public oci.CloudBridgeAsset.ICloudBridgeAssetCompute? Compute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#defined_tags CloudBridgeAsset#defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#display_name CloudBridgeAsset#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#freeform_tags CloudBridgeAsset#freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#id CloudBridgeAsset#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#timeouts CloudBridgeAsset#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetTimeouts\"}", isOptional: true)]
        public oci.CloudBridgeAsset.ICloudBridgeAssetTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>vm block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#vm CloudBridgeAsset#vm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vm", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVm\"}", isOptional: true)]
        public oci.CloudBridgeAsset.ICloudBridgeAssetVm? Vm
        {
            get;
            set;
        }

        /// <summary>vmware_vcenter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#vmware_vcenter CloudBridgeAsset#vmware_vcenter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vmwareVcenter", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVmwareVcenter\"}", isOptional: true)]
        public oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVcenter? VmwareVcenter
        {
            get;
            set;
        }

        /// <summary>vmware_vm block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/cloud_bridge_asset#vmware_vm CloudBridgeAsset#vmware_vm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vmwareVm", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVmwareVm\"}", isOptional: true)]
        public oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVm? VmwareVm
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
