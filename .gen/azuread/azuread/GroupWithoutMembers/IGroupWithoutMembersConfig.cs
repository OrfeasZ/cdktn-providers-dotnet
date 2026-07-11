using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupWithoutMembers
{
    [JsiiInterface(nativeType: typeof(IGroupWithoutMembersConfig), fullyQualifiedName: "azuread.groupWithoutMembers.GroupWithoutMembersConfig")]
    public interface IGroupWithoutMembersConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The display name for the group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#display_name GroupWithoutMembers#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>The administrative unit IDs in which the group should be.</summary>
        /// <remarks>
        /// If empty, the group will be created at the tenant level.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#administrative_unit_ids GroupWithoutMembers#administrative_unit_ids}
        /// </remarks>
        [JsiiProperty(name: "administrativeUnitIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AdministrativeUnitIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates whether this group can be assigned to an Azure Active Directory role.</summary>
        /// <remarks>
        /// This property can only be <c>true</c> for security-enabled groups.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#assignable_to_role GroupWithoutMembers#assignable_to_role}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "assignableToRole", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AssignableToRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates whether new members added to the group will be auto-subscribed to receive email notifications.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#auto_subscribe_new_members GroupWithoutMembers#auto_subscribe_new_members}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "autoSubscribeNewMembers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoSubscribeNewMembers
        {
            get
            {
                return null;
            }
        }

        /// <summary>The group behaviours for a Microsoft 365 group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#behaviors GroupWithoutMembers#behaviors}
        /// </remarks>
        [JsiiProperty(name: "behaviors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Behaviors
        {
            get
            {
                return null;
            }
        }

        /// <summary>The description for the group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#description GroupWithoutMembers#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>dynamic_membership block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#dynamic_membership GroupWithoutMembers#dynamic_membership}
        /// </remarks>
        [JsiiProperty(name: "dynamicMembership", typeJson: "{\"fqn\":\"azuread.groupWithoutMembers.GroupWithoutMembersDynamicMembership\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.GroupWithoutMembers.IGroupWithoutMembersDynamicMembership? DynamicMembership
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates whether people external to the organization can send messages to the group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#external_senders_allowed GroupWithoutMembers#external_senders_allowed}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "externalSendersAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExternalSendersAllowed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#hide_from_address_lists GroupWithoutMembers#hide_from_address_lists}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "hideFromAddressLists", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HideFromAddressLists
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#hide_from_outlook_clients GroupWithoutMembers#hide_from_outlook_clients}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "hideFromOutlookClients", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HideFromOutlookClients
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#id GroupWithoutMembers#id}.</summary>
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

        /// <summary>Whether the group is a mail enabled, with a shared group mailbox.</summary>
        /// <remarks>
        /// At least one of <c>mail_enabled</c> or <c>security_enabled</c> must be specified. A group can be mail enabled <em>and</em> security enabled
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#mail_enabled GroupWithoutMembers#mail_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "mailEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MailEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The mail alias for the group, unique in the organisation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#mail_nickname GroupWithoutMembers#mail_nickname}
        /// </remarks>
        [JsiiProperty(name: "mailNickname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MailNickname
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates the target on-premise group type the group will be written back as.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#onpremises_group_type GroupWithoutMembers#onpremises_group_type}
        /// </remarks>
        [JsiiProperty(name: "onpremisesGroupType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnpremisesGroupType
        {
            get
            {
                return null;
            }
        }

        /// <summary>A set of owners who own this group. Supported object types are Users or Service Principals.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#owners GroupWithoutMembers#owners}
        /// </remarks>
        [JsiiProperty(name: "owners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Owners
        {
            get
            {
                return null;
            }
        }

        /// <summary>If `true`, will return an error if an existing group is found with the same name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#prevent_duplicate_names GroupWithoutMembers#prevent_duplicate_names}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "preventDuplicateNames", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PreventDuplicateNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>The group provisioning options for a Microsoft 365 group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#provisioning_options GroupWithoutMembers#provisioning_options}
        /// </remarks>
        [JsiiProperty(name: "provisioningOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ProvisioningOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the group is a security group for controlling access to in-app resources.</summary>
        /// <remarks>
        /// At least one of <c>security_enabled</c> or <c>mail_enabled</c> must be specified. A group can be security enabled <em>and</em> mail enabled
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#security_enabled GroupWithoutMembers#security_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "securityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecurityEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The colour theme for a Microsoft 365 group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#theme GroupWithoutMembers#theme}
        /// </remarks>
        [JsiiProperty(name: "theme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Theme
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#timeouts GroupWithoutMembers#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.groupWithoutMembers.GroupWithoutMembersTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.GroupWithoutMembers.IGroupWithoutMembersTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>A set of group types to configure for the group.</summary>
        /// <remarks>
        /// <c>Unified</c> specifies a Microsoft 365 group. Required when <c>mail_enabled</c> is true
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#types GroupWithoutMembers#types}
        /// </remarks>
        [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Types
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the group join policy and group content visibility.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#visibility GroupWithoutMembers#visibility}
        /// </remarks>
        [JsiiProperty(name: "visibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Visibility
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether this group should be synced from Azure AD to the on-premises directory when Azure AD Connect is used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#writeback_enabled GroupWithoutMembers#writeback_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "writebackEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WritebackEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGroupWithoutMembersConfig), fullyQualifiedName: "azuread.groupWithoutMembers.GroupWithoutMembersConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.GroupWithoutMembers.IGroupWithoutMembersConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The display name for the group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#display_name GroupWithoutMembers#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The administrative unit IDs in which the group should be.</summary>
            /// <remarks>
            /// If empty, the group will be created at the tenant level.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#administrative_unit_ids GroupWithoutMembers#administrative_unit_ids}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "administrativeUnitIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AdministrativeUnitIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Indicates whether this group can be assigned to an Azure Active Directory role.</summary>
            /// <remarks>
            /// This property can only be <c>true</c> for security-enabled groups.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#assignable_to_role GroupWithoutMembers#assignable_to_role}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "assignableToRole", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AssignableToRole
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Indicates whether new members added to the group will be auto-subscribed to receive email notifications.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#auto_subscribe_new_members GroupWithoutMembers#auto_subscribe_new_members}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoSubscribeNewMembers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutoSubscribeNewMembers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The group behaviours for a Microsoft 365 group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#behaviors GroupWithoutMembers#behaviors}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "behaviors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Behaviors
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The description for the group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#description GroupWithoutMembers#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>dynamic_membership block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#dynamic_membership GroupWithoutMembers#dynamic_membership}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dynamicMembership", typeJson: "{\"fqn\":\"azuread.groupWithoutMembers.GroupWithoutMembersDynamicMembership\"}", isOptional: true)]
            public azuread.GroupWithoutMembers.IGroupWithoutMembersDynamicMembership? DynamicMembership
            {
                get => GetInstanceProperty<azuread.GroupWithoutMembers.IGroupWithoutMembersDynamicMembership?>();
            }

            /// <summary>Indicates whether people external to the organization can send messages to the group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#external_senders_allowed GroupWithoutMembers#external_senders_allowed}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalSendersAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExternalSendersAllowed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#hide_from_address_lists GroupWithoutMembers#hide_from_address_lists}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hideFromAddressLists", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HideFromAddressLists
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#hide_from_outlook_clients GroupWithoutMembers#hide_from_outlook_clients}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hideFromOutlookClients", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HideFromOutlookClients
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#id GroupWithoutMembers#id}.</summary>
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

            /// <summary>Whether the group is a mail enabled, with a shared group mailbox.</summary>
            /// <remarks>
            /// At least one of <c>mail_enabled</c> or <c>security_enabled</c> must be specified. A group can be mail enabled <em>and</em> security enabled
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#mail_enabled GroupWithoutMembers#mail_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mailEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MailEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The mail alias for the group, unique in the organisation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#mail_nickname GroupWithoutMembers#mail_nickname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mailNickname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MailNickname
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates the target on-premise group type the group will be written back as.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#onpremises_group_type GroupWithoutMembers#onpremises_group_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onpremisesGroupType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnpremisesGroupType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A set of owners who own this group. Supported object types are Users or Service Principals.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#owners GroupWithoutMembers#owners}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "owners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Owners
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>If `true`, will return an error if an existing group is found with the same name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#prevent_duplicate_names GroupWithoutMembers#prevent_duplicate_names}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preventDuplicateNames", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PreventDuplicateNames
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The group provisioning options for a Microsoft 365 group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#provisioning_options GroupWithoutMembers#provisioning_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioningOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ProvisioningOptions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Whether the group is a security group for controlling access to in-app resources.</summary>
            /// <remarks>
            /// At least one of <c>security_enabled</c> or <c>mail_enabled</c> must be specified. A group can be security enabled <em>and</em> mail enabled
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#security_enabled GroupWithoutMembers#security_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "securityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SecurityEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The colour theme for a Microsoft 365 group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#theme GroupWithoutMembers#theme}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "theme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Theme
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#timeouts GroupWithoutMembers#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.groupWithoutMembers.GroupWithoutMembersTimeouts\"}", isOptional: true)]
            public azuread.GroupWithoutMembers.IGroupWithoutMembersTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.GroupWithoutMembers.IGroupWithoutMembersTimeouts?>();
            }

            /// <summary>A set of group types to configure for the group.</summary>
            /// <remarks>
            /// <c>Unified</c> specifies a Microsoft 365 group. Required when <c>mail_enabled</c> is true
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#types GroupWithoutMembers#types}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Types
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Specifies the group join policy and group content visibility.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#visibility GroupWithoutMembers#visibility}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "visibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Visibility
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether this group should be synced from Azure AD to the on-premises directory when Azure AD Connect is used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_without_members#writeback_enabled GroupWithoutMembers#writeback_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writebackEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? WritebackEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
