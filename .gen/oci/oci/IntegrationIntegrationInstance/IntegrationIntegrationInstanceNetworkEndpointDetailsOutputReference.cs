using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IntegrationIntegrationInstance
{
    [JsiiClass(nativeType: typeof(oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsOutputReference), fullyQualifiedName: "oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IntegrationIntegrationInstanceNetworkEndpointDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IntegrationIntegrationInstanceNetworkEndpointDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IntegrationIntegrationInstanceNetworkEndpointDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IntegrationIntegrationInstanceNetworkEndpointDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns" />)[]</param>
        [JsiiMethod(name: "putAllowlistedHttpVcns", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAllowlistedHttpVcns(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDesignTime", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsDesignTime\"}}]")]
        public virtual void PutDesignTime(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsDesignTime @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsDesignTime)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRuntime", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsRuntime\"}}]")]
        public virtual void PutRuntime(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsRuntime @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsRuntime)}, new object[]{@value});
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

        [JsiiMethod(name: "resetDesignTime")]
        public virtual void ResetDesignTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsIntegrationVcnAllowlisted")]
        public virtual void ResetIsIntegrationVcnAllowlisted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuntime")]
        public virtual void ResetRuntime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "allowlistedHttpVcns", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcnsList\"}")]
        public virtual oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcnsList AllowlistedHttpVcns
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcnsList>()!;
        }

        [JsiiProperty(name: "designTime", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsDesignTimeOutputReference\"}")]
        public virtual oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsDesignTimeOutputReference DesignTime
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsDesignTimeOutputReference>()!;
        }

        [JsiiProperty(name: "runtime", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeOutputReference\"}")]
        public virtual oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeOutputReference Runtime
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsRuntimeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowlistedHttpIpsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowlistedHttpIpsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowlistedHttpVcnsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AllowlistedHttpVcnsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "designTimeInput", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsDesignTime\"}", isOptional: true)]
        public virtual oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsDesignTime? DesignTimeInput
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsDesignTime?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isIntegrationVcnAllowlistedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsIntegrationVcnAllowlistedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkEndpointTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkEndpointTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeInput", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsRuntime\"}", isOptional: true)]
        public virtual oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsRuntime? RuntimeInput
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsRuntime?>();
        }

        [JsiiProperty(name: "allowlistedHttpIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowlistedHttpIps
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isIntegrationVcnAllowlisted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsIntegrationVcnAllowlisted
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

        [JsiiProperty(name: "networkEndpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkEndpointType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetails\"}", isOptional: true)]
        public virtual oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetails? InternalValue
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
