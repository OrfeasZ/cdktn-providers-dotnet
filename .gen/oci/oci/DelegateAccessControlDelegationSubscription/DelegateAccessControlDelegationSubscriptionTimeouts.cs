using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DelegateAccessControlDelegationSubscription
{
    [JsiiByValue(fqn: "oci.delegateAccessControlDelegationSubscription.DelegateAccessControlDelegationSubscriptionTimeouts")]
    public class DelegateAccessControlDelegationSubscriptionTimeouts : oci.DelegateAccessControlDelegationSubscription.IDelegateAccessControlDelegationSubscriptionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/delegate_access_control_delegation_subscription#create DelegateAccessControlDelegationSubscription#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/delegate_access_control_delegation_subscription#delete DelegateAccessControlDelegationSubscription#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/delegate_access_control_delegation_subscription#update DelegateAccessControlDelegationSubscription#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
