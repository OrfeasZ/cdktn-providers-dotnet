using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApiDiagnostic
{
    [JsiiClass(nativeType: typeof(azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequestDataMaskingOutputReference), fullyQualifiedName: "azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequestDataMaskingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApiManagementApiDiagnosticBackendRequestDataMaskingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApiManagementApiDiagnosticBackendRequestDataMaskingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApiManagementApiDiagnosticBackendRequestDataMaskingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiManagementApiDiagnosticBackendRequestDataMaskingOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendRequestDataMaskingHeaders" />)[]</param>
        [JsiiMethod(name: "putHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequestDataMaskingHeaders\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHeaders(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendRequestDataMaskingHeaders[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendRequestDataMaskingHeaders).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendRequestDataMaskingHeaders).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendRequestDataMaskingQueryParams" />)[]</param>
        [JsiiMethod(name: "putQueryParams", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequestDataMaskingQueryParams\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutQueryParams(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendRequestDataMaskingQueryParams[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendRequestDataMaskingQueryParams).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendRequestDataMaskingQueryParams).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHeaders")]
        public virtual void ResetHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryParams")]
        public virtual void ResetQueryParams()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "headers", typeJson: "{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequestDataMaskingHeadersList\"}")]
        public virtual azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequestDataMaskingHeadersList Headers
        {
            get => GetInstanceProperty<azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequestDataMaskingHeadersList>()!;
        }

        [JsiiProperty(name: "queryParams", typeJson: "{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequestDataMaskingQueryParamsList\"}")]
        public virtual azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequestDataMaskingQueryParamsList QueryParams
        {
            get => GetInstanceProperty<azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequestDataMaskingQueryParamsList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendRequestDataMaskingHeaders" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequestDataMaskingHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HeadersInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendRequestDataMaskingQueryParams" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryParamsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequestDataMaskingQueryParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? QueryParamsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequestDataMasking\"}", isOptional: true)]
        public virtual azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendRequestDataMasking? InternalValue
        {
            get => GetInstanceProperty<azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendRequestDataMasking?>();
            set => SetInstanceProperty(value);
        }
    }
}
