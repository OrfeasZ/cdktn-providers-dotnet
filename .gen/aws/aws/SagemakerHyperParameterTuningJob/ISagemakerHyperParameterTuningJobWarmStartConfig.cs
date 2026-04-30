using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobWarmStartConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobWarmStartConfig")]
    public interface ISagemakerHyperParameterTuningJobWarmStartConfig
    {
        /// <summary>parent_hyper_parameter_tuning_jobs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#parent_hyper_parameter_tuning_jobs SagemakerHyperParameterTuningJob#parent_hyper_parameter_tuning_jobs}
        /// </remarks>
        [JsiiProperty(name: "parentHyperParameterTuningJobs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobWarmStartConfigParentHyperParameterTuningJobs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ParentHyperParameterTuningJobs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#warm_start_type SagemakerHyperParameterTuningJob#warm_start_type}.</summary>
        [JsiiProperty(name: "warmStartType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WarmStartType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobWarmStartConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobWarmStartConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobWarmStartConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>parent_hyper_parameter_tuning_jobs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#parent_hyper_parameter_tuning_jobs SagemakerHyperParameterTuningJob#parent_hyper_parameter_tuning_jobs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parentHyperParameterTuningJobs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobWarmStartConfigParentHyperParameterTuningJobs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ParentHyperParameterTuningJobs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#warm_start_type SagemakerHyperParameterTuningJob#warm_start_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "warmStartType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WarmStartType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
