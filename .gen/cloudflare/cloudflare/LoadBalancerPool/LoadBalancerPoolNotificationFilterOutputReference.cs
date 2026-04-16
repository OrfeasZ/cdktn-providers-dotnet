using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancerPool
{
    [JsiiClass(nativeType: typeof(cloudflare.LoadBalancerPool.LoadBalancerPoolNotificationFilterOutputReference), fullyQualifiedName: "cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LoadBalancerPoolNotificationFilterOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LoadBalancerPoolNotificationFilterOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LoadBalancerPoolNotificationFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerPoolNotificationFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOrigin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilterOrigin\"}}]")]
        public virtual void PutOrigin(cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilterOrigin @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilterOrigin)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPool", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilterPool\"}}]")]
        public virtual void PutPool(cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilterPool @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilterPool)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOrigin")]
        public virtual void ResetOrigin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPool")]
        public virtual void ResetPool()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "origin", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilterOriginOutputReference\"}")]
        public virtual cloudflare.LoadBalancerPool.LoadBalancerPoolNotificationFilterOriginOutputReference Origin
        {
            get => GetInstanceProperty<cloudflare.LoadBalancerPool.LoadBalancerPoolNotificationFilterOriginOutputReference>()!;
        }

        [JsiiProperty(name: "pool", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilterPoolOutputReference\"}")]
        public virtual cloudflare.LoadBalancerPool.LoadBalancerPoolNotificationFilterPoolOutputReference Pool
        {
            get => GetInstanceProperty<cloudflare.LoadBalancerPool.LoadBalancerPoolNotificationFilterPoolOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "originInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilterOrigin\"}]}}", isOptional: true)]
        public virtual object? OriginInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "poolInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilterPool\"}]}}", isOptional: true)]
        public virtual object? PoolInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilter\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilter cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilter).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
