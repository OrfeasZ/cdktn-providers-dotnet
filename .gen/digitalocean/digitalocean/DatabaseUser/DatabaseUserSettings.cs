using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseUser
{
    [JsiiByValue(fqn: "digitalocean.databaseUser.DatabaseUserSettings")]
    public class DatabaseUserSettings : digitalocean.DatabaseUser.IDatabaseUserSettings
    {
        private object? _acl;

        /// <summary>acl block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_user#acl DatabaseUser#acl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.databaseUser.DatabaseUserSettingsAcl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Acl
        {
            get => _acl;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.DatabaseUser.IDatabaseUserSettingsAcl[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DatabaseUser.IDatabaseUserSettingsAcl).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _acl = value;
            }
        }

        private object? _opensearchAcl;

        /// <summary>opensearch_acl block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_user#opensearch_acl DatabaseUser#opensearch_acl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "opensearchAcl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.databaseUser.DatabaseUserSettingsOpensearchAcl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OpensearchAcl
        {
            get => _opensearchAcl;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.DatabaseUser.IDatabaseUserSettingsOpensearchAcl[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DatabaseUser.IDatabaseUserSettingsOpensearchAcl).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _opensearchAcl = value;
            }
        }
    }
}
