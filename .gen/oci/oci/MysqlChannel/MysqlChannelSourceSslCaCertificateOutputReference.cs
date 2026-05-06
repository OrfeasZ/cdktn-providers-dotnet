using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlChannel
{
    [JsiiClass(nativeType: typeof(oci.MysqlChannel.MysqlChannelSourceSslCaCertificateOutputReference), fullyQualifiedName: "oci.mysqlChannel.MysqlChannelSourceSslCaCertificateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MysqlChannelSourceSslCaCertificateOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MysqlChannelSourceSslCaCertificateOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MysqlChannelSourceSslCaCertificateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlChannelSourceSslCaCertificateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contents", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Contents
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.mysqlChannel.MysqlChannelSourceSslCaCertificate\"}", isOptional: true)]
        public virtual oci.MysqlChannel.IMysqlChannelSourceSslCaCertificate? InternalValue
        {
            get => GetInstanceProperty<oci.MysqlChannel.IMysqlChannelSourceSslCaCertificate?>();
            set => SetInstanceProperty(value);
        }
    }
}
