using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseUser
{
    [JsiiInterface(nativeType: typeof(IDatabaseUserSettingsOpensearchAcl), fullyQualifiedName: "digitalocean.databaseUser.DatabaseUserSettingsOpensearchAcl")]
    public interface IDatabaseUserSettingsOpensearchAcl
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_user#index DatabaseUser#index}.</summary>
        [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"string\"}")]
        string Index
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_user#permission DatabaseUser#permission}.</summary>
        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        string Permission
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseUserSettingsOpensearchAcl), fullyQualifiedName: "digitalocean.databaseUser.DatabaseUserSettingsOpensearchAcl")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DatabaseUser.IDatabaseUserSettingsOpensearchAcl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_user#index DatabaseUser#index}.</summary>
            [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"string\"}")]
            public string Index
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_user#permission DatabaseUser#permission}.</summary>
            [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
            public string Permission
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
