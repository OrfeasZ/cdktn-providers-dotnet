using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.VpcPublicGatewayPatRule
{
    [JsiiInterface(nativeType: typeof(IVpcPublicGatewayPatRuleConfig), fullyQualifiedName: "scaleway.vpcPublicGatewayPatRule.VpcPublicGatewayPatRuleConfig")]
    public interface IVpcPublicGatewayPatRuleConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the gateway this PAT rule is applied to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_pat_rule#gateway_id VpcPublicGatewayPatRule#gateway_id}
        /// </remarks>
        [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}")]
        string GatewayId
        {
            get;
        }

        /// <summary>The private IP used in the PAT rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_pat_rule#private_ip VpcPublicGatewayPatRule#private_ip}
        /// </remarks>
        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}")]
        string PrivateIp
        {
            get;
        }

        /// <summary>The private port used in the PAT rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_pat_rule#private_port VpcPublicGatewayPatRule#private_port}
        /// </remarks>
        [JsiiProperty(name: "privatePort", typeJson: "{\"primitive\":\"number\"}")]
        double PrivatePort
        {
            get;
        }

        /// <summary>The public port used in the PAT rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_pat_rule#public_port VpcPublicGatewayPatRule#public_port}
        /// </remarks>
        [JsiiProperty(name: "publicPort", typeJson: "{\"primitive\":\"number\"}")]
        double PublicPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_pat_rule#id VpcPublicGatewayPatRule#id}.</summary>
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

        /// <summary>The protocol used in the PAT rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_pat_rule#protocol VpcPublicGatewayPatRule#protocol}
        /// </remarks>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Protocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_pat_rule#timeouts VpcPublicGatewayPatRule#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.vpcPublicGatewayPatRule.VpcPublicGatewayPatRuleTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.VpcPublicGatewayPatRule.IVpcPublicGatewayPatRuleTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>The zone you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_pat_rule#zone VpcPublicGatewayPatRule#zone}
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

        [JsiiTypeProxy(nativeType: typeof(IVpcPublicGatewayPatRuleConfig), fullyQualifiedName: "scaleway.vpcPublicGatewayPatRule.VpcPublicGatewayPatRuleConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.VpcPublicGatewayPatRule.IVpcPublicGatewayPatRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the gateway this PAT rule is applied to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_pat_rule#gateway_id VpcPublicGatewayPatRule#gateway_id}
            /// </remarks>
            [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}")]
            public string GatewayId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The private IP used in the PAT rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_pat_rule#private_ip VpcPublicGatewayPatRule#private_ip}
            /// </remarks>
            [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}")]
            public string PrivateIp
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The private port used in the PAT rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_pat_rule#private_port VpcPublicGatewayPatRule#private_port}
            /// </remarks>
            [JsiiProperty(name: "privatePort", typeJson: "{\"primitive\":\"number\"}")]
            public double PrivatePort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The public port used in the PAT rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_pat_rule#public_port VpcPublicGatewayPatRule#public_port}
            /// </remarks>
            [JsiiProperty(name: "publicPort", typeJson: "{\"primitive\":\"number\"}")]
            public double PublicPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_pat_rule#id VpcPublicGatewayPatRule#id}.</summary>
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

            /// <summary>The protocol used in the PAT rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_pat_rule#protocol VpcPublicGatewayPatRule#protocol}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Protocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_pat_rule#timeouts VpcPublicGatewayPatRule#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.vpcPublicGatewayPatRule.VpcPublicGatewayPatRuleTimeouts\"}", isOptional: true)]
            public scaleway.VpcPublicGatewayPatRule.IVpcPublicGatewayPatRuleTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.VpcPublicGatewayPatRule.IVpcPublicGatewayPatRuleTimeouts?>();
            }

            /// <summary>The zone you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_pat_rule#zone VpcPublicGatewayPatRule#zone}
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
