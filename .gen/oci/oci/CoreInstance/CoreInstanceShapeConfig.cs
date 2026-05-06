using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstance
{
    [JsiiByValue(fqn: "oci.coreInstance.CoreInstanceShapeConfig")]
    public class CoreInstanceShapeConfig : oci.CoreInstance.ICoreInstanceShapeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#baseline_ocpu_utilization CoreInstance#baseline_ocpu_utilization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "baselineOcpuUtilization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BaselineOcpuUtilization
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#memory_in_gbs CoreInstance#memory_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#nvmes CoreInstance#nvmes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nvmes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Nvmes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#ocpus CoreInstance#ocpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ocpus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#resource_management CoreInstance#resource_management}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceManagement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceManagement
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#vcpus CoreInstance#vcpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Vcpus
        {
            get;
            set;
        }
    }
}
