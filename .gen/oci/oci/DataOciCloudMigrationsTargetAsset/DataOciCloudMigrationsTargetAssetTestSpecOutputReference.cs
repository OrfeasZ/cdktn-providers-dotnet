using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudMigrationsTargetAsset
{
    [JsiiClass(nativeType: typeof(oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecOutputReference), fullyQualifiedName: "oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCloudMigrationsTargetAssetTestSpecOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCloudMigrationsTargetAssetTestSpecOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCloudMigrationsTargetAssetTestSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudMigrationsTargetAssetTestSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentConfig", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecAgentConfigList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecAgentConfigList AgentConfig
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecAgentConfigList>()!;
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

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecCreateVnicDetailsList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecCreateVnicDetailsList CreateVnicDetails
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecCreateVnicDetailsList>()!;
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

        [JsiiProperty(name: "instanceOptions", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecInstanceOptionsList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecInstanceOptionsList InstanceOptions
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecInstanceOptionsList>()!;
        }

        [JsiiProperty(name: "ipxeScript", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpxeScript
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isPvEncryptionInTransitEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPvEncryptionInTransitEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "preemptibleInstanceConfig", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecPreemptibleInstanceConfigList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecPreemptibleInstanceConfigList PreemptibleInstanceConfig
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecPreemptibleInstanceConfigList>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecShapeConfigList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecShapeConfigList ShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecShapeConfigList>()!;
        }

        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecSourceDetailsList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecSourceDetailsList SourceDetails
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecSourceDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpec\"}", isOptional: true)]
        public virtual oci.DataOciCloudMigrationsTargetAsset.IDataOciCloudMigrationsTargetAssetTestSpec? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAsset.IDataOciCloudMigrationsTargetAssetTestSpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
