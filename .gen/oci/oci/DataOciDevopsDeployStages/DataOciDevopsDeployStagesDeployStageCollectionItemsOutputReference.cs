using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDevopsDeployStages
{
    [JsiiClass(nativeType: typeof(oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDevopsDeployStagesDeployStageCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDevopsDeployStagesDeployStageCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDevopsDeployStagesDeployStageCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDevopsDeployStagesDeployStageCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "approvalPolicy", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsApprovalPolicyList\"}")]
        public virtual oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsApprovalPolicyList ApprovalPolicy
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsApprovalPolicyList>()!;
        }

        [JsiiProperty(name: "areHooksEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AreHooksEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "blueBackendIps", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsBlueBackendIpsList\"}")]
        public virtual oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsBlueBackendIpsList BlueBackendIps
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsBlueBackendIpsList>()!;
        }

        [JsiiProperty(name: "blueGreenStrategy", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsBlueGreenStrategyList\"}")]
        public virtual oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsBlueGreenStrategyList BlueGreenStrategy
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsBlueGreenStrategyList>()!;
        }

        [JsiiProperty(name: "canaryStrategy", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsCanaryStrategyList\"}")]
        public virtual oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsCanaryStrategyList CanaryStrategy
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsCanaryStrategyList>()!;
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

        [JsiiProperty(name: "containerConfig", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsContainerConfigList\"}")]
        public virtual oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsContainerConfigList ContainerConfig
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsContainerConfigList>()!;
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

        [JsiiProperty(name: "deployStagePredecessorCollection", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsDeployStagePredecessorCollectionList\"}")]
        public virtual oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsDeployStagePredecessorCollectionList DeployStagePredecessorCollection
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsDeployStagePredecessorCollectionList>()!;
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

        [JsiiProperty(name: "failurePolicy", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsFailurePolicyList\"}")]
        public virtual oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsFailurePolicyList FailurePolicy
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsFailurePolicyList>()!;
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

        [JsiiProperty(name: "greenBackendIps", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsGreenBackendIpsList\"}")]
        public virtual oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsGreenBackendIpsList GreenBackendIps
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsGreenBackendIpsList>()!;
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

        [JsiiProperty(name: "loadBalancerConfig", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsLoadBalancerConfigList\"}")]
        public virtual oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsLoadBalancerConfigList LoadBalancerConfig
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsLoadBalancerConfigList>()!;
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

        [JsiiProperty(name: "productionLoadBalancerConfig", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsProductionLoadBalancerConfigList\"}")]
        public virtual oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsProductionLoadBalancerConfigList ProductionLoadBalancerConfig
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsProductionLoadBalancerConfigList>()!;
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

        [JsiiProperty(name: "rollbackPolicy", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsRollbackPolicyList\"}")]
        public virtual oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsRollbackPolicyList RollbackPolicy
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsRollbackPolicyList>()!;
        }

        [JsiiProperty(name: "rolloutPolicy", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsRolloutPolicyList\"}")]
        public virtual oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsRolloutPolicyList RolloutPolicy
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsRolloutPolicyList>()!;
        }

        [JsiiProperty(name: "setString", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsSetStringList\"}")]
        public virtual oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsSetStringList SetString
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsSetStringList>()!;
        }

        [JsiiProperty(name: "setValues", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsSetValuesList\"}")]
        public virtual oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsSetValuesList SetValues
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsSetValuesList>()!;
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

        [JsiiProperty(name: "testLoadBalancerConfig", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsTestLoadBalancerConfigList\"}")]
        public virtual oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsTestLoadBalancerConfigList TestLoadBalancerConfig
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsTestLoadBalancerConfigList>()!;
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

        [JsiiProperty(name: "waitCriteria", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsWaitCriteriaList\"}")]
        public virtual oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsWaitCriteriaList WaitCriteria
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItemsWaitCriteriaList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStages.DataOciDevopsDeployStagesDeployStageCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDevopsDeployStages.IDataOciDevopsDeployStagesDeployStageCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStages.IDataOciDevopsDeployStagesDeployStageCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
