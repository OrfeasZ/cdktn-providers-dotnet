using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipeline
{
    [JsiiInterface(nativeType: typeof(IDatasciencePipelineStepDetails), fullyQualifiedName: "oci.datasciencePipeline.DatasciencePipelineStepDetails")]
    public interface IDatasciencePipelineStepDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_name DatasciencePipeline#step_name}.</summary>
        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        string StepName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_type DatasciencePipeline#step_type}.</summary>
        [JsiiProperty(name: "stepType", typeJson: "{\"primitive\":\"string\"}")]
        string StepType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#application_id DatasciencePipeline#application_id}.</summary>
        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplicationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#depends_on DatasciencePipeline#depends_on}.</summary>
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DependsOn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#description DatasciencePipeline#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#is_artifact_uploaded DatasciencePipeline#is_artifact_uploaded}.</summary>
        [JsiiProperty(name: "isArtifactUploaded", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsArtifactUploaded
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#job_id DatasciencePipeline#job_id}.</summary>
        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JobId
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_configuration_details DatasciencePipeline#step_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "stepConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepConfigurationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepConfigurationDetails? StepConfigurationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_container_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_container_configuration_details DatasciencePipeline#step_container_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "stepContainerConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepContainerConfigurationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepContainerConfigurationDetails? StepContainerConfigurationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_dataflow_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_dataflow_configuration_details DatasciencePipeline#step_dataflow_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "stepDataflowConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetails? StepDataflowConfigurationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_infrastructure_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_infrastructure_configuration_details DatasciencePipeline#step_infrastructure_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "stepInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails? StepInfrastructureConfigurationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_parameters DatasciencePipeline#step_parameters}
        /// </remarks>
        [JsiiProperty(name: "stepParameters", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParameters? StepParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_run_name DatasciencePipeline#step_run_name}.</summary>
        [JsiiProperty(name: "stepRunName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StepRunName
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_storage_mount_configuration_details_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_storage_mount_configuration_details_list DatasciencePipeline#step_storage_mount_configuration_details_list}
        /// </remarks>
        [JsiiProperty(name: "stepStorageMountConfigurationDetailsList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepStorageMountConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StepStorageMountConfigurationDetailsList
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasciencePipelineStepDetails), fullyQualifiedName: "oci.datasciencePipeline.DatasciencePipelineStepDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatasciencePipeline.IDatasciencePipelineStepDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_name DatasciencePipeline#step_name}.</summary>
            [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
            public string StepName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_type DatasciencePipeline#step_type}.</summary>
            [JsiiProperty(name: "stepType", typeJson: "{\"primitive\":\"string\"}")]
            public string StepType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#application_id DatasciencePipeline#application_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplicationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#depends_on DatasciencePipeline#depends_on}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DependsOn
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#description DatasciencePipeline#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#is_artifact_uploaded DatasciencePipeline#is_artifact_uploaded}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isArtifactUploaded", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsArtifactUploaded
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#job_id DatasciencePipeline#job_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JobId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>step_configuration_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_configuration_details DatasciencePipeline#step_configuration_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepConfigurationDetails\"}", isOptional: true)]
            public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepConfigurationDetails? StepConfigurationDetails
            {
                get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepConfigurationDetails?>();
            }

            /// <summary>step_container_configuration_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_container_configuration_details DatasciencePipeline#step_container_configuration_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepContainerConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepContainerConfigurationDetails\"}", isOptional: true)]
            public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepContainerConfigurationDetails? StepContainerConfigurationDetails
            {
                get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepContainerConfigurationDetails?>();
            }

            /// <summary>step_dataflow_configuration_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_dataflow_configuration_details DatasciencePipeline#step_dataflow_configuration_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepDataflowConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetails\"}", isOptional: true)]
            public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetails? StepDataflowConfigurationDetails
            {
                get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetails?>();
            }

            /// <summary>step_infrastructure_configuration_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_infrastructure_configuration_details DatasciencePipeline#step_infrastructure_configuration_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails\"}", isOptional: true)]
            public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails? StepInfrastructureConfigurationDetails
            {
                get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails?>();
            }

            /// <summary>step_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_parameters DatasciencePipeline#step_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepParameters", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParameters\"}", isOptional: true)]
            public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParameters? StepParameters
            {
                get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParameters?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_run_name DatasciencePipeline#step_run_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stepRunName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StepRunName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>step_storage_mount_configuration_details_list block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_storage_mount_configuration_details_list DatasciencePipeline#step_storage_mount_configuration_details_list}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepStorageMountConfigurationDetailsList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepStorageMountConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StepStorageMountConfigurationDetailsList
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
