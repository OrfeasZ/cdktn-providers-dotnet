using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineCluster
{
    [JsiiClass(nativeType: typeof(oci.ContainerengineCluster.ContainerengineClusterOptionsKubernetesNetworkConfigOutputReference), fullyQualifiedName: "oci.containerengineCluster.ContainerengineClusterOptionsKubernetesNetworkConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ContainerengineClusterOptionsKubernetesNetworkConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ContainerengineClusterOptionsKubernetesNetworkConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ContainerengineClusterOptionsKubernetesNetworkConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerengineClusterOptionsKubernetesNetworkConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPodsCidr")]
        public virtual void ResetPodsCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServicesCidr")]
        public virtual void ResetServicesCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "podsCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PodsCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "servicesCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServicesCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "podsCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PodsCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "servicesCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServicesCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsKubernetesNetworkConfig\"}", isOptional: true)]
        public virtual oci.ContainerengineCluster.IContainerengineClusterOptionsKubernetesNetworkConfig? InternalValue
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptionsKubernetesNetworkConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
