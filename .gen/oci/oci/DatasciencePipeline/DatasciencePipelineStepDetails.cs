using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datasciencePipeline.DatasciencePipelineStepDetails")]
    public class DatasciencePipelineStepDetails : oci.DatasciencePipeline.IDatasciencePipelineStepDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_name DatasciencePipeline#step_name}.</summary>
        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        public string StepName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_type DatasciencePipeline#step_type}.</summary>
        [JsiiProperty(name: "stepType", typeJson: "{\"primitive\":\"string\"}")]
        public string StepType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#application_id DatasciencePipeline#application_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplicationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#depends_on DatasciencePipeline#depends_on}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DependsOn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#description DatasciencePipeline#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _isArtifactUploaded;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#is_artifact_uploaded DatasciencePipeline#is_artifact_uploaded}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isArtifactUploaded", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsArtifactUploaded
        {
            get => _isArtifactUploaded;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isArtifactUploaded = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#job_id DatasciencePipeline#job_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JobId
        {
            get;
            set;
        }

        /// <summary>step_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_configuration_details DatasciencePipeline#step_configuration_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepConfigurationDetails\"}", isOptional: true)]
        public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepConfigurationDetails? StepConfigurationDetails
        {
            get;
            set;
        }

        /// <summary>step_container_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_container_configuration_details DatasciencePipeline#step_container_configuration_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepContainerConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepContainerConfigurationDetails\"}", isOptional: true)]
        public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepContainerConfigurationDetails? StepContainerConfigurationDetails
        {
            get;
            set;
        }

        /// <summary>step_dataflow_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_dataflow_configuration_details DatasciencePipeline#step_dataflow_configuration_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepDataflowConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetails\"}", isOptional: true)]
        public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetails? StepDataflowConfigurationDetails
        {
            get;
            set;
        }

        /// <summary>step_infrastructure_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_infrastructure_configuration_details DatasciencePipeline#step_infrastructure_configuration_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails\"}", isOptional: true)]
        public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails? StepInfrastructureConfigurationDetails
        {
            get;
            set;
        }

        /// <summary>step_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_parameters DatasciencePipeline#step_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepParameters", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParameters\"}", isOptional: true)]
        public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParameters? StepParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_run_name DatasciencePipeline#step_run_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stepRunName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StepRunName
        {
            get;
            set;
        }

        private object? _stepStorageMountConfigurationDetailsList;

        /// <summary>step_storage_mount_configuration_details_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_storage_mount_configuration_details_list DatasciencePipeline#step_storage_mount_configuration_details_list}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepStorageMountConfigurationDetailsList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepStorageMountConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepStorageMountConfigurationDetailsListStruct[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepStorageMountConfigurationDetailsListStruct).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stepStorageMountConfigurationDetailsList = value;
            }
        }
    }
}
