using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEbsAttachments")]
    public class CloudBridgeAssetAwsEbsAttachments : oci.CloudBridgeAsset.ICloudBridgeAssetAwsEbsAttachments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/cloud_bridge_asset#device CloudBridgeAsset#device}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "device", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Device
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/cloud_bridge_asset#instance_key CloudBridgeAsset#instance_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceKey
        {
            get;
            set;
        }

        private object? _isDeleteOnTermination;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/cloud_bridge_asset#is_delete_on_termination CloudBridgeAsset#is_delete_on_termination}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isDeleteOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsDeleteOnTermination
        {
            get => _isDeleteOnTermination;
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
                _isDeleteOnTermination = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/cloud_bridge_asset#status CloudBridgeAsset#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/cloud_bridge_asset#volume_key CloudBridgeAsset#volume_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeKey
        {
            get;
            set;
        }
    }
}
