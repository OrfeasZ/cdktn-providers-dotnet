using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsProjectRepositorySetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingApprovalRulesItemsReviewers")]
    public class DevopsProjectRepositorySettingApprovalRulesItemsReviewers : oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingApprovalRulesItemsReviewers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#principal_id DevopsProjectRepositorySetting#principal_id}.</summary>
        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
        public string PrincipalId
        {
            get;
            set;
        }
    }
}
