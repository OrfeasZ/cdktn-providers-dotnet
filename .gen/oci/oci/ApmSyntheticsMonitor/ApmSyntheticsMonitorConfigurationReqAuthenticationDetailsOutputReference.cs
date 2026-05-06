using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiClass(nativeType: typeof(oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationReqAuthenticationDetailsOutputReference), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationReqAuthenticationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApmSyntheticsMonitorConfigurationReqAuthenticationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApmSyntheticsMonitorConfigurationReqAuthenticationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApmSyntheticsMonitorConfigurationReqAuthenticationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApmSyntheticsMonitorConfigurationReqAuthenticationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuthHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationReqAuthenticationDetailsAuthHeaders\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAuthHeaders(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationReqAuthenticationDetailsAuthHeaders[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationReqAuthenticationDetailsAuthHeaders).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationReqAuthenticationDetailsAuthHeaders).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthHeaders")]
        public virtual void ResetAuthHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthRequestMethod")]
        public virtual void ResetAuthRequestMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthRequestPostBody")]
        public virtual void ResetAuthRequestPostBody()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthToken")]
        public virtual void ResetAuthToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthUrl")]
        public virtual void ResetAuthUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthUserName")]
        public virtual void ResetAuthUserName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthUserPassword")]
        public virtual void ResetAuthUserPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauthScheme")]
        public virtual void ResetOauthScheme()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "authHeaders", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationReqAuthenticationDetailsAuthHeadersList\"}")]
        public virtual oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationReqAuthenticationDetailsAuthHeadersList AuthHeaders
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationReqAuthenticationDetailsAuthHeadersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authHeadersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationReqAuthenticationDetailsAuthHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AuthHeadersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authRequestMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthRequestMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authRequestPostBodyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthRequestPostBodyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authUserNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthUserNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authUserPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthUserPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauthSchemeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OauthSchemeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "authRequestMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthRequestMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authRequestPostBody", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthRequestPostBody
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthToken
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthUserName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authUserPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthUserPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "oauthScheme", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OauthScheme
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationReqAuthenticationDetails\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationReqAuthenticationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationReqAuthenticationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
