using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DirectoryRoleEligibilityScheduleRequest
{
    [JsiiByValue(fqn: "azuread.directoryRoleEligibilityScheduleRequest.DirectoryRoleEligibilityScheduleRequestTimeouts")]
    public class DirectoryRoleEligibilityScheduleRequestTimeouts : azuread.DirectoryRoleEligibilityScheduleRequest.IDirectoryRoleEligibilityScheduleRequestTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#create DirectoryRoleEligibilityScheduleRequest#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#delete DirectoryRoleEligibilityScheduleRequest#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#read DirectoryRoleEligibilityScheduleRequest#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
