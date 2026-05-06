using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiInterface(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptions), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptions")]
    public interface ICoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#boot_volume_type CoreInstanceConfiguration#boot_volume_type}.</summary>
        [JsiiProperty(name: "bootVolumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BootVolumeType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#firmware CoreInstanceConfiguration#firmware}.</summary>
        [JsiiProperty(name: "firmware", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Firmware
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_consistent_volume_naming_enabled CoreInstanceConfiguration#is_consistent_volume_naming_enabled}.</summary>
        [JsiiProperty(name: "isConsistentVolumeNamingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsConsistentVolumeNamingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_pv_encryption_in_transit_enabled CoreInstanceConfiguration#is_pv_encryption_in_transit_enabled}.</summary>
        [JsiiProperty(name: "isPvEncryptionInTransitEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsPvEncryptionInTransitEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#network_type CoreInstanceConfiguration#network_type}.</summary>
        [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#remote_data_volume_type CoreInstanceConfiguration#remote_data_volume_type}.</summary>
        [JsiiProperty(name: "remoteDataVolumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RemoteDataVolumeType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptions), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptions")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#boot_volume_type CoreInstanceConfiguration#boot_volume_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bootVolumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BootVolumeType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#firmware CoreInstanceConfiguration#firmware}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firmware", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Firmware
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_consistent_volume_naming_enabled CoreInstanceConfiguration#is_consistent_volume_naming_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isConsistentVolumeNamingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsConsistentVolumeNamingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_pv_encryption_in_transit_enabled CoreInstanceConfiguration#is_pv_encryption_in_transit_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isPvEncryptionInTransitEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsPvEncryptionInTransitEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#network_type CoreInstanceConfiguration#network_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#remote_data_volume_type CoreInstanceConfiguration#remote_data_volume_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "remoteDataVolumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RemoteDataVolumeType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
