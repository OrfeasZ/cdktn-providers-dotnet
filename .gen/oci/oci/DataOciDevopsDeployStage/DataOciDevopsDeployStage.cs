using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDevopsDeployStage
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/devops_deploy_stage oci_devops_deploy_stage}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDevopsDeployStage.DataOciDevopsDeployStage), fullyQualifiedName: "oci.dataOciDevopsDeployStage.DataOciDevopsDeployStage", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageConfig\"}}]")]
    public class DataOciDevopsDeployStage : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/devops_deploy_stage oci_devops_deploy_stage} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDevopsDeployStage(Constructs.Construct scope, string id, oci.DataOciDevopsDeployStage.IDataOciDevopsDeployStageConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDevopsDeployStage.IDataOciDevopsDeployStageConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDevopsDeployStage(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDevopsDeployStage(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDevopsDeployStage resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDevopsDeployStage to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDevopsDeployStage that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDevopsDeployStage to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDevopsDeployStage to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/devops_deploy_stage#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDevopsDeployStage that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDevopsDeployStage to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDevopsDeployStage.DataOciDevopsDeployStage), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDevopsDeployStage.DataOciDevopsDeployStage))!;

        [JsiiProperty(name: "approvalPolicy", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageApprovalPolicyList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageApprovalPolicyList ApprovalPolicy
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageApprovalPolicyList>()!;
        }

        [JsiiProperty(name: "areHooksEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AreHooksEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "blueBackendIps", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageBlueBackendIpsList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageBlueBackendIpsList BlueBackendIps
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageBlueBackendIpsList>()!;
        }

        [JsiiProperty(name: "blueGreenStrategy", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageBlueGreenStrategyList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageBlueGreenStrategyList BlueGreenStrategy
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageBlueGreenStrategyList>()!;
        }

        [JsiiProperty(name: "canaryStrategy", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageCanaryStrategyList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageCanaryStrategyList CanaryStrategy
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageCanaryStrategyList>()!;
        }

        [JsiiProperty(name: "commandSpecDeployArtifactId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommandSpecDeployArtifactId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeInstanceGroupBlueGreenDeploymentDeployStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeInstanceGroupBlueGreenDeploymentDeployStageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeInstanceGroupCanaryDeployStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeInstanceGroupCanaryDeployStageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeInstanceGroupCanaryTrafficShiftDeployStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeInstanceGroupCanaryTrafficShiftDeployStageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeInstanceGroupDeployEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeInstanceGroupDeployEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Config
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "containerConfig", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageContainerConfigList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageContainerConfigList ContainerConfig
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageContainerConfigList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deployArtifactId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployArtifactId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployArtifactIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DeployArtifactIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "deployEnvironmentIdA", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployEnvironmentIdA
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployEnvironmentIdB", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployEnvironmentIdB
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deploymentSpecDeployArtifactId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentSpecDeployArtifactId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployPipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployPipelineId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployStagePredecessorCollection", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageDeployStagePredecessorCollectionList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageDeployStagePredecessorCollectionList DeployStagePredecessorCollection
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageDeployStagePredecessorCollectionList>()!;
        }

        [JsiiProperty(name: "deployStageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployStageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dockerImageDeployArtifactId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DockerImageDeployArtifactId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failurePolicy", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageFailurePolicyList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageFailurePolicyList FailurePolicy
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageFailurePolicyList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "functionDeployEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionDeployEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "functionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FunctionTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "greenBackendIps", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageGreenBackendIpsList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageGreenBackendIpsList GreenBackendIps
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageGreenBackendIpsList>()!;
        }

        [JsiiProperty(name: "helmChartDeployArtifactId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HelmChartDeployArtifactId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "helmCommandArtifactIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] HelmCommandArtifactIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAsync", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAsync
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDebugEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDebugEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isForceEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsForceEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isUninstallOnStageDelete", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsUninstallOnStageDelete
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isValidationEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsValidationEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "kubernetesManifestDeployArtifactIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] KubernetesManifestDeployArtifactIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loadBalancerConfig", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageLoadBalancerConfigList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageLoadBalancerConfigList LoadBalancerConfig
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageLoadBalancerConfigList>()!;
        }

        [JsiiProperty(name: "maxHistory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxHistory
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxMemoryInMbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxMemoryInMbs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "okeBlueGreenDeployStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OkeBlueGreenDeployStageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "okeCanaryDeployStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OkeCanaryDeployStageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "okeCanaryTrafficShiftDeployStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OkeCanaryTrafficShiftDeployStageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "okeClusterDeployEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OkeClusterDeployEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productionLoadBalancerConfig", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageProductionLoadBalancerConfigList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageProductionLoadBalancerConfigList ProductionLoadBalancerConfig
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageProductionLoadBalancerConfigList>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "purpose", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Purpose
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "releaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rollbackPolicy", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageRollbackPolicyList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageRollbackPolicyList RollbackPolicy
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageRollbackPolicyList>()!;
        }

        [JsiiProperty(name: "rolloutPolicy", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageRolloutPolicyList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageRolloutPolicyList RolloutPolicy
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageRolloutPolicyList>()!;
        }

        [JsiiProperty(name: "setString", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageSetStringList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageSetStringList SetString
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageSetStringList>()!;
        }

        [JsiiProperty(name: "setValues", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageSetValuesList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageSetValuesList SetValues
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageSetValuesList>()!;
        }

        [JsiiProperty(name: "shouldCleanupOnFail", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShouldCleanupOnFail
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "shouldNotWait", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShouldNotWait
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "shouldResetValues", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShouldResetValues
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "shouldReuseValues", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShouldReuseValues
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "shouldSkipCrds", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShouldSkipCrds
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "shouldSkipRenderSubchartNotes", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShouldSkipRenderSubchartNotes
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "testLoadBalancerConfig", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageTestLoadBalancerConfigList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageTestLoadBalancerConfigList TestLoadBalancerConfig
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageTestLoadBalancerConfigList>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trafficShiftTarget", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrafficShiftTarget
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "valuesArtifactIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ValuesArtifactIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "waitCriteria", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageWaitCriteriaList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageWaitCriteriaList WaitCriteria
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageWaitCriteriaList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployStageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeployStageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "deployStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployStageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
