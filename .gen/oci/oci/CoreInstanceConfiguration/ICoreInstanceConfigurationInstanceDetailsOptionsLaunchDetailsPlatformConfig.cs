using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiInterface(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsPlatformConfig), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsPlatformConfig")]
    public interface ICoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsPlatformConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#type CoreInstanceConfiguration#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#are_virtual_instructions_enabled CoreInstanceConfiguration#are_virtual_instructions_enabled}.</summary>
        [JsiiProperty(name: "areVirtualInstructionsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AreVirtualInstructionsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_access_control_service_enabled CoreInstanceConfiguration#is_access_control_service_enabled}.</summary>
        [JsiiProperty(name: "isAccessControlServiceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAccessControlServiceEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_input_output_memory_management_unit_enabled CoreInstanceConfiguration#is_input_output_memory_management_unit_enabled}.</summary>
        [JsiiProperty(name: "isInputOutputMemoryManagementUnitEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsInputOutputMemoryManagementUnitEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_measured_boot_enabled CoreInstanceConfiguration#is_measured_boot_enabled}.</summary>
        [JsiiProperty(name: "isMeasuredBootEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMeasuredBootEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_memory_encryption_enabled CoreInstanceConfiguration#is_memory_encryption_enabled}.</summary>
        [JsiiProperty(name: "isMemoryEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMemoryEncryptionEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_secure_boot_enabled CoreInstanceConfiguration#is_secure_boot_enabled}.</summary>
        [JsiiProperty(name: "isSecureBootEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSecureBootEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_symmetric_multi_threading_enabled CoreInstanceConfiguration#is_symmetric_multi_threading_enabled}.</summary>
        [JsiiProperty(name: "isSymmetricMultiThreadingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSymmetricMultiThreadingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_trusted_platform_module_enabled CoreInstanceConfiguration#is_trusted_platform_module_enabled}.</summary>
        [JsiiProperty(name: "isTrustedPlatformModuleEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsTrustedPlatformModuleEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#numa_nodes_per_socket CoreInstanceConfiguration#numa_nodes_per_socket}.</summary>
        [JsiiProperty(name: "numaNodesPerSocket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NumaNodesPerSocket
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#percentage_of_cores_enabled CoreInstanceConfiguration#percentage_of_cores_enabled}.</summary>
        [JsiiProperty(name: "percentageOfCoresEnabled", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PercentageOfCoresEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsPlatformConfig), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsPlatformConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsPlatformConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#type CoreInstanceConfiguration#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#are_virtual_instructions_enabled CoreInstanceConfiguration#are_virtual_instructions_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "areVirtualInstructionsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AreVirtualInstructionsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_access_control_service_enabled CoreInstanceConfiguration#is_access_control_service_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isAccessControlServiceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAccessControlServiceEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_input_output_memory_management_unit_enabled CoreInstanceConfiguration#is_input_output_memory_management_unit_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isInputOutputMemoryManagementUnitEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsInputOutputMemoryManagementUnitEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_measured_boot_enabled CoreInstanceConfiguration#is_measured_boot_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isMeasuredBootEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMeasuredBootEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_memory_encryption_enabled CoreInstanceConfiguration#is_memory_encryption_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isMemoryEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMemoryEncryptionEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_secure_boot_enabled CoreInstanceConfiguration#is_secure_boot_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isSecureBootEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSecureBootEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_symmetric_multi_threading_enabled CoreInstanceConfiguration#is_symmetric_multi_threading_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isSymmetricMultiThreadingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSymmetricMultiThreadingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_trusted_platform_module_enabled CoreInstanceConfiguration#is_trusted_platform_module_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isTrustedPlatformModuleEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsTrustedPlatformModuleEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#numa_nodes_per_socket CoreInstanceConfiguration#numa_nodes_per_socket}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numaNodesPerSocket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NumaNodesPerSocket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#percentage_of_cores_enabled CoreInstanceConfiguration#percentage_of_cores_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "percentageOfCoresEnabled", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PercentageOfCoresEnabled
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
