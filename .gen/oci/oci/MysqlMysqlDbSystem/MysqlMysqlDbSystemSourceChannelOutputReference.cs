using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiClass(nativeType: typeof(oci.MysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannelOutputReference), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannelOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MysqlMysqlDbSystemSourceChannelOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MysqlMysqlDbSystemSourceChannelOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MysqlMysqlDbSystemSourceChannelOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlMysqlDbSystemSourceChannelOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSslCaCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannelSslCaCertificate\"}}]")]
        public virtual void PutSslCaCertificate(oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemSourceChannelSslCaCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemSourceChannelSslCaCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplierUsername")]
        public virtual void ResetApplierUsername()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourcePassword")]
        public virtual void ResetSourcePassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceUsername")]
        public virtual void ResetSourceUsername()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslCaCertificate")]
        public virtual void ResetSslCaCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslMode")]
        public virtual void ResetSslMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "sslCaCertificate", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannelSslCaCertificateOutputReference\"}")]
        public virtual oci.MysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannelSslCaCertificateOutputReference SslCaCertificate
        {
            get => GetInstanceProperty<oci.MysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannelSslCaCertificateOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applierUsernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplierUsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourcePasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourcePasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceUsernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceUsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslCaCertificateInput", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannelSslCaCertificate\"}", isOptional: true)]
        public virtual oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemSourceChannelSslCaCertificate? SslCaCertificateInput
        {
            get => GetInstanceProperty<oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemSourceChannelSslCaCertificate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SslModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "applierUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplierUsername
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourcePassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourcePassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceUsername
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannel\"}", isOptional: true)]
        public virtual oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemSourceChannel? InternalValue
        {
            get => GetInstanceProperty<oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemSourceChannel?>();
            set => SetInstanceProperty(value);
        }
    }
}
