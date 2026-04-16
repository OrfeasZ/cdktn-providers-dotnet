using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseUser
{
    [JsiiInterface(nativeType: typeof(IDatabaseUserSettings), fullyQualifiedName: "digitalocean.databaseUser.DatabaseUserSettings")]
    public interface IDatabaseUserSettings
    {
        /// <summary>acl block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_user#acl DatabaseUser#acl}
        /// </remarks>
        [JsiiProperty(name: "acl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.databaseUser.DatabaseUserSettingsAcl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Acl
        {
            get
            {
                return null;
            }
        }

        /// <summary>opensearch_acl block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_user#opensearch_acl DatabaseUser#opensearch_acl}
        /// </remarks>
        [JsiiProperty(name: "opensearchAcl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.databaseUser.DatabaseUserSettingsOpensearchAcl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OpensearchAcl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseUserSettings), fullyQualifiedName: "digitalocean.databaseUser.DatabaseUserSettings")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DatabaseUser.IDatabaseUserSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>acl block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_user#acl DatabaseUser#acl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.databaseUser.DatabaseUserSettingsAcl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Acl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>opensearch_acl block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_user#opensearch_acl DatabaseUser#opensearch_acl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "opensearchAcl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.databaseUser.DatabaseUserSettingsOpensearchAcl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OpensearchAcl
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
