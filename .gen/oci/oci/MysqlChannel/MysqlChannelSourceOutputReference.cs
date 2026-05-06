using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlChannel
{
    [JsiiClass(nativeType: typeof(oci.MysqlChannel.MysqlChannelSourceOutputReference), fullyQualifiedName: "oci.mysqlChannel.MysqlChannelSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MysqlChannelSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MysqlChannelSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MysqlChannelSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlChannelSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnonymousTransactionsHandling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.mysqlChannel.MysqlChannelSourceAnonymousTransactionsHandling\"}}]")]
        public virtual void PutAnonymousTransactionsHandling(oci.MysqlChannel.IMysqlChannelSourceAnonymousTransactionsHandling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MysqlChannel.IMysqlChannelSourceAnonymousTransactionsHandling)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSslCaCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.mysqlChannel.MysqlChannelSourceSslCaCertificate\"}}]")]
        public virtual void PutSslCaCertificate(oci.MysqlChannel.IMysqlChannelSourceSslCaCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MysqlChannel.IMysqlChannelSourceSslCaCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAnonymousTransactionsHandling")]
        public virtual void ResetAnonymousTransactionsHandling()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPort")]
        public virtual void ResetPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslCaCertificate")]
        public virtual void ResetSslCaCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "anonymousTransactionsHandling", typeJson: "{\"fqn\":\"oci.mysqlChannel.MysqlChannelSourceAnonymousTransactionsHandlingOutputReference\"}")]
        public virtual oci.MysqlChannel.MysqlChannelSourceAnonymousTransactionsHandlingOutputReference AnonymousTransactionsHandling
        {
            get => GetInstanceProperty<oci.MysqlChannel.MysqlChannelSourceAnonymousTransactionsHandlingOutputReference>()!;
        }

        [JsiiProperty(name: "sslCaCertificate", typeJson: "{\"fqn\":\"oci.mysqlChannel.MysqlChannelSourceSslCaCertificateOutputReference\"}")]
        public virtual oci.MysqlChannel.MysqlChannelSourceSslCaCertificateOutputReference SslCaCertificate
        {
            get => GetInstanceProperty<oci.MysqlChannel.MysqlChannelSourceSslCaCertificateOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "anonymousTransactionsHandlingInput", typeJson: "{\"fqn\":\"oci.mysqlChannel.MysqlChannelSourceAnonymousTransactionsHandling\"}", isOptional: true)]
        public virtual oci.MysqlChannel.IMysqlChannelSourceAnonymousTransactionsHandling? AnonymousTransactionsHandlingInput
        {
            get => GetInstanceProperty<oci.MysqlChannel.IMysqlChannelSourceAnonymousTransactionsHandling?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslCaCertificateInput", typeJson: "{\"fqn\":\"oci.mysqlChannel.MysqlChannelSourceSslCaCertificate\"}", isOptional: true)]
        public virtual oci.MysqlChannel.IMysqlChannelSourceSslCaCertificate? SslCaCertificateInput
        {
            get => GetInstanceProperty<oci.MysqlChannel.IMysqlChannelSourceSslCaCertificate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SslModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Username
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.mysqlChannel.MysqlChannelSource\"}", isOptional: true)]
        public virtual oci.MysqlChannel.IMysqlChannelSource? InternalValue
        {
            get => GetInstanceProperty<oci.MysqlChannel.IMysqlChannelSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
