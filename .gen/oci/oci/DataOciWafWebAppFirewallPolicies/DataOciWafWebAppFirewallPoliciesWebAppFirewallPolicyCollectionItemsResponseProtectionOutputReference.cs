using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciWafWebAppFirewallPolicies
{
    [JsiiClass(nativeType: typeof(oci.DataOciWafWebAppFirewallPolicies.DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsResponseProtectionOutputReference), fullyQualifiedName: "oci.dataOciWafWebAppFirewallPolicies.DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsResponseProtectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsResponseProtectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsResponseProtectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsResponseProtectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsResponseProtectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "rules", typeJson: "{\"fqn\":\"oci.dataOciWafWebAppFirewallPolicies.DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsResponseProtectionRulesList\"}")]
        public virtual oci.DataOciWafWebAppFirewallPolicies.DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsResponseProtectionRulesList Rules
        {
            get => GetInstanceProperty<oci.DataOciWafWebAppFirewallPolicies.DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsResponseProtectionRulesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciWafWebAppFirewallPolicies.DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsResponseProtection\"}", isOptional: true)]
        public virtual oci.DataOciWafWebAppFirewallPolicies.IDataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsResponseProtection? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciWafWebAppFirewallPolicies.IDataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsResponseProtection?>();
            set => SetInstanceProperty(value);
        }
    }
}
