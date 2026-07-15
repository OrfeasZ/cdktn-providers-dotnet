using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreInstanceConfiguration.CoreInstanceConfigurationGmcConfigs")]
    public class CoreInstanceConfigurationGmcConfigs : oci.CoreInstanceConfiguration.ICoreInstanceConfigurationGmcConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/core_instance_configuration#availability_domain CoreInstanceConfiguration#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public string AvailabilityDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/core_instance_configuration#compartment_id CoreInstanceConfiguration#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public string CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/core_instance_configuration#instance_configuration_id CoreInstanceConfiguration#instance_configuration_id}.</summary>
        [JsiiProperty(name: "instanceConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceConfigurationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/core_instance_configuration#defined_tags CoreInstanceConfiguration#defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/core_instance_configuration#display_name CoreInstanceConfiguration#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/core_instance_configuration#freeform_tags CoreInstanceConfiguration#freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get;
            set;
        }

        /// <summary>gpu_memory_cluster_scale_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/core_instance_configuration#gpu_memory_cluster_scale_config CoreInstanceConfiguration#gpu_memory_cluster_scale_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gpuMemoryClusterScaleConfig", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationGmcConfigsGpuMemoryClusterScaleConfig\"}", isOptional: true)]
        public oci.CoreInstanceConfiguration.ICoreInstanceConfigurationGmcConfigsGpuMemoryClusterScaleConfig? GpuMemoryClusterScaleConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/core_instance_configuration#size CoreInstanceConfiguration#size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Size
        {
            get;
            set;
        }
    }
}
