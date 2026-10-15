using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiClass(nativeType: typeof(oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterRemoteReindexTrustConfigOutputReference), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterRemoteReindexTrustConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpensearchOpensearchClusterRemoteReindexTrustConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpensearchOpensearchClusterRemoteReindexTrustConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OpensearchOpensearchClusterRemoteReindexTrustConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchOpensearchClusterRemoteReindexTrustConfigOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources" />)[]</param>
        [JsiiMethod(name: "putRemoteSources", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRemoteSources(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "remoteSources", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSourcesList\"}")]
        public virtual oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSourcesList RemoteSources
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSourcesList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "remoteSourcesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterRemoteReindexTrustConfigRemoteSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RemoteSourcesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterRemoteReindexTrustConfig\"}", isOptional: true)]
        public virtual oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterRemoteReindexTrustConfig? InternalValue
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterRemoteReindexTrustConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
