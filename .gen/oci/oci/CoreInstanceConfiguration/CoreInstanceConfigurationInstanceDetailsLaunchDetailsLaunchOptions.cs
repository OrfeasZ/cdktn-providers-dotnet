using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiByValue(fqn: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptions")]
    public class CoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptions : oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#boot_volume_type CoreInstanceConfiguration#boot_volume_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bootVolumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BootVolumeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#firmware CoreInstanceConfiguration#firmware}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firmware", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Firmware
        {
            get;
            set;
        }

        private object? _isConsistentVolumeNamingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_consistent_volume_naming_enabled CoreInstanceConfiguration#is_consistent_volume_naming_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isConsistentVolumeNamingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsConsistentVolumeNamingEnabled
        {
            get => _isConsistentVolumeNamingEnabled;
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
                _isConsistentVolumeNamingEnabled = value;
            }
        }

        private object? _isPvEncryptionInTransitEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_pv_encryption_in_transit_enabled CoreInstanceConfiguration#is_pv_encryption_in_transit_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isPvEncryptionInTransitEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsPvEncryptionInTransitEnabled
        {
            get => _isPvEncryptionInTransitEnabled;
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
                _isPvEncryptionInTransitEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#network_type CoreInstanceConfiguration#network_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#remote_data_volume_type CoreInstanceConfiguration#remote_data_volume_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "remoteDataVolumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RemoteDataVolumeType
        {
            get;
            set;
        }
    }
}
