using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerPathRouteSet
{
    [JsiiClass(nativeType: typeof(oci.LoadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutesOutputReference), fullyQualifiedName: "oci.loadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LoadBalancerPathRouteSetPathRoutesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public LoadBalancerPathRouteSetPathRoutesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected LoadBalancerPathRouteSetPathRoutesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerPathRouteSetPathRoutesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPathMatchType", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.loadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutesPathMatchType\"}}]")]
        public virtual void PutPathMatchType(oci.LoadBalancerPathRouteSet.ILoadBalancerPathRouteSetPathRoutesPathMatchType @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LoadBalancerPathRouteSet.ILoadBalancerPathRouteSetPathRoutesPathMatchType)}, new object[]{@value});
        }

        [JsiiProperty(name: "pathMatchType", typeJson: "{\"fqn\":\"oci.loadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutesPathMatchTypeOutputReference\"}")]
        public virtual oci.LoadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutesPathMatchTypeOutputReference PathMatchType
        {
            get => GetInstanceProperty<oci.LoadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutesPathMatchTypeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backendSetNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackendSetNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathMatchTypeInput", typeJson: "{\"fqn\":\"oci.loadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutesPathMatchType\"}", isOptional: true)]
        public virtual oci.LoadBalancerPathRouteSet.ILoadBalancerPathRouteSetPathRoutesPathMatchType? PathMatchTypeInput
        {
            get => GetInstanceProperty<oci.LoadBalancerPathRouteSet.ILoadBalancerPathRouteSetPathRoutesPathMatchType?>();
        }

        [JsiiProperty(name: "backendSetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackendSetName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.loadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutes\"}]}}", isOptional: true)]
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
                        case oci.LoadBalancerPathRouteSet.ILoadBalancerPathRouteSetPathRoutes cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LoadBalancerPathRouteSet.ILoadBalancerPathRouteSetPathRoutes).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
