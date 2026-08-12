using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiClass(nativeType: typeof(aws.EksCluster.EksClusterKubeApiServerConfigOutputReference), fullyQualifiedName: "aws.eksCluster.EksClusterKubeApiServerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EksClusterKubeApiServerConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EksClusterKubeApiServerConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EksClusterKubeApiServerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterKubeApiServerConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putServiceNodePortRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterKubeApiServerConfigServiceNodePortRange\"}}]")]
        public virtual void PutServiceNodePortRange(aws.EksCluster.IEksClusterKubeApiServerConfigServiceNodePortRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterKubeApiServerConfigServiceNodePortRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEventTtl")]
        public virtual void ResetEventTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceNodePortRange")]
        public virtual void ResetServiceNodePortRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "serviceNodePortRange", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeApiServerConfigServiceNodePortRangeOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterKubeApiServerConfigServiceNodePortRangeOutputReference ServiceNodePortRange
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterKubeApiServerConfigServiceNodePortRangeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventTtlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventTtlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceNodePortRangeInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeApiServerConfigServiceNodePortRange\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterKubeApiServerConfigServiceNodePortRange? ServiceNodePortRangeInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterKubeApiServerConfigServiceNodePortRange?>();
        }

        [JsiiProperty(name: "eventTtl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventTtl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeApiServerConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterKubeApiServerConfig? InternalValue
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterKubeApiServerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
