using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DelegateAccessControlDelegationControl
{
    [JsiiByValue(fqn: "oci.delegateAccessControlDelegationControl.DelegateAccessControlDelegationControlTimeouts")]
    public class DelegateAccessControlDelegationControlTimeouts : oci.DelegateAccessControlDelegationControl.IDelegateAccessControlDelegationControlTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/delegate_access_control_delegation_control#create DelegateAccessControlDelegationControl#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/delegate_access_control_delegation_control#delete DelegateAccessControlDelegationControl#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/delegate_access_control_delegation_control#update DelegateAccessControlDelegationControl#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
