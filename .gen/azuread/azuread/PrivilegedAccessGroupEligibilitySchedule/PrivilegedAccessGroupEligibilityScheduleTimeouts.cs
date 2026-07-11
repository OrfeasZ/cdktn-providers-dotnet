using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.PrivilegedAccessGroupEligibilitySchedule
{
    [JsiiByValue(fqn: "azuread.privilegedAccessGroupEligibilitySchedule.PrivilegedAccessGroupEligibilityScheduleTimeouts")]
    public class PrivilegedAccessGroupEligibilityScheduleTimeouts : azuread.PrivilegedAccessGroupEligibilitySchedule.IPrivilegedAccessGroupEligibilityScheduleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_eligibility_schedule#create PrivilegedAccessGroupEligibilitySchedule#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_eligibility_schedule#delete PrivilegedAccessGroupEligibilitySchedule#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_eligibility_schedule#read PrivilegedAccessGroupEligibilitySchedule#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_eligibility_schedule#update PrivilegedAccessGroupEligibilitySchedule#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
