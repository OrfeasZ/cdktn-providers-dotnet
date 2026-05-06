using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployment
{
    [JsiiInterface(nativeType: typeof(IDevopsDeploymentConfig), fullyQualifiedName: "oci.devopsDeployment.DevopsDeploymentConfig")]
    public interface IDevopsDeploymentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#deployment_type DevopsDeployment#deployment_type}.</summary>
        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}")]
        string DeploymentType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#deploy_pipeline_id DevopsDeployment#deploy_pipeline_id}.</summary>
        [JsiiProperty(name: "deployPipelineId", typeJson: "{\"primitive\":\"string\"}")]
        string DeployPipelineId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#defined_tags DevopsDeployment#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>deploy_artifact_override_arguments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#deploy_artifact_override_arguments DevopsDeployment#deploy_artifact_override_arguments}
        /// </remarks>
        [JsiiProperty(name: "deployArtifactOverrideArguments", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeployArtifactOverrideArguments\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployment.IDevopsDeploymentDeployArtifactOverrideArguments? DeployArtifactOverrideArguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>deployment_arguments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#deployment_arguments DevopsDeployment#deployment_arguments}
        /// </remarks>
        [JsiiProperty(name: "deploymentArguments", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeploymentArguments\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployment.IDevopsDeploymentDeploymentArguments? DeploymentArguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#deploy_stage_id DevopsDeployment#deploy_stage_id}.</summary>
        [JsiiProperty(name: "deployStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeployStageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>deploy_stage_override_arguments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#deploy_stage_override_arguments DevopsDeployment#deploy_stage_override_arguments}
        /// </remarks>
        [JsiiProperty(name: "deployStageOverrideArguments", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeployStageOverrideArguments\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployment.IDevopsDeploymentDeployStageOverrideArguments? DeployStageOverrideArguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#display_name DevopsDeployment#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#freeform_tags DevopsDeployment#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#id DevopsDeployment#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#previous_deployment_id DevopsDeployment#previous_deployment_id}.</summary>
        [JsiiProperty(name: "previousDeploymentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreviousDeploymentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#timeouts DevopsDeployment#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployment.IDevopsDeploymentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#trigger_new_devops_deployment DevopsDeployment#trigger_new_devops_deployment}.</summary>
        [JsiiProperty(name: "triggerNewDevopsDeployment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TriggerNewDevopsDeployment
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsDeploymentConfig), fullyQualifiedName: "oci.devopsDeployment.DevopsDeploymentConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsDeployment.IDevopsDeploymentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#deployment_type DevopsDeployment#deployment_type}.</summary>
            [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}")]
            public string DeploymentType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#deploy_pipeline_id DevopsDeployment#deploy_pipeline_id}.</summary>
            [JsiiProperty(name: "deployPipelineId", typeJson: "{\"primitive\":\"string\"}")]
            public string DeployPipelineId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#defined_tags DevopsDeployment#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>deploy_artifact_override_arguments block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#deploy_artifact_override_arguments DevopsDeployment#deploy_artifact_override_arguments}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deployArtifactOverrideArguments", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeployArtifactOverrideArguments\"}", isOptional: true)]
            public oci.DevopsDeployment.IDevopsDeploymentDeployArtifactOverrideArguments? DeployArtifactOverrideArguments
            {
                get => GetInstanceProperty<oci.DevopsDeployment.IDevopsDeploymentDeployArtifactOverrideArguments?>();
            }

            /// <summary>deployment_arguments block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#deployment_arguments DevopsDeployment#deployment_arguments}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentArguments", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeploymentArguments\"}", isOptional: true)]
            public oci.DevopsDeployment.IDevopsDeploymentDeploymentArguments? DeploymentArguments
            {
                get => GetInstanceProperty<oci.DevopsDeployment.IDevopsDeploymentDeploymentArguments?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#deploy_stage_id DevopsDeployment#deploy_stage_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deployStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeployStageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>deploy_stage_override_arguments block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#deploy_stage_override_arguments DevopsDeployment#deploy_stage_override_arguments}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deployStageOverrideArguments", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeployStageOverrideArguments\"}", isOptional: true)]
            public oci.DevopsDeployment.IDevopsDeploymentDeployStageOverrideArguments? DeployStageOverrideArguments
            {
                get => GetInstanceProperty<oci.DevopsDeployment.IDevopsDeploymentDeployStageOverrideArguments?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#display_name DevopsDeployment#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#freeform_tags DevopsDeployment#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#id DevopsDeployment#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#previous_deployment_id DevopsDeployment#previous_deployment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "previousDeploymentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreviousDeploymentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#timeouts DevopsDeployment#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentTimeouts\"}", isOptional: true)]
            public oci.DevopsDeployment.IDevopsDeploymentTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DevopsDeployment.IDevopsDeploymentTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#trigger_new_devops_deployment DevopsDeployment#trigger_new_devops_deployment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "triggerNewDevopsDeployment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? TriggerNewDevopsDeployment
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
