using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbBackend
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend scaleway_lb_backend}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.LbBackend.LbBackend), fullyQualifiedName: "scaleway.lbBackend.LbBackend", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"scaleway.lbBackend.LbBackendConfig\"}}]")]
    public class LbBackend : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend scaleway_lb_backend} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LbBackend(Constructs.Construct scope, string id, scaleway.LbBackend.ILbBackendConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.LbBackend.ILbBackendConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbBackend(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbBackend(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a LbBackend resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LbBackend to import.</param>
        /// <param name="importFromId">The id of the existing LbBackend that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LbBackend to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LbBackend to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LbBackend that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LbBackend to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.LbBackend.LbBackend), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putHealthCheckHttp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckHttp\"}}]")]
        public virtual void PutHealthCheckHttp(scaleway.LbBackend.ILbBackendHealthCheckHttp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.LbBackend.ILbBackendHealthCheckHttp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHealthCheckHttps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckHttps\"}}]")]
        public virtual void PutHealthCheckHttps(scaleway.LbBackend.ILbBackendHealthCheckHttps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.LbBackend.ILbBackendHealthCheckHttps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHealthCheckTcp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckTcp\"}}]")]
        public virtual void PutHealthCheckTcp(scaleway.LbBackend.ILbBackendHealthCheckTcp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.LbBackend.ILbBackendHealthCheckTcp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.lbBackend.LbBackendTimeouts\"}}]")]
        public virtual void PutTimeouts(scaleway.LbBackend.ILbBackendTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.LbBackend.ILbBackendTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFailoverHost")]
        public virtual void ResetFailoverHost()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForwardPortAlgorithm")]
        public virtual void ResetForwardPortAlgorithm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckDelay")]
        public virtual void ResetHealthCheckDelay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckHttp")]
        public virtual void ResetHealthCheckHttp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckHttps")]
        public virtual void ResetHealthCheckHttps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckMaxRetries")]
        public virtual void ResetHealthCheckMaxRetries()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckPort")]
        public virtual void ResetHealthCheckPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckSendProxy")]
        public virtual void ResetHealthCheckSendProxy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckTcp")]
        public virtual void ResetHealthCheckTcp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckTimeout")]
        public virtual void ResetHealthCheckTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckTransientDelay")]
        public virtual void ResetHealthCheckTransientDelay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIgnoreSslServerVerify")]
        public virtual void ResetIgnoreSslServerVerify()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxConnections")]
        public virtual void ResetMaxConnections()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxRetries")]
        public virtual void ResetMaxRetries()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnMarkedDownAction")]
        public virtual void ResetOnMarkedDownAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProxyProtocol")]
        public virtual void ResetProxyProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedispatchAttemptCount")]
        public virtual void ResetRedispatchAttemptCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSendProxyV2")]
        public virtual void ResetSendProxyV2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerIps")]
        public virtual void ResetServerIps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslBridging")]
        public virtual void ResetSslBridging()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStickySessions")]
        public virtual void ResetStickySessions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStickySessionsCookieName")]
        public virtual void ResetStickySessionsCookieName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeoutConnect")]
        public virtual void ResetTimeoutConnect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeoutQueue")]
        public virtual void ResetTimeoutQueue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeoutServer")]
        public virtual void ResetTimeoutServer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeoutTunnel")]
        public virtual void ResetTimeoutTunnel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(scaleway.LbBackend.LbBackend))!;

        [JsiiProperty(name: "healthCheckHttp", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckHttpOutputReference\"}")]
        public virtual scaleway.LbBackend.LbBackendHealthCheckHttpOutputReference HealthCheckHttp
        {
            get => GetInstanceProperty<scaleway.LbBackend.LbBackendHealthCheckHttpOutputReference>()!;
        }

        [JsiiProperty(name: "healthCheckHttps", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckHttpsOutputReference\"}")]
        public virtual scaleway.LbBackend.LbBackendHealthCheckHttpsOutputReference HealthCheckHttps
        {
            get => GetInstanceProperty<scaleway.LbBackend.LbBackendHealthCheckHttpsOutputReference>()!;
        }

        [JsiiProperty(name: "healthCheckTcp", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckTcpOutputReference\"}")]
        public virtual scaleway.LbBackend.LbBackendHealthCheckTcpOutputReference HealthCheckTcp
        {
            get => GetInstanceProperty<scaleway.LbBackend.LbBackendHealthCheckTcpOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendTimeoutsOutputReference\"}")]
        public virtual scaleway.LbBackend.LbBackendTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<scaleway.LbBackend.LbBackendTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "failoverHostInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FailoverHostInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardPortAlgorithmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ForwardPortAlgorithmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ForwardPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardProtocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ForwardProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckDelayInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HealthCheckDelayInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckHttpInput", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckHttp\"}", isOptional: true)]
        public virtual scaleway.LbBackend.ILbBackendHealthCheckHttp? HealthCheckHttpInput
        {
            get => GetInstanceProperty<scaleway.LbBackend.ILbBackendHealthCheckHttp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckHttpsInput", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckHttps\"}", isOptional: true)]
        public virtual scaleway.LbBackend.ILbBackendHealthCheckHttps? HealthCheckHttpsInput
        {
            get => GetInstanceProperty<scaleway.LbBackend.ILbBackendHealthCheckHttps?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckMaxRetriesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HealthCheckMaxRetriesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HealthCheckPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckSendProxyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? HealthCheckSendProxyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckTcpInput", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckTcp\"}", isOptional: true)]
        public virtual scaleway.LbBackend.ILbBackendHealthCheckTcp? HealthCheckTcpInput
        {
            get => GetInstanceProperty<scaleway.LbBackend.ILbBackendHealthCheckTcp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckTimeoutInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HealthCheckTimeoutInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckTransientDelayInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HealthCheckTransientDelayInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ignoreSslServerVerifyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IgnoreSslServerVerifyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lbIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LbIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxConnectionsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxConnectionsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxRetriesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxRetriesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onMarkedDownActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OnMarkedDownActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "proxyProtocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProxyProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redispatchAttemptCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RedispatchAttemptCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sendProxyV2Input", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SendProxyV2Input
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverIpsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ServerIpsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslBridgingInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SslBridgingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stickySessionsCookieNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StickySessionsCookieNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stickySessionsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StickySessionsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutConnectInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeoutConnectInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutQueueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeoutQueueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutServerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeoutServerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.lbBackend.LbBackendTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutTunnelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeoutTunnelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "failoverHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailoverHost
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forwardPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ForwardPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forwardPortAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ForwardPortAlgorithm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forwardProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ForwardProtocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckDelay", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckDelay
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckMaxRetries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckMaxRetries
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckSendProxy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object HealthCheckSendProxy
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

        [JsiiProperty(name: "healthCheckTimeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckTimeout
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckTransientDelay", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckTransientDelay
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ignoreSslServerVerify", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IgnoreSslServerVerify
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

        [JsiiProperty(name: "lbId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LbId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConnections
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxRetries
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onMarkedDownAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnMarkedDownAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "proxyProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProxyProtocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "redispatchAttemptCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RedispatchAttemptCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sendProxyV2", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SendProxyV2
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

        [JsiiProperty(name: "serverIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ServerIps
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sslBridging", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SslBridging
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

        [JsiiProperty(name: "stickySessions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StickySessions
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stickySessionsCookieName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StickySessionsCookieName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeoutConnect", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeoutConnect
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeoutQueue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeoutQueue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeoutServer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeoutServer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeoutTunnel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeoutTunnel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
