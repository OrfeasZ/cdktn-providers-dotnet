using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiByValue(fqn: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsShapeConfig")]
    public class CoreInstanceConfigurationInstanceDetailsLaunchDetailsShapeConfig : oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsShapeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#baseline_ocpu_utilization CoreInstanceConfiguration#baseline_ocpu_utilization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "baselineOcpuUtilization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BaselineOcpuUtilization
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#memory_in_gbs CoreInstanceConfiguration#memory_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#nvmes CoreInstanceConfiguration#nvmes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nvmes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Nvmes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#ocpus CoreInstanceConfiguration#ocpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ocpus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#resource_management CoreInstanceConfiguration#resource_management}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceManagement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceManagement
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#vcpus CoreInstanceConfiguration#vcpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Vcpus
        {
            get;
            set;
        }
    }
}
