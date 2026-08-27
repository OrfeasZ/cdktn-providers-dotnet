using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedRedisAccessPolicyAssignment
{
    [JsiiInterface(nativeType: typeof(IManagedRedisAccessPolicyAssignmentTimeouts), fullyQualifiedName: "azurerm.managedRedisAccessPolicyAssignment.ManagedRedisAccessPolicyAssignmentTimeouts")]
    public interface IManagedRedisAccessPolicyAssignmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_redis_access_policy_assignment#create ManagedRedisAccessPolicyAssignment#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_redis_access_policy_assignment#delete ManagedRedisAccessPolicyAssignment#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_redis_access_policy_assignment#read ManagedRedisAccessPolicyAssignment#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedRedisAccessPolicyAssignmentTimeouts), fullyQualifiedName: "azurerm.managedRedisAccessPolicyAssignment.ManagedRedisAccessPolicyAssignmentTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedRedisAccessPolicyAssignment.IManagedRedisAccessPolicyAssignmentTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_redis_access_policy_assignment#create ManagedRedisAccessPolicyAssignment#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_redis_access_policy_assignment#delete ManagedRedisAccessPolicyAssignment#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_redis_access_policy_assignment#read ManagedRedisAccessPolicyAssignment#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
