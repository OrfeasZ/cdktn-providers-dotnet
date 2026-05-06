using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    [JsiiInterface(nativeType: typeof(IDatascienceScheduleActionActionDetails), fullyQualifiedName: "oci.datascienceSchedule.DatascienceScheduleActionActionDetails")]
    public interface IDatascienceScheduleActionActionDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#http_action_type DatascienceSchedule#http_action_type}.</summary>
        [JsiiProperty(name: "httpActionType", typeJson: "{\"primitive\":\"string\"}")]
        string HttpActionType
        {
            get;
        }

        /// <summary>create_job_run_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#create_job_run_details DatascienceSchedule#create_job_run_details}
        /// </remarks>
        [JsiiProperty(name: "createJobRunDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetails? CreateJobRunDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>create_pipeline_run_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#create_pipeline_run_details DatascienceSchedule#create_pipeline_run_details}
        /// </remarks>
        [JsiiProperty(name: "createPipelineRunDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetails? CreatePipelineRunDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#ml_application_instance_view_id DatascienceSchedule#ml_application_instance_view_id}.</summary>
        [JsiiProperty(name: "mlApplicationInstanceViewId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MlApplicationInstanceViewId
        {
            get
            {
                return null;
            }
        }

        /// <summary>trigger_ml_application_instance_view_flow_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#trigger_ml_application_instance_view_flow_details DatascienceSchedule#trigger_ml_application_instance_view_flow_details}
        /// </remarks>
        [JsiiProperty(name: "triggerMlApplicationInstanceViewFlowDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetails? TriggerMlApplicationInstanceViewFlowDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceScheduleActionActionDetails), fullyQualifiedName: "oci.datascienceSchedule.DatascienceScheduleActionActionDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceSchedule.IDatascienceScheduleActionActionDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#http_action_type DatascienceSchedule#http_action_type}.</summary>
            [JsiiProperty(name: "httpActionType", typeJson: "{\"primitive\":\"string\"}")]
            public string HttpActionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>create_job_run_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#create_job_run_details DatascienceSchedule#create_job_run_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createJobRunDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetails\"}", isOptional: true)]
            public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetails? CreateJobRunDetails
            {
                get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetails?>();
            }

            /// <summary>create_pipeline_run_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#create_pipeline_run_details DatascienceSchedule#create_pipeline_run_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createPipelineRunDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetails\"}", isOptional: true)]
            public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetails? CreatePipelineRunDetails
            {
                get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#ml_application_instance_view_id DatascienceSchedule#ml_application_instance_view_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mlApplicationInstanceViewId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MlApplicationInstanceViewId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>trigger_ml_application_instance_view_flow_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#trigger_ml_application_instance_view_flow_details DatascienceSchedule#trigger_ml_application_instance_view_flow_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "triggerMlApplicationInstanceViewFlowDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetails\"}", isOptional: true)]
            public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetails? TriggerMlApplicationInstanceViewFlowDetails
            {
                get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetails?>();
            }
        }
    }
}
