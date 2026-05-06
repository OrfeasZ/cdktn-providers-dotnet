using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsProjectRepositorySetting
{
    [JsiiInterface(nativeType: typeof(IDevopsProjectRepositorySettingApprovalRulesItems), fullyQualifiedName: "oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingApprovalRulesItems")]
    public interface IDevopsProjectRepositorySettingApprovalRulesItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#min_approvals_count DevopsProjectRepositorySetting#min_approvals_count}.</summary>
        [JsiiProperty(name: "minApprovalsCount", typeJson: "{\"primitive\":\"number\"}")]
        double MinApprovalsCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#name DevopsProjectRepositorySetting#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#destination_branch DevopsProjectRepositorySetting#destination_branch}.</summary>
        [JsiiProperty(name: "destinationBranch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationBranch
        {
            get
            {
                return null;
            }
        }

        /// <summary>reviewers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#reviewers DevopsProjectRepositorySetting#reviewers}
        /// </remarks>
        [JsiiProperty(name: "reviewers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingApprovalRulesItemsReviewers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Reviewers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsProjectRepositorySettingApprovalRulesItems), fullyQualifiedName: "oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingApprovalRulesItems")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingApprovalRulesItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#min_approvals_count DevopsProjectRepositorySetting#min_approvals_count}.</summary>
            [JsiiProperty(name: "minApprovalsCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MinApprovalsCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#name DevopsProjectRepositorySetting#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#destination_branch DevopsProjectRepositorySetting#destination_branch}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationBranch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationBranch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>reviewers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#reviewers DevopsProjectRepositorySetting#reviewers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reviewers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingApprovalRulesItemsReviewers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Reviewers
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
