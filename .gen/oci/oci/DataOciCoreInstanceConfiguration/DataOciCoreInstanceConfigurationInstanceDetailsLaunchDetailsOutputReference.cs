using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreInstanceConfiguration
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsOutputReference), fullyQualifiedName: "oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsAgentConfigList\"}")]
        public virtual oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsAgentConfigList AgentConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsAgentConfigList>()!;
        }

        [JsiiProperty(name: "availabilityConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfigList\"}")]
        public virtual oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfigList AvailabilityConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfigList>()!;
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

        [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsCreateVnicDetailsList\"}")]
        public virtual oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsCreateVnicDetailsList CreateVnicDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsCreateVnicDetailsList>()!;
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

        [JsiiProperty(name: "instanceOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsInstanceOptionsList\"}")]
        public virtual oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsInstanceOptionsList InstanceOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsInstanceOptionsList>()!;
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

        [JsiiProperty(name: "launchOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptionsList\"}")]
        public virtual oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptionsList LaunchOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptionsList>()!;
        }

        [JsiiProperty(name: "licensingConfigs", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsLicensingConfigsList\"}")]
        public virtual oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsLicensingConfigsList LicensingConfigs
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsLicensingConfigsList>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Metadata
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "placementConstraintDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsPlacementConstraintDetailsList\"}")]
        public virtual oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsPlacementConstraintDetailsList PlacementConstraintDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsPlacementConstraintDetailsList>()!;
        }

        [JsiiProperty(name: "platformConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsPlatformConfigList\"}")]
        public virtual oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsPlatformConfigList PlatformConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsPlatformConfigList>()!;
        }

        [JsiiProperty(name: "preemptibleInstanceConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsPreemptibleInstanceConfigList\"}")]
        public virtual oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsPreemptibleInstanceConfigList PreemptibleInstanceConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsPreemptibleInstanceConfigList>()!;
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

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsShapeConfigList\"}")]
        public virtual oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsShapeConfigList ShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsShapeConfigList>()!;
        }

        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetailsList\"}")]
        public virtual oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetailsList SourceDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsLaunchDetails\"}", isOptional: true)]
        public virtual oci.DataOciCoreInstanceConfiguration.IDataOciCoreInstanceConfigurationInstanceDetailsLaunchDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.IDataOciCoreInstanceConfigurationInstanceDetailsLaunchDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
