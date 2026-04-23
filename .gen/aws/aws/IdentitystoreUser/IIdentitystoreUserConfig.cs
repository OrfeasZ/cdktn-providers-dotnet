using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IdentitystoreUser
{
    [JsiiInterface(nativeType: typeof(IIdentitystoreUserConfig), fullyQualifiedName: "aws.identitystoreUser.IdentitystoreUserConfig")]
    public interface IIdentitystoreUserConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#display_name IdentitystoreUser#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#identity_store_id IdentitystoreUser#identity_store_id}.</summary>
        [JsiiProperty(name: "identityStoreId", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityStoreId
        {
            get;
        }

        /// <summary>name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#name IdentitystoreUser#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserName\"}")]
        aws.IdentitystoreUser.IIdentitystoreUserName Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#user_name IdentitystoreUser#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        string UserName
        {
            get;
        }

        /// <summary>addresses block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#addresses IdentitystoreUser#addresses}
        /// </remarks>
        [JsiiProperty(name: "addresses", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserAddresses\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IdentitystoreUser.IIdentitystoreUserAddresses? Addresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>emails block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#emails IdentitystoreUser#emails}
        /// </remarks>
        [JsiiProperty(name: "emails", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserEmails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IdentitystoreUser.IIdentitystoreUserEmails? Emails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#id IdentitystoreUser#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#locale IdentitystoreUser#locale}.</summary>
        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Locale
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#nickname IdentitystoreUser#nickname}.</summary>
        [JsiiProperty(name: "nickname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Nickname
        {
            get
            {
                return null;
            }
        }

        /// <summary>phone_numbers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#phone_numbers IdentitystoreUser#phone_numbers}
        /// </remarks>
        [JsiiProperty(name: "phoneNumbers", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserPhoneNumbers\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IdentitystoreUser.IIdentitystoreUserPhoneNumbers? PhoneNumbers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#preferred_language IdentitystoreUser#preferred_language}.</summary>
        [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredLanguage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#profile_url IdentitystoreUser#profile_url}.</summary>
        [JsiiProperty(name: "profileUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProfileUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#region IdentitystoreUser#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#timezone IdentitystoreUser#timezone}.</summary>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Timezone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#title IdentitystoreUser#title}.</summary>
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Title
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#user_type IdentitystoreUser#user_type}.</summary>
        [JsiiProperty(name: "userType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentitystoreUserConfig), fullyQualifiedName: "aws.identitystoreUser.IdentitystoreUserConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IdentitystoreUser.IIdentitystoreUserConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#display_name IdentitystoreUser#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#identity_store_id IdentitystoreUser#identity_store_id}.</summary>
            [JsiiProperty(name: "identityStoreId", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityStoreId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#name IdentitystoreUser#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserName\"}")]
            public aws.IdentitystoreUser.IIdentitystoreUserName Name
            {
                get => GetInstanceProperty<aws.IdentitystoreUser.IIdentitystoreUserName>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#user_name IdentitystoreUser#user_name}.</summary>
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
            public string UserName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>addresses block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#addresses IdentitystoreUser#addresses}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addresses", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserAddresses\"}", isOptional: true)]
            public aws.IdentitystoreUser.IIdentitystoreUserAddresses? Addresses
            {
                get => GetInstanceProperty<aws.IdentitystoreUser.IIdentitystoreUserAddresses?>();
            }

            /// <summary>emails block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#emails IdentitystoreUser#emails}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emails", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserEmails\"}", isOptional: true)]
            public aws.IdentitystoreUser.IIdentitystoreUserEmails? Emails
            {
                get => GetInstanceProperty<aws.IdentitystoreUser.IIdentitystoreUserEmails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#id IdentitystoreUser#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#locale IdentitystoreUser#locale}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Locale
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#nickname IdentitystoreUser#nickname}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nickname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Nickname
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>phone_numbers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#phone_numbers IdentitystoreUser#phone_numbers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phoneNumbers", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserPhoneNumbers\"}", isOptional: true)]
            public aws.IdentitystoreUser.IIdentitystoreUserPhoneNumbers? PhoneNumbers
            {
                get => GetInstanceProperty<aws.IdentitystoreUser.IIdentitystoreUserPhoneNumbers?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#preferred_language IdentitystoreUser#preferred_language}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredLanguage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#profile_url IdentitystoreUser#profile_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "profileUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProfileUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#region IdentitystoreUser#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#timezone IdentitystoreUser#timezone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Timezone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#title IdentitystoreUser#title}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Title
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/identitystore_user#user_type IdentitystoreUser#user_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserType
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
