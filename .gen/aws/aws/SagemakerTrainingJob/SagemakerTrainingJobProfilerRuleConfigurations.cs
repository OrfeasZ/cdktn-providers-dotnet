using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobProfilerRuleConfigurations")]
    public class SagemakerTrainingJobProfilerRuleConfigurations : aws.SagemakerTrainingJob.ISagemakerTrainingJobProfilerRuleConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#rule_configuration_name SagemakerTrainingJob#rule_configuration_name}.</summary>
        [JsiiProperty(name: "ruleConfigurationName", typeJson: "{\"primitive\":\"string\"}")]
        public string RuleConfigurationName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#rule_evaluator_image SagemakerTrainingJob#rule_evaluator_image}.</summary>
        [JsiiProperty(name: "ruleEvaluatorImage", typeJson: "{\"primitive\":\"string\"}")]
        public string RuleEvaluatorImage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#instance_type SagemakerTrainingJob#instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#local_path SagemakerTrainingJob#local_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#rule_parameters SagemakerTrainingJob#rule_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ruleParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? RuleParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#s3_output_path SagemakerTrainingJob#s3_output_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3OutputPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#volume_size_in_gb SagemakerTrainingJob#volume_size_in_gb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VolumeSizeInGb
        {
            get;
            set;
        }
    }
}
