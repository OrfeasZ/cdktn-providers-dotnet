using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiClass(nativeType: typeof(scaleway.DomainRegistration.DomainRegistrationAdministrativeContactExtensionFrOutputReference), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationAdministrativeContactExtensionFrOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DomainRegistrationAdministrativeContactExtensionFrOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DomainRegistrationAdministrativeContactExtensionFrOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DomainRegistrationAdministrativeContactExtensionFrOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainRegistrationAdministrativeContactExtensionFrOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "associationInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationAdministrativeContactExtensionFrAssociationInfoList\"}")]
        public virtual scaleway.DomainRegistration.DomainRegistrationAdministrativeContactExtensionFrAssociationInfoList AssociationInfo
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.DomainRegistrationAdministrativeContactExtensionFrAssociationInfoList>()!;
        }

        [JsiiProperty(name: "codeAuthAfnicInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationAdministrativeContactExtensionFrCodeAuthAfnicInfoList\"}")]
        public virtual scaleway.DomainRegistration.DomainRegistrationAdministrativeContactExtensionFrCodeAuthAfnicInfoList CodeAuthAfnicInfo
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.DomainRegistrationAdministrativeContactExtensionFrCodeAuthAfnicInfoList>()!;
        }

        [JsiiProperty(name: "dunsInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationAdministrativeContactExtensionFrDunsInfoList\"}")]
        public virtual scaleway.DomainRegistration.DomainRegistrationAdministrativeContactExtensionFrDunsInfoList DunsInfo
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.DomainRegistrationAdministrativeContactExtensionFrDunsInfoList>()!;
        }

        [JsiiProperty(name: "individualInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationAdministrativeContactExtensionFrIndividualInfoList\"}")]
        public virtual scaleway.DomainRegistration.DomainRegistrationAdministrativeContactExtensionFrIndividualInfoList IndividualInfo
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.DomainRegistrationAdministrativeContactExtensionFrIndividualInfoList>()!;
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trademarkInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationAdministrativeContactExtensionFrTrademarkInfoList\"}")]
        public virtual scaleway.DomainRegistration.DomainRegistrationAdministrativeContactExtensionFrTrademarkInfoList TrademarkInfo
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.DomainRegistrationAdministrativeContactExtensionFrTrademarkInfoList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationAdministrativeContactExtensionFr\"}", isOptional: true)]
        public virtual scaleway.DomainRegistration.IDomainRegistrationAdministrativeContactExtensionFr? InternalValue
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationAdministrativeContactExtensionFr?>();
            set => SetInstanceProperty(value);
        }
    }
}
