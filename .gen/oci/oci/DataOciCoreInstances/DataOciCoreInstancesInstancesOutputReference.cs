using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreInstances
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreInstances.DataOciCoreInstancesInstancesOutputReference), fullyQualifiedName: "oci.dataOciCoreInstances.DataOciCoreInstancesInstancesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreInstancesInstancesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreInstancesInstancesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreInstancesInstancesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreInstancesInstancesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreInstances.DataOciCoreInstancesInstancesAgentConfigList\"}")]
        public virtual oci.DataOciCoreInstances.DataOciCoreInstancesInstancesAgentConfigList AgentConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreInstances.DataOciCoreInstancesInstancesAgentConfigList>()!;
        }

        [JsiiProperty(name: "async", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Async
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "availabilityConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreInstances.DataOciCoreInstancesInstancesAvailabilityConfigList\"}")]
        public virtual oci.DataOciCoreInstances.DataOciCoreInstancesInstancesAvailabilityConfigList AvailabilityConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreInstances.DataOciCoreInstancesInstancesAvailabilityConfigList>()!;
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootVolumeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootVolumeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationId
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

        [JsiiProperty(name: "computeClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreInstances.DataOciCoreInstancesInstancesCreateVnicDetailsList\"}")]
        public virtual oci.DataOciCoreInstances.DataOciCoreInstancesInstancesCreateVnicDetailsList CreateVnicDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreInstances.DataOciCoreInstancesInstancesCreateVnicDetailsList>()!;
        }

        [JsiiProperty(name: "dedicatedVmHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DedicatedVmHostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "extendedMetadata", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap ExtendedMetadata
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FaultDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "hostnameLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostnameLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceConfigurationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreInstances.DataOciCoreInstancesInstancesInstanceOptionsList\"}")]
        public virtual oci.DataOciCoreInstances.DataOciCoreInstancesInstancesInstanceOptionsList InstanceOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreInstances.DataOciCoreInstancesInstancesInstanceOptionsList>()!;
        }

        [JsiiProperty(name: "ipxeScript", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpxeScript
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAiEnterpriseEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAiEnterpriseEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isCrossNumaNode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCrossNumaNode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPvEncryptionInTransitEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPvEncryptionInTransitEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "launchMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "launchOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreInstances.DataOciCoreInstancesInstancesLaunchOptionsList\"}")]
        public virtual oci.DataOciCoreInstances.DataOciCoreInstancesInstancesLaunchOptionsList LaunchOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreInstances.DataOciCoreInstancesInstancesLaunchOptionsList>()!;
        }

        [JsiiProperty(name: "launchVolumeAttachments", typeJson: "{\"fqn\":\"oci.dataOciCoreInstances.DataOciCoreInstancesInstancesLaunchVolumeAttachmentsList\"}")]
        public virtual oci.DataOciCoreInstances.DataOciCoreInstancesInstancesLaunchVolumeAttachmentsList LaunchVolumeAttachments
        {
            get => GetInstanceProperty<oci.DataOciCoreInstances.DataOciCoreInstancesInstancesLaunchVolumeAttachmentsList>()!;
        }

        [JsiiProperty(name: "licensingConfigs", typeJson: "{\"fqn\":\"oci.dataOciCoreInstances.DataOciCoreInstancesInstancesLicensingConfigsList\"}")]
        public virtual oci.DataOciCoreInstances.DataOciCoreInstancesInstancesLicensingConfigsList LicensingConfigs
        {
            get => GetInstanceProperty<oci.DataOciCoreInstances.DataOciCoreInstancesInstancesLicensingConfigsList>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Metadata
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "placementConstraintDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreInstances.DataOciCoreInstancesInstancesPlacementConstraintDetailsList\"}")]
        public virtual oci.DataOciCoreInstances.DataOciCoreInstancesInstancesPlacementConstraintDetailsList PlacementConstraintDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreInstances.DataOciCoreInstancesInstancesPlacementConstraintDetailsList>()!;
        }

        [JsiiProperty(name: "platformConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreInstances.DataOciCoreInstancesInstancesPlatformConfigList\"}")]
        public virtual oci.DataOciCoreInstances.DataOciCoreInstancesInstancesPlatformConfigList PlatformConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreInstances.DataOciCoreInstancesInstancesPlatformConfigList>()!;
        }

        [JsiiProperty(name: "preemptibleInstanceConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreInstances.DataOciCoreInstancesInstancesPreemptibleInstanceConfigList\"}")]
        public virtual oci.DataOciCoreInstances.DataOciCoreInstancesInstancesPreemptibleInstanceConfigList PreemptibleInstanceConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreInstances.DataOciCoreInstancesInstancesPreemptibleInstanceConfigList>()!;
        }

        [JsiiProperty(name: "preserveBootVolume", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PreserveBootVolume
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "preserveDataVolumesCreatedAtLaunch", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PreserveDataVolumesCreatedAtLaunch
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SecurityAttributes
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "securityAttributesState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityAttributesState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreInstances.DataOciCoreInstancesInstancesShapeConfigList\"}")]
        public virtual oci.DataOciCoreInstances.DataOciCoreInstancesInstancesShapeConfigList ShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreInstances.DataOciCoreInstancesInstancesShapeConfigList>()!;
        }

        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreInstances.DataOciCoreInstancesInstancesSourceDetailsList\"}")]
        public virtual oci.DataOciCoreInstances.DataOciCoreInstancesInstancesSourceDetailsList SourceDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreInstances.DataOciCoreInstancesInstancesSourceDetailsList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
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

        [JsiiProperty(name: "timeMaintenanceRebootDue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMaintenanceRebootDue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updateOperationConstraint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateOperationConstraint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreInstances.DataOciCoreInstancesInstances\"}", isOptional: true)]
        public virtual oci.DataOciCoreInstances.IDataOciCoreInstancesInstances? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreInstances.IDataOciCoreInstancesInstances?>();
            set => SetInstanceProperty(value);
        }
    }
}
