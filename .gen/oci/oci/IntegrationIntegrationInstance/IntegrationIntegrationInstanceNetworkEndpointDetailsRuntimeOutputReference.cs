using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IntegrationIntegrationInstance
{
    [JsiiClass(nativeType: typeof(oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeOutputReference), fullyQualifiedName: "oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeAllowlistedHttpVcns" />)[]</param>
        [JsiiMethod(name: "putAllowlistedHttpVcns", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeAllowlistedHttpVcns\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAllowlistedHttpVcns(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeAllowlistedHttpVcns[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeAllowlistedHttpVcns).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeAllowlistedHttpVcns).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllowlistedHttpIps")]
        public virtual void ResetAllowlistedHttpIps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowlistedHttpVcns")]
        public virtual void ResetAllowlistedHttpVcns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "allowlistedHttpVcns", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeAllowlistedHttpVcnsList\"}")]
        public virtual oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeAllowlistedHttpVcnsList AllowlistedHttpVcns
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeAllowlistedHttpVcnsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowlistedHttpIpsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowlistedHttpIpsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeAllowlistedHttpVcns" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowlistedHttpVcnsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeAllowlistedHttpVcns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AllowlistedHttpVcnsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "allowlistedHttpIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowlistedHttpIps
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsRuntime\"}", isOptional: true)]
        public virtual oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsRuntime? InternalValue
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsRuntime?>();
            set => SetInstanceProperty(value);
        }
    }
}
