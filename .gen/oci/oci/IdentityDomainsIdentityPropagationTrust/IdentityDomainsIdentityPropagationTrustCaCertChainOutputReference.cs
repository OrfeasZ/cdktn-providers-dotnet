using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityPropagationTrust
{
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsIdentityPropagationTrust.IdentityDomainsIdentityPropagationTrustCaCertChainOutputReference), fullyQualifiedName: "oci.identityDomainsIdentityPropagationTrust.IdentityDomainsIdentityPropagationTrustCaCertChainOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IdentityDomainsIdentityPropagationTrustCaCertChainOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IdentityDomainsIdentityPropagationTrustCaCertChainOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IdentityDomainsIdentityPropagationTrustCaCertChainOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsIdentityPropagationTrustCaCertChainOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetIntermediateCas")]
        public virtual void ResetIntermediateCas()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "intermediateCasInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IntermediateCasInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootCasInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RootCasInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "intermediateCas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IntermediateCas
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootCas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RootCas
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityPropagationTrust.IdentityDomainsIdentityPropagationTrustCaCertChain\"}", isOptional: true)]
        public virtual oci.IdentityDomainsIdentityPropagationTrust.IIdentityDomainsIdentityPropagationTrustCaCertChain? InternalValue
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityPropagationTrust.IIdentityDomainsIdentityPropagationTrustCaCertChain?>();
            set => SetInstanceProperty(value);
        }
    }
}
