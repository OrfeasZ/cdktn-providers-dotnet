using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiInterface(nativeType: typeof(ICoreInstanceConfigurationGmcConfigs), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationGmcConfigs")]
    public interface ICoreInstanceConfigurationGmcConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_instance_configuration#availability_domain CoreInstanceConfiguration#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        string AvailabilityDomain
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_instance_configuration#compartment_id CoreInstanceConfiguration#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_instance_configuration#instance_configuration_id CoreInstanceConfiguration#instance_configuration_id}.</summary>
        [JsiiProperty(name: "instanceConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceConfigurationId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_instance_configuration#defined_tags CoreInstanceConfiguration#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_instance_configuration#display_name CoreInstanceConfiguration#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_instance_configuration#freeform_tags CoreInstanceConfiguration#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>gpu_memory_cluster_scale_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_instance_configuration#gpu_memory_cluster_scale_config CoreInstanceConfiguration#gpu_memory_cluster_scale_config}
        /// </remarks>
        [JsiiProperty(name: "gpuMemoryClusterScaleConfig", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationGmcConfigsGpuMemoryClusterScaleConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreInstanceConfiguration.ICoreInstanceConfigurationGmcConfigsGpuMemoryClusterScaleConfig? GpuMemoryClusterScaleConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_instance_configuration#size CoreInstanceConfiguration#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Size
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstanceConfigurationGmcConfigs), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationGmcConfigs")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstanceConfiguration.ICoreInstanceConfigurationGmcConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_instance_configuration#availability_domain CoreInstanceConfiguration#availability_domain}.</summary>
            [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
            public string AvailabilityDomain
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_instance_configuration#compartment_id CoreInstanceConfiguration#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_instance_configuration#instance_configuration_id CoreInstanceConfiguration#instance_configuration_id}.</summary>
            [JsiiProperty(name: "instanceConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceConfigurationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_instance_configuration#defined_tags CoreInstanceConfiguration#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_instance_configuration#display_name CoreInstanceConfiguration#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_instance_configuration#freeform_tags CoreInstanceConfiguration#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>gpu_memory_cluster_scale_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_instance_configuration#gpu_memory_cluster_scale_config CoreInstanceConfiguration#gpu_memory_cluster_scale_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gpuMemoryClusterScaleConfig", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationGmcConfigsGpuMemoryClusterScaleConfig\"}", isOptional: true)]
            public oci.CoreInstanceConfiguration.ICoreInstanceConfigurationGmcConfigsGpuMemoryClusterScaleConfig? GpuMemoryClusterScaleConfig
            {
                get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationGmcConfigsGpuMemoryClusterScaleConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_instance_configuration#size CoreInstanceConfiguration#size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Size
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
