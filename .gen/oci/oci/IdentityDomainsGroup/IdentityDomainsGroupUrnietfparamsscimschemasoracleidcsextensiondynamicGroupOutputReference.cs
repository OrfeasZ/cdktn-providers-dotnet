using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsGroup
{
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroupOutputReference), fullyQualifiedName: "oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroupOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroupOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroupOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroupOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroupOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMembershipRule")]
        public virtual void ResetMembershipRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMembershipType")]
        public virtual void ResetMembershipType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "membershipRuleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MembershipRuleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "membershipTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MembershipTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "membershipRule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MembershipRule
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "membershipType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MembershipType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroup\"}", isOptional: true)]
        public virtual oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroup? InternalValue
        {
            get => GetInstanceProperty<oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroup?>();
            set => SetInstanceProperty(value);
        }
    }
}
