using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseSchedulingPolicySchedulingWindow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreference")]
    public class DatabaseSchedulingPolicySchedulingWindowWindowPreference : oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreference
    {
        private object _daysOfWeek;

        /// <summary>days_of_week block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#days_of_week DatabaseSchedulingPolicySchedulingWindow#days_of_week}
        /// </remarks>
        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceDaysOfWeek\"},\"kind\":\"array\"}}]}}")]
        public object DaysOfWeek
        {
            get => _daysOfWeek;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreferenceDaysOfWeek[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreferenceDaysOfWeek).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreferenceDaysOfWeek).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _daysOfWeek = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#duration DatabaseSchedulingPolicySchedulingWindow#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"number\"}")]
        public double Duration
        {
            get;
            set;
        }

        private object _isEnforcedDuration;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#is_enforced_duration DatabaseSchedulingPolicySchedulingWindow#is_enforced_duration}.</summary>
        [JsiiProperty(name: "isEnforcedDuration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsEnforcedDuration
        {
            get => _isEnforcedDuration;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isEnforcedDuration = value;
            }
        }

        private object _months;

        /// <summary>months block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#months DatabaseSchedulingPolicySchedulingWindow#months}
        /// </remarks>
        [JsiiProperty(name: "months", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceMonths\"},\"kind\":\"array\"}}]}}")]
        public object Months
        {
            get => _months;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreferenceMonths[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreferenceMonths).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreferenceMonths).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _months = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#start_time DatabaseSchedulingPolicySchedulingWindow#start_time}.</summary>
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        public string StartTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#weeks_of_month DatabaseSchedulingPolicySchedulingWindow#weeks_of_month}.</summary>
        [JsiiProperty(name: "weeksOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public double[] WeeksOfMonth
        {
            get;
            set;
        }
    }
}
