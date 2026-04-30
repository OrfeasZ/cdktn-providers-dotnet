using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobProfilerConfig")]
    public class SagemakerTrainingJobProfilerConfig : aws.SagemakerTrainingJob.ISagemakerTrainingJobProfilerConfig
    {
        private object? _disableProfiler;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#disable_profiler SagemakerTrainingJob#disable_profiler}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disableProfiler", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DisableProfiler
        {
            get => _disableProfiler;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _disableProfiler = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#profiling_interval_in_milliseconds SagemakerTrainingJob#profiling_interval_in_milliseconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "profilingIntervalInMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ProfilingIntervalInMilliseconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#profiling_parameters SagemakerTrainingJob#profiling_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "profilingParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? ProfilingParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#s3_output_path SagemakerTrainingJob#s3_output_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3OutputPath
        {
            get;
            set;
        }
    }
}
