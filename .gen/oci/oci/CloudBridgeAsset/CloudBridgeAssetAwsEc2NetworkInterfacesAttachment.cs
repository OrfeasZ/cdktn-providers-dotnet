using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAttachment")]
    public class CloudBridgeAssetAwsEc2NetworkInterfacesAttachment : oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAttachment
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#attachment_key CloudBridgeAsset#attachment_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attachmentKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AttachmentKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#device_index CloudBridgeAsset#device_index}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeviceIndex
        {
            get;
            set;
        }

        private object? _isDeleteOnTermination;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#is_delete_on_termination CloudBridgeAsset#is_delete_on_termination}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#network_card_index CloudBridgeAsset#network_card_index}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkCardIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetworkCardIndex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#status CloudBridgeAsset#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#time_attach CloudBridgeAsset#time_attach}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeAttach", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeAttach
        {
            get;
            set;
        }
    }
}
