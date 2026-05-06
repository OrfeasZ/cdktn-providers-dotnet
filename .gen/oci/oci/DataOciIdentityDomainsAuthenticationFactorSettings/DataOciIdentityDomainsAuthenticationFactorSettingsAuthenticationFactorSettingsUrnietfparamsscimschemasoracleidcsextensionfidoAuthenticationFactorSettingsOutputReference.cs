using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsAuthenticationFactorSettings
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettingsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "attestation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attestation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authenticatorSelectionAttachment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticatorSelectionAttachment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authenticatorSelectionRequireResidentKey", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AuthenticatorSelectionRequireResidentKey
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "authenticatorSelectionResidentKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticatorSelectionResidentKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authenticatorSelectionUserVerification", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticatorSelectionUserVerification
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainValidationLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DomainValidationLevel
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "excludeCredentials", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ExcludeCredentials
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "publicKeyTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PublicKeyTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Timeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSettings.DataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettings\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSettings.IDataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettings? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSettings.IDataOciIdentityDomainsAuthenticationFactorSettingsAuthenticationFactorSettingsUrnietfparamsscimschemasoracleidcsextensionfidoAuthenticationFactorSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
