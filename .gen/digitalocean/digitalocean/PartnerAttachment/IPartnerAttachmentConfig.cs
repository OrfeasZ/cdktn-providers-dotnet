using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.PartnerAttachment
{
    [JsiiInterface(nativeType: typeof(IPartnerAttachmentConfig), fullyQualifiedName: "digitalocean.partnerAttachment.PartnerAttachmentConfig")]
    public interface IPartnerAttachmentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The connection bandwidth in Mbps.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#connection_bandwidth_in_mbps PartnerAttachment#connection_bandwidth_in_mbps}
        /// </remarks>
        [JsiiProperty(name: "connectionBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}")]
        double ConnectionBandwidthInMbps
        {
            get;
        }

        /// <summary>The NaaS provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#naas_provider PartnerAttachment#naas_provider}
        /// </remarks>
        [JsiiProperty(name: "naasProvider", typeJson: "{\"primitive\":\"string\"}")]
        string NaasProvider
        {
            get;
        }

        /// <summary>The name of the Partner Attachment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#name PartnerAttachment#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The region where the Partner Attachment will be created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#region PartnerAttachment#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>The list of VPC IDs to attach the Partner Attachment to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#vpc_ids PartnerAttachment#vpc_ids}
        /// </remarks>
        [JsiiProperty(name: "vpcIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] VpcIds
        {
            get;
        }

        /// <summary>bgp block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#bgp PartnerAttachment#bgp}
        /// </remarks>
        [JsiiProperty(name: "bgp", typeJson: "{\"fqn\":\"digitalocean.partnerAttachment.PartnerAttachmentBgp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.PartnerAttachment.IPartnerAttachmentBgp? Bgp
        {
            get
            {
                return null;
            }
        }

        /// <summary>The UUID of the Parent Partner Attachment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#parent_uuid PartnerAttachment#parent_uuid}
        /// </remarks>
        [JsiiProperty(name: "parentUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParentUuid
        {
            get
            {
                return null;
            }
        }

        /// <summary>The redundancy zone for the NaaS.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#redundancy_zone PartnerAttachment#redundancy_zone}
        /// </remarks>
        [JsiiProperty(name: "redundancyZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RedundancyZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#timeouts PartnerAttachment#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"digitalocean.partnerAttachment.PartnerAttachmentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.PartnerAttachment.IPartnerAttachmentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPartnerAttachmentConfig), fullyQualifiedName: "digitalocean.partnerAttachment.PartnerAttachmentConfig")]
        internal sealed class _Proxy : DeputyBase, digitalocean.PartnerAttachment.IPartnerAttachmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The connection bandwidth in Mbps.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#connection_bandwidth_in_mbps PartnerAttachment#connection_bandwidth_in_mbps}
            /// </remarks>
            [JsiiProperty(name: "connectionBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}")]
            public double ConnectionBandwidthInMbps
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The NaaS provider.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#naas_provider PartnerAttachment#naas_provider}
            /// </remarks>
            [JsiiProperty(name: "naasProvider", typeJson: "{\"primitive\":\"string\"}")]
            public string NaasProvider
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the Partner Attachment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#name PartnerAttachment#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The region where the Partner Attachment will be created.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#region PartnerAttachment#region}
            /// </remarks>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The list of VPC IDs to attach the Partner Attachment to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#vpc_ids PartnerAttachment#vpc_ids}
            /// </remarks>
            [JsiiProperty(name: "vpcIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] VpcIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>bgp block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#bgp PartnerAttachment#bgp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bgp", typeJson: "{\"fqn\":\"digitalocean.partnerAttachment.PartnerAttachmentBgp\"}", isOptional: true)]
            public digitalocean.PartnerAttachment.IPartnerAttachmentBgp? Bgp
            {
                get => GetInstanceProperty<digitalocean.PartnerAttachment.IPartnerAttachmentBgp?>();
            }

            /// <summary>The UUID of the Parent Partner Attachment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#parent_uuid PartnerAttachment#parent_uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parentUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParentUuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The redundancy zone for the NaaS.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#redundancy_zone PartnerAttachment#redundancy_zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redundancyZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RedundancyZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#timeouts PartnerAttachment#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"digitalocean.partnerAttachment.PartnerAttachmentTimeouts\"}", isOptional: true)]
            public digitalocean.PartnerAttachment.IPartnerAttachmentTimeouts? Timeouts
            {
                get => GetInstanceProperty<digitalocean.PartnerAttachment.IPartnerAttachmentTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
