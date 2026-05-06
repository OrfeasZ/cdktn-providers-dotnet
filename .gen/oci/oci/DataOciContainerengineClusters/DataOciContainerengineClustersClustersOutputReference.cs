using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciContainerengineClusters
{
    [JsiiClass(nativeType: typeof(oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOutputReference), fullyQualifiedName: "oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciContainerengineClustersClustersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciContainerengineClustersClustersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciContainerengineClustersClustersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerengineClustersClustersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "availableKubernetesUpgrades", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailableKubernetesUpgrades
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "clusterPodNetworkOptions", typeJson: "{\"fqn\":\"oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersClusterPodNetworkOptionsList\"}")]
        public virtual oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersClusterPodNetworkOptionsList ClusterPodNetworkOptions
        {
            get => GetInstanceProperty<oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersClusterPodNetworkOptionsList>()!;
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

        [JsiiProperty(name: "endpointConfig", typeJson: "{\"fqn\":\"oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersEndpointConfigList\"}")]
        public virtual oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersEndpointConfigList EndpointConfig
        {
            get => GetInstanceProperty<oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersEndpointConfigList>()!;
        }

        [JsiiProperty(name: "endpoints", typeJson: "{\"fqn\":\"oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersEndpointsList\"}")]
        public virtual oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersEndpointsList Endpoints
        {
            get => GetInstanceProperty<oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersEndpointsList>()!;
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

        [JsiiProperty(name: "imagePolicyConfig", typeJson: "{\"fqn\":\"oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersImagePolicyConfigList\"}")]
        public virtual oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersImagePolicyConfigList ImagePolicyConfig
        {
            get => GetInstanceProperty<oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersImagePolicyConfigList>()!;
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersMetadataList\"}")]
        public virtual oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersMetadataList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "openIdConnectDiscoveryEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpenIdConnectDiscoveryEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "openIdConnectDiscoveryKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpenIdConnectDiscoveryKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "options", typeJson: "{\"fqn\":\"oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsList\"}")]
        public virtual oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsList Options
        {
            get => GetInstanceProperty<oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcnId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciContainerengineClusters.DataOciContainerengineClustersClusters\"}", isOptional: true)]
        public virtual oci.DataOciContainerengineClusters.IDataOciContainerengineClustersClusters? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciContainerengineClusters.IDataOciContainerengineClustersClusters?>();
            set => SetInstanceProperty(value);
        }
    }
}
