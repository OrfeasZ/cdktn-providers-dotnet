using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseUser
{
    [JsiiInterface(nativeType: typeof(IDatabaseUserSettingsAcl), fullyQualifiedName: "digitalocean.databaseUser.DatabaseUserSettingsAcl")]
    public interface IDatabaseUserSettingsAcl
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_user#permission DatabaseUser#permission}.</summary>
        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        string Permission
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_user#topic DatabaseUser#topic}.</summary>
        [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}")]
        string Topic
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseUserSettingsAcl), fullyQualifiedName: "digitalocean.databaseUser.DatabaseUserSettingsAcl")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DatabaseUser.IDatabaseUserSettingsAcl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_user#permission DatabaseUser#permission}.</summary>
            [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
            public string Permission
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_user#topic DatabaseUser#topic}.</summary>
            [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}")]
            public string Topic
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
