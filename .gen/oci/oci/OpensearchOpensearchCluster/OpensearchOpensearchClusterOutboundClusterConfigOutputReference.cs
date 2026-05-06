using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiClass(nativeType: typeof(oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfigOutputReference), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpensearchOpensearchClusterOutboundClusterConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpensearchOpensearchClusterOutboundClusterConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OpensearchOpensearchClusterOutboundClusterConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchOpensearchClusterOutboundClusterConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOutboundClusters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfigOutboundClusters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOutboundClusters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterOutboundClusterConfigOutboundClusters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterOutboundClusterConfigOutboundClusters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterOutboundClusterConfigOutboundClusters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "outboundClusters", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfigOutboundClustersList\"}")]
        public virtual oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfigOutboundClustersList OutboundClusters
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfigOutboundClustersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "isEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outboundClustersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfigOutboundClusters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OutboundClustersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfig\"}", isOptional: true)]
        public virtual oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterOutboundClusterConfig? InternalValue
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterOutboundClusterConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
