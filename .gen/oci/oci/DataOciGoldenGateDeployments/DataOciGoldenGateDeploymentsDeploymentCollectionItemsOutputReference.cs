using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGoldenGateDeployments
{
    [JsiiClass(nativeType: typeof(oci.DataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciGoldenGateDeploymentsDeploymentCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciGoldenGateDeploymentsDeploymentCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciGoldenGateDeploymentsDeploymentCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGoldenGateDeploymentsDeploymentCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupSchedule", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsBackupScheduleList\"}")]
        public virtual oci.DataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsBackupScheduleList BackupSchedule
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsBackupScheduleList>()!;
        }

        [JsiiProperty(name: "byolCpuCoreCountLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ByolCpuCoreCountLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterPlacementGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deploymentBackupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentBackupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deploymentDiagnosticData", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsDeploymentDiagnosticDataList\"}")]
        public virtual oci.DataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsDeploymentDiagnosticDataList DeploymentDiagnosticData
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsDeploymentDiagnosticDataList>()!;
        }

        [JsiiProperty(name: "deploymentRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentRole
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deploymentUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentUrl
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

        [JsiiProperty(name: "environmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnvironmentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FaultDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ingressIps", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsIngressIpsList\"}")]
        public virtual oci.DataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsIngressIpsList IngressIps
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsIngressIpsList>()!;
        }

        [JsiiProperty(name: "isAutoScalingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoScalingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isByolCpuCoreCountLimitEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsByolCpuCoreCountLimitEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHealthy", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHealthy
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isLatestVersion", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLatestVersion
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isLockOverride", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLockOverride
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPublic", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPublic
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isStorageUtilizationLimitExceeded", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsStorageUtilizationLimitExceeded
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleSubState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleSubState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loadBalancerSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerSubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locks", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsLocksList\"}")]
        public virtual oci.DataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsLocksList Locks
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsLocksList>()!;
        }

        [JsiiProperty(name: "maintenanceConfiguration", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsMaintenanceConfigurationList\"}")]
        public virtual oci.DataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsMaintenanceConfigurationList MaintenanceConfiguration
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsMaintenanceConfigurationList>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsMaintenanceWindowList\"}")]
        public virtual oci.DataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsMaintenanceWindowList>()!;
        }

        [JsiiProperty(name: "nextMaintenanceActionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextMaintenanceActionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nextMaintenanceDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextMaintenanceDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "oggData", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsOggDataList\"}")]
        public virtual oci.DataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsOggDataList OggData
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsOggDataList>()!;
        }

        [JsiiProperty(name: "placements", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsPlacementsList\"}")]
        public virtual oci.DataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsPlacementsList Placements
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItemsPlacementsList>()!;
        }

        [JsiiProperty(name: "privateIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SecurityAttributes
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "sourceDeploymentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDeploymentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageUtilizationInBytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageUtilizationInBytes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastBackupScheduled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastBackupScheduled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeNextBackupScheduled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeNextBackupScheduled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfNextMaintenance", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfNextMaintenance
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOggVersionSupportedUntil", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOggVersionSupportedUntil
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeRoleChanged", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeRoleChanged
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpgradeRequired", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpgradeRequired
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateDeployments.DataOciGoldenGateDeploymentsDeploymentCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciGoldenGateDeployments.IDataOciGoldenGateDeploymentsDeploymentCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateDeployments.IDataOciGoldenGateDeploymentsDeploymentCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
