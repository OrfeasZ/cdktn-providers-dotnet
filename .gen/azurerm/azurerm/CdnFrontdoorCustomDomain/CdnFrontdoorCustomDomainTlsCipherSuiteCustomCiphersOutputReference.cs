using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorCustomDomain
{
    [JsiiClass(nativeType: typeof(azurerm.CdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainTlsCipherSuiteCustomCiphersOutputReference), fullyQualifiedName: "azurerm.cdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainTlsCipherSuiteCustomCiphersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CdnFrontdoorCustomDomainTlsCipherSuiteCustomCiphersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CdnFrontdoorCustomDomainTlsCipherSuiteCustomCiphersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CdnFrontdoorCustomDomainTlsCipherSuiteCustomCiphersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorCustomDomainTlsCipherSuiteCustomCiphersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTls12")]
        public virtual void ResetTls12()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTls13")]
        public virtual void ResetTls13()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "tls12Input", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? Tls12Input
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tls13Input", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? Tls13Input
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "tls12", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tls12
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tls13", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tls13
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainTlsCipherSuiteCustomCiphers\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorCustomDomain.ICdnFrontdoorCustomDomainTlsCipherSuiteCustomCiphers? InternalValue
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorCustomDomain.ICdnFrontdoorCustomDomainTlsCipherSuiteCustomCiphers?>();
            set => SetInstanceProperty(value);
        }
    }
}
