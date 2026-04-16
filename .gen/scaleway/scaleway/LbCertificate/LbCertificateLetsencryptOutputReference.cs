using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbCertificate
{
    [JsiiClass(nativeType: typeof(scaleway.LbCertificate.LbCertificateLetsencryptOutputReference), fullyQualifiedName: "scaleway.lbCertificate.LbCertificateLetsencryptOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LbCertificateLetsencryptOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LbCertificateLetsencryptOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LbCertificateLetsencryptOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbCertificateLetsencryptOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSubjectAlternativeName")]
        public virtual void ResetSubjectAlternativeName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "commonNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommonNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subjectAlternativeNameInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SubjectAlternativeNameInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommonName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subjectAlternativeName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubjectAlternativeName
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.lbCertificate.LbCertificateLetsencrypt\"}", isOptional: true)]
        public virtual scaleway.LbCertificate.ILbCertificateLetsencrypt? InternalValue
        {
            get => GetInstanceProperty<scaleway.LbCertificate.ILbCertificateLetsencrypt?>();
            set => SetInstanceProperty(value);
        }
    }
}
