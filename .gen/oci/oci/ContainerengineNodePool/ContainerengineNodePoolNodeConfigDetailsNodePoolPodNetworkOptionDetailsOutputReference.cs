using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    [JsiiClass(nativeType: typeof(oci.ContainerengineNodePool.ContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetailsOutputReference), fullyQualifiedName: "oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxPodsPerNode")]
        public virtual void ResetMaxPodsPerNode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPodNsgIds")]
        public virtual void ResetPodNsgIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPodSubnetIds")]
        public virtual void ResetPodSubnetIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "cniTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CniTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxPodsPerNodeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxPodsPerNodeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "podNsgIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PodNsgIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "podSubnetIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PodSubnetIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "cniType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CniType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxPodsPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxPodsPerNode
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "podNsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PodNsgIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "podSubnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PodSubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetails\"}", isOptional: true)]
        public virtual oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetails? InternalValue
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
