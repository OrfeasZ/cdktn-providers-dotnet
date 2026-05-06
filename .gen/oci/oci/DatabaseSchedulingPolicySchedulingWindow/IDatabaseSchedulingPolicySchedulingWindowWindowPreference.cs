using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseSchedulingPolicySchedulingWindow
{
    [JsiiInterface(nativeType: typeof(IDatabaseSchedulingPolicySchedulingWindowWindowPreference), fullyQualifiedName: "oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreference")]
    public interface IDatabaseSchedulingPolicySchedulingWindowWindowPreference
    {
        /// <summary>days_of_week block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#days_of_week DatabaseSchedulingPolicySchedulingWindow#days_of_week}
        /// </remarks>
        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceDaysOfWeek\"},\"kind\":\"array\"}}]}}")]
        object DaysOfWeek
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#duration DatabaseSchedulingPolicySchedulingWindow#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"number\"}")]
        double Duration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#is_enforced_duration DatabaseSchedulingPolicySchedulingWindow#is_enforced_duration}.</summary>
        [JsiiProperty(name: "isEnforcedDuration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsEnforcedDuration
        {
            get;
        }

        /// <summary>months block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#months DatabaseSchedulingPolicySchedulingWindow#months}
        /// </remarks>
        [JsiiProperty(name: "months", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceMonths\"},\"kind\":\"array\"}}]}}")]
        object Months
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#start_time DatabaseSchedulingPolicySchedulingWindow#start_time}.</summary>
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        string StartTime
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#weeks_of_month DatabaseSchedulingPolicySchedulingWindow#weeks_of_month}.</summary>
        [JsiiProperty(name: "weeksOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        double[] WeeksOfMonth
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseSchedulingPolicySchedulingWindowWindowPreference), fullyQualifiedName: "oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreference")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>days_of_week block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#days_of_week DatabaseSchedulingPolicySchedulingWindow#days_of_week}
            /// </remarks>
            [JsiiProperty(name: "daysOfWeek", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceDaysOfWeek\"},\"kind\":\"array\"}}]}}")]
            public object DaysOfWeek
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#duration DatabaseSchedulingPolicySchedulingWindow#duration}.</summary>
            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"number\"}")]
            public double Duration
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#is_enforced_duration DatabaseSchedulingPolicySchedulingWindow#is_enforced_duration}.</summary>
            [JsiiProperty(name: "isEnforcedDuration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsEnforcedDuration
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>months block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#months DatabaseSchedulingPolicySchedulingWindow#months}
            /// </remarks>
            [JsiiProperty(name: "months", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceMonths\"},\"kind\":\"array\"}}]}}")]
            public object Months
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#start_time DatabaseSchedulingPolicySchedulingWindow#start_time}.</summary>
            [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
            public string StartTime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#weeks_of_month DatabaseSchedulingPolicySchedulingWindow#weeks_of_month}.</summary>
            [JsiiProperty(name: "weeksOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
            public double[] WeeksOfMonth
            {
                get => GetInstanceProperty<double[]>()!;
            }
        }
    }
}
