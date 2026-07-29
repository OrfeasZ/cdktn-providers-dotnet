using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationScalingConfig")]
    public class GenerativeAiHostedApplicationScalingConfig : oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationScalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_hosted_application#scaling_type GenerativeAiHostedApplication#scaling_type}.</summary>
        [JsiiProperty(name: "scalingType", typeJson: "{\"primitive\":\"string\"}")]
        public string ScalingType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_hosted_application#max_replica GenerativeAiHostedApplication#max_replica}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxReplica", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxReplica
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_hosted_application#min_replica GenerativeAiHostedApplication#min_replica}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minReplica", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinReplica
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_hosted_application#target_concurrency_threshold GenerativeAiHostedApplication#target_concurrency_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetConcurrencyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetConcurrencyThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_hosted_application#target_cpu_threshold GenerativeAiHostedApplication#target_cpu_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetCpuThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetCpuThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_hosted_application#target_memory_threshold GenerativeAiHostedApplication#target_memory_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetMemoryThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetMemoryThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_hosted_application#target_rps_threshold GenerativeAiHostedApplication#target_rps_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetRpsThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetRpsThreshold
        {
            get;
            set;
        }
    }
}
