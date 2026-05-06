using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMysqlMysqlDbSystem
{
    [JsiiClass(nativeType: typeof(oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemBackupPolicyOutputReference), fullyQualifiedName: "oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemBackupPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMysqlMysqlDbSystemBackupPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMysqlMysqlDbSystemBackupPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMysqlMysqlDbSystemBackupPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMysqlMysqlDbSystemBackupPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "copyPolicies", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemBackupPolicyCopyPoliciesList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemBackupPolicyCopyPoliciesList CopyPolicies
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemBackupPolicyCopyPoliciesList>()!;
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

        [JsiiProperty(name: "pitrPolicy", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemBackupPolicyPitrPolicyList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemBackupPolicyPitrPolicyList PitrPolicy
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemBackupPolicyPitrPolicyList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemBackupPolicy\"}", isOptional: true)]
        public virtual oci.DataOciMysqlMysqlDbSystem.IDataOciMysqlMysqlDbSystemBackupPolicy? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.IDataOciMysqlMysqlDbSystemBackupPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
