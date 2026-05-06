using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage oci_devops_deploy_stage}.</summary>
    [JsiiClass(nativeType: typeof(oci.DevopsDeployStage.DevopsDeployStage), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStage", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageConfig\"}}]")]
    public class DevopsDeployStage : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage oci_devops_deploy_stage} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DevopsDeployStage(Constructs.Construct scope, string id, oci.DevopsDeployStage.IDevopsDeployStageConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DevopsDeployStage.IDevopsDeployStageConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsDeployStage(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsDeployStage(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DevopsDeployStage resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DevopsDeployStage to import.</param>
        /// <param name="importFromId">The id of the existing DevopsDeployStage that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DevopsDeployStage to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DevopsDeployStage to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DevopsDeployStage that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DevopsDeployStage to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DevopsDeployStage.DevopsDeployStage), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putApprovalPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageApprovalPolicy\"}}]")]
        public virtual void PutApprovalPolicy(oci.DevopsDeployStage.IDevopsDeployStageApprovalPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageApprovalPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlueBackendIps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageBlueBackendIps\"}}]")]
        public virtual void PutBlueBackendIps(oci.DevopsDeployStage.IDevopsDeployStageBlueBackendIps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageBlueBackendIps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlueGreenStrategy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageBlueGreenStrategy\"}}]")]
        public virtual void PutBlueGreenStrategy(oci.DevopsDeployStage.IDevopsDeployStageBlueGreenStrategy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageBlueGreenStrategy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCanaryStrategy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageCanaryStrategy\"}}]")]
        public virtual void PutCanaryStrategy(oci.DevopsDeployStage.IDevopsDeployStageCanaryStrategy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageCanaryStrategy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putContainerConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageContainerConfig\"}}]")]
        public virtual void PutContainerConfig(oci.DevopsDeployStage.IDevopsDeployStageContainerConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageContainerConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeployStagePredecessorCollection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageDeployStagePredecessorCollection\"}}]")]
        public virtual void PutDeployStagePredecessorCollection(oci.DevopsDeployStage.IDevopsDeployStageDeployStagePredecessorCollection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageDeployStagePredecessorCollection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFailurePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageFailurePolicy\"}}]")]
        public virtual void PutFailurePolicy(oci.DevopsDeployStage.IDevopsDeployStageFailurePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageFailurePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGreenBackendIps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageGreenBackendIps\"}}]")]
        public virtual void PutGreenBackendIps(oci.DevopsDeployStage.IDevopsDeployStageGreenBackendIps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageGreenBackendIps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoadBalancerConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageLoadBalancerConfig\"}}]")]
        public virtual void PutLoadBalancerConfig(oci.DevopsDeployStage.IDevopsDeployStageLoadBalancerConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageLoadBalancerConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProductionLoadBalancerConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageProductionLoadBalancerConfig\"}}]")]
        public virtual void PutProductionLoadBalancerConfig(oci.DevopsDeployStage.IDevopsDeployStageProductionLoadBalancerConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageProductionLoadBalancerConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRollbackPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageRollbackPolicy\"}}]")]
        public virtual void PutRollbackPolicy(oci.DevopsDeployStage.IDevopsDeployStageRollbackPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageRollbackPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRolloutPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageRolloutPolicy\"}}]")]
        public virtual void PutRolloutPolicy(oci.DevopsDeployStage.IDevopsDeployStageRolloutPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageRolloutPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSetString", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageSetString\"}}]")]
        public virtual void PutSetString(oci.DevopsDeployStage.IDevopsDeployStageSetString @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageSetString)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSetValues", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageSetValues\"}}]")]
        public virtual void PutSetValues(oci.DevopsDeployStage.IDevopsDeployStageSetValues @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageSetValues)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTestLoadBalancerConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageTestLoadBalancerConfig\"}}]")]
        public virtual void PutTestLoadBalancerConfig(oci.DevopsDeployStage.IDevopsDeployStageTestLoadBalancerConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageTestLoadBalancerConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DevopsDeployStage.IDevopsDeployStageTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWaitCriteria", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageWaitCriteria\"}}]")]
        public virtual void PutWaitCriteria(oci.DevopsDeployStage.IDevopsDeployStageWaitCriteria @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageWaitCriteria)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApprovalPolicy")]
        public virtual void ResetApprovalPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAreHooksEnabled")]
        public virtual void ResetAreHooksEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlueBackendIps")]
        public virtual void ResetBlueBackendIps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlueGreenStrategy")]
        public virtual void ResetBlueGreenStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCanaryStrategy")]
        public virtual void ResetCanaryStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCommandSpecDeployArtifactId")]
        public virtual void ResetCommandSpecDeployArtifactId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeInstanceGroupBlueGreenDeploymentDeployStageId")]
        public virtual void ResetComputeInstanceGroupBlueGreenDeploymentDeployStageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeInstanceGroupCanaryDeployStageId")]
        public virtual void ResetComputeInstanceGroupCanaryDeployStageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeInstanceGroupCanaryTrafficShiftDeployStageId")]
        public virtual void ResetComputeInstanceGroupCanaryTrafficShiftDeployStageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeInstanceGroupDeployEnvironmentId")]
        public virtual void ResetComputeInstanceGroupDeployEnvironmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfig")]
        public virtual void ResetConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContainerConfig")]
        public virtual void ResetContainerConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeployArtifactId")]
        public virtual void ResetDeployArtifactId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeployArtifactIds")]
        public virtual void ResetDeployArtifactIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeployEnvironmentIdA")]
        public virtual void ResetDeployEnvironmentIdA()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeployEnvironmentIdB")]
        public virtual void ResetDeployEnvironmentIdB()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentSpecDeployArtifactId")]
        public virtual void ResetDeploymentSpecDeployArtifactId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDockerImageDeployArtifactId")]
        public virtual void ResetDockerImageDeployArtifactId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFailurePolicy")]
        public virtual void ResetFailurePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFunctionDeployEnvironmentId")]
        public virtual void ResetFunctionDeployEnvironmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFunctionTimeoutInSeconds")]
        public virtual void ResetFunctionTimeoutInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGreenBackendIps")]
        public virtual void ResetGreenBackendIps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHelmChartDeployArtifactId")]
        public virtual void ResetHelmChartDeployArtifactId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHelmCommandArtifactIds")]
        public virtual void ResetHelmCommandArtifactIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsAsync")]
        public virtual void ResetIsAsync()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsDebugEnabled")]
        public virtual void ResetIsDebugEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsForceEnabled")]
        public virtual void ResetIsForceEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsUninstallOnStageDelete")]
        public virtual void ResetIsUninstallOnStageDelete()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsValidationEnabled")]
        public virtual void ResetIsValidationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKubernetesManifestDeployArtifactIds")]
        public virtual void ResetKubernetesManifestDeployArtifactIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancerConfig")]
        public virtual void ResetLoadBalancerConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxHistory")]
        public virtual void ResetMaxHistory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxMemoryInMbs")]
        public virtual void ResetMaxMemoryInMbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamespace")]
        public virtual void ResetNamespace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOkeBlueGreenDeployStageId")]
        public virtual void ResetOkeBlueGreenDeployStageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOkeCanaryDeployStageId")]
        public virtual void ResetOkeCanaryDeployStageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOkeCanaryTrafficShiftDeployStageId")]
        public virtual void ResetOkeCanaryTrafficShiftDeployStageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOkeClusterDeployEnvironmentId")]
        public virtual void ResetOkeClusterDeployEnvironmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProductionLoadBalancerConfig")]
        public virtual void ResetProductionLoadBalancerConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPurpose")]
        public virtual void ResetPurpose()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReleaseName")]
        public virtual void ResetReleaseName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRollbackPolicy")]
        public virtual void ResetRollbackPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRolloutPolicy")]
        public virtual void ResetRolloutPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSetString")]
        public virtual void ResetSetString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSetValues")]
        public virtual void ResetSetValues()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShouldCleanupOnFail")]
        public virtual void ResetShouldCleanupOnFail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShouldNotWait")]
        public virtual void ResetShouldNotWait()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShouldResetValues")]
        public virtual void ResetShouldResetValues()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShouldReuseValues")]
        public virtual void ResetShouldReuseValues()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShouldSkipCrds")]
        public virtual void ResetShouldSkipCrds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShouldSkipRenderSubchartNotes")]
        public virtual void ResetShouldSkipRenderSubchartNotes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTestLoadBalancerConfig")]
        public virtual void ResetTestLoadBalancerConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeoutInSeconds")]
        public virtual void ResetTimeoutInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrafficShiftTarget")]
        public virtual void ResetTrafficShiftTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValuesArtifactIds")]
        public virtual void ResetValuesArtifactIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitCriteria")]
        public virtual void ResetWaitCriteria()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DevopsDeployStage.DevopsDeployStage))!;

        [JsiiProperty(name: "approvalPolicy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageApprovalPolicyOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageApprovalPolicyOutputReference ApprovalPolicy
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageApprovalPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "blueBackendIps", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageBlueBackendIpsOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageBlueBackendIpsOutputReference BlueBackendIps
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageBlueBackendIpsOutputReference>()!;
        }

        [JsiiProperty(name: "blueGreenStrategy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageBlueGreenStrategyOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageBlueGreenStrategyOutputReference BlueGreenStrategy
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageBlueGreenStrategyOutputReference>()!;
        }

        [JsiiProperty(name: "canaryStrategy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageCanaryStrategyOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageCanaryStrategyOutputReference CanaryStrategy
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageCanaryStrategyOutputReference>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "containerConfig", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageContainerConfigOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageContainerConfigOutputReference ContainerConfig
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageContainerConfigOutputReference>()!;
        }

        [JsiiProperty(name: "deployStagePredecessorCollection", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageDeployStagePredecessorCollectionOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageDeployStagePredecessorCollectionOutputReference DeployStagePredecessorCollection
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageDeployStagePredecessorCollectionOutputReference>()!;
        }

        [JsiiProperty(name: "failurePolicy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageFailurePolicyOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageFailurePolicyOutputReference FailurePolicy
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageFailurePolicyOutputReference>()!;
        }

        [JsiiProperty(name: "greenBackendIps", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageGreenBackendIpsOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageGreenBackendIpsOutputReference GreenBackendIps
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageGreenBackendIpsOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loadBalancerConfig", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageLoadBalancerConfigOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageLoadBalancerConfigOutputReference LoadBalancerConfig
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageLoadBalancerConfigOutputReference>()!;
        }

        [JsiiProperty(name: "productionLoadBalancerConfig", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageProductionLoadBalancerConfigOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageProductionLoadBalancerConfigOutputReference ProductionLoadBalancerConfig
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageProductionLoadBalancerConfigOutputReference>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rollbackPolicy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageRollbackPolicyOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageRollbackPolicyOutputReference RollbackPolicy
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageRollbackPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "rolloutPolicy", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageRolloutPolicyOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageRolloutPolicyOutputReference RolloutPolicy
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageRolloutPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "setString", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageSetStringOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageSetStringOutputReference SetString
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageSetStringOutputReference>()!;
        }

        [JsiiProperty(name: "setValues", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageSetValuesOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageSetValuesOutputReference SetValues
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageSetValuesOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "testLoadBalancerConfig", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageTestLoadBalancerConfigOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageTestLoadBalancerConfigOutputReference TestLoadBalancerConfig
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageTestLoadBalancerConfigOutputReference>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageTimeoutsOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "waitCriteria", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageWaitCriteriaOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageWaitCriteriaOutputReference WaitCriteria
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageWaitCriteriaOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "approvalPolicyInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageApprovalPolicy\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageApprovalPolicy? ApprovalPolicyInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageApprovalPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "areHooksEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AreHooksEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blueBackendIpsInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageBlueBackendIps\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageBlueBackendIps? BlueBackendIpsInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageBlueBackendIps?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blueGreenStrategyInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageBlueGreenStrategy\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageBlueGreenStrategy? BlueGreenStrategyInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageBlueGreenStrategy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "canaryStrategyInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageCanaryStrategy\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageCanaryStrategy? CanaryStrategyInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageCanaryStrategy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commandSpecDeployArtifactIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommandSpecDeployArtifactIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeInstanceGroupBlueGreenDeploymentDeployStageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeInstanceGroupBlueGreenDeploymentDeployStageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeInstanceGroupCanaryDeployStageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeInstanceGroupCanaryDeployStageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeInstanceGroupCanaryTrafficShiftDeployStageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeInstanceGroupCanaryTrafficShiftDeployStageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeInstanceGroupDeployEnvironmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeInstanceGroupDeployEnvironmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ConfigInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerConfigInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageContainerConfig\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageContainerConfig? ContainerConfigInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageContainerConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployArtifactIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeployArtifactIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployArtifactIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DeployArtifactIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployEnvironmentIdAInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeployEnvironmentIdAInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployEnvironmentIdBInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeployEnvironmentIdBInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentSpecDeployArtifactIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeploymentSpecDeployArtifactIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployPipelineIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeployPipelineIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployStagePredecessorCollectionInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageDeployStagePredecessorCollection\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageDeployStagePredecessorCollection? DeployStagePredecessorCollectionInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageDeployStagePredecessorCollection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployStageTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeployStageTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dockerImageDeployArtifactIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DockerImageDeployArtifactIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "failurePolicyInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageFailurePolicy\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageFailurePolicy? FailurePolicyInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageFailurePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionDeployEnvironmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FunctionDeployEnvironmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionTimeoutInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FunctionTimeoutInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "greenBackendIpsInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageGreenBackendIps\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageGreenBackendIps? GreenBackendIpsInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageGreenBackendIps?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "helmChartDeployArtifactIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HelmChartDeployArtifactIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "helmCommandArtifactIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? HelmCommandArtifactIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isAsyncInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsAsyncInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isDebugEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsDebugEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isForceEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsForceEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isUninstallOnStageDeleteInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsUninstallOnStageDeleteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isValidationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsValidationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kubernetesManifestDeployArtifactIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? KubernetesManifestDeployArtifactIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerConfigInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageLoadBalancerConfig\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageLoadBalancerConfig? LoadBalancerConfigInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageLoadBalancerConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxHistoryInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxHistoryInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxMemoryInMbsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxMemoryInMbsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "okeBlueGreenDeployStageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OkeBlueGreenDeployStageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "okeCanaryDeployStageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OkeCanaryDeployStageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "okeCanaryTrafficShiftDeployStageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OkeCanaryTrafficShiftDeployStageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "okeClusterDeployEnvironmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OkeClusterDeployEnvironmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productionLoadBalancerConfigInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageProductionLoadBalancerConfig\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageProductionLoadBalancerConfig? ProductionLoadBalancerConfigInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageProductionLoadBalancerConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "purposeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PurposeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "releaseNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReleaseNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rollbackPolicyInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageRollbackPolicy\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageRollbackPolicy? RollbackPolicyInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageRollbackPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rolloutPolicyInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageRolloutPolicy\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageRolloutPolicy? RolloutPolicyInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageRolloutPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "setStringInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageSetString\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageSetString? SetStringInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageSetString?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "setValuesInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageSetValues\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageSetValues? SetValuesInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageSetValues?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shouldCleanupOnFailInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ShouldCleanupOnFailInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shouldNotWaitInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ShouldNotWaitInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shouldResetValuesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ShouldResetValuesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shouldReuseValuesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ShouldReuseValuesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shouldSkipCrdsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ShouldSkipCrdsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shouldSkipRenderSubchartNotesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ShouldSkipRenderSubchartNotesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "testLoadBalancerConfigInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageTestLoadBalancerConfig\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageTestLoadBalancerConfig? TestLoadBalancerConfigInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageTestLoadBalancerConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeoutInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trafficShiftTargetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrafficShiftTargetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "valuesArtifactIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ValuesArtifactIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitCriteriaInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageWaitCriteria\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageWaitCriteria? WaitCriteriaInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageWaitCriteria?>();
        }

        [JsiiProperty(name: "areHooksEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AreHooksEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "commandSpecDeployArtifactId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommandSpecDeployArtifactId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeInstanceGroupBlueGreenDeploymentDeployStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeInstanceGroupBlueGreenDeploymentDeployStageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeInstanceGroupCanaryDeployStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeInstanceGroupCanaryDeployStageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeInstanceGroupCanaryTrafficShiftDeployStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeInstanceGroupCanaryTrafficShiftDeployStageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeInstanceGroupDeployEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeInstanceGroupDeployEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "config", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Config
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deployArtifactId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployArtifactId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deployArtifactIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DeployArtifactIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deployEnvironmentIdA", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployEnvironmentIdA
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deployEnvironmentIdB", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployEnvironmentIdB
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentSpecDeployArtifactId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentSpecDeployArtifactId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deployPipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployPipelineId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deployStageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployStageType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dockerImageDeployArtifactId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DockerImageDeployArtifactId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "functionDeployEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionDeployEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "functionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FunctionTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "helmChartDeployArtifactId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HelmChartDeployArtifactId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "helmCommandArtifactIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] HelmCommandArtifactIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isAsync", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsAsync
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isDebugEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsDebugEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isForceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsForceEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isUninstallOnStageDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsUninstallOnStageDelete
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isValidationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsValidationEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "kubernetesManifestDeployArtifactIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] KubernetesManifestDeployArtifactIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxHistory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxHistory
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxMemoryInMbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxMemoryInMbs
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "okeBlueGreenDeployStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OkeBlueGreenDeployStageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "okeCanaryDeployStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OkeCanaryDeployStageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "okeCanaryTrafficShiftDeployStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OkeCanaryTrafficShiftDeployStageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "okeClusterDeployEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OkeClusterDeployEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "purpose", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Purpose
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "releaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shouldCleanupOnFail", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ShouldCleanupOnFail
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "shouldNotWait", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ShouldNotWait
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "shouldResetValues", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ShouldResetValues
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "shouldReuseValues", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ShouldReuseValues
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "shouldSkipCrds", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ShouldSkipCrds
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "shouldSkipRenderSubchartNotes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ShouldSkipRenderSubchartNotes
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trafficShiftTarget", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrafficShiftTarget
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "valuesArtifactIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ValuesArtifactIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
