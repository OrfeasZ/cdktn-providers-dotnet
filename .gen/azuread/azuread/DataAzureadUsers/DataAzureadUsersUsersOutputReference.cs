using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadUsers
{
    [JsiiClass(nativeType: typeof(azuread.DataAzureadUsers.DataAzureadUsersUsersOutputReference), fullyQualifiedName: "azuread.dataAzureadUsers.DataAzureadUsersUsersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzureadUsersUsersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzureadUsersUsersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzureadUsersUsersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzureadUsersUsersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accountEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AccountEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "employeeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmployeeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mailNickname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MailNickname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "onpremisesImmutableId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnpremisesImmutableId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "onpremisesSamAccountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnpremisesSamAccountName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "onpremisesUserPrincipalName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnpremisesUserPrincipalName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "usageLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userPrincipalName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPrincipalName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuread.dataAzureadUsers.DataAzureadUsersUsers\"}", isOptional: true)]
        public virtual azuread.DataAzureadUsers.IDataAzureadUsersUsers? InternalValue
        {
            get => GetInstanceProperty<azuread.DataAzureadUsers.IDataAzureadUsersUsers?>();
            set => SetInstanceProperty(value);
        }
    }
}
