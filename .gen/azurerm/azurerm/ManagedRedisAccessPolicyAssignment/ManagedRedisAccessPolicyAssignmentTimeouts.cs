using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedRedisAccessPolicyAssignment
{
    [JsiiByValue(fqn: "azurerm.managedRedisAccessPolicyAssignment.ManagedRedisAccessPolicyAssignmentTimeouts")]
    public class ManagedRedisAccessPolicyAssignmentTimeouts : azurerm.ManagedRedisAccessPolicyAssignment.IManagedRedisAccessPolicyAssignmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_redis_access_policy_assignment#create ManagedRedisAccessPolicyAssignment#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_redis_access_policy_assignment#delete ManagedRedisAccessPolicyAssignment#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_redis_access_policy_assignment#read ManagedRedisAccessPolicyAssignment#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
