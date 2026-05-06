using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciContainerengineClusters
{
    [JsiiClass(nativeType: typeof(oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsOutputReference), fullyQualifiedName: "oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciContainerengineClustersClustersOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciContainerengineClustersClustersOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciContainerengineClustersClustersOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerengineClustersClustersOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addOns", typeJson: "{\"fqn\":\"oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsAddOnsList\"}")]
        public virtual oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsAddOnsList AddOns
        {
            get => GetInstanceProperty<oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsAddOnsList>()!;
        }

        [JsiiProperty(name: "admissionControllerOptions", typeJson: "{\"fqn\":\"oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsAdmissionControllerOptionsList\"}")]
        public virtual oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsAdmissionControllerOptionsList AdmissionControllerOptions
        {
            get => GetInstanceProperty<oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsAdmissionControllerOptionsList>()!;
        }

        [JsiiProperty(name: "ipFamilies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IpFamilies
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "kubernetesNetworkConfig", typeJson: "{\"fqn\":\"oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsKubernetesNetworkConfigList\"}")]
        public virtual oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsKubernetesNetworkConfigList KubernetesNetworkConfig
        {
            get => GetInstanceProperty<oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsKubernetesNetworkConfigList>()!;
        }

        [JsiiProperty(name: "openIdConnectDiscovery", typeJson: "{\"fqn\":\"oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsOpenIdConnectDiscoveryList\"}")]
        public virtual oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsOpenIdConnectDiscoveryList OpenIdConnectDiscovery
        {
            get => GetInstanceProperty<oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsOpenIdConnectDiscoveryList>()!;
        }

        [JsiiProperty(name: "openIdConnectTokenAuthenticationConfig", typeJson: "{\"fqn\":\"oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsOpenIdConnectTokenAuthenticationConfigList\"}")]
        public virtual oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsOpenIdConnectTokenAuthenticationConfigList OpenIdConnectTokenAuthenticationConfig
        {
            get => GetInstanceProperty<oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsOpenIdConnectTokenAuthenticationConfigList>()!;
        }

        [JsiiProperty(name: "persistentVolumeConfig", typeJson: "{\"fqn\":\"oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsPersistentVolumeConfigList\"}")]
        public virtual oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsPersistentVolumeConfigList PersistentVolumeConfig
        {
            get => GetInstanceProperty<oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsPersistentVolumeConfigList>()!;
        }

        [JsiiProperty(name: "serviceLbConfig", typeJson: "{\"fqn\":\"oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsServiceLbConfigList\"}")]
        public virtual oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsServiceLbConfigList ServiceLbConfig
        {
            get => GetInstanceProperty<oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsServiceLbConfigList>()!;
        }

        [JsiiProperty(name: "serviceLbSubnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ServiceLbSubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersOptions\"}", isOptional: true)]
        public virtual oci.DataOciContainerengineClusters.IDataOciContainerengineClustersClustersOptions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciContainerengineClusters.IDataOciContainerengineClustersClustersOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
