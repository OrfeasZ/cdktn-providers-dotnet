using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceSchedule.DatascienceScheduleTrigger")]
    public class DatascienceScheduleTrigger : oci.DatascienceSchedule.IDatascienceScheduleTrigger
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#trigger_type DatascienceSchedule#trigger_type}.</summary>
        [JsiiProperty(name: "triggerType", typeJson: "{\"primitive\":\"string\"}")]
        public string TriggerType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#cron_expression DatascienceSchedule#cron_expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cronExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CronExpression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#frequency DatascienceSchedule#frequency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Frequency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#interval DatascienceSchedule#interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Interval
        {
            get;
            set;
        }

        private object? _isRandomStartTime;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#is_random_start_time DatascienceSchedule#is_random_start_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isRandomStartTime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsRandomStartTime
        {
            get => _isRandomStartTime;
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
                _isRandomStartTime = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#recurrence DatascienceSchedule#recurrence}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recurrence", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Recurrence
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#time_end DatascienceSchedule#time_end}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeEnd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeEnd
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#time_start DatascienceSchedule#time_start}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeStart
        {
            get;
            set;
        }
    }
}
