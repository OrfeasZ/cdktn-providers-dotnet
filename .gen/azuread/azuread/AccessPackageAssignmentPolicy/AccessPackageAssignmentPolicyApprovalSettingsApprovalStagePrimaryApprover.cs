using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageAssignmentPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyApprovalSettingsApprovalStagePrimaryApprover")]
    public class AccessPackageAssignmentPolicyApprovalSettingsApprovalStagePrimaryApprover : azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyApprovalSettingsApprovalStagePrimaryApprover
    {
        /// <summary>Type of users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#subject_type AccessPackageAssignmentPolicy#subject_type}
        /// </remarks>
        [JsiiProperty(name: "subjectType", typeJson: "{\"primitive\":\"string\"}")]
        public string SubjectType
        {
            get;
            set;
        }

        private object? _backup;

        /// <summary>For a user in an approval stage, this property indicates whether the user is a backup fallback approver.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#backup AccessPackageAssignmentPolicy#backup}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Backup
        {
            get => _backup;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _backup = value;
            }
        }

        /// <summary>The object ID of the subject.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#object_id AccessPackageAssignmentPolicy#object_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectId
        {
            get;
            set;
        }
    }
}
