using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobDebugRuleConfigurations), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobDebugRuleConfigurations")]
    public interface ISagemakerTrainingJobDebugRuleConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#rule_configuration_name SagemakerTrainingJob#rule_configuration_name}.</summary>
        [JsiiProperty(name: "ruleConfigurationName", typeJson: "{\"primitive\":\"string\"}")]
        string RuleConfigurationName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#rule_evaluator_image SagemakerTrainingJob#rule_evaluator_image}.</summary>
        [JsiiProperty(name: "ruleEvaluatorImage", typeJson: "{\"primitive\":\"string\"}")]
        string RuleEvaluatorImage
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#instance_type SagemakerTrainingJob#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#local_path SagemakerTrainingJob#local_path}.</summary>
        [JsiiProperty(name: "localPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LocalPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#rule_parameters SagemakerTrainingJob#rule_parameters}.</summary>
        [JsiiProperty(name: "ruleParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? RuleParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#s3_output_path SagemakerTrainingJob#s3_output_path}.</summary>
        [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3OutputPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#volume_size_in_gb SagemakerTrainingJob#volume_size_in_gb}.</summary>
        [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VolumeSizeInGb
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobDebugRuleConfigurations), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobDebugRuleConfigurations")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobDebugRuleConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#rule_configuration_name SagemakerTrainingJob#rule_configuration_name}.</summary>
            [JsiiProperty(name: "ruleConfigurationName", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleConfigurationName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#rule_evaluator_image SagemakerTrainingJob#rule_evaluator_image}.</summary>
            [JsiiProperty(name: "ruleEvaluatorImage", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleEvaluatorImage
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#instance_type SagemakerTrainingJob#instance_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#local_path SagemakerTrainingJob#local_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LocalPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#rule_parameters SagemakerTrainingJob#rule_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ruleParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? RuleParameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#s3_output_path SagemakerTrainingJob#s3_output_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3OutputPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#volume_size_in_gb SagemakerTrainingJob#volume_size_in_gb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VolumeSizeInGb
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
