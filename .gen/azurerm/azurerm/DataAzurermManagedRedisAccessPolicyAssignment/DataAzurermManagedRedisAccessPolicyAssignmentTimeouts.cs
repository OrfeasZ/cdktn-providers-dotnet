using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagedRedisAccessPolicyAssignment
{
    [JsiiByValue(fqn: "azurerm.dataAzurermManagedRedisAccessPolicyAssignment.DataAzurermManagedRedisAccessPolicyAssignmentTimeouts")]
    public class DataAzurermManagedRedisAccessPolicyAssignmentTimeouts : azurerm.DataAzurermManagedRedisAccessPolicyAssignment.IDataAzurermManagedRedisAccessPolicyAssignmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/managed_redis_access_policy_assignment#read DataAzurermManagedRedisAccessPolicyAssignment#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
