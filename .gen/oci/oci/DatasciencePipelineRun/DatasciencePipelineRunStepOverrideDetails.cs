using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipelineRun
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetails")]
    public class DatasciencePipelineRunStepOverrideDetails : oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetails
    {
        /// <summary>step_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_configuration_details DatasciencePipelineRun#step_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "stepConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepConfigurationDetails\"}")]
        public oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepConfigurationDetails StepConfigurationDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_name DatasciencePipelineRun#step_name}.</summary>
        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        public string StepName
        {
            get;
            set;
        }

        /// <summary>step_container_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_container_configuration_details DatasciencePipelineRun#step_container_configuration_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepContainerConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetails\"}", isOptional: true)]
        public oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetails? StepContainerConfigurationDetails
        {
            get;
            set;
        }

        /// <summary>step_dataflow_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_dataflow_configuration_details DatasciencePipelineRun#step_dataflow_configuration_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepDataflowConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails\"}", isOptional: true)]
        public oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails? StepDataflowConfigurationDetails
        {
            get;
            set;
        }

        /// <summary>step_infrastructure_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_infrastructure_configuration_details DatasciencePipelineRun#step_infrastructure_configuration_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetails\"}", isOptional: true)]
        public oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetails? StepInfrastructureConfigurationDetails
        {
            get;
            set;
        }

        private object? _stepStorageMountConfigurationDetailsList;

        /// <summary>step_storage_mount_configuration_details_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_storage_mount_configuration_details_list DatasciencePipelineRun#step_storage_mount_configuration_details_list}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepStorageMountConfigurationDetailsList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepStorageMountConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StepStorageMountConfigurationDetailsList
        {
            get => _stepStorageMountConfigurationDetailsList;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepStorageMountConfigurationDetailsListStruct[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepStorageMountConfigurationDetailsListStruct).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stepStorageMountConfigurationDetailsList = value;
            }
        }
    }
}
