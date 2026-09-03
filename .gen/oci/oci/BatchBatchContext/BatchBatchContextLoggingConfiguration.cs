using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BatchBatchContext
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.batchBatchContext.BatchBatchContextLoggingConfiguration")]
    public class BatchBatchContextLoggingConfiguration : oci.BatchBatchContext.IBatchBatchContextLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/batch_batch_context#log_group_id BatchBatchContext#log_group_id}.</summary>
        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/batch_batch_context#log_id BatchBatchContext#log_id}.</summary>
        [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}")]
        public string LogId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/batch_batch_context#type BatchBatchContext#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        private object? _isJobTaskEventsPropagationEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/batch_batch_context#is_job_task_events_propagation_enabled BatchBatchContext#is_job_task_events_propagation_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isJobTaskEventsPropagationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsJobTaskEventsPropagationEnabled
        {
            get => _isJobTaskEventsPropagationEnabled;
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
                _isJobTaskEventsPropagationEnabled = value;
            }
        }
    }
}
