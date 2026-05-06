using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudMigrationsTargetAssets
{
    [JsiiClass(nativeType: typeof(oci.DataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecOutputReference), fullyQualifiedName: "oci.dataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentConfig", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecAgentConfigList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecAgentConfigList AgentConfig
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecAgentConfigList>()!;
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

        [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecCreateVnicDetailsList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecCreateVnicDetailsList CreateVnicDetails
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecCreateVnicDetailsList>()!;
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

        [JsiiProperty(name: "instanceOptions", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecInstanceOptionsList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecInstanceOptionsList InstanceOptions
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecInstanceOptionsList>()!;
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

        [JsiiProperty(name: "preemptibleInstanceConfig", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecPreemptibleInstanceConfigList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecPreemptibleInstanceConfigList PreemptibleInstanceConfig
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecPreemptibleInstanceConfigList>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecShapeConfigList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecShapeConfigList ShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecShapeConfigList>()!;
        }

        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecSourceDetailsList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecSourceDetailsList SourceDetails
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpecSourceDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpec\"}", isOptional: true)]
        public virtual oci.DataOciCloudMigrationsTargetAssets.IDataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpec? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAssets.IDataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsRecommendedSpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
