using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityPropagationTrust
{
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsIdentityPropagationTrust.IdentityDomainsIdentityPropagationTrustKeytabOutputReference), fullyQualifiedName: "oci.identityDomainsIdentityPropagationTrust.IdentityDomainsIdentityPropagationTrustKeytabOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IdentityDomainsIdentityPropagationTrustKeytabOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IdentityDomainsIdentityPropagationTrustKeytabOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IdentityDomainsIdentityPropagationTrustKeytabOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsIdentityPropagationTrustKeytabOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSecretVersion")]
        public virtual void ResetSecretVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretOcidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretOcidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretVersionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SecretVersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "secretOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretOcid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secretVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SecretVersion
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityPropagationTrust.IdentityDomainsIdentityPropagationTrustKeytab\"}", isOptional: true)]
        public virtual oci.IdentityDomainsIdentityPropagationTrust.IIdentityDomainsIdentityPropagationTrustKeytab? InternalValue
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityPropagationTrust.IIdentityDomainsIdentityPropagationTrustKeytab?>();
            set => SetInstanceProperty(value);
        }
    }
}
