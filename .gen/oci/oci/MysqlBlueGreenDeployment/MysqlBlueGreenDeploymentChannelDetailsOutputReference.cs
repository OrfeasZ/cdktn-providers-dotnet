using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlBlueGreenDeployment
{
    [JsiiClass(nativeType: typeof(oci.MysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetailsOutputReference), fullyQualifiedName: "oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MysqlBlueGreenDeploymentChannelDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MysqlBlueGreenDeploymentChannelDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MysqlBlueGreenDeploymentChannelDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlBlueGreenDeploymentChannelDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSslCaCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetailsSslCaCertificate\"}}]")]
        public virtual void PutSslCaCertificate(oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetailsSslCaCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetailsSslCaCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplierUsername")]
        public virtual void ResetApplierUsername()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslCaCertificate")]
        public virtual void ResetSslCaCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "sslCaCertificate", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetailsSslCaCertificateOutputReference\"}")]
        public virtual oci.MysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetailsSslCaCertificateOutputReference SslCaCertificate
        {
            get => GetInstanceProperty<oci.MysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetailsSslCaCertificateOutputReference>()!;
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
        [JsiiProperty(name: "sslCaCertificateInput", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetailsSslCaCertificate\"}", isOptional: true)]
        public virtual oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetailsSslCaCertificate? SslCaCertificateInput
        {
            get => GetInstanceProperty<oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetailsSslCaCertificate?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetails\"}", isOptional: true)]
        public virtual oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetails? InternalValue
        {
            get => GetInstanceProperty<oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
