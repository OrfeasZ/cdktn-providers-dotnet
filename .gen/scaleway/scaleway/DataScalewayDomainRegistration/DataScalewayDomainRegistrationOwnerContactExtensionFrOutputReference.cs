using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayDomainRegistration
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFrOutputReference), fullyQualifiedName: "scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFrOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayDomainRegistrationOwnerContactExtensionFrOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayDomainRegistrationOwnerContactExtensionFrOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataScalewayDomainRegistrationOwnerContactExtensionFrOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayDomainRegistrationOwnerContactExtensionFrOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "associationInfo", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFrAssociationInfoList\"}")]
        public virtual scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFrAssociationInfoList AssociationInfo
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFrAssociationInfoList>()!;
        }

        [JsiiProperty(name: "codeAuthAfnicInfo", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfoList\"}")]
        public virtual scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfoList CodeAuthAfnicInfo
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfoList>()!;
        }

        [JsiiProperty(name: "dunsInfo", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFrDunsInfoList\"}")]
        public virtual scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFrDunsInfoList DunsInfo
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFrDunsInfoList>()!;
        }

        [JsiiProperty(name: "individualInfo", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFrIndividualInfoList\"}")]
        public virtual scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFrIndividualInfoList IndividualInfo
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFrIndividualInfoList>()!;
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trademarkInfo", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFrTrademarkInfoList\"}")]
        public virtual scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFrTrademarkInfoList TrademarkInfo
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFrTrademarkInfoList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationOwnerContactExtensionFr\"}", isOptional: true)]
        public virtual scaleway.DataScalewayDomainRegistration.IDataScalewayDomainRegistrationOwnerContactExtensionFr? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.IDataScalewayDomainRegistrationOwnerContactExtensionFr?>();
            set => SetInstanceProperty(value);
        }
    }
}
