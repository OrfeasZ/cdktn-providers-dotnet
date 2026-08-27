using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetComputeDisks")]
    public class CloudBridgeAssetComputeDisks : oci.CloudBridgeAsset.ICloudBridgeAssetComputeDisks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#boot_order CloudBridgeAsset#boot_order}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bootOrder", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BootOrder
        {
            get;
            set;
        }

        private object? _isCbtEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#is_cbt_enabled CloudBridgeAsset#is_cbt_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isCbtEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsCbtEnabled
        {
            get => _isCbtEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isCbtEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#location CloudBridgeAsset#location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Location
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#name CloudBridgeAsset#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#persistent_mode CloudBridgeAsset#persistent_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "persistentMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PersistentMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#size_in_mbs CloudBridgeAsset#size_in_mbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sizeInMbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SizeInMbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#uuid CloudBridgeAsset#uuid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uuid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#uuid_lun CloudBridgeAsset#uuid_lun}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uuidLun", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UuidLun
        {
            get;
            set;
        }
    }
}
