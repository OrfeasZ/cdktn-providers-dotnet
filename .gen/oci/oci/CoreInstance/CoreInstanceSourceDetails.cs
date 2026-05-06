using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreInstance.CoreInstanceSourceDetails")]
    public class CoreInstanceSourceDetails : oci.CoreInstance.ICoreInstanceSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#source_type CoreInstance#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#boot_volume_size_in_gbs CoreInstance#boot_volume_size_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bootVolumeSizeInGbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BootVolumeSizeInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#boot_volume_vpus_per_gb CoreInstance#boot_volume_vpus_per_gb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bootVolumeVpusPerGb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BootVolumeVpusPerGb
        {
            get;
            set;
        }

        /// <summary>instance_source_image_filter_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#instance_source_image_filter_details CoreInstance#instance_source_image_filter_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instanceSourceImageFilterDetails", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceSourceDetailsInstanceSourceImageFilterDetails\"}", isOptional: true)]
        public oci.CoreInstance.ICoreInstanceSourceDetailsInstanceSourceImageFilterDetails? InstanceSourceImageFilterDetails
        {
            get;
            set;
        }

        private object? _isPreserveBootVolumeEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#is_preserve_boot_volume_enabled CoreInstance#is_preserve_boot_volume_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isPreserveBootVolumeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsPreserveBootVolumeEnabled
        {
            get => _isPreserveBootVolumeEnabled;
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
                _isPreserveBootVolumeEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#kms_key_id CoreInstance#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#source_id CoreInstance#source_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceId
        {
            get;
            set;
        }
    }
}
