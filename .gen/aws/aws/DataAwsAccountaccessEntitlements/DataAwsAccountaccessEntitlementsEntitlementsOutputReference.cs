using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAccountaccessEntitlements
{
    [JsiiClass(nativeType: typeof(aws.DataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsEntitlementsOutputReference), fullyQualifiedName: "aws.dataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsEntitlementsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsAccountaccessEntitlementsEntitlementsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsAccountaccessEntitlementsEntitlementsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsAccountaccessEntitlementsEntitlementsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAccountaccessEntitlementsEntitlementsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entitlement", typeJson: "{\"fqn\":\"aws.dataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsEntitlementsEntitlementList\"}")]
        public virtual aws.DataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsEntitlementsEntitlementList Entitlement
        {
            get => GetInstanceProperty<aws.DataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsEntitlementsEntitlementList>()!;
        }

        [JsiiProperty(name: "entitlementId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntitlementId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsEntitlements\"}", isOptional: true)]
        public virtual aws.DataAwsAccountaccessEntitlements.IDataAwsAccountaccessEntitlementsEntitlements? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsAccountaccessEntitlements.IDataAwsAccountaccessEntitlementsEntitlements?>();
            set => SetInstanceProperty(value);
        }
    }
}
