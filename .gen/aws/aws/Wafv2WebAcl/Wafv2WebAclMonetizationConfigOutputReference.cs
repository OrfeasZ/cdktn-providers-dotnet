using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiClass(nativeType: typeof(aws.Wafv2WebAcl.Wafv2WebAclMonetizationConfigOutputReference), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2WebAclMonetizationConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2WebAclMonetizationConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected Wafv2WebAclMonetizationConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclMonetizationConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCryptoConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfig\"}}]")]
        public virtual void PutCryptoConfig(aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCryptoConfig")]
        public virtual void ResetCryptoConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCurrencyMode")]
        public virtual void ResetCurrencyMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cryptoConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfigOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfigOutputReference CryptoConfig
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cryptoConfigInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfig\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfig? CryptoConfigInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "currencyModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CurrencyModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "currencyMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrencyMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclMonetizationConfig\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
