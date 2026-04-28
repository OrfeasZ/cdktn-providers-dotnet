using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseUser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.databaseUser.DatabaseUserSettingsOpensearchAcl")]
    public class DatabaseUserSettingsOpensearchAcl : digitalocean.DatabaseUser.IDatabaseUserSettingsOpensearchAcl
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_user#index DatabaseUser#index}.</summary>
        [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"string\"}")]
        public string Index
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_user#permission DatabaseUser#permission}.</summary>
        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        public string Permission
        {
            get;
            set;
        }
    }
}
