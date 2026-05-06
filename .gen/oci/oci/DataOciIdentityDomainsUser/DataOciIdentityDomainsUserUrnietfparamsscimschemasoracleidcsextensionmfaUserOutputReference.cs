using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsUser
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bypassCodes", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserBypassCodesList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserBypassCodesList BypassCodes
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserBypassCodesList>()!;
        }

        [JsiiProperty(name: "devices", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserDevicesList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserDevicesList Devices
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserDevicesList>()!;
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

        [JsiiProperty(name: "preferredDevice", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserPreferredDeviceList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserPreferredDeviceList PreferredDevice
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserPreferredDeviceList>()!;
        }

        [JsiiProperty(name: "preferredThirdPartyVendor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredThirdPartyVendor
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trustedUserAgents", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserTrustedUserAgentsList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserTrustedUserAgentsList TrustedUserAgents
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserTrustedUserAgentsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsUser.IDataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.IDataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser?>();
            set => SetInstanceProperty(value);
        }
    }
}
