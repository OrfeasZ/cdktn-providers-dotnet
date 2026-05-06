using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    [JsiiByValue(fqn: "oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetails")]
    public class DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetails : oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetails
    {
        /// <summary>step_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#step_configuration_details DatascienceSchedule#step_configuration_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepConfigurationDetails\"}", isOptional: true)]
        public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepConfigurationDetails? StepConfigurationDetails
        {
            get;
            set;
        }

        /// <summary>step_container_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#step_container_configuration_details DatascienceSchedule#step_container_configuration_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepContainerConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepContainerConfigurationDetails\"}", isOptional: true)]
        public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepContainerConfigurationDetails? StepContainerConfigurationDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#step_name DatascienceSchedule#step_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StepName
        {
            get;
            set;
        }
    }
}
