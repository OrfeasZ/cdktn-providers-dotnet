using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsRepositorySetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsRepositorySetting.DevopsRepositorySettingApprovalRulesItems")]
    public class DevopsRepositorySettingApprovalRulesItems : oci.DevopsRepositorySetting.IDevopsRepositorySettingApprovalRulesItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting#min_approvals_count DevopsRepositorySetting#min_approvals_count}.</summary>
        [JsiiProperty(name: "minApprovalsCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MinApprovalsCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting#name DevopsRepositorySetting#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting#destination_branch DevopsRepositorySetting#destination_branch}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationBranch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationBranch
        {
            get;
            set;
        }

        private object? _reviewers;

        /// <summary>reviewers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting#reviewers DevopsRepositorySetting#reviewers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reviewers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsRepositorySetting.DevopsRepositorySettingApprovalRulesItemsReviewers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Reviewers
        {
            get => _reviewers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DevopsRepositorySetting.IDevopsRepositorySettingApprovalRulesItemsReviewers[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DevopsRepositorySetting.IDevopsRepositorySettingApprovalRulesItemsReviewers).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _reviewers = value;
            }
        }
    }
}
