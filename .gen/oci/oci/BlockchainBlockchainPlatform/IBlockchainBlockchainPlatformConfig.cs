using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BlockchainBlockchainPlatform
{
    [JsiiInterface(nativeType: typeof(IBlockchainBlockchainPlatformConfig), fullyQualifiedName: "oci.blockchainBlockchainPlatform.BlockchainBlockchainPlatformConfig")]
    public interface IBlockchainBlockchainPlatformConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#compartment_id BlockchainBlockchainPlatform#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#compute_shape BlockchainBlockchainPlatform#compute_shape}.</summary>
        [JsiiProperty(name: "computeShape", typeJson: "{\"primitive\":\"string\"}")]
        string ComputeShape
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#display_name BlockchainBlockchainPlatform#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#idcs_access_token BlockchainBlockchainPlatform#idcs_access_token}.</summary>
        [JsiiProperty(name: "idcsAccessToken", typeJson: "{\"primitive\":\"string\"}")]
        string IdcsAccessToken
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#platform_role BlockchainBlockchainPlatform#platform_role}.</summary>
        [JsiiProperty(name: "platformRole", typeJson: "{\"primitive\":\"string\"}")]
        string PlatformRole
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#ca_cert_archive_text BlockchainBlockchainPlatform#ca_cert_archive_text}.</summary>
        [JsiiProperty(name: "caCertArchiveText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaCertArchiveText
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#defined_tags BlockchainBlockchainPlatform#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#description BlockchainBlockchainPlatform#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#federated_user_id BlockchainBlockchainPlatform#federated_user_id}.</summary>
        [JsiiProperty(name: "federatedUserId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FederatedUserId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#freeform_tags BlockchainBlockchainPlatform#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#id BlockchainBlockchainPlatform#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#is_byol BlockchainBlockchainPlatform#is_byol}.</summary>
        [JsiiProperty(name: "isByol", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsByol
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#load_balancer_shape BlockchainBlockchainPlatform#load_balancer_shape}.</summary>
        [JsiiProperty(name: "loadBalancerShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoadBalancerShape
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#platform_version BlockchainBlockchainPlatform#platform_version}.</summary>
        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlatformVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>replicas block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#replicas BlockchainBlockchainPlatform#replicas}
        /// </remarks>
        [JsiiProperty(name: "replicas", typeJson: "{\"fqn\":\"oci.blockchainBlockchainPlatform.BlockchainBlockchainPlatformReplicas\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.BlockchainBlockchainPlatform.IBlockchainBlockchainPlatformReplicas? Replicas
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#storage_size_in_tbs BlockchainBlockchainPlatform#storage_size_in_tbs}.</summary>
        [JsiiProperty(name: "storageSizeInTbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StorageSizeInTbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#timeouts BlockchainBlockchainPlatform#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.blockchainBlockchainPlatform.BlockchainBlockchainPlatformTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.BlockchainBlockchainPlatform.IBlockchainBlockchainPlatformTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#total_ocpu_capacity BlockchainBlockchainPlatform#total_ocpu_capacity}.</summary>
        [JsiiProperty(name: "totalOcpuCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TotalOcpuCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBlockchainBlockchainPlatformConfig), fullyQualifiedName: "oci.blockchainBlockchainPlatform.BlockchainBlockchainPlatformConfig")]
        internal sealed class _Proxy : DeputyBase, oci.BlockchainBlockchainPlatform.IBlockchainBlockchainPlatformConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#compartment_id BlockchainBlockchainPlatform#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#compute_shape BlockchainBlockchainPlatform#compute_shape}.</summary>
            [JsiiProperty(name: "computeShape", typeJson: "{\"primitive\":\"string\"}")]
            public string ComputeShape
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#display_name BlockchainBlockchainPlatform#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#idcs_access_token BlockchainBlockchainPlatform#idcs_access_token}.</summary>
            [JsiiProperty(name: "idcsAccessToken", typeJson: "{\"primitive\":\"string\"}")]
            public string IdcsAccessToken
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#platform_role BlockchainBlockchainPlatform#platform_role}.</summary>
            [JsiiProperty(name: "platformRole", typeJson: "{\"primitive\":\"string\"}")]
            public string PlatformRole
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#ca_cert_archive_text BlockchainBlockchainPlatform#ca_cert_archive_text}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caCertArchiveText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaCertArchiveText
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#defined_tags BlockchainBlockchainPlatform#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#description BlockchainBlockchainPlatform#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#federated_user_id BlockchainBlockchainPlatform#federated_user_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "federatedUserId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FederatedUserId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#freeform_tags BlockchainBlockchainPlatform#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#id BlockchainBlockchainPlatform#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#is_byol BlockchainBlockchainPlatform#is_byol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isByol", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsByol
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#load_balancer_shape BlockchainBlockchainPlatform#load_balancer_shape}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoadBalancerShape
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#platform_version BlockchainBlockchainPlatform#platform_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlatformVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>replicas block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#replicas BlockchainBlockchainPlatform#replicas}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replicas", typeJson: "{\"fqn\":\"oci.blockchainBlockchainPlatform.BlockchainBlockchainPlatformReplicas\"}", isOptional: true)]
            public oci.BlockchainBlockchainPlatform.IBlockchainBlockchainPlatformReplicas? Replicas
            {
                get => GetInstanceProperty<oci.BlockchainBlockchainPlatform.IBlockchainBlockchainPlatformReplicas?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#storage_size_in_tbs BlockchainBlockchainPlatform#storage_size_in_tbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageSizeInTbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StorageSizeInTbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#timeouts BlockchainBlockchainPlatform#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.blockchainBlockchainPlatform.BlockchainBlockchainPlatformTimeouts\"}", isOptional: true)]
            public oci.BlockchainBlockchainPlatform.IBlockchainBlockchainPlatformTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.BlockchainBlockchainPlatform.IBlockchainBlockchainPlatformTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#total_ocpu_capacity BlockchainBlockchainPlatform#total_ocpu_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "totalOcpuCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalOcpuCapacity
            {
                get => GetInstanceProperty<double?>();
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
