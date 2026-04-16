using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchComputeEnvironment
{
    [JsiiByValue(fqn: "aws.batchComputeEnvironment.BatchComputeEnvironmentUpdatePolicy")]
    public class BatchComputeEnvironmentUpdatePolicy : aws.BatchComputeEnvironment.IBatchComputeEnvironmentUpdatePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/batch_compute_environment#job_execution_timeout_minutes BatchComputeEnvironment#job_execution_timeout_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jobExecutionTimeoutMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? JobExecutionTimeoutMinutes
        {
            get;
            set;
        }

        private object? _terminateJobsOnUpdate;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/batch_compute_environment#terminate_jobs_on_update BatchComputeEnvironment#terminate_jobs_on_update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "terminateJobsOnUpdate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? TerminateJobsOnUpdate
        {
            get => _terminateJobsOnUpdate;
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
                _terminateJobsOnUpdate = value;
            }
        }
    }
}
