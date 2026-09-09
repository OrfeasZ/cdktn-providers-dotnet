using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAccountaccessEntitlements
{
    [JsiiClass(nativeType: typeof(aws.DataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsEntitlementsEntitlementPrincipalRoleOutputReference), fullyQualifiedName: "aws.dataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsEntitlementsEntitlementPrincipalRoleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsAccountaccessEntitlementsEntitlementsEntitlementPrincipalRoleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsAccountaccessEntitlementsEntitlementsEntitlementPrincipalRoleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsAccountaccessEntitlementsEntitlementsEntitlementPrincipalRoleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAccountaccessEntitlementsEntitlementsEntitlementPrincipalRoleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "principal", typeJson: "{\"fqn\":\"aws.dataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsEntitlementsEntitlementPrincipalRolePrincipalList\"}")]
        public virtual aws.DataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsEntitlementsEntitlementPrincipalRolePrincipalList Principal
        {
            get => GetInstanceProperty<aws.DataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsEntitlementsEntitlementPrincipalRolePrincipalList>()!;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsEntitlementsEntitlementPrincipalRole\"}", isOptional: true)]
        public virtual aws.DataAwsAccountaccessEntitlements.IDataAwsAccountaccessEntitlementsEntitlementsEntitlementPrincipalRole? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsAccountaccessEntitlements.IDataAwsAccountaccessEntitlementsEntitlementsEntitlementPrincipalRole?>();
            set => SetInstanceProperty(value);
        }
    }
}
