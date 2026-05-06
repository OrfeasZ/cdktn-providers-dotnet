using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    [JsiiInterface(nativeType: typeof(IDevopsDeployStageConfig), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageConfig")]
    public interface IDevopsDeployStageConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#deploy_pipeline_id DevopsDeployStage#deploy_pipeline_id}.</summary>
        [JsiiProperty(name: "deployPipelineId", typeJson: "{\"primitive\":\"string\"}")]
        string DeployPipelineId
        {
            get;
        }

        /// <summary>deploy_stage_predecessor_collection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#deploy_stage_predecessor_collection DevopsDeployStage#deploy_stage_predecessor_collection}
        /// </remarks>
        [JsiiProperty(name: "deployStagePredecessorCollection", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageDeployStagePredecessorCollection\"}")]
        oci.DevopsDeployStage.IDevopsDeployStageDeployStagePredecessorCollection DeployStagePredecessorCollection
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#deploy_stage_type DevopsDeployStage#deploy_stage_type}.</summary>
        [JsiiProperty(name: "deployStageType", typeJson: "{\"primitive\":\"string\"}")]
        string DeployStageType
        {
            get;
        }

        /// <summary>approval_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#approval_policy DevopsDeployStage#approval_policy}
        /// </remarks>
        [JsiiProperty(name: "approvalPolicy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageApprovalPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployStage.IDevopsDeployStageApprovalPolicy? ApprovalPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#are_hooks_enabled DevopsDeployStage#are_hooks_enabled}.</summary>
        [JsiiProperty(name: "areHooksEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AreHooksEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>blue_backend_ips block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#blue_backend_ips DevopsDeployStage#blue_backend_ips}
        /// </remarks>
        [JsiiProperty(name: "blueBackendIps", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageBlueBackendIps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployStage.IDevopsDeployStageBlueBackendIps? BlueBackendIps
        {
            get
            {
                return null;
            }
        }

        /// <summary>blue_green_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#blue_green_strategy DevopsDeployStage#blue_green_strategy}
        /// </remarks>
        [JsiiProperty(name: "blueGreenStrategy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageBlueGreenStrategy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployStage.IDevopsDeployStageBlueGreenStrategy? BlueGreenStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>canary_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#canary_strategy DevopsDeployStage#canary_strategy}
        /// </remarks>
        [JsiiProperty(name: "canaryStrategy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageCanaryStrategy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployStage.IDevopsDeployStageCanaryStrategy? CanaryStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#command_spec_deploy_artifact_id DevopsDeployStage#command_spec_deploy_artifact_id}.</summary>
        [JsiiProperty(name: "commandSpecDeployArtifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CommandSpecDeployArtifactId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#compute_instance_group_blue_green_deployment_deploy_stage_id DevopsDeployStage#compute_instance_group_blue_green_deployment_deploy_stage_id}.</summary>
        [JsiiProperty(name: "computeInstanceGroupBlueGreenDeploymentDeployStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeInstanceGroupBlueGreenDeploymentDeployStageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#compute_instance_group_canary_deploy_stage_id DevopsDeployStage#compute_instance_group_canary_deploy_stage_id}.</summary>
        [JsiiProperty(name: "computeInstanceGroupCanaryDeployStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeInstanceGroupCanaryDeployStageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#compute_instance_group_canary_traffic_shift_deploy_stage_id DevopsDeployStage#compute_instance_group_canary_traffic_shift_deploy_stage_id}.</summary>
        [JsiiProperty(name: "computeInstanceGroupCanaryTrafficShiftDeployStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeInstanceGroupCanaryTrafficShiftDeployStageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#compute_instance_group_deploy_environment_id DevopsDeployStage#compute_instance_group_deploy_environment_id}.</summary>
        [JsiiProperty(name: "computeInstanceGroupDeployEnvironmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeInstanceGroupDeployEnvironmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#config DevopsDeployStage#config}.</summary>
        [JsiiProperty(name: "config", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Config
        {
            get
            {
                return null;
            }
        }

        /// <summary>container_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#container_config DevopsDeployStage#container_config}
        /// </remarks>
        [JsiiProperty(name: "containerConfig", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageContainerConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployStage.IDevopsDeployStageContainerConfig? ContainerConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#defined_tags DevopsDeployStage#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#deploy_artifact_id DevopsDeployStage#deploy_artifact_id}.</summary>
        [JsiiProperty(name: "deployArtifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeployArtifactId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#deploy_artifact_ids DevopsDeployStage#deploy_artifact_ids}.</summary>
        [JsiiProperty(name: "deployArtifactIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DeployArtifactIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#deploy_environment_id_a DevopsDeployStage#deploy_environment_id_a}.</summary>
        [JsiiProperty(name: "deployEnvironmentIdA", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeployEnvironmentIdA
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#deploy_environment_id_b DevopsDeployStage#deploy_environment_id_b}.</summary>
        [JsiiProperty(name: "deployEnvironmentIdB", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeployEnvironmentIdB
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#deployment_spec_deploy_artifact_id DevopsDeployStage#deployment_spec_deploy_artifact_id}.</summary>
        [JsiiProperty(name: "deploymentSpecDeployArtifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeploymentSpecDeployArtifactId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#description DevopsDeployStage#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#display_name DevopsDeployStage#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#docker_image_deploy_artifact_id DevopsDeployStage#docker_image_deploy_artifact_id}.</summary>
        [JsiiProperty(name: "dockerImageDeployArtifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DockerImageDeployArtifactId
        {
            get
            {
                return null;
            }
        }

        /// <summary>failure_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#failure_policy DevopsDeployStage#failure_policy}
        /// </remarks>
        [JsiiProperty(name: "failurePolicy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageFailurePolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployStage.IDevopsDeployStageFailurePolicy? FailurePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#freeform_tags DevopsDeployStage#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#function_deploy_environment_id DevopsDeployStage#function_deploy_environment_id}.</summary>
        [JsiiProperty(name: "functionDeployEnvironmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FunctionDeployEnvironmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#function_timeout_in_seconds DevopsDeployStage#function_timeout_in_seconds}.</summary>
        [JsiiProperty(name: "functionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FunctionTimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>green_backend_ips block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#green_backend_ips DevopsDeployStage#green_backend_ips}
        /// </remarks>
        [JsiiProperty(name: "greenBackendIps", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageGreenBackendIps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployStage.IDevopsDeployStageGreenBackendIps? GreenBackendIps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#helm_chart_deploy_artifact_id DevopsDeployStage#helm_chart_deploy_artifact_id}.</summary>
        [JsiiProperty(name: "helmChartDeployArtifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HelmChartDeployArtifactId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#helm_command_artifact_ids DevopsDeployStage#helm_command_artifact_ids}.</summary>
        [JsiiProperty(name: "helmCommandArtifactIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? HelmCommandArtifactIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#id DevopsDeployStage#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#is_async DevopsDeployStage#is_async}.</summary>
        [JsiiProperty(name: "isAsync", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAsync
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#is_debug_enabled DevopsDeployStage#is_debug_enabled}.</summary>
        [JsiiProperty(name: "isDebugEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDebugEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#is_force_enabled DevopsDeployStage#is_force_enabled}.</summary>
        [JsiiProperty(name: "isForceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsForceEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#is_uninstall_on_stage_delete DevopsDeployStage#is_uninstall_on_stage_delete}.</summary>
        [JsiiProperty(name: "isUninstallOnStageDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsUninstallOnStageDelete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#is_validation_enabled DevopsDeployStage#is_validation_enabled}.</summary>
        [JsiiProperty(name: "isValidationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsValidationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#kubernetes_manifest_deploy_artifact_ids DevopsDeployStage#kubernetes_manifest_deploy_artifact_ids}.</summary>
        [JsiiProperty(name: "kubernetesManifestDeployArtifactIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? KubernetesManifestDeployArtifactIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>load_balancer_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#load_balancer_config DevopsDeployStage#load_balancer_config}
        /// </remarks>
        [JsiiProperty(name: "loadBalancerConfig", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageLoadBalancerConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployStage.IDevopsDeployStageLoadBalancerConfig? LoadBalancerConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#max_history DevopsDeployStage#max_history}.</summary>
        [JsiiProperty(name: "maxHistory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxHistory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#max_memory_in_mbs DevopsDeployStage#max_memory_in_mbs}.</summary>
        [JsiiProperty(name: "maxMemoryInMbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxMemoryInMbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#namespace DevopsDeployStage#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#oke_blue_green_deploy_stage_id DevopsDeployStage#oke_blue_green_deploy_stage_id}.</summary>
        [JsiiProperty(name: "okeBlueGreenDeployStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OkeBlueGreenDeployStageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#oke_canary_deploy_stage_id DevopsDeployStage#oke_canary_deploy_stage_id}.</summary>
        [JsiiProperty(name: "okeCanaryDeployStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OkeCanaryDeployStageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#oke_canary_traffic_shift_deploy_stage_id DevopsDeployStage#oke_canary_traffic_shift_deploy_stage_id}.</summary>
        [JsiiProperty(name: "okeCanaryTrafficShiftDeployStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OkeCanaryTrafficShiftDeployStageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#oke_cluster_deploy_environment_id DevopsDeployStage#oke_cluster_deploy_environment_id}.</summary>
        [JsiiProperty(name: "okeClusterDeployEnvironmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OkeClusterDeployEnvironmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>production_load_balancer_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#production_load_balancer_config DevopsDeployStage#production_load_balancer_config}
        /// </remarks>
        [JsiiProperty(name: "productionLoadBalancerConfig", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageProductionLoadBalancerConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployStage.IDevopsDeployStageProductionLoadBalancerConfig? ProductionLoadBalancerConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#purpose DevopsDeployStage#purpose}.</summary>
        [JsiiProperty(name: "purpose", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Purpose
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#release_name DevopsDeployStage#release_name}.</summary>
        [JsiiProperty(name: "releaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReleaseName
        {
            get
            {
                return null;
            }
        }

        /// <summary>rollback_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#rollback_policy DevopsDeployStage#rollback_policy}
        /// </remarks>
        [JsiiProperty(name: "rollbackPolicy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageRollbackPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployStage.IDevopsDeployStageRollbackPolicy? RollbackPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>rollout_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#rollout_policy DevopsDeployStage#rollout_policy}
        /// </remarks>
        [JsiiProperty(name: "rolloutPolicy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageRolloutPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployStage.IDevopsDeployStageRolloutPolicy? RolloutPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>set_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#set_string DevopsDeployStage#set_string}
        /// </remarks>
        [JsiiProperty(name: "setString", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageSetString\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployStage.IDevopsDeployStageSetString? SetString
        {
            get
            {
                return null;
            }
        }

        /// <summary>set_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#set_values DevopsDeployStage#set_values}
        /// </remarks>
        [JsiiProperty(name: "setValues", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageSetValues\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployStage.IDevopsDeployStageSetValues? SetValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#should_cleanup_on_fail DevopsDeployStage#should_cleanup_on_fail}.</summary>
        [JsiiProperty(name: "shouldCleanupOnFail", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldCleanupOnFail
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#should_not_wait DevopsDeployStage#should_not_wait}.</summary>
        [JsiiProperty(name: "shouldNotWait", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldNotWait
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#should_reset_values DevopsDeployStage#should_reset_values}.</summary>
        [JsiiProperty(name: "shouldResetValues", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldResetValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#should_reuse_values DevopsDeployStage#should_reuse_values}.</summary>
        [JsiiProperty(name: "shouldReuseValues", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldReuseValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#should_skip_crds DevopsDeployStage#should_skip_crds}.</summary>
        [JsiiProperty(name: "shouldSkipCrds", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldSkipCrds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#should_skip_render_subchart_notes DevopsDeployStage#should_skip_render_subchart_notes}.</summary>
        [JsiiProperty(name: "shouldSkipRenderSubchartNotes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldSkipRenderSubchartNotes
        {
            get
            {
                return null;
            }
        }

        /// <summary>test_load_balancer_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#test_load_balancer_config DevopsDeployStage#test_load_balancer_config}
        /// </remarks>
        [JsiiProperty(name: "testLoadBalancerConfig", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageTestLoadBalancerConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployStage.IDevopsDeployStageTestLoadBalancerConfig? TestLoadBalancerConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#timeout_in_seconds DevopsDeployStage#timeout_in_seconds}.</summary>
        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#timeouts DevopsDeployStage#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployStage.IDevopsDeployStageTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#traffic_shift_target DevopsDeployStage#traffic_shift_target}.</summary>
        [JsiiProperty(name: "trafficShiftTarget", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrafficShiftTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#values_artifact_ids DevopsDeployStage#values_artifact_ids}.</summary>
        [JsiiProperty(name: "valuesArtifactIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ValuesArtifactIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>wait_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#wait_criteria DevopsDeployStage#wait_criteria}
        /// </remarks>
        [JsiiProperty(name: "waitCriteria", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageWaitCriteria\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsDeployStage.IDevopsDeployStageWaitCriteria? WaitCriteria
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsDeployStageConfig), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsDeployStage.IDevopsDeployStageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#deploy_pipeline_id DevopsDeployStage#deploy_pipeline_id}.</summary>
            [JsiiProperty(name: "deployPipelineId", typeJson: "{\"primitive\":\"string\"}")]
            public string DeployPipelineId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>deploy_stage_predecessor_collection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#deploy_stage_predecessor_collection DevopsDeployStage#deploy_stage_predecessor_collection}
            /// </remarks>
            [JsiiProperty(name: "deployStagePredecessorCollection", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageDeployStagePredecessorCollection\"}")]
            public oci.DevopsDeployStage.IDevopsDeployStageDeployStagePredecessorCollection DeployStagePredecessorCollection
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageDeployStagePredecessorCollection>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#deploy_stage_type DevopsDeployStage#deploy_stage_type}.</summary>
            [JsiiProperty(name: "deployStageType", typeJson: "{\"primitive\":\"string\"}")]
            public string DeployStageType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>approval_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#approval_policy DevopsDeployStage#approval_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "approvalPolicy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageApprovalPolicy\"}", isOptional: true)]
            public oci.DevopsDeployStage.IDevopsDeployStageApprovalPolicy? ApprovalPolicy
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageApprovalPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#are_hooks_enabled DevopsDeployStage#are_hooks_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "areHooksEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AreHooksEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>blue_backend_ips block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#blue_backend_ips DevopsDeployStage#blue_backend_ips}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blueBackendIps", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageBlueBackendIps\"}", isOptional: true)]
            public oci.DevopsDeployStage.IDevopsDeployStageBlueBackendIps? BlueBackendIps
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageBlueBackendIps?>();
            }

            /// <summary>blue_green_strategy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#blue_green_strategy DevopsDeployStage#blue_green_strategy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blueGreenStrategy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageBlueGreenStrategy\"}", isOptional: true)]
            public oci.DevopsDeployStage.IDevopsDeployStageBlueGreenStrategy? BlueGreenStrategy
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageBlueGreenStrategy?>();
            }

            /// <summary>canary_strategy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#canary_strategy DevopsDeployStage#canary_strategy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "canaryStrategy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageCanaryStrategy\"}", isOptional: true)]
            public oci.DevopsDeployStage.IDevopsDeployStageCanaryStrategy? CanaryStrategy
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageCanaryStrategy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#command_spec_deploy_artifact_id DevopsDeployStage#command_spec_deploy_artifact_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "commandSpecDeployArtifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CommandSpecDeployArtifactId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#compute_instance_group_blue_green_deployment_deploy_stage_id DevopsDeployStage#compute_instance_group_blue_green_deployment_deploy_stage_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeInstanceGroupBlueGreenDeploymentDeployStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeInstanceGroupBlueGreenDeploymentDeployStageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#compute_instance_group_canary_deploy_stage_id DevopsDeployStage#compute_instance_group_canary_deploy_stage_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeInstanceGroupCanaryDeployStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeInstanceGroupCanaryDeployStageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#compute_instance_group_canary_traffic_shift_deploy_stage_id DevopsDeployStage#compute_instance_group_canary_traffic_shift_deploy_stage_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeInstanceGroupCanaryTrafficShiftDeployStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeInstanceGroupCanaryTrafficShiftDeployStageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#compute_instance_group_deploy_environment_id DevopsDeployStage#compute_instance_group_deploy_environment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeInstanceGroupDeployEnvironmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeInstanceGroupDeployEnvironmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#config DevopsDeployStage#config}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "config", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Config
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>container_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#container_config DevopsDeployStage#container_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "containerConfig", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageContainerConfig\"}", isOptional: true)]
            public oci.DevopsDeployStage.IDevopsDeployStageContainerConfig? ContainerConfig
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageContainerConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#defined_tags DevopsDeployStage#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#deploy_artifact_id DevopsDeployStage#deploy_artifact_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deployArtifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeployArtifactId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#deploy_artifact_ids DevopsDeployStage#deploy_artifact_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deployArtifactIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DeployArtifactIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#deploy_environment_id_a DevopsDeployStage#deploy_environment_id_a}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deployEnvironmentIdA", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeployEnvironmentIdA
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#deploy_environment_id_b DevopsDeployStage#deploy_environment_id_b}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deployEnvironmentIdB", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeployEnvironmentIdB
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#deployment_spec_deploy_artifact_id DevopsDeployStage#deployment_spec_deploy_artifact_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentSpecDeployArtifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeploymentSpecDeployArtifactId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#description DevopsDeployStage#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#display_name DevopsDeployStage#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#docker_image_deploy_artifact_id DevopsDeployStage#docker_image_deploy_artifact_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dockerImageDeployArtifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DockerImageDeployArtifactId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>failure_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#failure_policy DevopsDeployStage#failure_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failurePolicy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageFailurePolicy\"}", isOptional: true)]
            public oci.DevopsDeployStage.IDevopsDeployStageFailurePolicy? FailurePolicy
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageFailurePolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#freeform_tags DevopsDeployStage#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#function_deploy_environment_id DevopsDeployStage#function_deploy_environment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "functionDeployEnvironmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FunctionDeployEnvironmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#function_timeout_in_seconds DevopsDeployStage#function_timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "functionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FunctionTimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>green_backend_ips block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#green_backend_ips DevopsDeployStage#green_backend_ips}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "greenBackendIps", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageGreenBackendIps\"}", isOptional: true)]
            public oci.DevopsDeployStage.IDevopsDeployStageGreenBackendIps? GreenBackendIps
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageGreenBackendIps?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#helm_chart_deploy_artifact_id DevopsDeployStage#helm_chart_deploy_artifact_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "helmChartDeployArtifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HelmChartDeployArtifactId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#helm_command_artifact_ids DevopsDeployStage#helm_command_artifact_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "helmCommandArtifactIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? HelmCommandArtifactIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#id DevopsDeployStage#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#is_async DevopsDeployStage#is_async}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isAsync", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAsync
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#is_debug_enabled DevopsDeployStage#is_debug_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isDebugEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDebugEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#is_force_enabled DevopsDeployStage#is_force_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isForceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsForceEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#is_uninstall_on_stage_delete DevopsDeployStage#is_uninstall_on_stage_delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isUninstallOnStageDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsUninstallOnStageDelete
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#is_validation_enabled DevopsDeployStage#is_validation_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isValidationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsValidationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#kubernetes_manifest_deploy_artifact_ids DevopsDeployStage#kubernetes_manifest_deploy_artifact_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kubernetesManifestDeployArtifactIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? KubernetesManifestDeployArtifactIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>load_balancer_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#load_balancer_config DevopsDeployStage#load_balancer_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerConfig", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageLoadBalancerConfig\"}", isOptional: true)]
            public oci.DevopsDeployStage.IDevopsDeployStageLoadBalancerConfig? LoadBalancerConfig
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageLoadBalancerConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#max_history DevopsDeployStage#max_history}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxHistory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxHistory
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#max_memory_in_mbs DevopsDeployStage#max_memory_in_mbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxMemoryInMbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxMemoryInMbs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#namespace DevopsDeployStage#namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#oke_blue_green_deploy_stage_id DevopsDeployStage#oke_blue_green_deploy_stage_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "okeBlueGreenDeployStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OkeBlueGreenDeployStageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#oke_canary_deploy_stage_id DevopsDeployStage#oke_canary_deploy_stage_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "okeCanaryDeployStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OkeCanaryDeployStageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#oke_canary_traffic_shift_deploy_stage_id DevopsDeployStage#oke_canary_traffic_shift_deploy_stage_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "okeCanaryTrafficShiftDeployStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OkeCanaryTrafficShiftDeployStageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#oke_cluster_deploy_environment_id DevopsDeployStage#oke_cluster_deploy_environment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "okeClusterDeployEnvironmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OkeClusterDeployEnvironmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>production_load_balancer_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#production_load_balancer_config DevopsDeployStage#production_load_balancer_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "productionLoadBalancerConfig", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageProductionLoadBalancerConfig\"}", isOptional: true)]
            public oci.DevopsDeployStage.IDevopsDeployStageProductionLoadBalancerConfig? ProductionLoadBalancerConfig
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageProductionLoadBalancerConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#purpose DevopsDeployStage#purpose}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "purpose", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Purpose
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#release_name DevopsDeployStage#release_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "releaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReleaseName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>rollback_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#rollback_policy DevopsDeployStage#rollback_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rollbackPolicy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageRollbackPolicy\"}", isOptional: true)]
            public oci.DevopsDeployStage.IDevopsDeployStageRollbackPolicy? RollbackPolicy
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageRollbackPolicy?>();
            }

            /// <summary>rollout_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#rollout_policy DevopsDeployStage#rollout_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rolloutPolicy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageRolloutPolicy\"}", isOptional: true)]
            public oci.DevopsDeployStage.IDevopsDeployStageRolloutPolicy? RolloutPolicy
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageRolloutPolicy?>();
            }

            /// <summary>set_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#set_string DevopsDeployStage#set_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "setString", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageSetString\"}", isOptional: true)]
            public oci.DevopsDeployStage.IDevopsDeployStageSetString? SetString
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageSetString?>();
            }

            /// <summary>set_values block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#set_values DevopsDeployStage#set_values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "setValues", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageSetValues\"}", isOptional: true)]
            public oci.DevopsDeployStage.IDevopsDeployStageSetValues? SetValues
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageSetValues?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#should_cleanup_on_fail DevopsDeployStage#should_cleanup_on_fail}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldCleanupOnFail", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldCleanupOnFail
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#should_not_wait DevopsDeployStage#should_not_wait}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldNotWait", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldNotWait
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#should_reset_values DevopsDeployStage#should_reset_values}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldResetValues", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldResetValues
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#should_reuse_values DevopsDeployStage#should_reuse_values}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldReuseValues", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldReuseValues
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#should_skip_crds DevopsDeployStage#should_skip_crds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldSkipCrds", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldSkipCrds
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#should_skip_render_subchart_notes DevopsDeployStage#should_skip_render_subchart_notes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldSkipRenderSubchartNotes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldSkipRenderSubchartNotes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>test_load_balancer_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#test_load_balancer_config DevopsDeployStage#test_load_balancer_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "testLoadBalancerConfig", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageTestLoadBalancerConfig\"}", isOptional: true)]
            public oci.DevopsDeployStage.IDevopsDeployStageTestLoadBalancerConfig? TestLoadBalancerConfig
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageTestLoadBalancerConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#timeout_in_seconds DevopsDeployStage#timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#timeouts DevopsDeployStage#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageTimeouts\"}", isOptional: true)]
            public oci.DevopsDeployStage.IDevopsDeployStageTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#traffic_shift_target DevopsDeployStage#traffic_shift_target}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trafficShiftTarget", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrafficShiftTarget
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#values_artifact_ids DevopsDeployStage#values_artifact_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "valuesArtifactIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ValuesArtifactIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>wait_criteria block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#wait_criteria DevopsDeployStage#wait_criteria}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "waitCriteria", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageWaitCriteria\"}", isOptional: true)]
            public oci.DevopsDeployStage.IDevopsDeployStageWaitCriteria? WaitCriteria
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageWaitCriteria?>();
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
