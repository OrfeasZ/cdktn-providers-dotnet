using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Droplet
{
    [JsiiByValue(fqn: "digitalocean.droplet.DropletBackupPolicy")]
    public class DropletBackupPolicy : digitalocean.Droplet.IDropletBackupPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet#hour Droplet#hour}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Hour
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet#plan Droplet#plan}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "plan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Plan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet#weekday Droplet#weekday}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weekday", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Weekday
        {
            get;
            set;
        }
    }
}
