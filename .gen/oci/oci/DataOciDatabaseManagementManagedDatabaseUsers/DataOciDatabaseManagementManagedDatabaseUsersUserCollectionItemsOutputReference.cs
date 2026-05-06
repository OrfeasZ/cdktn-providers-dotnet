using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabaseUsers
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedDatabaseUsers.DataOciDatabaseManagementManagedDatabaseUsersUserCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseUsers.DataOciDatabaseManagementManagedDatabaseUsersUserCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementManagedDatabaseUsersUserCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementManagedDatabaseUsersUserCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementManagedDatabaseUsersUserCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseUsersUserCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allShared", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllShared
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authentication", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authentication
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "common", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Common
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "consumerGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumerGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultCollation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultCollation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultTablespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultTablespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "editionsEnabled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EditionsEnabled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalShared", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalShared
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "implicit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Implicit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inherited", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Inherited
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "localTempTablespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalTempTablespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oracleMaintained", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OracleMaintained
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordVersions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordVersions
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Profile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "proxyConnect", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProxyConnect
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tempTablespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TempTablespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeExpiring", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeExpiring
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastLogin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastLogin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLocked", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLocked
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timePasswordChanged", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePasswordChanged
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseUsers.DataOciDatabaseManagementManagedDatabaseUsersUserCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseUsers.IDataOciDatabaseManagementManagedDatabaseUsersUserCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseUsers.IDataOciDatabaseManagementManagedDatabaseUsersUserCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
