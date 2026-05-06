using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsCloudGateMapping
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsCloudGateMappingConfig), fullyQualifiedName: "oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingConfig")]
    public interface IIdentityDomainsCloudGateMappingConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>cloud_gate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#cloud_gate IdentityDomainsCloudGateMapping#cloud_gate}
        /// </remarks>
        [JsiiProperty(name: "cloudGate", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingCloudGate\"}")]
        oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingCloudGate CloudGate
        {
            get;
        }

        /// <summary>gateway_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#gateway_app IdentityDomainsCloudGateMapping#gateway_app}
        /// </remarks>
        [JsiiProperty(name: "gatewayApp", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingGatewayApp\"}")]
        oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingGatewayApp GatewayApp
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#idcs_endpoint IdentityDomainsCloudGateMapping#idcs_endpoint}.</summary>
        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string IdcsEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#policy_name IdentityDomainsCloudGateMapping#policy_name}.</summary>
        [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}")]
        string PolicyName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#resource_prefix IdentityDomainsCloudGateMapping#resource_prefix}.</summary>
        [JsiiProperty(name: "resourcePrefix", typeJson: "{\"primitive\":\"string\"}")]
        string ResourcePrefix
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#schemas IdentityDomainsCloudGateMapping#schemas}.</summary>
        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Schemas
        {
            get;
        }

        /// <summary>server block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#server IdentityDomainsCloudGateMapping#server}
        /// </remarks>
        [JsiiProperty(name: "server", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingServer\"}")]
        oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingServer Server
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#attributes IdentityDomainsCloudGateMapping#attributes}.</summary>
        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Attributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#attribute_sets IdentityDomainsCloudGateMapping#attribute_sets}.</summary>
        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AttributeSets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#authorization IdentityDomainsCloudGateMapping#authorization}.</summary>
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Authorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#description IdentityDomainsCloudGateMapping#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#nginx_settings IdentityDomainsCloudGateMapping#nginx_settings}.</summary>
        [JsiiProperty(name: "nginxSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NginxSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#ocid IdentityDomainsCloudGateMapping#ocid}.</summary>
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ocid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#proxy_pass IdentityDomainsCloudGateMapping#proxy_pass}.</summary>
        [JsiiProperty(name: "proxyPass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProxyPass
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#resource_type_schema_version IdentityDomainsCloudGateMapping#resource_type_schema_version}.</summary>
        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceTypeSchemaVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#tags IdentityDomainsCloudGateMapping#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#timeouts IdentityDomainsCloudGateMapping#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>upstream_server_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#upstream_server_group IdentityDomainsCloudGateMapping#upstream_server_group}
        /// </remarks>
        [JsiiProperty(name: "upstreamServerGroup", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingUpstreamServerGroup\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingUpstreamServerGroup? UpstreamServerGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsCloudGateMappingConfig), fullyQualifiedName: "oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingConfig")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloud_gate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#cloud_gate IdentityDomainsCloudGateMapping#cloud_gate}
            /// </remarks>
            [JsiiProperty(name: "cloudGate", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingCloudGate\"}")]
            public oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingCloudGate CloudGate
            {
                get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingCloudGate>()!;
            }

            /// <summary>gateway_app block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#gateway_app IdentityDomainsCloudGateMapping#gateway_app}
            /// </remarks>
            [JsiiProperty(name: "gatewayApp", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingGatewayApp\"}")]
            public oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingGatewayApp GatewayApp
            {
                get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingGatewayApp>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#idcs_endpoint IdentityDomainsCloudGateMapping#idcs_endpoint}.</summary>
            [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string IdcsEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#policy_name IdentityDomainsCloudGateMapping#policy_name}.</summary>
            [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicyName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#resource_prefix IdentityDomainsCloudGateMapping#resource_prefix}.</summary>
            [JsiiProperty(name: "resourcePrefix", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourcePrefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#schemas IdentityDomainsCloudGateMapping#schemas}.</summary>
            [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Schemas
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>server block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#server IdentityDomainsCloudGateMapping#server}
            /// </remarks>
            [JsiiProperty(name: "server", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingServer\"}")]
            public oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingServer Server
            {
                get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingServer>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#attributes IdentityDomainsCloudGateMapping#attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Attributes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#attribute_sets IdentityDomainsCloudGateMapping#attribute_sets}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AttributeSets
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#authorization IdentityDomainsCloudGateMapping#authorization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Authorization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#description IdentityDomainsCloudGateMapping#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#nginx_settings IdentityDomainsCloudGateMapping#nginx_settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nginxSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NginxSettings
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#ocid IdentityDomainsCloudGateMapping#ocid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ocid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#proxy_pass IdentityDomainsCloudGateMapping#proxy_pass}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "proxyPass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProxyPass
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#resource_type_schema_version IdentityDomainsCloudGateMapping#resource_type_schema_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceTypeSchemaVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#tags IdentityDomainsCloudGateMapping#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#timeouts IdentityDomainsCloudGateMapping#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingTimeouts\"}", isOptional: true)]
            public oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingTimeouts?>();
            }

            /// <summary>upstream_server_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#upstream_server_group IdentityDomainsCloudGateMapping#upstream_server_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upstreamServerGroup", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingUpstreamServerGroup\"}", isOptional: true)]
            public oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingUpstreamServerGroup? UpstreamServerGroup
            {
                get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingUpstreamServerGroup?>();
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
