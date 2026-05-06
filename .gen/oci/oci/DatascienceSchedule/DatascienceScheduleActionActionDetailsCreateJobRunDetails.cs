using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    [JsiiByValue(fqn: "oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetails")]
    public class DatascienceScheduleActionActionDetailsCreateJobRunDetails : oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#compartment_id DatascienceSchedule#compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#defined_tags DatascienceSchedule#defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#display_name DatascienceSchedule#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#freeform_tags DatascienceSchedule#freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get;
            set;
        }

        /// <summary>job_configuration_override_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#job_configuration_override_details DatascienceSchedule#job_configuration_override_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jobConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetailsJobConfigurationOverrideDetails\"}", isOptional: true)]
        public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetailsJobConfigurationOverrideDetails? JobConfigurationOverrideDetails
        {
            get;
            set;
        }

        /// <summary>job_environment_configuration_override_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#job_environment_configuration_override_details DatascienceSchedule#job_environment_configuration_override_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jobEnvironmentConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetailsJobEnvironmentConfigurationOverrideDetails\"}", isOptional: true)]
        public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetailsJobEnvironmentConfigurationOverrideDetails? JobEnvironmentConfigurationOverrideDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#job_id DatascienceSchedule#job_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JobId
        {
            get;
            set;
        }

        /// <summary>job_log_configuration_override_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#job_log_configuration_override_details DatascienceSchedule#job_log_configuration_override_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jobLogConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetailsJobLogConfigurationOverrideDetails\"}", isOptional: true)]
        public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetailsJobLogConfigurationOverrideDetails? JobLogConfigurationOverrideDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#project_id DatascienceSchedule#project_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProjectId
        {
            get;
            set;
        }
    }
}
