using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagedRedisAccessPolicyAssignment
{
    [JsiiInterface(nativeType: typeof(IDataAzurermManagedRedisAccessPolicyAssignmentTimeouts), fullyQualifiedName: "azurerm.dataAzurermManagedRedisAccessPolicyAssignment.DataAzurermManagedRedisAccessPolicyAssignmentTimeouts")]
    public interface IDataAzurermManagedRedisAccessPolicyAssignmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/managed_redis_access_policy_assignment#read DataAzurermManagedRedisAccessPolicyAssignment#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermManagedRedisAccessPolicyAssignmentTimeouts), fullyQualifiedName: "azurerm.dataAzurermManagedRedisAccessPolicyAssignment.DataAzurermManagedRedisAccessPolicyAssignmentTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermManagedRedisAccessPolicyAssignment.IDataAzurermManagedRedisAccessPolicyAssignmentTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/managed_redis_access_policy_assignment#read DataAzurermManagedRedisAccessPolicyAssignment#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
