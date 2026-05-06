using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsIdentityProvider
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProviderOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProviderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProviderOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProviderOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProviderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProviderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "certMatchAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertMatchAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "crlCheckOnOcspFailureEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CrlCheckOnOcspFailureEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "crlEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CrlEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "crlLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CrlLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "crlReloadDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CrlReloadDuration
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ekuValidationEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EkuValidationEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ekuValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EkuValues
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "ocspAllowUnknownResponseStatus", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable OcspAllowUnknownResponseStatus
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ocspEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable OcspEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ocspEnableSignedResponse", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable OcspEnableSignedResponse
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ocspResponderUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OcspResponderUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocspRevalidateTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OcspRevalidateTime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ocspServerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OcspServerName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocspTrustCertChain", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OcspTrustCertChain
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "otherCertMatchAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OtherCertMatchAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signingCertificateChain", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SigningCertificateChain
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "userMatchAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserMatchAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProvider.DataOciIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsIdentityProvider.IDataOciIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProvider.IDataOciIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider?>();
            set => SetInstanceProperty(value);
        }
    }
}
