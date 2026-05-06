using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsUsers
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "apiKeys", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserApiKeysList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserApiKeysList ApiKeys
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserApiKeysList>()!;
        }

        [JsiiProperty(name: "authTokens", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserAuthTokensList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserAuthTokensList AuthTokens
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserAuthTokensList>()!;
        }

        [JsiiProperty(name: "customerSecretKeys", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserCustomerSecretKeysList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserCustomerSecretKeysList CustomerSecretKeys
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserCustomerSecretKeysList>()!;
        }

        [JsiiProperty(name: "dbCredentials", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserDbCredentialsList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserDbCredentialsList DbCredentials
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserDbCredentialsList>()!;
        }

        [JsiiProperty(name: "oAuth2ClientCredentials", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOAuth2ClientCredentialsList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOAuth2ClientCredentialsList OAuth2ClientCredentials
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOAuth2ClientCredentialsList>()!;
        }

        [JsiiProperty(name: "smtpCredentials", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserSmtpCredentialsList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserSmtpCredentialsList SmtpCredentials
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserSmtpCredentialsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUser\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsUsers.IDataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUser? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.IDataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUser?>();
            set => SetInstanceProperty(value);
        }
    }
}
