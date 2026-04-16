using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiClass(nativeType: typeof(scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfoOutputReference), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCodeAuthAfnic")]
        public virtual void ResetCodeAuthAfnic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeAuthAfnicInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CodeAuthAfnicInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "codeAuthAfnic", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CodeAuthAfnic
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo\"}", isOptional: true)]
        public virtual scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo? InternalValue
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
