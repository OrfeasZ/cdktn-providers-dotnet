using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceApplicationTaskSchedule
{
    [JsiiInterface(nativeType: typeof(IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetails), fullyQualifiedName: "oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetails")]
    public interface IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#model_type DataintegrationWorkspaceApplicationTaskSchedule#model_type}.</summary>
        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        string ModelType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#custom_expression DataintegrationWorkspaceApplicationTaskSchedule#custom_expression}.</summary>
        [JsiiProperty(name: "customExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#day_of_week DataintegrationWorkspaceApplicationTaskSchedule#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DayOfWeek
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#days DataintegrationWorkspaceApplicationTaskSchedule#days}.</summary>
        [JsiiProperty(name: "days", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? Days
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#frequency DataintegrationWorkspaceApplicationTaskSchedule#frequency}.</summary>
        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Frequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#interval DataintegrationWorkspaceApplicationTaskSchedule#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Interval
        {
            get
            {
                return null;
            }
        }

        /// <summary>time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#time DataintegrationWorkspaceApplicationTaskSchedule#time}
        /// </remarks>
        [JsiiProperty(name: "time", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsTime\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsTime? Time
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#week_of_month DataintegrationWorkspaceApplicationTaskSchedule#week_of_month}.</summary>
        [JsiiProperty(name: "weekOfMonth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WeekOfMonth
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetails), fullyQualifiedName: "oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#model_type DataintegrationWorkspaceApplicationTaskSchedule#model_type}.</summary>
            [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#custom_expression DataintegrationWorkspaceApplicationTaskSchedule#custom_expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomExpression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#day_of_week DataintegrationWorkspaceApplicationTaskSchedule#day_of_week}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DayOfWeek
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#days DataintegrationWorkspaceApplicationTaskSchedule#days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "days", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? Days
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#frequency DataintegrationWorkspaceApplicationTaskSchedule#frequency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Frequency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#interval DataintegrationWorkspaceApplicationTaskSchedule#interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Interval
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>time block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#time DataintegrationWorkspaceApplicationTaskSchedule#time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "time", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsTime\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsTime? Time
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsTime?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#week_of_month DataintegrationWorkspaceApplicationTaskSchedule#week_of_month}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weekOfMonth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WeekOfMonth
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
