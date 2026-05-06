using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesDatabaseViewAccessEntryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesDatabaseViewAccessEntryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesDatabaseViewAccessEntryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesDatabaseViewAccessEntryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesDatabaseViewAccessEntryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesDatabaseViewAccessEntryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ColumnName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "grantee", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Grantee
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "grantFromRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GrantFromRole
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "grantor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Grantor
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAccessConstrainedByDatabaseVault", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAccessConstrainedByDatabaseVault
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isAccessConstrainedByRealApplicationSecurity", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAccessConstrainedByRealApplicationSecurity
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isAccessConstrainedByRedaction", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAccessConstrainedByRedaction
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isAccessConstrainedBySqlFirewall", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAccessConstrainedBySqlFirewall
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isAccessConstrainedByVirtualPrivateDatabase", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAccessConstrainedByVirtualPrivateDatabase
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privilege", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Privilege
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privilegeGrantable", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivilegeGrantable
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privilegeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivilegeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tableSchema", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableSchema
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "viewName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "viewSchema", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewSchema
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "viewText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewText
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesDatabaseViewAccessEntryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.IDataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesDatabaseViewAccessEntryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.IDataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesDatabaseViewAccessEntryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
