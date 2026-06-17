using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiClass(nativeType: typeof(aws.EksCluster.EksClusterOutpostConfigOutputReference), fullyQualifiedName: "aws.eksCluster.EksClusterOutpostConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EksClusterOutpostConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EksClusterOutpostConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EksClusterOutpostConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterOutpostConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putControlPlanePlacement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterOutpostConfigControlPlanePlacement\"}}]")]
        public virtual void PutControlPlanePlacement(aws.EksCluster.IEksClusterOutpostConfigControlPlanePlacement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterOutpostConfigControlPlanePlacement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEtcdPlacement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterOutpostConfigEtcdPlacement\"}}]")]
        public virtual void PutEtcdPlacement(aws.EksCluster.IEksClusterOutpostConfigEtcdPlacement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterOutpostConfigEtcdPlacement)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetControlPlanePlacement")]
        public virtual void ResetControlPlanePlacement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEtcdInstanceType")]
        public virtual void ResetEtcdInstanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEtcdPlacement")]
        public virtual void ResetEtcdPlacement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "controlPlanePlacement", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterOutpostConfigControlPlanePlacementOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterOutpostConfigControlPlanePlacementOutputReference ControlPlanePlacement
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterOutpostConfigControlPlanePlacementOutputReference>()!;
        }

        [JsiiProperty(name: "etcdPlacement", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterOutpostConfigEtcdPlacementOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterOutpostConfigEtcdPlacementOutputReference EtcdPlacement
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterOutpostConfigEtcdPlacementOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "controlPlaneInstanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ControlPlaneInstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "controlPlanePlacementInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterOutpostConfigControlPlanePlacement\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterOutpostConfigControlPlanePlacement? ControlPlanePlacementInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterOutpostConfigControlPlanePlacement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "etcdInstanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EtcdInstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "etcdPlacementInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterOutpostConfigEtcdPlacement\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterOutpostConfigEtcdPlacement? EtcdPlacementInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterOutpostConfigEtcdPlacement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outpostArnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? OutpostArnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "controlPlaneInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ControlPlaneInstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "etcdInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EtcdInstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outpostArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OutpostArns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterOutpostConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterOutpostConfig? InternalValue
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterOutpostConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
