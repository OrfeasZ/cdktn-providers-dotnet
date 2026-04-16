using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbBackend
{
    [JsiiClass(nativeType: typeof(scaleway.LbBackend.LbBackendHealthCheckHttpsOutputReference), fullyQualifiedName: "scaleway.lbBackend.LbBackendHealthCheckHttpsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LbBackendHealthCheckHttpsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LbBackendHealthCheckHttpsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LbBackendHealthCheckHttpsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbBackendHealthCheckHttpsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCode")]
        public virtual void ResetCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostHeader")]
        public virtual void ResetHostHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMethod")]
        public virtual void ResetMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSni")]
        public virtual void ResetSni()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CodeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostHeaderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostHeaderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "methodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sniInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SniInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Code
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostHeader", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostHeader
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Method
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sni", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sni
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.lbBackend.LbBackendHealthCheckHttps\"}", isOptional: true)]
        public virtual scaleway.LbBackend.ILbBackendHealthCheckHttps? InternalValue
        {
            get => GetInstanceProperty<scaleway.LbBackend.ILbBackendHealthCheckHttps?>();
            set => SetInstanceProperty(value);
        }
    }
}
