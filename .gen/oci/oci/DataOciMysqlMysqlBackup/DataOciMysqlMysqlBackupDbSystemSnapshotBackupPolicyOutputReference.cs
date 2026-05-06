using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMysqlMysqlBackup
{
    [JsiiClass(nativeType: typeof(oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicyOutputReference), fullyQualifiedName: "oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "copyPolicies", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicyCopyPoliciesList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicyCopyPoliciesList CopyPolicies
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicyCopyPoliciesList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "isEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "pitrPolicy", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicyPitrPolicyList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicyPitrPolicyList PitrPolicy
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicyPitrPolicyList>()!;
        }

        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetentionInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "softDelete", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftDelete
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "windowStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WindowStartTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicy\"}", isOptional: true)]
        public virtual oci.DataOciMysqlMysqlBackup.IDataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicy? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.IDataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
