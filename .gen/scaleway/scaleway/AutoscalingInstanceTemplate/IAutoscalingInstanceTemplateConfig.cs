using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingInstanceTemplate
{
    [JsiiInterface(nativeType: typeof(IAutoscalingInstanceTemplateConfig), fullyQualifiedName: "scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateConfig")]
    public interface IAutoscalingInstanceTemplateConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Name of Instance commercial type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#commercial_type AutoscalingInstanceTemplate#commercial_type}
        /// </remarks>
        [JsiiProperty(name: "commercialType", typeJson: "{\"primitive\":\"string\"}")]
        string CommercialType
        {
            get;
        }

        /// <summary>Cloud-config to apply to each instance (will be passed in Base64 format).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#cloud_init AutoscalingInstanceTemplate#cloud_init}
        /// </remarks>
        [JsiiProperty(name: "cloudInit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudInit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#id AutoscalingInstanceTemplate#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Instance image ID.</summary>
        /// <remarks>
        /// Can be an ID of a marketplace or personal image. This image must be compatible with <c>volume</c> and <c>commercial_type</c> template
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#image_id AutoscalingInstanceTemplate#image_id}
        /// </remarks>
        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Instance template name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#name AutoscalingInstanceTemplate#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Instance placement group ID.</summary>
        /// <remarks>
        /// This is optional, but it is highly recommended to set a preference for Instance location within Availability Zone
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#placement_group_id AutoscalingInstanceTemplate#placement_group_id}
        /// </remarks>
        [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlacementGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Private Network IDs to attach to the new Instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#private_network_ids AutoscalingInstanceTemplate#private_network_ids}
        /// </remarks>
        [JsiiProperty(name: "privateNetworkIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PrivateNetworkIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#project_id AutoscalingInstanceTemplate#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of flexible IPv4 addresses to attach to the new Instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#public_ips_v4_count AutoscalingInstanceTemplate#public_ips_v4_count}
        /// </remarks>
        [JsiiProperty(name: "publicIpsV4Count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PublicIpsV4Count
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of flexible IPv6 addresses to attach to the new Instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#public_ips_v6_count AutoscalingInstanceTemplate#public_ips_v6_count}
        /// </remarks>
        [JsiiProperty(name: "publicIpsV6Count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PublicIpsV6Count
        {
            get
            {
                return null;
            }
        }

        /// <summary>Instance security group ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#security_group_id AutoscalingInstanceTemplate#security_group_id}
        /// </remarks>
        [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The tags associated with the Instance template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#tags AutoscalingInstanceTemplate#tags}
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

        /// <summary>volumes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#volumes AutoscalingInstanceTemplate#volumes}
        /// </remarks>
        [JsiiProperty(name: "volumes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Volumes
        {
            get
            {
                return null;
            }
        }

        /// <summary>The zone you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#zone AutoscalingInstanceTemplate#zone}
        /// </remarks>
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Zone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingInstanceTemplateConfig), fullyQualifiedName: "scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of Instance commercial type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#commercial_type AutoscalingInstanceTemplate#commercial_type}
            /// </remarks>
            [JsiiProperty(name: "commercialType", typeJson: "{\"primitive\":\"string\"}")]
            public string CommercialType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Cloud-config to apply to each instance (will be passed in Base64 format).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#cloud_init AutoscalingInstanceTemplate#cloud_init}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudInit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudInit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#id AutoscalingInstanceTemplate#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Instance image ID.</summary>
            /// <remarks>
            /// Can be an ID of a marketplace or personal image. This image must be compatible with <c>volume</c> and <c>commercial_type</c> template
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#image_id AutoscalingInstanceTemplate#image_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Instance template name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#name AutoscalingInstanceTemplate#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Instance placement group ID.</summary>
            /// <remarks>
            /// This is optional, but it is highly recommended to set a preference for Instance location within Availability Zone
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#placement_group_id AutoscalingInstanceTemplate#placement_group_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlacementGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Private Network IDs to attach to the new Instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#private_network_ids AutoscalingInstanceTemplate#private_network_ids}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateNetworkIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PrivateNetworkIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#project_id AutoscalingInstanceTemplate#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Number of flexible IPv4 addresses to attach to the new Instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#public_ips_v4_count AutoscalingInstanceTemplate#public_ips_v4_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicIpsV4Count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PublicIpsV4Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Number of flexible IPv6 addresses to attach to the new Instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#public_ips_v6_count AutoscalingInstanceTemplate#public_ips_v6_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicIpsV6Count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PublicIpsV6Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Instance security group ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#security_group_id AutoscalingInstanceTemplate#security_group_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The tags associated with the Instance template.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#tags AutoscalingInstanceTemplate#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>volumes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#volumes AutoscalingInstanceTemplate#volumes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Volumes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The zone you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#zone AutoscalingInstanceTemplate#zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Zone
            {
                get => GetInstanceProperty<string?>();
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
