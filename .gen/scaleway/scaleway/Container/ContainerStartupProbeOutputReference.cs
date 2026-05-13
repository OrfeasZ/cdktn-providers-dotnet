using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Container
{
    [JsiiClass(nativeType: typeof(scaleway.Container.ContainerStartupProbeOutputReference), fullyQualifiedName: "scaleway.container.ContainerStartupProbeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ContainerStartupProbeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ContainerStartupProbeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ContainerStartupProbeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerStartupProbeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHttp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.container.ContainerStartupProbeHttp\"}}]")]
        public virtual void PutHttp(scaleway.Container.IContainerStartupProbeHttp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.Container.IContainerStartupProbeHttp)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHttp")]
        public virtual void ResetHttp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTcp")]
        public virtual void ResetTcp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"scaleway.container.ContainerStartupProbeHttpOutputReference\"}")]
        public virtual scaleway.Container.ContainerStartupProbeHttpOutputReference Http
        {
            get => GetInstanceProperty<scaleway.Container.ContainerStartupProbeHttpOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "failureThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FailureThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpInput", typeJson: "{\"fqn\":\"scaleway.container.ContainerStartupProbeHttp\"}", isOptional: true)]
        public virtual scaleway.Container.IContainerStartupProbeHttp? HttpInput
        {
            get => GetInstanceProperty<scaleway.Container.IContainerStartupProbeHttp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "intervalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IntervalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tcpInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TcpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeoutInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailureThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Interval
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tcp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Tcp
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

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timeout
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.container.ContainerStartupProbe\"}", isOptional: true)]
        public virtual scaleway.Container.IContainerStartupProbe? InternalValue
        {
            get => GetInstanceProperty<scaleway.Container.IContainerStartupProbe?>();
            set => SetInstanceProperty(value);
        }
    }
}
