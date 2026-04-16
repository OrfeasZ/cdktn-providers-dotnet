using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayDomainRegistration
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFrOutputReference), fullyQualifiedName: "scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFrOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayDomainRegistrationTechnicalContactExtensionFrOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayDomainRegistrationTechnicalContactExtensionFrOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataScalewayDomainRegistrationTechnicalContactExtensionFrOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayDomainRegistrationTechnicalContactExtensionFrOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "associationInfo", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFrAssociationInfoList\"}")]
        public virtual scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFrAssociationInfoList AssociationInfo
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFrAssociationInfoList>()!;
        }

        [JsiiProperty(name: "codeAuthAfnicInfo", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFrCodeAuthAfnicInfoList\"}")]
        public virtual scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFrCodeAuthAfnicInfoList CodeAuthAfnicInfo
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFrCodeAuthAfnicInfoList>()!;
        }

        [JsiiProperty(name: "dunsInfo", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFrDunsInfoList\"}")]
        public virtual scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFrDunsInfoList DunsInfo
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFrDunsInfoList>()!;
        }

        [JsiiProperty(name: "individualInfo", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFrIndividualInfoList\"}")]
        public virtual scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFrIndividualInfoList IndividualInfo
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFrIndividualInfoList>()!;
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trademarkInfo", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFrTrademarkInfoList\"}")]
        public virtual scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFrTrademarkInfoList TrademarkInfo
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFrTrademarkInfoList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationTechnicalContactExtensionFr\"}", isOptional: true)]
        public virtual scaleway.DataScalewayDomainRegistration.IDataScalewayDomainRegistrationTechnicalContactExtensionFr? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.IDataScalewayDomainRegistrationTechnicalContactExtensionFr?>();
            set => SetInstanceProperty(value);
        }
    }
}
