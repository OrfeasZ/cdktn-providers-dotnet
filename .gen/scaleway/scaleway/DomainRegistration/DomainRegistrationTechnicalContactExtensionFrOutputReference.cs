using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiClass(nativeType: typeof(scaleway.DomainRegistration.DomainRegistrationTechnicalContactExtensionFrOutputReference), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationTechnicalContactExtensionFrOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DomainRegistrationTechnicalContactExtensionFrOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DomainRegistrationTechnicalContactExtensionFrOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainRegistrationTechnicalContactExtensionFrOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainRegistrationTechnicalContactExtensionFrOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "associationInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationTechnicalContactExtensionFrAssociationInfoList\"}")]
        public virtual scaleway.DomainRegistration.DomainRegistrationTechnicalContactExtensionFrAssociationInfoList AssociationInfo
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.DomainRegistrationTechnicalContactExtensionFrAssociationInfoList>()!;
        }

        [JsiiProperty(name: "codeAuthAfnicInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationTechnicalContactExtensionFrCodeAuthAfnicInfoList\"}")]
        public virtual scaleway.DomainRegistration.DomainRegistrationTechnicalContactExtensionFrCodeAuthAfnicInfoList CodeAuthAfnicInfo
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.DomainRegistrationTechnicalContactExtensionFrCodeAuthAfnicInfoList>()!;
        }

        [JsiiProperty(name: "dunsInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationTechnicalContactExtensionFrDunsInfoList\"}")]
        public virtual scaleway.DomainRegistration.DomainRegistrationTechnicalContactExtensionFrDunsInfoList DunsInfo
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.DomainRegistrationTechnicalContactExtensionFrDunsInfoList>()!;
        }

        [JsiiProperty(name: "individualInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationTechnicalContactExtensionFrIndividualInfoList\"}")]
        public virtual scaleway.DomainRegistration.DomainRegistrationTechnicalContactExtensionFrIndividualInfoList IndividualInfo
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.DomainRegistrationTechnicalContactExtensionFrIndividualInfoList>()!;
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trademarkInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationTechnicalContactExtensionFrTrademarkInfoList\"}")]
        public virtual scaleway.DomainRegistration.DomainRegistrationTechnicalContactExtensionFrTrademarkInfoList TrademarkInfo
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.DomainRegistrationTechnicalContactExtensionFrTrademarkInfoList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationTechnicalContactExtensionFr\"}", isOptional: true)]
        public virtual scaleway.DomainRegistration.IDomainRegistrationTechnicalContactExtensionFr? InternalValue
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationTechnicalContactExtensionFr?>();
            set => SetInstanceProperty(value);
        }
    }
}
