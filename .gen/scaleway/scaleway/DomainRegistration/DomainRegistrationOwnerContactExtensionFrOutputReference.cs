using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiClass(nativeType: typeof(scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionFrOutputReference), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainRegistrationOwnerContactExtensionFrOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainRegistrationOwnerContactExtensionFrOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainRegistrationOwnerContactExtensionFrOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainRegistrationOwnerContactExtensionFrOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAssociationInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrAssociationInfo\"}}]")]
        public virtual void PutAssociationInfo(scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrAssociationInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrAssociationInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCodeAuthAfnicInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo\"}}]")]
        public virtual void PutCodeAuthAfnicInfo(scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDunsInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrDunsInfo\"}}]")]
        public virtual void PutDunsInfo(scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrDunsInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrDunsInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIndividualInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrIndividualInfo\"}}]")]
        public virtual void PutIndividualInfo(scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrIndividualInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrIndividualInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrademarkInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrTrademarkInfo\"}}]")]
        public virtual void PutTrademarkInfo(scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrTrademarkInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrTrademarkInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAssociationInfo")]
        public virtual void ResetAssociationInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCodeAuthAfnicInfo")]
        public virtual void ResetCodeAuthAfnicInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDunsInfo")]
        public virtual void ResetDunsInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndividualInfo")]
        public virtual void ResetIndividualInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMode")]
        public virtual void ResetMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrademarkInfo")]
        public virtual void ResetTrademarkInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "associationInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrAssociationInfoOutputReference\"}")]
        public virtual scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionFrAssociationInfoOutputReference AssociationInfo
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionFrAssociationInfoOutputReference>()!;
        }

        [JsiiProperty(name: "codeAuthAfnicInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfoOutputReference\"}")]
        public virtual scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfoOutputReference CodeAuthAfnicInfo
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfoOutputReference>()!;
        }

        [JsiiProperty(name: "dunsInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrDunsInfoOutputReference\"}")]
        public virtual scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionFrDunsInfoOutputReference DunsInfo
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionFrDunsInfoOutputReference>()!;
        }

        [JsiiProperty(name: "individualInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrIndividualInfoOutputReference\"}")]
        public virtual scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionFrIndividualInfoOutputReference IndividualInfo
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionFrIndividualInfoOutputReference>()!;
        }

        [JsiiProperty(name: "trademarkInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrTrademarkInfoOutputReference\"}")]
        public virtual scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionFrTrademarkInfoOutputReference TrademarkInfo
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionFrTrademarkInfoOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "associationInfoInput", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrAssociationInfo\"}", isOptional: true)]
        public virtual scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrAssociationInfo? AssociationInfoInput
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrAssociationInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeAuthAfnicInfoInput", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo\"}", isOptional: true)]
        public virtual scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo? CodeAuthAfnicInfoInput
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dunsInfoInput", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrDunsInfo\"}", isOptional: true)]
        public virtual scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrDunsInfo? DunsInfoInput
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrDunsInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "individualInfoInput", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrIndividualInfo\"}", isOptional: true)]
        public virtual scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrIndividualInfo? IndividualInfoInput
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrIndividualInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trademarkInfoInput", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrTrademarkInfo\"}", isOptional: true)]
        public virtual scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrTrademarkInfo? TrademarkInfoInput
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrTrademarkInfo?>();
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFr\"}", isOptional: true)]
        public virtual scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFr? InternalValue
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFr?>();
            set => SetInstanceProperty(value);
        }
    }
}
