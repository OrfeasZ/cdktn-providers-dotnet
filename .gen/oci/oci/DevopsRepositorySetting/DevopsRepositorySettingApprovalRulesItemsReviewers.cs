using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsRepositorySetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsRepositorySetting.DevopsRepositorySettingApprovalRulesItemsReviewers")]
    public class DevopsRepositorySettingApprovalRulesItemsReviewers : oci.DevopsRepositorySetting.IDevopsRepositorySettingApprovalRulesItemsReviewers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting#principal_id DevopsRepositorySetting#principal_id}.</summary>
        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
        public string PrincipalId
        {
            get;
            set;
        }
    }
}
