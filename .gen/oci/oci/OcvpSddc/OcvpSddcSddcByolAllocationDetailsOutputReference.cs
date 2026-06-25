using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpSddc
{
    [JsiiClass(nativeType: typeof(oci.OcvpSddc.OcvpSddcSddcByolAllocationDetailsOutputReference), fullyQualifiedName: "oci.ocvpSddc.OcvpSddcSddcByolAllocationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OcvpSddcSddcByolAllocationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OcvpSddcSddcByolAllocationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OcvpSddcSddcByolAllocationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OcvpSddcSddcByolAllocationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLoadBalancerByolAllocationId")]
        public virtual void ResetLoadBalancerByolAllocationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancerInstanceCount")]
        public virtual void ResetLoadBalancerInstanceCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerByolAllocationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoadBalancerByolAllocationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerInstanceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LoadBalancerInstanceCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "loadBalancerByolAllocationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerByolAllocationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancerInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LoadBalancerInstanceCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.ocvpSddc.OcvpSddcSddcByolAllocationDetails\"}", isOptional: true)]
        public virtual oci.OcvpSddc.IOcvpSddcSddcByolAllocationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.OcvpSddc.IOcvpSddcSddcByolAllocationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
