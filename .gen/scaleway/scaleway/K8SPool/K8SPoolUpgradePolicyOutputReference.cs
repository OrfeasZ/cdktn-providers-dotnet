using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.K8SPool
{
    [JsiiClass(nativeType: typeof(scaleway.K8SPool.K8SPoolUpgradePolicyOutputReference), fullyQualifiedName: "scaleway.k8SPool.K8SPoolUpgradePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class K8SPoolUpgradePolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public K8SPoolUpgradePolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected K8SPoolUpgradePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected K8SPoolUpgradePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxSurge")]
        public virtual void ResetMaxSurge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxUnavailable")]
        public virtual void ResetMaxUnavailable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxSurgeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxSurgeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxUnavailableInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxUnavailableInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxSurge", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSurge
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxUnavailable
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.k8SPool.K8SPoolUpgradePolicy\"}", isOptional: true)]
        public virtual scaleway.K8SPool.IK8SPoolUpgradePolicy? InternalValue
        {
            get => GetInstanceProperty<scaleway.K8SPool.IK8SPoolUpgradePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
