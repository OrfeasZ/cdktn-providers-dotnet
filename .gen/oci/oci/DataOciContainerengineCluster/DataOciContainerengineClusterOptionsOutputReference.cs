using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciContainerengineCluster
{
    [JsiiClass(nativeType: typeof(oci.DataOciContainerengineCluster.DataOciContainerengineClusterOptionsOutputReference), fullyQualifiedName: "oci.dataOciContainerengineCluster.DataOciContainerengineClusterOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciContainerengineClusterOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciContainerengineClusterOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciContainerengineClusterOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerengineClusterOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addOns", typeJson: "{\"fqn\":\"oci.dataOciContainerengineCluster.DataOciContainerengineClusterOptionsAddOnsList\"}")]
        public virtual oci.DataOciContainerengineCluster.DataOciContainerengineClusterOptionsAddOnsList AddOns
        {
            get => GetInstanceProperty<oci.DataOciContainerengineCluster.DataOciContainerengineClusterOptionsAddOnsList>()!;
        }

        [JsiiProperty(name: "admissionControllerOptions", typeJson: "{\"fqn\":\"oci.dataOciContainerengineCluster.DataOciContainerengineClusterOptionsAdmissionControllerOptionsList\"}")]
        public virtual oci.DataOciContainerengineCluster.DataOciContainerengineClusterOptionsAdmissionControllerOptionsList AdmissionControllerOptions
        {
            get => GetInstanceProperty<oci.DataOciContainerengineCluster.DataOciContainerengineClusterOptionsAdmissionControllerOptionsList>()!;
        }

        [JsiiProperty(name: "ipFamilies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IpFamilies
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "kubernetesNetworkConfig", typeJson: "{\"fqn\":\"oci.dataOciContainerengineCluster.DataOciContainerengineClusterOptionsKubernetesNetworkConfigList\"}")]
        public virtual oci.DataOciContainerengineCluster.DataOciContainerengineClusterOptionsKubernetesNetworkConfigList KubernetesNetworkConfig
        {
            get => GetInstanceProperty<oci.DataOciContainerengineCluster.DataOciContainerengineClusterOptionsKubernetesNetworkConfigList>()!;
        }

        [JsiiProperty(name: "openIdConnectDiscovery", typeJson: "{\"fqn\":\"oci.dataOciContainerengineCluster.DataOciContainerengineClusterOptionsOpenIdConnectDiscoveryList\"}")]
        public virtual oci.DataOciContainerengineCluster.DataOciContainerengineClusterOptionsOpenIdConnectDiscoveryList OpenIdConnectDiscovery
        {
            get => GetInstanceProperty<oci.DataOciContainerengineCluster.DataOciContainerengineClusterOptionsOpenIdConnectDiscoveryList>()!;
        }

        [JsiiProperty(name: "openIdConnectTokenAuthenticationConfig", typeJson: "{\"fqn\":\"oci.dataOciContainerengineCluster.DataOciContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigList\"}")]
        public virtual oci.DataOciContainerengineCluster.DataOciContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigList OpenIdConnectTokenAuthenticationConfig
        {
            get => GetInstanceProperty<oci.DataOciContainerengineCluster.DataOciContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigList>()!;
        }

        [JsiiProperty(name: "persistentVolumeConfig", typeJson: "{\"fqn\":\"oci.dataOciContainerengineCluster.DataOciContainerengineClusterOptionsPersistentVolumeConfigList\"}")]
        public virtual oci.DataOciContainerengineCluster.DataOciContainerengineClusterOptionsPersistentVolumeConfigList PersistentVolumeConfig
        {
            get => GetInstanceProperty<oci.DataOciContainerengineCluster.DataOciContainerengineClusterOptionsPersistentVolumeConfigList>()!;
        }

        [JsiiProperty(name: "serviceLbConfig", typeJson: "{\"fqn\":\"oci.dataOciContainerengineCluster.DataOciContainerengineClusterOptionsServiceLbConfigList\"}")]
        public virtual oci.DataOciContainerengineCluster.DataOciContainerengineClusterOptionsServiceLbConfigList ServiceLbConfig
        {
            get => GetInstanceProperty<oci.DataOciContainerengineCluster.DataOciContainerengineClusterOptionsServiceLbConfigList>()!;
        }

        [JsiiProperty(name: "serviceLbSubnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ServiceLbSubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciContainerengineCluster.DataOciContainerengineClusterOptions\"}", isOptional: true)]
        public virtual oci.DataOciContainerengineCluster.IDataOciContainerengineClusterOptions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciContainerengineCluster.IDataOciContainerengineClusterOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
