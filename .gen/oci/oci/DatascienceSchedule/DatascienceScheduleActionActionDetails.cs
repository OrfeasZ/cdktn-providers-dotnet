using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceSchedule.DatascienceScheduleActionActionDetails")]
    public class DatascienceScheduleActionActionDetails : oci.DatascienceSchedule.IDatascienceScheduleActionActionDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#http_action_type DatascienceSchedule#http_action_type}.</summary>
        [JsiiProperty(name: "httpActionType", typeJson: "{\"primitive\":\"string\"}")]
        public string HttpActionType
        {
            get;
            set;
        }

        /// <summary>create_job_run_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#create_job_run_details DatascienceSchedule#create_job_run_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createJobRunDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetails\"}", isOptional: true)]
        public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetails? CreateJobRunDetails
        {
            get;
            set;
        }

        /// <summary>create_pipeline_run_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#create_pipeline_run_details DatascienceSchedule#create_pipeline_run_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createPipelineRunDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetails\"}", isOptional: true)]
        public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetails? CreatePipelineRunDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#ml_application_instance_view_id DatascienceSchedule#ml_application_instance_view_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mlApplicationInstanceViewId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MlApplicationInstanceViewId
        {
            get;
            set;
        }

        /// <summary>trigger_ml_application_instance_view_flow_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#trigger_ml_application_instance_view_flow_details DatascienceSchedule#trigger_ml_application_instance_view_flow_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "triggerMlApplicationInstanceViewFlowDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetails\"}", isOptional: true)]
        public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetails? TriggerMlApplicationInstanceViewFlowDetails
        {
            get;
            set;
        }
    }
}
