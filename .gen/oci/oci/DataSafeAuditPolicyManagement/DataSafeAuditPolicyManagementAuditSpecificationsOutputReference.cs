using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeAuditPolicyManagement
{
    [JsiiClass(nativeType: typeof(oci.DataSafeAuditPolicyManagement.DataSafeAuditPolicyManagementAuditSpecificationsOutputReference), fullyQualifiedName: "oci.dataSafeAuditPolicyManagement.DataSafeAuditPolicyManagementAuditSpecificationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataSafeAuditPolicyManagementAuditSpecificationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataSafeAuditPolicyManagementAuditSpecificationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataSafeAuditPolicyManagementAuditSpecificationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeAuditPolicyManagementAuditSpecificationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "auditPolicyCategory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuditPolicyCategory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "auditPolicyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuditPolicyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databasePolicyNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DatabasePolicyNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "enabledEntities", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnabledEntities
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enableStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnableStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isCreated", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCreated
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isEnabledForAllUsers", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnabledForAllUsers
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSeededInDataSafe", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSeededInDataSafe
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSeededInTarget", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSeededInTarget
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isViewOnly", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsViewOnly
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "partiallyEnabledMsg", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartiallyEnabledMsg
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataSafeAuditPolicyManagement.DataSafeAuditPolicyManagementAuditSpecifications\"}", isOptional: true)]
        public virtual oci.DataSafeAuditPolicyManagement.IDataSafeAuditPolicyManagementAuditSpecifications? InternalValue
        {
            get => GetInstanceProperty<oci.DataSafeAuditPolicyManagement.IDataSafeAuditPolicyManagementAuditSpecifications?>();
            set => SetInstanceProperty(value);
        }
    }
}
