using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2CoreVaultUsBankAccount
{
    [JsiiClass(nativeType: typeof(stripe.V2CoreVaultUsBankAccount.V2CoreVaultUsBankAccountVerificationMicrodepositVerificationDetailsOutputReference), fullyQualifiedName: "stripe.v2CoreVaultUsBankAccount.V2CoreVaultUsBankAccountVerificationMicrodepositVerificationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class V2CoreVaultUsBankAccountVerificationMicrodepositVerificationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public V2CoreVaultUsBankAccountVerificationMicrodepositVerificationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected V2CoreVaultUsBankAccountVerificationMicrodepositVerificationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2CoreVaultUsBankAccountVerificationMicrodepositVerificationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "expires", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Expires
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "microdepositType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MicrodepositType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.v2CoreVaultUsBankAccount.V2CoreVaultUsBankAccountVerificationMicrodepositVerificationDetails\"}", isOptional: true)]
        public virtual stripe.V2CoreVaultUsBankAccount.IV2CoreVaultUsBankAccountVerificationMicrodepositVerificationDetails? InternalValue
        {
            get => GetInstanceProperty<stripe.V2CoreVaultUsBankAccount.IV2CoreVaultUsBankAccountVerificationMicrodepositVerificationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
