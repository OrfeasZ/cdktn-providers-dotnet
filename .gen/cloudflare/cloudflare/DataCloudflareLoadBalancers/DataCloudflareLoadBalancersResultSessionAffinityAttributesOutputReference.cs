using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareLoadBalancers
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareLoadBalancers.DataCloudflareLoadBalancersResultSessionAffinityAttributesOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareLoadBalancers.DataCloudflareLoadBalancersResultSessionAffinityAttributesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareLoadBalancersResultSessionAffinityAttributesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareLoadBalancersResultSessionAffinityAttributesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareLoadBalancersResultSessionAffinityAttributesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareLoadBalancersResultSessionAffinityAttributesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDrainDuration")]
        public virtual void ResetDrainDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Headers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "requireAllHeaders", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RequireAllHeaders
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "samesite", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Samesite
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secure", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Secure
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zeroDowntimeFailover", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZeroDowntimeFailover
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "drainDurationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DrainDurationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "drainDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DrainDuration
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLoadBalancers.DataCloudflareLoadBalancersResultSessionAffinityAttributes\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareLoadBalancers.IDataCloudflareLoadBalancersResultSessionAffinityAttributes? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLoadBalancers.IDataCloudflareLoadBalancersResultSessionAffinityAttributes?>();
            set => SetInstanceProperty(value);
        }
    }
}
