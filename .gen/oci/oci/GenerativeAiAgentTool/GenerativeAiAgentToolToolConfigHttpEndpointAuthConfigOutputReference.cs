using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigOutputReference), fullyQualifiedName: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHttpEndpointAuthSources", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSources\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHttpEndpointAuthSources(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSources[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSources).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSources).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHttpEndpointAuthSources")]
        public virtual void ResetHttpEndpointAuthSources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "httpEndpointAuthSources", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSourcesList\"}")]
        public virtual oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSourcesList HttpEndpointAuthSources
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSourcesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpEndpointAuthSourcesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HttpEndpointAuthSourcesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfig? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
