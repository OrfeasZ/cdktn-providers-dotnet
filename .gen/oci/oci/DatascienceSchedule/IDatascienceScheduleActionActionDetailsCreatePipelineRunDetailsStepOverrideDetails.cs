using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    [JsiiInterface(nativeType: typeof(IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetails), fullyQualifiedName: "oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetails")]
    public interface IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetails
    {
        /// <summary>step_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#step_configuration_details DatascienceSchedule#step_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "stepConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepConfigurationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepConfigurationDetails? StepConfigurationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_container_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#step_container_configuration_details DatascienceSchedule#step_container_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "stepContainerConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepContainerConfigurationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepContainerConfigurationDetails? StepContainerConfigurationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#step_name DatascienceSchedule#step_name}.</summary>
        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StepName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetails), fullyQualifiedName: "oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>step_configuration_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#step_configuration_details DatascienceSchedule#step_configuration_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepConfigurationDetails\"}", isOptional: true)]
            public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepConfigurationDetails? StepConfigurationDetails
            {
                get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepConfigurationDetails?>();
            }

            /// <summary>step_container_configuration_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#step_container_configuration_details DatascienceSchedule#step_container_configuration_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepContainerConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepContainerConfigurationDetails\"}", isOptional: true)]
            public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepContainerConfigurationDetails? StepContainerConfigurationDetails
            {
                get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepContainerConfigurationDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#step_name DatascienceSchedule#step_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StepName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
