using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsApp
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "captureClientIp", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CaptureClientIp
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "clientIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "countryCodeResponseAttributeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CountryCodeResponseAttributeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endUserIpAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndUserIpAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "groupMembershipRadiusAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupMembershipRadiusAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "groupMembershipToReturn", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppGroupMembershipToReturnList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppGroupMembershipToReturnList GroupMembershipToReturn
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppGroupMembershipToReturnList>()!;
        }

        [JsiiProperty(name: "groupNameFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupNameFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "includeGroupInResponse", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IncludeGroupInResponse
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "passwordAndOtpTogether", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PasswordAndOtpTogether
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Port
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "radiusVendorSpecificId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RadiusVendorSpecificId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "responseFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "responseFormatDelimiter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseFormatDelimiter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "typeOfRadiusApp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TypeOfRadiusApp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsApp.IDataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.IDataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp?>();
            set => SetInstanceProperty(value);
        }
    }
}
