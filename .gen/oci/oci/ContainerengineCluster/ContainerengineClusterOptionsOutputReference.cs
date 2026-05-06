using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineCluster
{
    [JsiiClass(nativeType: typeof(oci.ContainerengineCluster.ContainerengineClusterOptionsOutputReference), fullyQualifiedName: "oci.containerengineCluster.ContainerengineClusterOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ContainerengineClusterOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ContainerengineClusterOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerengineClusterOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerengineClusterOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAddOns", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsAddOns\"}}]")]
        public virtual void PutAddOns(oci.ContainerengineCluster.IContainerengineClusterOptionsAddOns @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineCluster.IContainerengineClusterOptionsAddOns)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAdmissionControllerOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsAdmissionControllerOptions\"}}]")]
        public virtual void PutAdmissionControllerOptions(oci.ContainerengineCluster.IContainerengineClusterOptionsAdmissionControllerOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineCluster.IContainerengineClusterOptionsAdmissionControllerOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKubernetesNetworkConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsKubernetesNetworkConfig\"}}]")]
        public virtual void PutKubernetesNetworkConfig(oci.ContainerengineCluster.IContainerengineClusterOptionsKubernetesNetworkConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineCluster.IContainerengineClusterOptionsKubernetesNetworkConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenIdConnectDiscovery", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectDiscovery\"}}]")]
        public virtual void PutOpenIdConnectDiscovery(oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectDiscovery @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectDiscovery)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenIdConnectTokenAuthenticationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig\"}}]")]
        public virtual void PutOpenIdConnectTokenAuthenticationConfig(oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPersistentVolumeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsPersistentVolumeConfig\"}}]")]
        public virtual void PutPersistentVolumeConfig(oci.ContainerengineCluster.IContainerengineClusterOptionsPersistentVolumeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineCluster.IContainerengineClusterOptionsPersistentVolumeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceLbConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsServiceLbConfig\"}}]")]
        public virtual void PutServiceLbConfig(oci.ContainerengineCluster.IContainerengineClusterOptionsServiceLbConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineCluster.IContainerengineClusterOptionsServiceLbConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAddOns")]
        public virtual void ResetAddOns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdmissionControllerOptions")]
        public virtual void ResetAdmissionControllerOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpFamilies")]
        public virtual void ResetIpFamilies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKubernetesNetworkConfig")]
        public virtual void ResetKubernetesNetworkConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenIdConnectDiscovery")]
        public virtual void ResetOpenIdConnectDiscovery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenIdConnectTokenAuthenticationConfig")]
        public virtual void ResetOpenIdConnectTokenAuthenticationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPersistentVolumeConfig")]
        public virtual void ResetPersistentVolumeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceLbConfig")]
        public virtual void ResetServiceLbConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceLbSubnetIds")]
        public virtual void ResetServiceLbSubnetIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "addOns", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsAddOnsOutputReference\"}")]
        public virtual oci.ContainerengineCluster.ContainerengineClusterOptionsAddOnsOutputReference AddOns
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.ContainerengineClusterOptionsAddOnsOutputReference>()!;
        }

        [JsiiProperty(name: "admissionControllerOptions", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsAdmissionControllerOptionsOutputReference\"}")]
        public virtual oci.ContainerengineCluster.ContainerengineClusterOptionsAdmissionControllerOptionsOutputReference AdmissionControllerOptions
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.ContainerengineClusterOptionsAdmissionControllerOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "kubernetesNetworkConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsKubernetesNetworkConfigOutputReference\"}")]
        public virtual oci.ContainerengineCluster.ContainerengineClusterOptionsKubernetesNetworkConfigOutputReference KubernetesNetworkConfig
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.ContainerengineClusterOptionsKubernetesNetworkConfigOutputReference>()!;
        }

        [JsiiProperty(name: "openIdConnectDiscovery", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectDiscoveryOutputReference\"}")]
        public virtual oci.ContainerengineCluster.ContainerengineClusterOptionsOpenIdConnectDiscoveryOutputReference OpenIdConnectDiscovery
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.ContainerengineClusterOptionsOpenIdConnectDiscoveryOutputReference>()!;
        }

        [JsiiProperty(name: "openIdConnectTokenAuthenticationConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigOutputReference\"}")]
        public virtual oci.ContainerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigOutputReference OpenIdConnectTokenAuthenticationConfig
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigOutputReference>()!;
        }

        [JsiiProperty(name: "persistentVolumeConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsPersistentVolumeConfigOutputReference\"}")]
        public virtual oci.ContainerengineCluster.ContainerengineClusterOptionsPersistentVolumeConfigOutputReference PersistentVolumeConfig
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.ContainerengineClusterOptionsPersistentVolumeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "serviceLbConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsServiceLbConfigOutputReference\"}")]
        public virtual oci.ContainerengineCluster.ContainerengineClusterOptionsServiceLbConfigOutputReference ServiceLbConfig
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.ContainerengineClusterOptionsServiceLbConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "addOnsInput", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsAddOns\"}", isOptional: true)]
        public virtual oci.ContainerengineCluster.IContainerengineClusterOptionsAddOns? AddOnsInput
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptionsAddOns?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "admissionControllerOptionsInput", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsAdmissionControllerOptions\"}", isOptional: true)]
        public virtual oci.ContainerengineCluster.IContainerengineClusterOptionsAdmissionControllerOptions? AdmissionControllerOptionsInput
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptionsAdmissionControllerOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipFamiliesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IpFamiliesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kubernetesNetworkConfigInput", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsKubernetesNetworkConfig\"}", isOptional: true)]
        public virtual oci.ContainerengineCluster.IContainerengineClusterOptionsKubernetesNetworkConfig? KubernetesNetworkConfigInput
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptionsKubernetesNetworkConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openIdConnectDiscoveryInput", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectDiscovery\"}", isOptional: true)]
        public virtual oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectDiscovery? OpenIdConnectDiscoveryInput
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectDiscovery?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openIdConnectTokenAuthenticationConfigInput", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig\"}", isOptional: true)]
        public virtual oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig? OpenIdConnectTokenAuthenticationConfigInput
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "persistentVolumeConfigInput", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsPersistentVolumeConfig\"}", isOptional: true)]
        public virtual oci.ContainerengineCluster.IContainerengineClusterOptionsPersistentVolumeConfig? PersistentVolumeConfigInput
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptionsPersistentVolumeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceLbConfigInput", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsServiceLbConfig\"}", isOptional: true)]
        public virtual oci.ContainerengineCluster.IContainerengineClusterOptionsServiceLbConfig? ServiceLbConfigInput
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptionsServiceLbConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceLbSubnetIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ServiceLbSubnetIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "ipFamilies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IpFamilies
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceLbSubnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ServiceLbSubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptions\"}", isOptional: true)]
        public virtual oci.ContainerengineCluster.IContainerengineClusterOptions? InternalValue
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
