using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AdministrativeUnitRoleMember
{
    [JsiiInterface(nativeType: typeof(IAdministrativeUnitRoleMemberConfig), fullyQualifiedName: "azuread.administrativeUnitRoleMember.AdministrativeUnitRoleMemberConfig")]
    public interface IAdministrativeUnitRoleMemberConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The object ID of the administrative unit.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/administrative_unit_role_member#administrative_unit_object_id AdministrativeUnitRoleMember#administrative_unit_object_id}
        /// </remarks>
        [JsiiProperty(name: "administrativeUnitObjectId", typeJson: "{\"primitive\":\"string\"}")]
        string AdministrativeUnitObjectId
        {
            get;
        }

        /// <summary>The object ID of the member.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/administrative_unit_role_member#member_object_id AdministrativeUnitRoleMember#member_object_id}
        /// </remarks>
        [JsiiProperty(name: "memberObjectId", typeJson: "{\"primitive\":\"string\"}")]
        string MemberObjectId
        {
            get;
        }

        /// <summary>The object ID of the directory role.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/administrative_unit_role_member#role_object_id AdministrativeUnitRoleMember#role_object_id}
        /// </remarks>
        [JsiiProperty(name: "roleObjectId", typeJson: "{\"primitive\":\"string\"}")]
        string RoleObjectId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/administrative_unit_role_member#id AdministrativeUnitRoleMember#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/administrative_unit_role_member#timeouts AdministrativeUnitRoleMember#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.administrativeUnitRoleMember.AdministrativeUnitRoleMemberTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.AdministrativeUnitRoleMember.IAdministrativeUnitRoleMemberTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAdministrativeUnitRoleMemberConfig), fullyQualifiedName: "azuread.administrativeUnitRoleMember.AdministrativeUnitRoleMemberConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.AdministrativeUnitRoleMember.IAdministrativeUnitRoleMemberConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The object ID of the administrative unit.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/administrative_unit_role_member#administrative_unit_object_id AdministrativeUnitRoleMember#administrative_unit_object_id}
            /// </remarks>
            [JsiiProperty(name: "administrativeUnitObjectId", typeJson: "{\"primitive\":\"string\"}")]
            public string AdministrativeUnitObjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The object ID of the member.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/administrative_unit_role_member#member_object_id AdministrativeUnitRoleMember#member_object_id}
            /// </remarks>
            [JsiiProperty(name: "memberObjectId", typeJson: "{\"primitive\":\"string\"}")]
            public string MemberObjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The object ID of the directory role.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/administrative_unit_role_member#role_object_id AdministrativeUnitRoleMember#role_object_id}
            /// </remarks>
            [JsiiProperty(name: "roleObjectId", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleObjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/administrative_unit_role_member#id AdministrativeUnitRoleMember#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/administrative_unit_role_member#timeouts AdministrativeUnitRoleMember#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.administrativeUnitRoleMember.AdministrativeUnitRoleMemberTimeouts\"}", isOptional: true)]
            public azuread.AdministrativeUnitRoleMember.IAdministrativeUnitRoleMemberTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.AdministrativeUnitRoleMember.IAdministrativeUnitRoleMemberTimeouts?>();
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
