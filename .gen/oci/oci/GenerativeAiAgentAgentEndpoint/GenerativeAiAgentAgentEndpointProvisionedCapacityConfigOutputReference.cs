using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgentEndpoint
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigOutputReference), fullyQualifiedName: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiAgentAgentEndpointProvisionedCapacityConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiAgentAgentEndpointProvisionedCapacityConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiAgentAgentEndpointProvisionedCapacityConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiAgentAgentEndpointProvisionedCapacityConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPlatformRuntimeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig\"}}]")]
        public virtual void PutPlatformRuntimeConfig(oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs" />)[]</param>
        [JsiiMethod(name: "putToolRuntimeConfigs", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutToolRuntimeConfigs(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPlatformRuntimeConfig")]
        public virtual void ResetPlatformRuntimeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetToolRuntimeConfigs")]
        public virtual void ResetToolRuntimeConfigs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "platformRuntimeConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfigOutputReference\"}")]
        public virtual oci.GenerativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfigOutputReference PlatformRuntimeConfig
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "toolRuntimeConfigs", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigsList\"}")]
        public virtual oci.GenerativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigsList ToolRuntimeConfigs
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformRuntimeConfigInput", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig? PlatformRuntimeConfigInput
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "provisionedCapacityIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProvisionedCapacityIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "toolRuntimeConfigsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ToolRuntimeConfigsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "provisionedCapacityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisionedCapacityId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfig? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
