using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    [JsiiByValue(fqn: "oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetails")]
    public class DatascienceScheduleActionActionDetailsCreatePipelineRunDetails : oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#compartment_id DatascienceSchedule#compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompartmentId
        {
            get;
            set;
        }

        /// <summary>configuration_override_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#configuration_override_details DatascienceSchedule#configuration_override_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsConfigurationOverrideDetails\"}", isOptional: true)]
        public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsConfigurationOverrideDetails? ConfigurationOverrideDetails
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

        /// <summary>log_configuration_override_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#log_configuration_override_details DatascienceSchedule#log_configuration_override_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsLogConfigurationOverrideDetails\"}", isOptional: true)]
        public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsLogConfigurationOverrideDetails? LogConfigurationOverrideDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#pipeline_id DatascienceSchedule#pipeline_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PipelineId
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

        private object? _stepOverrideDetails;

        /// <summary>step_override_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#step_override_details DatascienceSchedule#step_override_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepOverrideDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StepOverrideDetails
        {
            get => _stepOverrideDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stepOverrideDetails = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#system_tags DatascienceSchedule#system_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "systemTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? SystemTags
        {
            get;
            set;
        }
    }
}
