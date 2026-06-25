using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.FederatedIdentity
{
    [JsiiInterface(nativeType: typeof(IFederatedIdentityConfig), fullyQualifiedName: "tailscale.federatedIdentity.FederatedIdentityConfig")]
    public interface IFederatedIdentityConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The issuer of the OIDC identity token used in the token exchange.</summary>
        /// <remarks>
        /// Must be a valid and publicly reachable https:// URL.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/federated_identity#issuer FederatedIdentity#issuer}
        /// </remarks>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        string Issuer
        {
            get;
        }

        /// <summary>Scopes to grant to the federated identity. See https://tailscale.com/kb/1623/ for a list of available scopes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/federated_identity#scopes FederatedIdentity#scopes}
        /// </remarks>
        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Scopes
        {
            get;
        }

        /// <summary>The pattern used when matching against the `sub` claim from an OIDC identity token.</summary>
        /// <remarks>
        /// Patterns can include <c>*</c> characters to match against any character.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/federated_identity#subject FederatedIdentity#subject}
        /// </remarks>
        [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}")]
        string Subject
        {
            get;
        }

        /// <summary>The value used when matching against the `aud` claim from an OIDC identity token.</summary>
        /// <remarks>
        /// Specifying the audience is optional as Tailscale will generate a secure audience at creation time by default.   It is recommended to let Tailscale generate the audience unless the identity provider you are integrating with requires a specific audience format.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/federated_identity#audience FederatedIdentity#audience}
        /// </remarks>
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Audience
        {
            get
            {
                return null;
            }
        }

        /// <summary>A map of claim names to pattern strings used to match against arbitrary claims in the OIDC identity token.</summary>
        /// <remarks>
        /// Patterns can include <c>*</c> characters to match against any character.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/federated_identity#custom_claim_rules FederatedIdentity#custom_claim_rules}
        /// </remarks>
        [JsiiProperty(name: "customClaimRules", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? CustomClaimRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>A description of the federated identity consisting of alphanumeric characters. Defaults to `""`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/federated_identity#description FederatedIdentity#description}
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

        /// <summary>A list of tags that access tokens generated for the federated identity will be able to assign to devices.</summary>
        /// <remarks>
        /// Mandatory if the scopes include "devices:core" or "auth_keys".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/federated_identity#tags FederatedIdentity#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFederatedIdentityConfig), fullyQualifiedName: "tailscale.federatedIdentity.FederatedIdentityConfig")]
        internal sealed class _Proxy : DeputyBase, tailscale.FederatedIdentity.IFederatedIdentityConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The issuer of the OIDC identity token used in the token exchange.</summary>
            /// <remarks>
            /// Must be a valid and publicly reachable https:// URL.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/federated_identity#issuer FederatedIdentity#issuer}
            /// </remarks>
            [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
            public string Issuer
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Scopes to grant to the federated identity. See https://tailscale.com/kb/1623/ for a list of available scopes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/federated_identity#scopes FederatedIdentity#scopes}
            /// </remarks>
            [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Scopes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>The pattern used when matching against the `sub` claim from an OIDC identity token.</summary>
            /// <remarks>
            /// Patterns can include <c>*</c> characters to match against any character.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/federated_identity#subject FederatedIdentity#subject}
            /// </remarks>
            [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}")]
            public string Subject
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The value used when matching against the `aud` claim from an OIDC identity token.</summary>
            /// <remarks>
            /// Specifying the audience is optional as Tailscale will generate a secure audience at creation time by default.   It is recommended to let Tailscale generate the audience unless the identity provider you are integrating with requires a specific audience format.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/federated_identity#audience FederatedIdentity#audience}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Audience
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A map of claim names to pattern strings used to match against arbitrary claims in the OIDC identity token.</summary>
            /// <remarks>
            /// Patterns can include <c>*</c> characters to match against any character.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/federated_identity#custom_claim_rules FederatedIdentity#custom_claim_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customClaimRules", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? CustomClaimRules
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>A description of the federated identity consisting of alphanumeric characters. Defaults to `""`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/federated_identity#description FederatedIdentity#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A list of tags that access tokens generated for the federated identity will be able to assign to devices.</summary>
            /// <remarks>
            /// Mandatory if the scopes include "devices:core" or "auth_keys".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/federated_identity#tags FederatedIdentity#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
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
