using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplicationIam
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamScalingConfig")]
    public class GenerativeAiHostedApplicationIamScalingConfig : oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamScalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#scaling_type GenerativeAiHostedApplicationIam#scaling_type}.</summary>
        [JsiiProperty(name: "scalingType", typeJson: "{\"primitive\":\"string\"}")]
        public string ScalingType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#max_replica GenerativeAiHostedApplicationIam#max_replica}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxReplica", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxReplica
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#min_replica GenerativeAiHostedApplicationIam#min_replica}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minReplica", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinReplica
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#target_concurrency_threshold GenerativeAiHostedApplicationIam#target_concurrency_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetConcurrencyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetConcurrencyThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#target_cpu_threshold GenerativeAiHostedApplicationIam#target_cpu_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetCpuThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetCpuThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#target_memory_threshold GenerativeAiHostedApplicationIam#target_memory_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetMemoryThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetMemoryThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#target_rps_threshold GenerativeAiHostedApplicationIam#target_rps_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetRpsThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetRpsThreshold
        {
            get;
            set;
        }
    }
}
