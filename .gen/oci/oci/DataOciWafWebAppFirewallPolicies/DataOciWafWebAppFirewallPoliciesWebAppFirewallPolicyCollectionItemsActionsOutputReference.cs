using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciWafWebAppFirewallPolicies
{
    [JsiiClass(nativeType: typeof(oci.DataOciWafWebAppFirewallPolicies.DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsActionsOutputReference), fullyQualifiedName: "oci.dataOciWafWebAppFirewallPolicies.DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsActionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsActionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsActionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsActionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsActionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"oci.dataOciWafWebAppFirewallPolicies.DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsActionsBodyList\"}")]
        public virtual oci.DataOciWafWebAppFirewallPolicies.DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsActionsBodyList Body
        {
            get => GetInstanceProperty<oci.DataOciWafWebAppFirewallPolicies.DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsActionsBodyList>()!;
        }

        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Code
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "headers", typeJson: "{\"fqn\":\"oci.dataOciWafWebAppFirewallPolicies.DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsActionsHeadersList\"}")]
        public virtual oci.DataOciWafWebAppFirewallPolicies.DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsActionsHeadersList Headers
        {
            get => GetInstanceProperty<oci.DataOciWafWebAppFirewallPolicies.DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsActionsHeadersList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciWafWebAppFirewallPolicies.DataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsActions\"}", isOptional: true)]
        public virtual oci.DataOciWafWebAppFirewallPolicies.IDataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsActions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciWafWebAppFirewallPolicies.IDataOciWafWebAppFirewallPoliciesWebAppFirewallPolicyCollectionItemsActions?>();
            set => SetInstanceProperty(value);
        }
    }
}
