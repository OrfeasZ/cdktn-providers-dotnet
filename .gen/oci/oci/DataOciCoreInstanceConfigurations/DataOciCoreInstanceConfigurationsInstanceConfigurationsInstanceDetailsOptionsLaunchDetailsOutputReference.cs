using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreInstanceConfigurations
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsOutputReference), fullyQualifiedName: "oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsAgentConfigList\"}")]
        public virtual oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsAgentConfigList AgentConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsAgentConfigList>()!;
        }

        [JsiiProperty(name: "availabilityConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsAvailabilityConfigList\"}")]
        public virtual oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsAvailabilityConfigList AvailabilityConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsAvailabilityConfigList>()!;
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
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

        [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsCreateVnicDetailsList\"}")]
        public virtual oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsCreateVnicDetailsList CreateVnicDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsCreateVnicDetailsList>()!;
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

        [JsiiProperty(name: "instanceOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsInstanceOptionsList\"}")]
        public virtual oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsInstanceOptionsList InstanceOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsInstanceOptionsList>()!;
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

        [JsiiProperty(name: "launchOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsLaunchOptionsList\"}")]
        public virtual oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsLaunchOptionsList LaunchOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsLaunchOptionsList>()!;
        }

        [JsiiProperty(name: "licensingConfigs", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsLicensingConfigsList\"}")]
        public virtual oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsLicensingConfigsList LicensingConfigs
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsLicensingConfigsList>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Metadata
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "placementConstraintDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsPlacementConstraintDetailsList\"}")]
        public virtual oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsPlacementConstraintDetailsList PlacementConstraintDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsPlacementConstraintDetailsList>()!;
        }

        [JsiiProperty(name: "platformConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsPlatformConfigList\"}")]
        public virtual oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsPlatformConfigList PlatformConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsPlatformConfigList>()!;
        }

        [JsiiProperty(name: "preemptibleInstanceConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsPreemptibleInstanceConfigList\"}")]
        public virtual oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsPreemptibleInstanceConfigList PreemptibleInstanceConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsPreemptibleInstanceConfigList>()!;
        }

        [JsiiProperty(name: "preferredMaintenanceAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredMaintenanceAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SecurityAttributes
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsShapeConfigList\"}")]
        public virtual oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsShapeConfigList ShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsShapeConfigList>()!;
        }

        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsSourceDetailsList\"}")]
        public virtual oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsSourceDetailsList SourceDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsSourceDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetails\"}", isOptional: true)]
        public virtual oci.DataOciCoreInstanceConfigurations.IDataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.IDataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
