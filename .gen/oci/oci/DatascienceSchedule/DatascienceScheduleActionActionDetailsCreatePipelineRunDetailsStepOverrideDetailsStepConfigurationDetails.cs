using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    [JsiiByValue(fqn: "oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepConfigurationDetails")]
    public class DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepConfigurationDetails : oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#command_line_arguments DatascienceSchedule#command_line_arguments}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "commandLineArguments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CommandLineArguments
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#environment_variables DatascienceSchedule#environment_variables}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#maximum_runtime_in_minutes DatascienceSchedule#maximum_runtime_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumRuntimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaximumRuntimeInMinutes
        {
            get;
            set;
        }
    }
}
