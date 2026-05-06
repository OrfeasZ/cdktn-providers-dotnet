using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsUsers
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bypassCodes", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserBypassCodesList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserBypassCodesList BypassCodes
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserBypassCodesList>()!;
        }

        [JsiiProperty(name: "devices", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserDevicesList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserDevicesList Devices
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserDevicesList>()!;
        }

        [JsiiProperty(name: "loginAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LoginAttempts
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mfaEnabledOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MfaEnabledOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mfaIgnoredApps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MfaIgnoredApps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "mfaStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MfaStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preferredAuthenticationFactor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredAuthenticationFactor
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preferredAuthenticationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredAuthenticationMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preferredDevice", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserPreferredDeviceList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserPreferredDeviceList PreferredDevice
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserPreferredDeviceList>()!;
        }

        [JsiiProperty(name: "preferredThirdPartyVendor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredThirdPartyVendor
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trustedUserAgents", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserTrustedUserAgentsList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserTrustedUserAgentsList TrustedUserAgents
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserTrustedUserAgentsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUser\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsUsers.IDataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUser? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.IDataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUser?>();
            set => SetInstanceProperty(value);
        }
    }
}
