using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DirectoryRoleEligibilityScheduleRequest
{
    [JsiiInterface(nativeType: typeof(IDirectoryRoleEligibilityScheduleRequestTimeouts), fullyQualifiedName: "azuread.directoryRoleEligibilityScheduleRequest.DirectoryRoleEligibilityScheduleRequestTimeouts")]
    public interface IDirectoryRoleEligibilityScheduleRequestTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#create DirectoryRoleEligibilityScheduleRequest#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#delete DirectoryRoleEligibilityScheduleRequest#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#read DirectoryRoleEligibilityScheduleRequest#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDirectoryRoleEligibilityScheduleRequestTimeouts), fullyQualifiedName: "azuread.directoryRoleEligibilityScheduleRequest.DirectoryRoleEligibilityScheduleRequestTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.DirectoryRoleEligibilityScheduleRequest.IDirectoryRoleEligibilityScheduleRequestTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#create DirectoryRoleEligibilityScheduleRequest#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#delete DirectoryRoleEligibilityScheduleRequest#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#read DirectoryRoleEligibilityScheduleRequest#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
