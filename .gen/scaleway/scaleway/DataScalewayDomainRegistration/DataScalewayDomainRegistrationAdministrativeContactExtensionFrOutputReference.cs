using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayDomainRegistration
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrOutputReference), fullyQualifiedName: "scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayDomainRegistrationAdministrativeContactExtensionFrOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayDomainRegistrationAdministrativeContactExtensionFrOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataScalewayDomainRegistrationAdministrativeContactExtensionFrOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayDomainRegistrationAdministrativeContactExtensionFrOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "associationInfo", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrAssociationInfoList\"}")]
        public virtual scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrAssociationInfoList AssociationInfo
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrAssociationInfoList>()!;
        }

        [JsiiProperty(name: "codeAuthAfnicInfo", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrCodeAuthAfnicInfoList\"}")]
        public virtual scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrCodeAuthAfnicInfoList CodeAuthAfnicInfo
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrCodeAuthAfnicInfoList>()!;
        }

        [JsiiProperty(name: "dunsInfo", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrDunsInfoList\"}")]
        public virtual scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrDunsInfoList DunsInfo
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrDunsInfoList>()!;
        }

        [JsiiProperty(name: "individualInfo", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrIndividualInfoList\"}")]
        public virtual scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrIndividualInfoList IndividualInfo
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrIndividualInfoList>()!;
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trademarkInfo", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrTrademarkInfoList\"}")]
        public virtual scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrTrademarkInfoList TrademarkInfo
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrTrademarkInfoList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFr\"}", isOptional: true)]
        public virtual scaleway.DataScalewayDomainRegistration.IDataScalewayDomainRegistrationAdministrativeContactExtensionFr? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.IDataScalewayDomainRegistrationAdministrativeContactExtensionFr?>();
            set => SetInstanceProperty(value);
        }
    }
}
