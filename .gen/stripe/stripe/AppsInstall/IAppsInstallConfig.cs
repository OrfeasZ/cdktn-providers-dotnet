using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.AppsInstall
{
    [JsiiInterface(nativeType: typeof(IAppsInstallConfig), fullyQualifiedName: "stripe.appsInstall.AppsInstallConfig")]
    public interface IAppsInstallConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the app installed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/apps_install#app AppsInstall#app}
        /// </remarks>
        [JsiiProperty(name: "app", typeJson: "{\"primitive\":\"string\"}")]
        string App
        {
            get;
        }

        /// <summary>The distribution channel associated with the app install.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/apps_install#channel AppsInstall#channel}
        /// </remarks>
        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Channel
        {
            get
            {
                return null;
            }
        }

        /// <summary>For OAuth apps, the PKCE code challenge used to issue the `auth_code` returned on the install.</summary>
        /// <remarks>
        /// Must be 43 to 128 characters and contain only letters, numbers, <c>-</c>, <c>.</c>, <c>_</c>, and <c>~</c>. Only applies to installs made by the app developer or an embedding platform; ignored when an account installs its own private app.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/apps_install#code_challenge AppsInstall#code_challenge}
        /// </remarks>
        [JsiiProperty(name: "codeChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CodeChallenge
        {
            get
            {
                return null;
            }
        }

        /// <summary>The method used to derive `code_challenge`. Required when `code_challenge` is provided, and must be `S256`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/apps_install#code_challenge_method AppsInstall#code_challenge_method}
        /// </remarks>
        [JsiiProperty(name: "codeChallengeMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CodeChallengeMethod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsInstallConfig), fullyQualifiedName: "stripe.appsInstall.AppsInstallConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.AppsInstall.IAppsInstallConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the app installed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/apps_install#app AppsInstall#app}
            /// </remarks>
            [JsiiProperty(name: "app", typeJson: "{\"primitive\":\"string\"}")]
            public string App
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The distribution channel associated with the app install.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/apps_install#channel AppsInstall#channel}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Channel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For OAuth apps, the PKCE code challenge used to issue the `auth_code` returned on the install.</summary>
            /// <remarks>
            /// Must be 43 to 128 characters and contain only letters, numbers, <c>-</c>, <c>.</c>, <c>_</c>, and <c>~</c>. Only applies to installs made by the app developer or an embedding platform; ignored when an account installs its own private app.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/apps_install#code_challenge AppsInstall#code_challenge}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CodeChallenge
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The method used to derive `code_challenge`. Required when `code_challenge` is provided, and must be `S256`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/apps_install#code_challenge_method AppsInstall#code_challenge_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeChallengeMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CodeChallengeMethod
            {
                get => GetInstanceProperty<string?>();
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
