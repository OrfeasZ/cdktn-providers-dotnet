using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IamPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.iamPolicy.IamPolicyRule")]
    public class IamPolicyRule : scaleway.IamPolicy.IIamPolicyRule
    {
        /// <summary>Names of permission sets bound to the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iam_policy#permission_set_names IamPolicy#permission_set_names}
        /// </remarks>
        [JsiiProperty(name: "permissionSetNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] PermissionSetNames
        {
            get;
            set;
        }

        /// <summary>Conditions of the policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iam_policy#condition IamPolicy#condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Condition
        {
            get;
            set;
        }

        /// <summary>ID of organization scoped to the rule. Only one of project_ids and organization_id may be set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iam_policy#organization_id IamPolicy#organization_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrganizationId
        {
            get;
            set;
        }

        /// <summary>List of project IDs scoped to the rule. Only one of project_ids and organization_id may be set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iam_policy#project_ids IamPolicy#project_ids}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "projectIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ProjectIds
        {
            get;
            set;
        }
    }
}
