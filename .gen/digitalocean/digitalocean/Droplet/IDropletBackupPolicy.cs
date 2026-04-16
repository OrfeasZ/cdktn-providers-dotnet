using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Droplet
{
    [JsiiInterface(nativeType: typeof(IDropletBackupPolicy), fullyQualifiedName: "digitalocean.droplet.DropletBackupPolicy")]
    public interface IDropletBackupPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet#hour Droplet#hour}.</summary>
        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Hour
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet#plan Droplet#plan}.</summary>
        [JsiiProperty(name: "plan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Plan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet#weekday Droplet#weekday}.</summary>
        [JsiiProperty(name: "weekday", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Weekday
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDropletBackupPolicy), fullyQualifiedName: "digitalocean.droplet.DropletBackupPolicy")]
        internal sealed class _Proxy : DeputyBase, digitalocean.Droplet.IDropletBackupPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet#hour Droplet#hour}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Hour
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet#plan Droplet#plan}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "plan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Plan
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet#weekday Droplet#weekday}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weekday", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Weekday
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
