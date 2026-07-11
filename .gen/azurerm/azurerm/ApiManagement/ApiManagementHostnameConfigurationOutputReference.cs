using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    [JsiiClass(nativeType: typeof(azurerm.ApiManagement.ApiManagementHostnameConfigurationOutputReference), fullyQualifiedName: "azurerm.apiManagement.ApiManagementHostnameConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApiManagementHostnameConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApiManagementHostnameConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApiManagementHostnameConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiManagementHostnameConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagement.IApiManagementHostnameConfigurationDeveloperPortal" />)[]</param>
        [JsiiMethod(name: "putDeveloperPortal", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationDeveloperPortal\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDeveloperPortal(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ApiManagement.IApiManagementHostnameConfigurationDeveloperPortal[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementHostnameConfigurationDeveloperPortal).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementHostnameConfigurationDeveloperPortal).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagement.IApiManagementHostnameConfigurationManagement" />)[]</param>
        [JsiiMethod(name: "putManagement", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationManagement\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutManagement(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ApiManagement.IApiManagementHostnameConfigurationManagement[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementHostnameConfigurationManagement).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementHostnameConfigurationManagement).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagement.IApiManagementHostnameConfigurationPortal" />)[]</param>
        [JsiiMethod(name: "putPortal", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationPortal\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPortal(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ApiManagement.IApiManagementHostnameConfigurationPortal[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementHostnameConfigurationPortal).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementHostnameConfigurationPortal).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagement.IApiManagementHostnameConfigurationProxy" />)[]</param>
        [JsiiMethod(name: "putProxy", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationProxy\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProxy(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ApiManagement.IApiManagementHostnameConfigurationProxy[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementHostnameConfigurationProxy).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementHostnameConfigurationProxy).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagement.IApiManagementHostnameConfigurationScm" />)[]</param>
        [JsiiMethod(name: "putScm", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationScm\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutScm(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ApiManagement.IApiManagementHostnameConfigurationScm[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementHostnameConfigurationScm).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementHostnameConfigurationScm).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDeveloperPortal")]
        public virtual void ResetDeveloperPortal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagement")]
        public virtual void ResetManagement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPortal")]
        public virtual void ResetPortal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProxy")]
        public virtual void ResetProxy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScm")]
        public virtual void ResetScm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "developerPortal", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationDeveloperPortalList\"}")]
        public virtual azurerm.ApiManagement.ApiManagementHostnameConfigurationDeveloperPortalList DeveloperPortal
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementHostnameConfigurationDeveloperPortalList>()!;
        }

        [JsiiProperty(name: "management", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationManagementList\"}")]
        public virtual azurerm.ApiManagement.ApiManagementHostnameConfigurationManagementList Management
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementHostnameConfigurationManagementList>()!;
        }

        [JsiiProperty(name: "portal", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationPortalList\"}")]
        public virtual azurerm.ApiManagement.ApiManagementHostnameConfigurationPortalList Portal
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementHostnameConfigurationPortalList>()!;
        }

        [JsiiProperty(name: "proxy", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationProxyList\"}")]
        public virtual azurerm.ApiManagement.ApiManagementHostnameConfigurationProxyList Proxy
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementHostnameConfigurationProxyList>()!;
        }

        [JsiiProperty(name: "scm", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationScmList\"}")]
        public virtual azurerm.ApiManagement.ApiManagementHostnameConfigurationScmList Scm
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementHostnameConfigurationScmList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagement.IApiManagementHostnameConfigurationDeveloperPortal" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "developerPortalInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationDeveloperPortal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DeveloperPortalInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagement.IApiManagementHostnameConfigurationManagement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managementInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationManagement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ManagementInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagement.IApiManagementHostnameConfigurationPortal" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "portalInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationPortal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PortalInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagement.IApiManagementHostnameConfigurationProxy" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "proxyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationProxy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProxyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagement.IApiManagementHostnameConfigurationScm" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scmInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationScm\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ScmInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfiguration\"}", isOptional: true)]
        public virtual azurerm.ApiManagement.IApiManagementHostnameConfiguration? InternalValue
        {
            get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementHostnameConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
