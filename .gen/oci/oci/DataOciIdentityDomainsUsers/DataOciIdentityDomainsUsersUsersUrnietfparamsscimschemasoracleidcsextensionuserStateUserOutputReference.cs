using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsUsers
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUserOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUserOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUserOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUserOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUserOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUserOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "lastFailedLoginDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastFailedLoginDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastSuccessfulLoginDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastSuccessfulLoginDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locked", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUserLockedList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUserLockedList Locked
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUserLockedList>()!;
        }

        [JsiiProperty(name: "loginAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LoginAttempts
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxConcurrentSessions", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConcurrentSessions
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "previousSuccessfulLoginDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreviousSuccessfulLoginDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recoveryAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecoveryAttempts
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "recoveryEnrollAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecoveryEnrollAttempts
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "recoveryLocked", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLockedList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLockedList RecoveryLocked
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLockedList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUser\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsUsers.IDataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUser? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.IDataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUser?>();
            set => SetInstanceProperty(value);
        }
    }
}
