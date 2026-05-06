using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciContainerengineVirtualNodePools
{
    [JsiiClass(nativeType: typeof(oci.DataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePoolsOutputReference), fullyQualifiedName: "oci.dataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePoolsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciContainerengineVirtualNodePoolsVirtualNodePoolsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciContainerengineVirtualNodePoolsVirtualNodePoolsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciContainerengineVirtualNodePoolsVirtualNodePoolsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerengineVirtualNodePoolsVirtualNodePoolsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
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

        [JsiiProperty(name: "initialVirtualNodeLabels", typeJson: "{\"fqn\":\"oci.dataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePoolsInitialVirtualNodeLabelsList\"}")]
        public virtual oci.DataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePoolsInitialVirtualNodeLabelsList InitialVirtualNodeLabels
        {
            get => GetInstanceProperty<oci.DataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePoolsInitialVirtualNodeLabelsList>()!;
        }

        [JsiiProperty(name: "kubernetesVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KubernetesVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "placementConfigurations", typeJson: "{\"fqn\":\"oci.dataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePoolsPlacementConfigurationsList\"}")]
        public virtual oci.DataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePoolsPlacementConfigurationsList PlacementConfigurations
        {
            get => GetInstanceProperty<oci.DataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePoolsPlacementConfigurationsList>()!;
        }

        [JsiiProperty(name: "podConfiguration", typeJson: "{\"fqn\":\"oci.dataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePoolsPodConfigurationList\"}")]
        public virtual oci.DataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePoolsPodConfigurationList PodConfiguration
        {
            get => GetInstanceProperty<oci.DataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePoolsPodConfigurationList>()!;
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Size
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "taints", typeJson: "{\"fqn\":\"oci.dataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePoolsTaintsList\"}")]
        public virtual oci.DataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePoolsTaintsList Taints
        {
            get => GetInstanceProperty<oci.DataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePoolsTaintsList>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualNodePoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualNodePoolId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualNodeTags", typeJson: "{\"fqn\":\"oci.dataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePoolsVirtualNodeTagsList\"}")]
        public virtual oci.DataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePoolsVirtualNodeTagsList VirtualNodeTags
        {
            get => GetInstanceProperty<oci.DataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePoolsVirtualNodeTagsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciContainerengineVirtualNodePools.DataOciContainerengineVirtualNodePoolsVirtualNodePools\"}", isOptional: true)]
        public virtual oci.DataOciContainerengineVirtualNodePools.IDataOciContainerengineVirtualNodePoolsVirtualNodePools? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciContainerengineVirtualNodePools.IDataOciContainerengineVirtualNodePoolsVirtualNodePools?>();
            set => SetInstanceProperty(value);
        }
    }
}
