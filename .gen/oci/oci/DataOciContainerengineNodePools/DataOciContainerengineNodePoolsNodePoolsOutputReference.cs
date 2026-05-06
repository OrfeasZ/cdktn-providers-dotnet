using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciContainerengineNodePools
{
    [JsiiClass(nativeType: typeof(oci.DataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsOutputReference), fullyQualifiedName: "oci.dataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciContainerengineNodePoolsNodePoolsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciContainerengineNodePoolsNodePoolsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciContainerengineNodePoolsNodePoolsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerengineNodePoolsNodePoolsOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "initialNodeLabels", typeJson: "{\"fqn\":\"oci.dataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsInitialNodeLabelsList\"}")]
        public virtual oci.DataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsInitialNodeLabelsList InitialNodeLabels
        {
            get => GetInstanceProperty<oci.DataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsInitialNodeLabelsList>()!;
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeConfigDetails", typeJson: "{\"fqn\":\"oci.dataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodeConfigDetailsList\"}")]
        public virtual oci.DataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodeConfigDetailsList NodeConfigDetails
        {
            get => GetInstanceProperty<oci.DataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodeConfigDetailsList>()!;
        }

        [JsiiProperty(name: "nodeEvictionNodePoolSettings", typeJson: "{\"fqn\":\"oci.dataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodeEvictionNodePoolSettingsList\"}")]
        public virtual oci.DataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodeEvictionNodePoolSettingsList NodeEvictionNodePoolSettings
        {
            get => GetInstanceProperty<oci.DataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodeEvictionNodePoolSettingsList>()!;
        }

        [JsiiProperty(name: "nodeImageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeImageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeImageName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeImageName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeMetadata", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap NodeMetadata
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "nodePoolCyclingDetails", typeJson: "{\"fqn\":\"oci.dataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodePoolCyclingDetailsList\"}")]
        public virtual oci.DataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodePoolCyclingDetailsList NodePoolCyclingDetails
        {
            get => GetInstanceProperty<oci.DataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodePoolCyclingDetailsList>()!;
        }

        [JsiiProperty(name: "nodePoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodePoolId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodes", typeJson: "{\"fqn\":\"oci.dataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodesList\"}")]
        public virtual oci.DataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodesList Nodes
        {
            get => GetInstanceProperty<oci.DataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodesList>()!;
        }

        [JsiiProperty(name: "nodeShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeShapeConfig", typeJson: "{\"fqn\":\"oci.dataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodeShapeConfigList\"}")]
        public virtual oci.DataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodeShapeConfigList NodeShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodeShapeConfigList>()!;
        }

        [JsiiProperty(name: "nodeSource", typeJson: "{\"fqn\":\"oci.dataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodeSourceList\"}")]
        public virtual oci.DataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodeSourceList NodeSource
        {
            get => GetInstanceProperty<oci.DataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodeSourceList>()!;
        }

        [JsiiProperty(name: "nodeSourceDetails", typeJson: "{\"fqn\":\"oci.dataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodeSourceDetailsList\"}")]
        public virtual oci.DataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodeSourceDetailsList NodeSourceDetails
        {
            get => GetInstanceProperty<oci.DataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePoolsNodeSourceDetailsList>()!;
        }

        [JsiiProperty(name: "quantityPerSubnet", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QuantityPerSubnet
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sshPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SshPublicKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciContainerengineNodePools.DataOciContainerengineNodePoolsNodePools\"}", isOptional: true)]
        public virtual oci.DataOciContainerengineNodePools.IDataOciContainerengineNodePoolsNodePools? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciContainerengineNodePools.IDataOciContainerengineNodePoolsNodePools?>();
            set => SetInstanceProperty(value);
        }
    }
}
