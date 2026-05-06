using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipelineRun
{
    [JsiiInterface(nativeType: typeof(IDatasciencePipelineRunStepOverrideDetails), fullyQualifiedName: "oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetails")]
    public interface IDatasciencePipelineRunStepOverrideDetails
    {
        /// <summary>step_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_configuration_details DatasciencePipelineRun#step_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "stepConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepConfigurationDetails\"}")]
        oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepConfigurationDetails StepConfigurationDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_name DatasciencePipelineRun#step_name}.</summary>
        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        string StepName
        {
            get;
        }

        /// <summary>step_container_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_container_configuration_details DatasciencePipelineRun#step_container_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "stepContainerConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetails? StepContainerConfigurationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_dataflow_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_dataflow_configuration_details DatasciencePipelineRun#step_dataflow_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "stepDataflowConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails? StepDataflowConfigurationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_infrastructure_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_infrastructure_configuration_details DatasciencePipelineRun#step_infrastructure_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "stepInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetails? StepInfrastructureConfigurationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_storage_mount_configuration_details_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_storage_mount_configuration_details_list DatasciencePipelineRun#step_storage_mount_configuration_details_list}
        /// </remarks>
        [JsiiProperty(name: "stepStorageMountConfigurationDetailsList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepStorageMountConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StepStorageMountConfigurationDetailsList
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasciencePipelineRunStepOverrideDetails), fullyQualifiedName: "oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>step_configuration_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_configuration_details DatasciencePipelineRun#step_configuration_details}
            /// </remarks>
            [JsiiProperty(name: "stepConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepConfigurationDetails\"}")]
            public oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepConfigurationDetails StepConfigurationDetails
            {
                get => GetInstanceProperty<oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepConfigurationDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_name DatasciencePipelineRun#step_name}.</summary>
            [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
            public string StepName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>step_container_configuration_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_container_configuration_details DatasciencePipelineRun#step_container_configuration_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepContainerConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetails\"}", isOptional: true)]
            public oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetails? StepContainerConfigurationDetails
            {
                get => GetInstanceProperty<oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetails?>();
            }

            /// <summary>step_dataflow_configuration_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_dataflow_configuration_details DatasciencePipelineRun#step_dataflow_configuration_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepDataflowConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails\"}", isOptional: true)]
            public oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails? StepDataflowConfigurationDetails
            {
                get => GetInstanceProperty<oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails?>();
            }

            /// <summary>step_infrastructure_configuration_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_infrastructure_configuration_details DatasciencePipelineRun#step_infrastructure_configuration_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetails\"}", isOptional: true)]
            public oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetails? StepInfrastructureConfigurationDetails
            {
                get => GetInstanceProperty<oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetails?>();
            }

            /// <summary>step_storage_mount_configuration_details_list block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#step_storage_mount_configuration_details_list DatasciencePipelineRun#step_storage_mount_configuration_details_list}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepStorageMountConfigurationDetailsList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepStorageMountConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StepStorageMountConfigurationDetailsList
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
