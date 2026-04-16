using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IamPolicy
{
    [JsiiInterface(nativeType: typeof(IIamPolicyRule), fullyQualifiedName: "scaleway.iamPolicy.IamPolicyRule")]
    public interface IIamPolicyRule
    {
        /// <summary>Names of permission sets bound to the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iam_policy#permission_set_names IamPolicy#permission_set_names}
        /// </remarks>
        [JsiiProperty(name: "permissionSetNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] PermissionSetNames
        {
            get;
        }

        /// <summary>Conditions of the policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iam_policy#condition IamPolicy#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Condition
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of organization scoped to the rule. Only one of project_ids and organization_id may be set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iam_policy#organization_id IamPolicy#organization_id}
        /// </remarks>
        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrganizationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of project IDs scoped to the rule. Only one of project_ids and organization_id may be set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iam_policy#project_ids IamPolicy#project_ids}
        /// </remarks>
        [JsiiProperty(name: "projectIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ProjectIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIamPolicyRule), fullyQualifiedName: "scaleway.iamPolicy.IamPolicyRule")]
        internal sealed class _Proxy : DeputyBase, scaleway.IamPolicy.IIamPolicyRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Names of permission sets bound to the rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iam_policy#permission_set_names IamPolicy#permission_set_names}
            /// </remarks>
            [JsiiProperty(name: "permissionSetNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] PermissionSetNames
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Conditions of the policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iam_policy#condition IamPolicy#condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Condition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of organization scoped to the rule. Only one of project_ids and organization_id may be set.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iam_policy#organization_id IamPolicy#organization_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrganizationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>List of project IDs scoped to the rule. Only one of project_ids and organization_id may be set.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iam_policy#project_ids IamPolicy#project_ids}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ProjectIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
