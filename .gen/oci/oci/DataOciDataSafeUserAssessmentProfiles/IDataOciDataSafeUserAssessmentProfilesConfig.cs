using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeUserAssessmentProfiles
{
    [JsiiInterface(nativeType: typeof(IDataOciDataSafeUserAssessmentProfilesConfig), fullyQualifiedName: "oci.dataOciDataSafeUserAssessmentProfiles.DataOciDataSafeUserAssessmentProfilesConfig")]
    public interface IDataOciDataSafeUserAssessmentProfilesConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#compartment_id DataOciDataSafeUserAssessmentProfiles#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#user_assessment_id DataOciDataSafeUserAssessmentProfiles#user_assessment_id}.</summary>
        [JsiiProperty(name: "userAssessmentId", typeJson: "{\"primitive\":\"string\"}")]
        string UserAssessmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#access_level DataOciDataSafeUserAssessmentProfiles#access_level}.</summary>
        [JsiiProperty(name: "accessLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#compartment_id_in_subtree DataOciDataSafeUserAssessmentProfiles#compartment_id_in_subtree}.</summary>
        [JsiiProperty(name: "compartmentIdInSubtree", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CompartmentIdInSubtree
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#failed_login_attempts_greater_than_or_equal DataOciDataSafeUserAssessmentProfiles#failed_login_attempts_greater_than_or_equal}.</summary>
        [JsiiProperty(name: "failedLoginAttemptsGreaterThanOrEqual", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FailedLoginAttemptsGreaterThanOrEqual
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#failed_login_attempts_less_than DataOciDataSafeUserAssessmentProfiles#failed_login_attempts_less_than}.</summary>
        [JsiiProperty(name: "failedLoginAttemptsLessThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FailedLoginAttemptsLessThan
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#filter DataOciDataSafeUserAssessmentProfiles#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeUserAssessmentProfiles.DataOciDataSafeUserAssessmentProfilesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#id DataOciDataSafeUserAssessmentProfiles#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#inactive_account_time_greater_than_or_equal DataOciDataSafeUserAssessmentProfiles#inactive_account_time_greater_than_or_equal}.</summary>
        [JsiiProperty(name: "inactiveAccountTimeGreaterThanOrEqual", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InactiveAccountTimeGreaterThanOrEqual
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#inactive_account_time_less_than DataOciDataSafeUserAssessmentProfiles#inactive_account_time_less_than}.</summary>
        [JsiiProperty(name: "inactiveAccountTimeLessThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InactiveAccountTimeLessThan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#is_user_created DataOciDataSafeUserAssessmentProfiles#is_user_created}.</summary>
        [JsiiProperty(name: "isUserCreated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsUserCreated
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#password_lock_time_greater_than_or_equal DataOciDataSafeUserAssessmentProfiles#password_lock_time_greater_than_or_equal}.</summary>
        [JsiiProperty(name: "passwordLockTimeGreaterThanOrEqual", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordLockTimeGreaterThanOrEqual
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#password_lock_time_less_than DataOciDataSafeUserAssessmentProfiles#password_lock_time_less_than}.</summary>
        [JsiiProperty(name: "passwordLockTimeLessThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordLockTimeLessThan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#password_verification_function DataOciDataSafeUserAssessmentProfiles#password_verification_function}.</summary>
        [JsiiProperty(name: "passwordVerificationFunction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordVerificationFunction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#profile_name DataOciDataSafeUserAssessmentProfiles#profile_name}.</summary>
        [JsiiProperty(name: "profileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProfileName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#sessions_per_user_greater_than_or_equal DataOciDataSafeUserAssessmentProfiles#sessions_per_user_greater_than_or_equal}.</summary>
        [JsiiProperty(name: "sessionsPerUserGreaterThanOrEqual", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SessionsPerUserGreaterThanOrEqual
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#sessions_per_user_less_than DataOciDataSafeUserAssessmentProfiles#sessions_per_user_less_than}.</summary>
        [JsiiProperty(name: "sessionsPerUserLessThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SessionsPerUserLessThan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#target_id DataOciDataSafeUserAssessmentProfiles#target_id}.</summary>
        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#user_count_greater_than_or_equal DataOciDataSafeUserAssessmentProfiles#user_count_greater_than_or_equal}.</summary>
        [JsiiProperty(name: "userCountGreaterThanOrEqual", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserCountGreaterThanOrEqual
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#user_count_less_than DataOciDataSafeUserAssessmentProfiles#user_count_less_than}.</summary>
        [JsiiProperty(name: "userCountLessThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserCountLessThan
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDataSafeUserAssessmentProfilesConfig), fullyQualifiedName: "oci.dataOciDataSafeUserAssessmentProfiles.DataOciDataSafeUserAssessmentProfilesConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDataSafeUserAssessmentProfiles.IDataOciDataSafeUserAssessmentProfilesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#compartment_id DataOciDataSafeUserAssessmentProfiles#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#user_assessment_id DataOciDataSafeUserAssessmentProfiles#user_assessment_id}.</summary>
            [JsiiProperty(name: "userAssessmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string UserAssessmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#access_level DataOciDataSafeUserAssessmentProfiles#access_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#compartment_id_in_subtree DataOciDataSafeUserAssessmentProfiles#compartment_id_in_subtree}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentIdInSubtree", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CompartmentIdInSubtree
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#failed_login_attempts_greater_than_or_equal DataOciDataSafeUserAssessmentProfiles#failed_login_attempts_greater_than_or_equal}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failedLoginAttemptsGreaterThanOrEqual", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FailedLoginAttemptsGreaterThanOrEqual
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#failed_login_attempts_less_than DataOciDataSafeUserAssessmentProfiles#failed_login_attempts_less_than}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failedLoginAttemptsLessThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FailedLoginAttemptsLessThan
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#filter DataOciDataSafeUserAssessmentProfiles#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeUserAssessmentProfiles.DataOciDataSafeUserAssessmentProfilesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#id DataOciDataSafeUserAssessmentProfiles#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#inactive_account_time_greater_than_or_equal DataOciDataSafeUserAssessmentProfiles#inactive_account_time_greater_than_or_equal}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inactiveAccountTimeGreaterThanOrEqual", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InactiveAccountTimeGreaterThanOrEqual
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#inactive_account_time_less_than DataOciDataSafeUserAssessmentProfiles#inactive_account_time_less_than}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inactiveAccountTimeLessThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InactiveAccountTimeLessThan
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#is_user_created DataOciDataSafeUserAssessmentProfiles#is_user_created}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isUserCreated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsUserCreated
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#password_lock_time_greater_than_or_equal DataOciDataSafeUserAssessmentProfiles#password_lock_time_greater_than_or_equal}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordLockTimeGreaterThanOrEqual", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordLockTimeGreaterThanOrEqual
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#password_lock_time_less_than DataOciDataSafeUserAssessmentProfiles#password_lock_time_less_than}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordLockTimeLessThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordLockTimeLessThan
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#password_verification_function DataOciDataSafeUserAssessmentProfiles#password_verification_function}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordVerificationFunction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordVerificationFunction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#profile_name DataOciDataSafeUserAssessmentProfiles#profile_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "profileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProfileName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#sessions_per_user_greater_than_or_equal DataOciDataSafeUserAssessmentProfiles#sessions_per_user_greater_than_or_equal}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sessionsPerUserGreaterThanOrEqual", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SessionsPerUserGreaterThanOrEqual
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#sessions_per_user_less_than DataOciDataSafeUserAssessmentProfiles#sessions_per_user_less_than}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sessionsPerUserLessThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SessionsPerUserLessThan
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#target_id DataOciDataSafeUserAssessmentProfiles#target_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#user_count_greater_than_or_equal DataOciDataSafeUserAssessmentProfiles#user_count_greater_than_or_equal}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userCountGreaterThanOrEqual", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserCountGreaterThanOrEqual
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_profiles#user_count_less_than DataOciDataSafeUserAssessmentProfiles#user_count_less_than}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userCountLessThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserCountLessThan
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
