using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkmailUser
{
    [JsiiInterface(nativeType: typeof(IWorkmailUserConfig), fullyQualifiedName: "aws.workmailUser.WorkmailUserConfig")]
    public interface IWorkmailUserConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Display name of the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#display_name WorkmailUser#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Primary email address used to register the user with WorkMail.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#email WorkmailUser#email}
        /// </remarks>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        string Email
        {
            get;
        }

        /// <summary>Username of the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#name WorkmailUser#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Identifier of the WorkMail organization where the user is managed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#organization_id WorkmailUser#organization_id}
        /// </remarks>
        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        string OrganizationId
        {
            get;
        }

        /// <summary>City where the user is located.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#city WorkmailUser#city}
        /// </remarks>
        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? City
        {
            get
            {
                return null;
            }
        }

        /// <summary>Company associated with the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#company WorkmailUser#company}
        /// </remarks>
        [JsiiProperty(name: "company", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Company
        {
            get
            {
                return null;
            }
        }

        /// <summary>Country where the user is located.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#country WorkmailUser#country}
        /// </remarks>
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Country
        {
            get
            {
                return null;
            }
        }

        /// <summary>Department associated with the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#department WorkmailUser#department}
        /// </remarks>
        [JsiiProperty(name: "department", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Department
        {
            get
            {
                return null;
            }
        }

        /// <summary>First name of the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#first_name WorkmailUser#first_name}
        /// </remarks>
        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FirstName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to hide the user from the global address list.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#hidden_from_global_address_list WorkmailUser#hidden_from_global_address_list}
        /// </remarks>
        [JsiiProperty(name: "hiddenFromGlobalAddressList", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HiddenFromGlobalAddressList
        {
            get
            {
                return null;
            }
        }

        /// <summary>User ID from IAM Identity Center associated with the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#identity_provider_user_id WorkmailUser#identity_provider_user_id}
        /// </remarks>
        [JsiiProperty(name: "identityProviderUserId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdentityProviderUserId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Initials of the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#initials WorkmailUser#initials}
        /// </remarks>
        [JsiiProperty(name: "initials", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Initials
        {
            get
            {
                return null;
            }
        }

        /// <summary>Job title of the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#job_title WorkmailUser#job_title}
        /// </remarks>
        [JsiiProperty(name: "jobTitle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JobTitle
        {
            get
            {
                return null;
            }
        }

        /// <summary>Last name of the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#last_name WorkmailUser#last_name}
        /// </remarks>
        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LastName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Office where the user is located.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#office WorkmailUser#office}
        /// </remarks>
        [JsiiProperty(name: "office", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Office
        {
            get
            {
                return null;
            }
        }

        /// <summary>Password to set for the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#password WorkmailUser#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#region WorkmailUser#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Street address of the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#street WorkmailUser#street}
        /// </remarks>
        [JsiiProperty(name: "street", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Street
        {
            get
            {
                return null;
            }
        }

        /// <summary>Telephone number of the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#telephone WorkmailUser#telephone}
        /// </remarks>
        [JsiiProperty(name: "telephone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Telephone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Role assigned to the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#user_role WorkmailUser#user_role}
        /// </remarks>
        [JsiiProperty(name: "userRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>ZIP or postal code of the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#zip_code WorkmailUser#zip_code}
        /// </remarks>
        [JsiiProperty(name: "zipCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZipCode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkmailUserConfig), fullyQualifiedName: "aws.workmailUser.WorkmailUserConfig")]
        internal sealed class _Proxy : DeputyBase, aws.WorkmailUser.IWorkmailUserConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Display name of the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#display_name WorkmailUser#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Primary email address used to register the user with WorkMail.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#email WorkmailUser#email}
            /// </remarks>
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
            public string Email
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Username of the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#name WorkmailUser#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifier of the WorkMail organization where the user is managed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#organization_id WorkmailUser#organization_id}
            /// </remarks>
            [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
            public string OrganizationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>City where the user is located.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#city WorkmailUser#city}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? City
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Company associated with the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#company WorkmailUser#company}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "company", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Company
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Country where the user is located.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#country WorkmailUser#country}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Country
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Department associated with the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#department WorkmailUser#department}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "department", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Department
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>First name of the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#first_name WorkmailUser#first_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FirstName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether to hide the user from the global address list.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#hidden_from_global_address_list WorkmailUser#hidden_from_global_address_list}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hiddenFromGlobalAddressList", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HiddenFromGlobalAddressList
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>User ID from IAM Identity Center associated with the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#identity_provider_user_id WorkmailUser#identity_provider_user_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityProviderUserId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdentityProviderUserId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Initials of the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#initials WorkmailUser#initials}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initials", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Initials
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Job title of the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#job_title WorkmailUser#job_title}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobTitle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JobTitle
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Last name of the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#last_name WorkmailUser#last_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LastName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Office where the user is located.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#office WorkmailUser#office}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "office", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Office
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Password to set for the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#password WorkmailUser#password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#region WorkmailUser#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Street address of the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#street WorkmailUser#street}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "street", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Street
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Telephone number of the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#telephone WorkmailUser#telephone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "telephone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Telephone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Role assigned to the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#user_role WorkmailUser#user_role}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserRole
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ZIP or postal code of the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#zip_code WorkmailUser#zip_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zipCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZipCode
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
