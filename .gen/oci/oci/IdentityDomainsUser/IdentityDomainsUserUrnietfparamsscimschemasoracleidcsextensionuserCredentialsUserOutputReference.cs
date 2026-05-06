using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOutputReference), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "apiKeys", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserApiKeysList\"}")]
        public virtual oci.IdentityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserApiKeysList ApiKeys
        {
            get => GetInstanceProperty<oci.IdentityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserApiKeysList>()!;
        }

        [JsiiProperty(name: "authTokens", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserAuthTokensList\"}")]
        public virtual oci.IdentityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserAuthTokensList AuthTokens
        {
            get => GetInstanceProperty<oci.IdentityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserAuthTokensList>()!;
        }

        [JsiiProperty(name: "customerSecretKeys", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserCustomerSecretKeysList\"}")]
        public virtual oci.IdentityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserCustomerSecretKeysList CustomerSecretKeys
        {
            get => GetInstanceProperty<oci.IdentityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserCustomerSecretKeysList>()!;
        }

        [JsiiProperty(name: "dbCredentials", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserDbCredentialsList\"}")]
        public virtual oci.IdentityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserDbCredentialsList DbCredentials
        {
            get => GetInstanceProperty<oci.IdentityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserDbCredentialsList>()!;
        }

        [JsiiProperty(name: "oAuth2ClientCredentials", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOAuth2ClientCredentialsList\"}")]
        public virtual oci.IdentityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOAuth2ClientCredentialsList OAuth2ClientCredentials
        {
            get => GetInstanceProperty<oci.IdentityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserOAuth2ClientCredentialsList>()!;
        }

        [JsiiProperty(name: "smtpCredentials", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserSmtpCredentialsList\"}")]
        public virtual oci.IdentityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserSmtpCredentialsList SmtpCredentials
        {
            get => GetInstanceProperty<oci.IdentityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserSmtpCredentialsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUser\"}", isOptional: true)]
        public virtual oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUser? InternalValue
        {
            get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUser?>();
            set => SetInstanceProperty(value);
        }
    }
}
