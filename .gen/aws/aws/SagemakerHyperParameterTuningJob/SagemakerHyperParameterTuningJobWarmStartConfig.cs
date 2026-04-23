using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobWarmStartConfig")]
    public class SagemakerHyperParameterTuningJobWarmStartConfig : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobWarmStartConfig
    {
        private object? _parentHyperParameterTuningJobs;

        /// <summary>parent_hyper_parameter_tuning_jobs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#parent_hyper_parameter_tuning_jobs SagemakerHyperParameterTuningJob#parent_hyper_parameter_tuning_jobs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parentHyperParameterTuningJobs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobWarmStartConfigParentHyperParameterTuningJobs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ParentHyperParameterTuningJobs
        {
            get => _parentHyperParameterTuningJobs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobWarmStartConfigParentHyperParameterTuningJobs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobWarmStartConfigParentHyperParameterTuningJobs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parentHyperParameterTuningJobs = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#warm_start_type SagemakerHyperParameterTuningJob#warm_start_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "warmStartType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WarmStartType
        {
            get;
            set;
        }
    }
}
