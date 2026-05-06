using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeUserAssessmentUsers
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeUserAssessmentUsers.DataOciDataSafeUserAssessmentUsersUsersOutputReference), fullyQualifiedName: "oci.dataOciDataSafeUserAssessmentUsers.DataOciDataSafeUserAssessmentUsersUsersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeUserAssessmentUsersUsersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeUserAssessmentUsersUsersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeUserAssessmentUsersUsersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeUserAssessmentUsersUsersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accountStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "adminRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AdminRoles
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "areAllSchemasAccessible", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AreAllSchemasAccessible
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemaList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SchemaList
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastLogin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastLogin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timePasswordChanged", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePasswordChanged
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timePasswordExpiry", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePasswordExpiry
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUserCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUserCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userCategory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserCategory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userProfile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserProfile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] UserTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeUserAssessmentUsers.DataOciDataSafeUserAssessmentUsersUsers\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeUserAssessmentUsers.IDataOciDataSafeUserAssessmentUsersUsers? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeUserAssessmentUsers.IDataOciDataSafeUserAssessmentUsersUsers?>();
            set => SetInstanceProperty(value);
        }
    }
}
