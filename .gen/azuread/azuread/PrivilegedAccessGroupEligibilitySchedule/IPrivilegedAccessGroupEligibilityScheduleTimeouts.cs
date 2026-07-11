using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.PrivilegedAccessGroupEligibilitySchedule
{
    [JsiiInterface(nativeType: typeof(IPrivilegedAccessGroupEligibilityScheduleTimeouts), fullyQualifiedName: "azuread.privilegedAccessGroupEligibilitySchedule.PrivilegedAccessGroupEligibilityScheduleTimeouts")]
    public interface IPrivilegedAccessGroupEligibilityScheduleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_eligibility_schedule#create PrivilegedAccessGroupEligibilitySchedule#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_eligibility_schedule#delete PrivilegedAccessGroupEligibilitySchedule#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_eligibility_schedule#read PrivilegedAccessGroupEligibilitySchedule#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_eligibility_schedule#update PrivilegedAccessGroupEligibilitySchedule#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPrivilegedAccessGroupEligibilityScheduleTimeouts), fullyQualifiedName: "azuread.privilegedAccessGroupEligibilitySchedule.PrivilegedAccessGroupEligibilityScheduleTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.PrivilegedAccessGroupEligibilitySchedule.IPrivilegedAccessGroupEligibilityScheduleTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_eligibility_schedule#create PrivilegedAccessGroupEligibilitySchedule#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_eligibility_schedule#delete PrivilegedAccessGroupEligibilitySchedule#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_eligibility_schedule#read PrivilegedAccessGroupEligibilitySchedule#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_eligibility_schedule#update PrivilegedAccessGroupEligibilitySchedule#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
